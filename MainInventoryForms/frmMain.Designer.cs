namespace MainInventoryForms
{
    partial class frmMain
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
            this.menuNav = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsTool = new System.Windows.Forms.ToolStripMenuItem();
            this.panelUsers = new System.Windows.Forms.Panel();
            this.menuNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuNav
            // 
            this.menuNav.AutoSize = false;
            this.menuNav.BackColor = System.Drawing.Color.White;
            this.menuNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuNav.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuNav.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuNav.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.settingsTool});
            this.menuNav.Location = new System.Drawing.Point(0, 0);
            this.menuNav.Margin = new System.Windows.Forms.Padding(1);
            this.menuNav.MaximumSize = new System.Drawing.Size(156, 860);
            this.menuNav.MinimumSize = new System.Drawing.Size(156, 860);
            this.menuNav.Name = "menuNav";
            this.menuNav.Padding = new System.Windows.Forms.Padding(2);
            this.menuNav.Size = new System.Drawing.Size(156, 860);
            this.menuNav.TabIndex = 0;
            this.menuNav.Text = "menuStrip";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.usersToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(151, 41);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // settingsTool
            // 
            this.settingsTool.BackColor = System.Drawing.Color.SkyBlue;
            this.settingsTool.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.settingsTool.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.settingsTool.Name = "settingsTool";
            this.settingsTool.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.settingsTool.Size = new System.Drawing.Size(151, 41);
            this.settingsTool.Text = "Settings";
            this.settingsTool.Click += new System.EventHandler(this.settingsTool_Click);
            // 
            // panelUsers
            // 
            this.panelUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.panelUsers.Location = new System.Drawing.Point(160, 0);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Padding = new System.Windows.Forms.Padding(10);
            this.panelUsers.Size = new System.Drawing.Size(1197, 860);
            this.panelUsers.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(230)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1359, 860);
            this.Controls.Add(this.panelUsers);
            this.Controls.Add(this.menuNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuNav.ResumeLayout(false);
            this.menuNav.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.MenuStrip menuNav;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsTool;
        private System.Windows.Forms.Panel panelUsers;

        #endregion
    }
}