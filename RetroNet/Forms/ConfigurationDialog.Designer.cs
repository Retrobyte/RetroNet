namespace RetroNet.Forms
{
    partial class ConfigurationDialog
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
            this.portsMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageNotificationCheckBox = new System.Windows.Forms.CheckBox();
            this.soundNotificationCheckBox = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.portsListView = new RetroNet.Controls.AeroListView();
            this.portsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.portsMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // portsMenuStrip
            // 
            this.portsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.portsMenuStrip.Name = "portsMenuStrip";
            this.portsMenuStrip.Size = new System.Drawing.Size(118, 48);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Image = global::RetroNet.Properties.Resources.add;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Image = global::RetroNet.Properties.Resources.delete;
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // messageNotificationCheckBox
            // 
            this.messageNotificationCheckBox.AutoSize = true;
            this.messageNotificationCheckBox.Location = new System.Drawing.Point(12, 218);
            this.messageNotificationCheckBox.Name = "messageNotificationCheckBox";
            this.messageNotificationCheckBox.Size = new System.Drawing.Size(211, 17);
            this.messageNotificationCheckBox.TabIndex = 1;
            this.messageNotificationCheckBox.Text = "Show Message On New Connection";
            this.messageNotificationCheckBox.UseVisualStyleBackColor = true;
            // 
            // soundNotificationCheckBox
            // 
            this.soundNotificationCheckBox.AutoSize = true;
            this.soundNotificationCheckBox.Location = new System.Drawing.Point(12, 241);
            this.soundNotificationCheckBox.Name = "soundNotificationCheckBox";
            this.soundNotificationCheckBox.Size = new System.Drawing.Size(191, 17);
            this.soundNotificationCheckBox.TabIndex = 2;
            this.soundNotificationCheckBox.Text = "Play Sound On New Connection";
            this.soundNotificationCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(67, 264);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(148, 264);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // portsListView
            // 
            this.portsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.portsHeader});
            this.portsListView.ContextMenuStrip = this.portsMenuStrip;
            this.portsListView.FullRowSelect = true;
            this.portsListView.Location = new System.Drawing.Point(12, 12);
            this.portsListView.Name = "portsListView";
            this.portsListView.Size = new System.Drawing.Size(211, 200);
            this.portsListView.TabIndex = 0;
            this.portsListView.UseCompatibleStateImageBehavior = false;
            this.portsListView.View = System.Windows.Forms.View.Details;
            // 
            // portsHeader
            // 
            this.portsHeader.Text = "Port";
            this.portsHeader.Width = 192;
            // 
            // ConfigurationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 299);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.soundNotificationCheckBox);
            this.Controls.Add(this.messageNotificationCheckBox);
            this.Controls.Add(this.portsListView);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigurationDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.portsMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.AeroListView portsListView;
        private System.Windows.Forms.CheckBox messageNotificationCheckBox;
        private System.Windows.Forms.CheckBox soundNotificationCheckBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ColumnHeader portsHeader;
        private System.Windows.Forms.ContextMenuStrip portsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}