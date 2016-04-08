namespace RetroNet.Forms
{
    partial class KeystrokeCapturerDialog
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
            this.keystrokeWebBrowser = new System.Windows.Forms.WebBrowser();
            this.keystrokeMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keystrokeMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // keystrokeWebBrowser
            // 
            this.keystrokeWebBrowser.ContextMenuStrip = this.keystrokeMenuStrip;
            this.keystrokeWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keystrokeWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.keystrokeWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.keystrokeWebBrowser.Name = "keystrokeWebBrowser";
            this.keystrokeWebBrowser.Size = new System.Drawing.Size(334, 236);
            this.keystrokeWebBrowser.TabIndex = 0;
            // 
            // keystrokeMenuStrip
            // 
            this.keystrokeMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.keystrokeMenuStrip.Name = "keystrokeMenuStrip";
            this.keystrokeMenuStrip.Size = new System.Drawing.Size(102, 48);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::RetroNet.Properties.Resources.disk;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Image = global::RetroNet.Properties.Resources.cross;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // KeystrokeCapturerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 236);
            this.Controls.Add(this.keystrokeWebBrowser);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KeystrokeCapturerDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KeystrokeCapturerDialog_FormClosing);
            this.Load += new System.EventHandler(this.KeystrokeCapturerDialog_Load);
            this.keystrokeMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser keystrokeWebBrowser;
        private System.Windows.Forms.ContextMenuStrip keystrokeMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    }
}