using System;

namespace Eliot.Extensions.SupportAnalyzer
{
	using UEExplorer.Development;
	using UEExplorer.UI;

	[ExtensionTitle( "Support Analyzer" )]
	public class ExtSupportAnalyzer : IExtension
	{
		private ProgramForm _Owner;

		/// <summary>
		/// Called after UEExplorer_Form is initialized.
		/// </summary>
		/// <param name="form"></param>
		public void Initialize( ProgramForm form )
		{
			_Owner = form;
		}

		/// <summary>
		/// Called when activated by end-user.
		/// </summary>
		public void OnActivate( object sender, EventArgs e )
		{
			_Owner.Tabs.Add( typeof(UC_SupportAnalyzer), "Support Analyzer" );
		}
	}
}
