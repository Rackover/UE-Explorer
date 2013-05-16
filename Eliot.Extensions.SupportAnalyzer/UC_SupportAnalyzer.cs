using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using UEExplorer.UI.Tabs;

namespace Eliot.Extensions.SupportAnalyzer
{
    using UELib;
    using UELib.Core;

    [System.Runtime.InteropServices.ComVisible( false )]
    public partial class UC_SupportAnalyzer : UserControl_Tab
    {
        private const string PackagesPath = @"C:\Users\Eliot\Documents\Visual Studio 2010\Projects\UE Explorer\Misc\Production\Packages-Supported\";
        private static readonly string UnitTestsPath = Path.Combine( PackagesPath, "UnitTests" );

        private struct UnitTest
        {
            // Object.GetPackageName
            public string Group;
            public string Context;
        }

        private static string FixFunctionTest( string context )
        {
            var globalIndex = 0;
            while( true )
            {
                globalIndex = context.IndexOf( "0x", globalIndex, StringComparison.Ordinal );
                if( globalIndex == -1 )
                    break;

                globalIndex += 2;
                context = context.Remove( globalIndex, 2 );
            }
            return context;
        }

        private void Button_Add_Click( object sender, EventArgs e )
        {
            var unitDir = Directory.GetFiles( UnitTestsPath );
            var tests = new List<UnitTest>( unitDir.Count() );
            foreach( var unitPath in unitDir )
            {
                var unitTest = new UnitTest
                {
                    Context = FixFunctionTest( File.ReadAllText( unitPath ) ),
                    Group = Path.GetFileNameWithoutExtension( unitPath )
                };
                tests.Add( unitTest );
            }
            
            var dir = Directory.GetFiles( PackagesPath );
            foreach( var filePath in dir )
            {
                try
                {
                    var containsErrors = false;
                    var package = UnrealLoader.LoadPackage( filePath );
                    package.InitializePackage();

                    var packageNode = new TreeNode( package.PackageName );
                    foreach( var obj in package.Objects )
                    {
                        var unitTest = tests.Find( u => (u.Group == obj.GetOuterGroup()) );
                        if( unitTest.Group != null )
                        {
                            var objNode = new TreeNode( obj.Name + " " + obj.GetClassName() );

                            var context = FixFunctionTest( obj.Decompile() );
                            if( context == unitTest.Context )
                            {
                                objNode.ForeColor = Color.DarkGreen;
                                objNode.ToolTipText = String.Format( "Unit test{0} has succeeded", unitTest.Group );    
                            }
                            else
                            {
                                objNode.ForeColor = Color.DarkViolet;
                                objNode.ToolTipText = String.Format( "Unit test{0} has failed\r\n\r\n{1}\r\n\r\n{2}", 
                                    unitTest.Group, unitTest.Context, context
                                );      

                                containsErrors = true;
                            }
                            packageNode.Nodes.Add( objNode );
                        }
                        else if( obj.DeserializationState == UObject.ObjectState.Errorlized )
                        {
                            var objNode = new TreeNode( obj.Name + " " + obj.GetClassName() );
                            objNode.ToolTipText = obj.ThrownException.ToString();
                            packageNode.Nodes.Add( objNode );    

                            containsErrors = true;
                        }
                    }

                    if( packageNode.Nodes.Count == 0 )
                        continue;

                    packageNode.Text += String.Format( "({0})", packageNode.Nodes.Count );
                    packageNode.ForeColor = containsErrors ? Color.DarkRed : Color.DarkGreen;
                    TreeView_Packages.Nodes.Add( packageNode );
                    TreeView_Packages.Refresh();
                }
                catch( Exception exc )
                {
                    var packageNode = new TreeNode( filePath );
                    packageNode.ToolTipText = exc.ToString();
                    packageNode.ForeColor = Color.DarkRed;
                    TreeView_Packages.Nodes.Add( packageNode );
                    
                }
                finally
                {
                    TreeView_Packages.Refresh();    
                }
            }
        } 
    }
}
