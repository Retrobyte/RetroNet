namespace RetroNet.Forms
{
    partial class ClipboardLoggerDialog
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
            this.clipboardTextBox = new System.Windows.Forms.TextBox();
            this.clipboardMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clipboardMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // clipboardTextBox
            // 
            this.clipboardTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clipboardTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.clipboardTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clipboardTextBox.ContextMenuStrip = this.clipboardMenuStrip;
            this.clipboardTextBox.Location = new System.Drawing.Point(12, 12);
            this.clipboardTextBox.Multiline = true;
            this.clipboardTextBox.Name = "clipboardTextBox";
            this.clipboardTextBox.ReadOnly = true;
            this.clipboardTextBox.Size = new System.Drawing.Size(310, 212);
            this.clipboardTextBox.TabIndex = 0;
            // 
            // clipboardMenuStrip
            // 
            this.clipboardMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.clipboardMenuStrip.Name = "clipboardMenuStrip";
            this.clipboardMenuStrip.Size = new System.Drawing.Size(102, 48);
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
            // ClipboardLoggerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 236);
            this.Controls.Add(this.clipboardTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClipboardLoggerDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClipboardLoggerDialog_FormClosing);
            this.Load += new System.EventHandler(this.ClipboardLoggerDialog_Load);
            this.clipboardMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox clipboardTextBox;
        private System.Windows.Forms.ContextMenuStrip clipboardMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    }
}