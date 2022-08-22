﻿namespace UEExplorer.UI
{
    partial class ProgramForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.MenuItem menuItem26;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramForm));
            this.UEStatusStrip = new System.Windows.Forms.StatusStrip();
            this.LoadingProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.ProgressLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SelectedNativeTable = new System.Windows.Forms.ToolStripDropDownButton();
            this.Platform = new System.Windows.Forms.ToolStripDropDownButton();
            this.pCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabComponentsStrip = new Storm.TabControl.TabStrip();
            this.tabStripItem2 = new Storm.TabControl.TabStripItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this._ROF = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem21 = new System.Windows.Forms.MenuItem();
            this.menuItem22 = new System.Windows.Forms.MenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this._CacheExtractorItem = new System.Windows.Forms.MenuItem();
            this.menuItem16 = new System.Windows.Forms.MenuItem();
            this.menuItem17 = new System.Windows.Forms.MenuItem();
            this.menuItem19 = new System.Windows.Forms.MenuItem();
            this.menuItem20 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.menuItem23 = new System.Windows.Forms.MenuItem();
            this.menuItem25 = new System.Windows.Forms.MenuItem();
            this.menuItem24 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.SocialMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem27 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.tabStripItem1 = new Storm.TabControl.TabStripItem();
            this.tabStripItem3 = new Storm.TabControl.TabStripItem();
            this.OpenHome = new System.Windows.Forms.Button();
            this.HomepageButton = new System.Windows.Forms.Button();
            this.kryptonManager = new Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPalette = new Krypton.Toolkit.KryptonPalette(this.components);
            menuItem26 = new System.Windows.Forms.MenuItem();
            this.UEStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabComponentsStrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuItem26
            // 
            menuItem26.Index = 3;
            resources.ApplyResources(menuItem26, "menuItem26");
            menuItem26.Click += new System.EventHandler(this.MenuItem26_Click);
            // 
            // UEStatusStrip
            // 
            this.UEStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadingProgress,
            this.ProgressLabel,
            this.SelectedNativeTable,
            this.Platform});
            resources.ApplyResources(this.UEStatusStrip, "UEStatusStrip");
            this.UEStatusStrip.Name = "UEStatusStrip";
            this.UEStatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // LoadingProgress
            // 
            this.LoadingProgress.CausesValidation = false;
            resources.ApplyResources(this.LoadingProgress, "LoadingProgress");
            this.LoadingProgress.Name = "LoadingProgress";
            this.LoadingProgress.Step = 1;
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProgressLabel.Name = "ProgressLabel";
            resources.ApplyResources(this.ProgressLabel, "ProgressLabel");
            this.ProgressLabel.Spring = true;
            // 
            // SelectedNativeTable
            // 
            this.SelectedNativeTable.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SelectedNativeTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.SelectedNativeTable, "SelectedNativeTable");
            this.SelectedNativeTable.Name = "SelectedNativeTable";
            this.SelectedNativeTable.DropDownOpening += new System.EventHandler(this.SelectedNativeTable_DropDownOpening);
            this.SelectedNativeTable.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.SelectedNativeTable_DropDownItemClicked);
            // 
            // Platform
            // 
            this.Platform.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Platform.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pCToolStripMenuItem,
            this.consoleToolStripMenuItem});
            resources.ApplyResources(this.Platform, "Platform");
            this.Platform.Name = "Platform";
            this.Platform.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Platform_DropDownItemClicked);
            // 
            // pCToolStripMenuItem
            // 
            this.pCToolStripMenuItem.Name = "pCToolStripMenuItem";
            resources.ApplyResources(this.pCToolStripMenuItem, "pCToolStripMenuItem");
            // 
            // consoleToolStripMenuItem
            // 
            this.consoleToolStripMenuItem.Name = "consoleToolStripMenuItem";
            resources.ApplyResources(this.consoleToolStripMenuItem, "consoleToolStripMenuItem");
            // 
            // TabComponentsStrip
            // 
            this.TabComponentsStrip.AllowDrop = true;
            resources.ApplyResources(this.TabComponentsStrip, "TabComponentsStrip");
            this.TabComponentsStrip.Name = "TabComponentsStrip";
            this.TabComponentsStrip.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.TabComponentsStrip.NormalColorEnd = System.Drawing.Color.White;
            this.TabComponentsStrip.NormalColorStart = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.TabComponentsStrip.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.TabComponentsStrip.RightClickMenu = null;
            this.TabComponentsStrip.SelectedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.TabComponentsStrip.SelectedColorEnd = System.Drawing.Color.White;
            this.TabComponentsStrip.SelectedColorStart = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.TabComponentsStrip.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TabComponentsStrip.SelectedItem = this.tabStripItem2;
            this.TabComponentsStrip.TabStripItemClosing += new Storm.TabControl.TabStripItemClosingHandler(this.TabComponentsStrip_TabStripItemClosing);
            this.TabComponentsStrip.TabStripItemSelectionChanged += new Storm.TabControl.TabStripItemChangedHandler(this.TabComponentsStrip_TabStripItemSelectionChanged);
            this.TabComponentsStrip.TabStripItemClosed += new System.EventHandler(this.TabComponentsStrip_TabStripItemClosed);
            this.TabComponentsStrip.DragDrop += new System.Windows.Forms.DragEventHandler(this.UEExplorer_Form_DragDrop);
            this.TabComponentsStrip.DragEnter += new System.Windows.Forms.DragEventHandler(this.UEExplorer_Form_DragEnter);
            // 
            // tabStripItem2
            // 
            this.tabStripItem2.IsDrawn = true;
            this.tabStripItem2.Name = "tabStripItem2";
            this.tabStripItem2.Selected = true;
            resources.ApplyResources(this.tabStripItem2, "tabStripItem2");
            this.tabStripItem2.TabStripParent = this.TabComponentsStrip;
            this.tabStripItem2.Title = "TabStrip Page 1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.toolsToolStripMenuItem,
            this.menuItem7,
            this.menuItem3});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem8,
            this._ROF,
            this.menuItem9,
            this.menuItem12,
            this.menuItem11,
            this.menuItem10});
            resources.ApplyResources(this.menuItem1, "menuItem1");
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 0;
            resources.ApplyResources(this.menuItem8, "menuItem8");
            this.menuItem8.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // _ROF
            // 
            resources.ApplyResources(this._ROF, "_ROF");
            this._ROF.Index = 1;
            // 
            // menuItem9
            // 
            resources.ApplyResources(this.menuItem9, "menuItem9");
            this.menuItem9.Index = 2;
            // 
            // menuItem12
            // 
            resources.ApplyResources(this.menuItem12, "menuItem12");
            this.menuItem12.Index = 3;
            this.menuItem12.Click += new System.EventHandler(this.SaveFileToolStripMenuItem_Click);
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 4;
            resources.ApplyResources(this.menuItem11, "menuItem11");
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 5;
            resources.ApplyResources(this.menuItem10, "menuItem10");
            this.menuItem10.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // menuItem2
            // 
            resources.ApplyResources(this.menuItem2, "menuItem2");
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem21});
            // 
            // menuItem21
            // 
            this.menuItem21.Index = 0;
            this.menuItem21.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem22});
            resources.ApplyResources(this.menuItem21, "menuItem21");
            this.menuItem21.Click += new System.EventHandler(this.FindToolStripMenuItem_Click);
            // 
            // menuItem22
            // 
            this.menuItem22.Index = 0;
            resources.ApplyResources(this.menuItem22, "menuItem22");
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Index = 2;
            this.toolsToolStripMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem13,
            this.menuItem14,
            this._CacheExtractorItem,
            this.menuItem16,
            this.menuItem17,
            this.menuItem19,
            this.menuItem20});
            resources.ApplyResources(this.toolsToolStripMenuItem, "toolsToolStripMenuItem");
            this.toolsToolStripMenuItem.Popup += new System.EventHandler(this.ToolsToolStripMenuItem_DropDownOpening);
            // 
            // menuItem13
            // 
            resources.ApplyResources(this.menuItem13, "menuItem13");
            this.menuItem13.Index = 0;
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 1;
            resources.ApplyResources(this.menuItem14, "menuItem14");
            // 
            // _CacheExtractorItem
            // 
            resources.ApplyResources(this._CacheExtractorItem, "_CacheExtractorItem");
            this._CacheExtractorItem.Index = 2;
            this._CacheExtractorItem.Click += new System.EventHandler(this.UnrealCacheExtractorToolStripMenuItem_Click);
            // 
            // menuItem16
            // 
            this.menuItem16.Index = 3;
            resources.ApplyResources(this.menuItem16, "menuItem16");
            // 
            // menuItem17
            // 
            this.menuItem17.Index = 4;
            resources.ApplyResources(this.menuItem17, "menuItem17");
            this.menuItem17.Click += new System.EventHandler(this.UnrealColorGeneratorToolStripMenuItem_Click);
            // 
            // menuItem19
            // 
            this.menuItem19.Index = 5;
            resources.ApplyResources(this.menuItem19, "menuItem19");
            // 
            // menuItem20
            // 
            this.menuItem20.Index = 6;
            resources.ApplyResources(this.menuItem20, "menuItem20");
            this.menuItem20.Click += new System.EventHandler(this.ToggleUEExplorerFileIconsToolStripMenuItem_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 3;
            resources.ApplyResources(this.menuItem7, "menuItem7");
            this.menuItem7.Click += new System.EventHandler(this.MenuItem7_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 4;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem15,
            this.menuItem23,
            this.menuItem25,
            menuItem26,
            this.menuItem24,
            this.menuItem6,
            this.menuItem4,
            this.SocialMenuItem,
            this.menuItem27,
            this.menuItem5});
            resources.ApplyResources(this.menuItem3, "menuItem3");
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 0;
            resources.ApplyResources(this.menuItem15, "menuItem15");
            this.menuItem15.Click += new System.EventHandler(this.ReportAnIssue);
            // 
            // menuItem23
            // 
            this.menuItem23.Index = 1;
            resources.ApplyResources(this.menuItem23, "menuItem23");
            this.menuItem23.Click += new System.EventHandler(this.OnCheckForUpdates);
            // 
            // menuItem25
            // 
            this.menuItem25.Index = 2;
            resources.ApplyResources(this.menuItem25, "menuItem25");
            // 
            // menuItem24
            // 
            this.menuItem24.Index = 4;
            resources.ApplyResources(this.menuItem24, "menuItem24");
            this.menuItem24.Click += new System.EventHandler(this.MenuItem24_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 5;
            resources.ApplyResources(this.menuItem6, "menuItem6");
            this.menuItem6.Click += new System.EventHandler(this.DonateToolStripMenuItem1_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 6;
            resources.ApplyResources(this.menuItem4, "menuItem4");
            this.menuItem4.Click += new System.EventHandler(this.MenuItem4_Click);
            // 
            // SocialMenuItem
            // 
            this.SocialMenuItem.Index = 7;
            resources.ApplyResources(this.SocialMenuItem, "SocialMenuItem");
            this.SocialMenuItem.Click += new System.EventHandler(this.SocialMenuItem_Click);
            // 
            // menuItem27
            // 
            this.menuItem27.Index = 8;
            resources.ApplyResources(this.menuItem27, "menuItem27");
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 9;
            resources.ApplyResources(this.menuItem5, "menuItem5");
            this.menuItem5.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // tabStripItem1
            // 
            this.tabStripItem1.IsDrawn = true;
            this.tabStripItem1.Name = "tabStripItem1";
            resources.ApplyResources(this.tabStripItem1, "tabStripItem1");
            this.tabStripItem1.TabStripParent = this.TabComponentsStrip;
            this.tabStripItem1.Title = "TabStrip Page 1";
            // 
            // tabStripItem3
            // 
            this.tabStripItem3.IsDrawn = true;
            this.tabStripItem3.Name = "tabStripItem3";
            resources.ApplyResources(this.tabStripItem3, "tabStripItem3");
            this.tabStripItem3.TabStripParent = this.TabComponentsStrip;
            this.tabStripItem3.Title = "TabStrip Page 2";
            // 
            // OpenHome
            // 
            resources.ApplyResources(this.OpenHome, "OpenHome");
            this.OpenHome.Name = "OpenHome";
            this.OpenHome.Click += new System.EventHandler(this.OpenHome_Click);
            // 
            // HomepageButton
            // 
            resources.ApplyResources(this.HomepageButton, "HomepageButton");
            this.HomepageButton.Name = "HomepageButton";
            this.HomepageButton.UseVisualStyleBackColor = true;
            this.HomepageButton.Click += new System.EventHandler(this.OpenHome_Click);
            // 
            // kryptonManager
            // 
            this.kryptonManager.GlobalPalette = this.kryptonPalette;
            this.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteModeManager.Custom;
            // 
            // kryptonPalette
            // 
            this.kryptonPalette.BasePaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonPalette.BaseRenderMode = Krypton.Toolkit.RendererMode.Standard;
            this.kryptonPalette.ButtonSpecs.FormClose.Image = global::UEExplorer.Properties.Resources.Close;
            this.kryptonPalette.ButtonSpecs.PinHorizontal.Image = global::UEExplorer.Properties.Resources.Pin;
            this.kryptonPalette.ButtonSpecs.PinVertical.Image = global::UEExplorer.Properties.Resources.Pin;
            this.kryptonPalette.TabStyles.TabCommon.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // ProgramForm
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.BackgroundImage = global::UEExplorer.Properties.Resources.UE_ProgramLogo;
            this.Controls.Add(this.HomepageButton);
            this.Controls.Add(this.TabComponentsStrip);
            this.Controls.Add(this.UEStatusStrip);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Menu = this.mainMenu1;
            this.Name = "ProgramForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClosed);
            this.Shown += new System.EventHandler(this.Unreal_Explorer_Form_Shown);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.UEExplorer_Form_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.UEExplorer_Form_DragEnter);
            this.UEStatusStrip.ResumeLayout(false);
            this.UEStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabComponentsStrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.StatusStrip UEStatusStrip;
        internal System.Windows.Forms.ToolStripStatusLabel ProgressLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.ToolStripProgressBar LoadingProgress;
        internal System.Windows.Forms.ToolStripDropDownButton SelectedNativeTable;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.MenuItem menuItem12;
        private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.MenuItem menuItem13;
        private System.Windows.Forms.MenuItem menuItem14;
        private System.Windows.Forms.MenuItem _CacheExtractorItem;
        private System.Windows.Forms.MenuItem menuItem16;
        private System.Windows.Forms.MenuItem menuItem17;
        private System.Windows.Forms.MenuItem menuItem19;
        private System.Windows.Forms.MenuItem menuItem20;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem21;
        private System.Windows.Forms.MenuItem menuItem22;
        private System.Windows.Forms.MenuItem menuItem23;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem24;
        private System.Windows.Forms.MenuItem menuItem25;
        private System.Windows.Forms.MenuItem menuItem27;
        private System.Windows.Forms.ToolStripMenuItem pCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consoleToolStripMenuItem;
        internal System.Windows.Forms.ToolStripDropDownButton Platform;
        private Storm.TabControl.TabStripItem tabStripItem1;
        private Storm.TabControl.TabStripItem tabStripItem2;
        private Storm.TabControl.TabStripItem tabStripItem3;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem _ROF;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.Button OpenHome;
        private Storm.TabControl.TabStrip TabComponentsStrip;
        private System.Windows.Forms.Button HomepageButton;
        private System.Windows.Forms.MenuItem SocialMenuItem;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem15;
        private Krypton.Toolkit.KryptonManager kryptonManager;
        private Krypton.Toolkit.KryptonPalette kryptonPalette;


        // OnClick events!

    }
}

