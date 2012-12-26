﻿using System;
using System.Collections.Generic;
using System.Linq;
using UELib.Core;

namespace UELib
{
	#region Exceptions
	[Serializable]
	public class UnrealException : Exception
	{
		protected UnrealException()
		{
		}

		public UnrealException( string message ) : base( message )
		{
		}

		public UnrealException( string message, Exception innerException ) : base( message, innerException )
		{
		}
	}

	[Serializable]
	public class DeserializationException : UnrealException
	{
		[NonSerializedAttribute]
		private readonly string _Output;

		public DeserializationException()
		{
			_Output = "DeserializationException";
		}

		public DeserializationException( string output ) : base( output )
		{
			_Output = output;
		}

		public override string ToString()
		{
			return _Output + "\r\n" + base.ToString();
		}
	}

	[Serializable]
	public class DecompilingCastException : DeserializationException
	{
	}

	[Serializable]
	public class DecompilingHeaderException : UnrealException
	{
		[NonSerializedAttribute] 
		private readonly string _Output;

		public DecompilingHeaderException()
		{
			_Output = "DecompilingHeaderException";
		}

		public DecompilingHeaderException( string output )
		{
			_Output = output;
		}

		public override string ToString()
		{
			return _Output + "\r\n" + base.ToString();
		}
	}

	[Serializable]
	public class CookedPackageException : UnrealException
	{
		public CookedPackageException() : base( "The package is cooked" )
		{
		}			
	}

	[Serializable]
	public class DecompressPackageException : UnrealException
	{
		public DecompressPackageException() : base( "Failed to decompress this package" )
		{
		}			
	}

	[Serializable]
	public class OccurredWhileException : UnrealException
	{
		public OccurredWhileException( string postMessage ) : base( "An exception occurred while " + postMessage )
		{
		}			
	}

	[Serializable]
	public class DeserializingObjectsException : OccurredWhileException
	{
		public DeserializingObjectsException() : base( "deserializing objects" )
		{
		}
	}

	[Serializable]
	public class ImportingObjectsException : OccurredWhileException
	{
		public ImportingObjectsException() : base( "importing objects" )
		{
		}
	}

	[Serializable]
	public class LinkingObjectsException : OccurredWhileException
	{
		public LinkingObjectsException() : base( "linking objects" )
		{
		}
	}
	#endregion

	#region Static Methods
	/// <summary>
	/// Provides static methods for formating flags.
	/// </summary>
	public static class UnrealMethods
	{
		public static string FlagsListToString( List<string> flagsList )
		{
			string output = String.Empty;
			foreach( string s in flagsList )
			{
				output += s + (s != flagsList.Last() ? "\n" : String.Empty);
			}
			return output;
		}

		public static List<string> FlagsToList( Type flagEnum, uint flagsDWORD )
		{
			var flagsList = new List<string>();
			var flagValues = Enum.GetValues( flagEnum );
			foreach( uint flag in flagValues )
			{
				if( (flagsDWORD & flag) != flag )
					continue;

				string eName = Enum.GetName( flagEnum, flag );
				if( flagsList.Contains( eName ) )
					continue;

				flagsList.Add( eName );
			}
			return flagsList;
		}

		public static List<string> FlagsToList( Type flagEnum, ulong flagsDWORD )
		{
			var flagsList = new List<string>();
			var flagValues = Enum.GetValues( flagEnum );
			foreach( ulong flag in flagValues )
			{
				if( (flagsDWORD & flag) != flag )
					continue;

				string eName = Enum.GetName( flagEnum, flag );
				if( flagsList.Contains( eName ) )
					continue;

				flagsList.Add( eName );
			}
			return flagsList;
		}

		public static List<string> FlagsToList( Type flagEnum, Type flagEnum2, ulong flagsQWORD )
		{
			var list = FlagsToList( flagEnum, flagsQWORD );
			list.AddRange( FlagsToList( flagEnum2, flagsQWORD >> 32 ) );
			return list; 
		}

		public static string FlagToString( uint flags )
		{
			return "0x" + String.Format( "{0:X4}", flags ).PadLeft( 8, '0' );
		}

		public static string FlagToString( ulong flags )
		{
			return FlagToString( (uint)(flags >> 32) ) + "-" + FlagToString( (uint)(flags) );
		}
	}
	#endregion

	#region Lists
	[System.Runtime.InteropServices.ComVisible( false )]
	public sealed class DefaultPropertiesCollection : List<UDefaultProperty>
	{
		public UDefaultProperty FindPropertyByName( string name )
		{
			return Find( prop => prop.Name == name );
		}

		public UDefaultProperty FindPropertyByIndex( int index )
		{
			return Find( prop => prop.NameIndex == index );
		}

		public bool ContainsIndex( int index )
		{
			return FindPropertyByIndex( index ) != null;
		}

		public bool ContainsIndex( int index, out UDefaultProperty prop )
		{
			prop = FindPropertyByIndex( index );
			return prop != null;
		}

		public bool ContainsName( string name )
		{
			return FindPropertyByName( name ) != null;
		}

		public bool ContainsName( string name, out UDefaultProperty prop )
		{
			prop = FindPropertyByName( name );
			return prop != null;
		}
	}
	#endregion
}
