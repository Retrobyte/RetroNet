namespace RetroNet.Forms
{
    partial class ApplicationHandlerDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.applicationsMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uninstallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationsListView = new RetroNet.Controls.AeroListView();
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uninstallStringHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quietHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.applicationsMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // applicationsMenuStrip
            // 
            this.applicationsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uninstallToolStripMenuItem});
            this.applicationsMenuStrip.Name = "applicationsMenuStrip";
            this.applicationsMenuStrip.Size = new System.Drawing.Size(121, 26);
            this.applicationsMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.applicationsMenuStrip_Opening);
            // 
            // uninstallToolStripMenuItem
            // 
            this.uninstallToolStripMenuItem.Image = global::RetroNet.Properties.Resources.cross;
            this.uninstallToolStripMenuItem.Name = "uninstallToolStripMenuItem";
            this.uninstallToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.uninstallToolStripMenuItem.Text = "Uninstall";
            this.uninstallToolStripMenuItem.Click += new System.EventHandler(this.uninstallToolStripMenuItem_Click);
            // 
            // applicationsListView
            // 
            this.applicationsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.applicationsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader,
            this.uninstallStringHeader,
            this.quietHeader});
            this.applicationsListView.ContextMenuStrip = this.applicationsMenuStrip;
            this.applicationsListView.FullRowSelect = true;
            this.applicationsListView.Location = new System.Drawing.Point(12, 12);
            this.applicationsListView.Name = "applicationsListView";
            this.applicationsListView.Size = new System.Drawing.Size(310, 212);
            this.applicationsListView.TabIndex = 0;
            this.applicationsListView.UseCompatibleStateImageBehavior = false;
            this.applicationsListView.View = System.Windows.Forms.View.Details;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Name";
            this.nameHeader.Width = 110;
            // 
            // uninstallStringHeader
            // 
            this.uninstallStringHeader.Text = "Uninstall String";
            this.uninstallStringHeader.Width = 135;
            // 
            // quietHeader
            // 
            this.quietHeader.Text = "Quiet";
            this.quietHeader.Width = 46;
            // 
            // ApplicationHandlerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 236);
            this.Controls.Add(this.applicationsListView);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApplicationHandlerDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ApplicationHandlerDialog_Load);
            this.applicationsMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.AeroListView applicationsListView;
        private System.Windows.Forms.ContextMenuStrip applicationsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem uninstallToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader uninstallStringHeader;
        private System.Windows.Forms.ColumnHeader quietHeader;
    }
}