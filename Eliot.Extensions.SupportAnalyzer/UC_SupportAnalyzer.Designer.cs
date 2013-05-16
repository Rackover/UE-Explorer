namespace Eliot.Extensions.SupportAnalyzer
{
	using UEExplorer.UI;

	partial class UC_SupportAnalyzer
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		protected override void InitializeComponent()
		{
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage_Packages = new System.Windows.Forms.TabPage();
            this.TreeView_Packages = new System.Windows.Forms.TreeView();
            this.Button_Add = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.TabPage_Packages.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.TabPage_Packages);
            this.tabControl1.Location = new System.Drawing.Point(0, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(827, 475);
            this.tabControl1.TabIndex = 0;
            // 
            // TabPage_Packages
            // 
            this.TabPage_Packages.Controls.Add(this.TreeView_Packages);
            this.TabPage_Packages.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Packages.Name = "TabPage_Packages";
            this.TabPage_Packages.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Packages.Size = new System.Drawing.Size(819, 449);
            this.TabPage_Packages.TabIndex = 0;
            this.TabPage_Packages.Text = "Loaded Packages";
            this.TabPage_Packages.UseVisualStyleBackColor = true;
            // 
            // TreeView_Packages
            // 
            this.TreeView_Packages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeView_Packages.Location = new System.Drawing.Point(3, 3);
            this.TreeView_Packages.Name = "TreeView_Packages";
            this.TreeView_Packages.ShowNodeToolTips = true;
            this.TreeView_Packages.Size = new System.Drawing.Size(813, 443);
            this.TreeView_Packages.TabIndex = 0;
            // 
            // Button_Add
            // 
            this.Button_Add.Location = new System.Drawing.Point(3, 3);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(99, 23);
            this.Button_Add.TabIndex = 4;
            this.Button_Add.Text = "Scan Packages";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // UC_SupportAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.tabControl1);
            this.Name = "UC_SupportAnalyzer";
            this.Size = new System.Drawing.Size(827, 507);
            this.tabControl1.ResumeLayout(false);
            this.TabPage_Packages.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabPage TabPage_Packages;
		internal System.Windows.Forms.TabControl tabControl1;
		internal System.Windows.Forms.TreeView TreeView_Packages;
        internal System.Windows.Forms.Button Button_Add;
	}
}
