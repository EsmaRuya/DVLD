namespace DVLD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tsTopMenu = new ToolStrip();
            btnApplications = new ToolStripButton();
            btnPeople = new ToolStripButton();
            btnDrivers = new ToolStripButton();
            btnUsers = new ToolStripButton();
            btnAccountSettings = new ToolStripButton();
            panelContent = new Panel();
            tsTopMenu.SuspendLayout();
            SuspendLayout();
            // 
            // tsTopMenu
            // 
            tsTopMenu.BackgroundImageLayout = ImageLayout.None;
            tsTopMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tsTopMenu.Items.AddRange(new ToolStripItem[] { btnApplications, btnPeople, btnDrivers, btnUsers, btnAccountSettings });
            tsTopMenu.Location = new Point(0, 0);
            tsTopMenu.Name = "tsTopMenu";
            tsTopMenu.Padding = new Padding(0);
            tsTopMenu.Size = new Size(1026, 71);
            tsTopMenu.TabIndex = 0;
            tsTopMenu.Text = "toolStrip1";
            // 
            // btnApplications
            // 
            btnApplications.Image = Properties.Resources.Applications_641;
            btnApplications.ImageScaling = ToolStripItemImageScaling.None;
            btnApplications.ImageTransparentColor = Color.Magenta;
            btnApplications.Name = "btnApplications";
            btnApplications.Size = new Size(174, 68);
            btnApplications.Text = "Applications";
            // 
            // btnPeople
            // 
            btnPeople.Image = Properties.Resources.People_64;
            btnPeople.ImageScaling = ToolStripItemImageScaling.None;
            btnPeople.ImageTransparentColor = Color.Magenta;
            btnPeople.Name = "btnPeople";
            btnPeople.Size = new Size(131, 68);
            btnPeople.Text = "People";
            btnPeople.Click += btnPeople_Click;
            // 
            // btnDrivers
            // 
            btnDrivers.Image = Properties.Resources.Drivers_64;
            btnDrivers.ImageScaling = ToolStripItemImageScaling.None;
            btnDrivers.ImageTransparentColor = Color.Magenta;
            btnDrivers.Name = "btnDrivers";
            btnDrivers.Size = new Size(132, 68);
            btnDrivers.Text = "Drivers";
            // 
            // btnUsers
            // 
            btnUsers.Image = Properties.Resources.Users_2_64;
            btnUsers.ImageScaling = ToolStripItemImageScaling.None;
            btnUsers.ImageTransparentColor = Color.Magenta;
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(119, 68);
            btnUsers.Text = "Users";
            // 
            // btnAccountSettings
            // 
            btnAccountSettings.Image = Properties.Resources.account_settings_64;
            btnAccountSettings.ImageScaling = ToolStripItemImageScaling.None;
            btnAccountSettings.ImageTransparentColor = Color.Magenta;
            btnAccountSettings.Name = "btnAccountSettings";
            btnAccountSettings.Size = new Size(207, 68);
            btnAccountSettings.Text = "Account Settings";
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 71);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1026, 468);
            panelContent.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 539);
            Controls.Add(panelContent);
            Controls.Add(tsTopMenu);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DVLD";
            WindowState = FormWindowState.Maximized;
            tsTopMenu.ResumeLayout(false);
            tsTopMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip tsTopMenu;
        private ToolStripButton btnApplications;
        private ToolStripButton btnPeople;
        private ToolStripButton btnDrivers;
        private ToolStripButton btnUsers;
        private ToolStripButton btnAccountSettings;
        private Panel panelContent;
    }
}
