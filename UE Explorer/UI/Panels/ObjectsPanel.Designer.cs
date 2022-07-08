namespace UEExplorer.UI.Panels
{
    partial class ObjectsPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ObjectListView = new BrightIdeasSoftware.TreeListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.ObjectListView)).BeginInit();
            this.SuspendLayout();
            // 
            // ObjectListView
            // 
            this.ObjectListView.AllColumns.Add(this.olvColumn1);
            this.ObjectListView.AllColumns.Add(this.olvColumn2);
            this.ObjectListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ObjectListView.CellEditUseWholeCell = false;
            this.ObjectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2});
            this.ObjectListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ObjectListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ObjectListView.HideSelection = false;
            this.ObjectListView.Location = new System.Drawing.Point(0, 0);
            this.ObjectListView.Name = "ObjectListView";
            this.ObjectListView.ShowGroups = false;
            this.ObjectListView.Size = new System.Drawing.Size(494, 600);
            this.ObjectListView.TabIndex = 25;
            this.ObjectListView.UseCompatibleStateImageBehavior = false;
            this.ObjectListView.View = System.Windows.Forms.View.Details;
            this.ObjectListView.VirtualMode = true;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Name";
            this.olvColumn1.Text = "Name";
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Class";
            this.olvColumn2.Text = "Class";
            // 
            // ObjectsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ObjectListView);
            this.Name = "ObjectsPanel";
            this.Size = new System.Drawing.Size(494, 600);
            ((System.ComponentModel.ISupportInitialize)(this.ObjectListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        public BrightIdeasSoftware.TreeListView ObjectListView;
    }
}
