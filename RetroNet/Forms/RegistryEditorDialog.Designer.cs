namespace RetroNet.Forms
{
    partial class RegistryEditorDialog
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
            this.registryListView = new RetroNet.Controls.AeroListView();
            this.valuesListView = new RetroNet.Controls.AeroListView();
            this.registryMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.valuesMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valuesMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // registryListView
            // 
            this.registryListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.registryListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registryListView.ContextMenuStrip = this.registryMenuStrip;
            this.registryListView.FullRowSelect = true;
            this.registryListView.Location = new System.Drawing.Point(12, 12);
            this.registryListView.MultiSelect = false;
            this.registryListView.Name = "registryListView";
            this.registryListView.Size = new System.Drawing.Size(125, 237);
            this.registryListView.TabIndex = 0;
            this.registryListView.UseCompatibleStateImageBehavior = false;
            this.registryListView.View = System.Windows.Forms.View.Details;
            // 
            // valuesListView
            // 
            this.valuesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valuesListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valuesListView.ContextMenuStrip = this.valuesMenuStrip;
            this.valuesListView.FullRowSelect = true;
            this.valuesListView.Location = new System.Drawing.Point(143, 12);
            this.valuesListView.MultiSelect = false;
            this.valuesListView.Name = "valuesListView";
            this.valuesListView.Size = new System.Drawing.Size(279, 237);
            this.valuesListView.TabIndex = 1;
            this.valuesListView.UseCompatibleStateImageBehavior = false;
            this.valuesListView.View = System.Windows.Forms.View.Details;
            // 
            // registryMenuStrip
            // 
            this.registryMenuStrip.Name = "registryMenuStrip";
            this.registryMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // valuesMenuStrip
            // 
            this.valuesMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.editToolStripMenuItem});
            this.valuesMenuStrip.Name = "valuesMenuStrip";
            this.valuesMenuStrip.Size = new System.Drawing.Size(109, 70);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // RegistryEditorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.valuesListView);
            this.Controls.Add(this.registryListView);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistryEditorDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RegistryEditorDialog_Load);
            this.valuesMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.AeroListView registryListView;
        private Controls.AeroListView valuesListView;
        private System.Windows.Forms.ContextMenuStrip registryMenuStrip;
        private System.Windows.Forms.ContextMenuStrip valuesMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}