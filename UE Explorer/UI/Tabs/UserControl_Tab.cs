﻿using System.ComponentModel;
using System.Windows.Forms;
using Storm.TabControl;

namespace UEExplorer.UI.Tabs
{
    public abstract class UserControl_Tab : UserControl, ITabComponent
    {
        public TabsCollection Tabs{ protected get; set; }
        public TabStripItem TabItem{ get; set; }

        protected UserControl_Tab()
        {
            if( LicenseManager.UsageMode != LicenseUsageMode.Designtime )
            {
                Dock = DockStyle.Fill;
            }
            InitializeComponent();
        }

        protected abstract void InitializeComponent();

        /// <summary>
        /// Called after the tab was constructed.
        /// </summary>
        // Not done in the constructor, because of some null references, neither won't use constructor params.
        public virtual void TabInitialize()
        {
            TabCreated();
            TabSelected();
        }

        /// <summary>
        /// Called when the Tab is added to the chain.
        /// </summary>
        protected virtual void TabCreated()
        {
            TabItem.Controls.Add( this );
        }

        /// <summary>
        /// Called when the Tab is selected.
        /// </summary>
        public virtual void TabSelected()
        {
        }

        /// <summary>
        /// Called when the Tab is closing.
        /// </summary>
        public virtual void TabClosing()
        {
        }

        public virtual void TabSave()
        {
        }

        public virtual void TabFind()
        {
        }
    }
}
