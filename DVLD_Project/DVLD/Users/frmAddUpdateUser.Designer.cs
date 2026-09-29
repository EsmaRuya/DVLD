namespace DVLD.Users
{
    partial class frmAddUpdateUser
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
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            btnNext = new Button();
            tabControl = new TabControl();
            tbPersonInfo = new TabPage();
            ctrlPersonCardWithFilter = new DVLD.People.Controls.ctrlPersonCardWithFilter();
            tbLoginInfo = new TabPage();
            cb_isActive = new CheckBox();
            lblUserID = new Label();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSave = new Button();
            btnClose = new Button();
            errorProvider = new ErrorProvider(components);
            tabControl.SuspendLayout();
            tbPersonInfo.SuspendLayout();
            tbLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ActiveCaption;
            lblTitle.Location = new Point(355, 3);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 37);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Add New User";
            // 
            // btnNext
            // 
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 12F);
            btnNext.ForeColor = SystemColors.ActiveCaptionText;
            btnNext.Image = Properties.Resources.Next_32;
            btnNext.ImageAlign = ContentAlignment.MiddleLeft;
            btnNext.Location = new Point(738, 488);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(156, 36);
            btnNext.TabIndex = 5;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tbPersonInfo);
            tabControl.Controls.Add(tbLoginInfo);
            tabControl.Location = new Point(12, 43);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(911, 566);
            tabControl.TabIndex = 4;
            // 
            // tbPersonInfo
            // 
            tbPersonInfo.Controls.Add(btnNext);
            tbPersonInfo.Controls.Add(ctrlPersonCardWithFilter);
            tbPersonInfo.Location = new Point(4, 24);
            tbPersonInfo.Name = "tbPersonInfo";
            tbPersonInfo.Padding = new Padding(3);
            tbPersonInfo.Size = new Size(903, 538);
            tbPersonInfo.TabIndex = 1;
            tbPersonInfo.Text = "Personal Info";
            tbPersonInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlPersonCardWithFilter
            // 
            ctrlPersonCardWithFilter.BackColor = Color.White;
            ctrlPersonCardWithFilter.FilterEnabled = true;
            ctrlPersonCardWithFilter.Location = new Point(5, 2);
            ctrlPersonCardWithFilter.Name = "ctrlPersonCardWithFilter";
            ctrlPersonCardWithFilter.ShowAddPerson = true;
            ctrlPersonCardWithFilter.Size = new Size(896, 486);
            ctrlPersonCardWithFilter.TabIndex = 3;
            // 
            // tbLoginInfo
            // 
            tbLoginInfo.Controls.Add(cb_isActive);
            tbLoginInfo.Controls.Add(lblUserID);
            tbLoginInfo.Controls.Add(txtConfirmPassword);
            tbLoginInfo.Controls.Add(txtPassword);
            tbLoginInfo.Controls.Add(txtUserName);
            tbLoginInfo.Controls.Add(pictureBox4);
            tbLoginInfo.Controls.Add(pictureBox3);
            tbLoginInfo.Controls.Add(pictureBox2);
            tbLoginInfo.Controls.Add(pictureBox1);
            tbLoginInfo.Controls.Add(label4);
            tbLoginInfo.Controls.Add(label3);
            tbLoginInfo.Controls.Add(label2);
            tbLoginInfo.Controls.Add(label1);
            tbLoginInfo.Location = new Point(4, 24);
            tbLoginInfo.Name = "tbLoginInfo";
            tbLoginInfo.Padding = new Padding(3);
            tbLoginInfo.Size = new Size(903, 538);
            tbLoginInfo.TabIndex = 2;
            tbLoginInfo.Text = "Login Info";
            tbLoginInfo.UseVisualStyleBackColor = true;
            // 
            // cb_isActive
            // 
            cb_isActive.AutoSize = true;
            cb_isActive.Font = new Font("Segoe UI", 12F);
            cb_isActive.Location = new Point(253, 274);
            cb_isActive.Name = "cb_isActive";
            cb_isActive.Size = new Size(82, 25);
            cb_isActive.TabIndex = 12;
            cb_isActive.Text = "isActive";
            cb_isActive.UseVisualStyleBackColor = true;
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUserID.Location = new Point(253, 83);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(46, 21);
            lblUserID.TabIndex = 11;
            lblUserID.Text = "####";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(253, 225);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(231, 23);
            txtConfirmPassword.TabIndex = 10;
            txtConfirmPassword.Validating += txtConfirmPassword_Validating;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(253, 177);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(231, 23);
            txtPassword.TabIndex = 9;
            txtPassword.Validating += txtPassword_Validating;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(253, 129);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(231, 23);
            txtUserName.TabIndex = 8;
            txtUserName.Validating += txtUserName_Validating;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Number_32;
            pictureBox4.Location = new Point(205, 223);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(29, 28);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Number_32;
            pictureBox3.Location = new Point(205, 175);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 28);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Person_32;
            pictureBox2.Location = new Point(205, 127);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Number_32;
            pictureBox1.Location = new Point(205, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(36, 227);
            label4.Name = "label4";
            label4.Size = new Size(148, 21);
            label4.TabIndex = 3;
            label4.Text = "Confirm Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(102, 179);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(94, 131);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 1;
            label2.Text = "UserName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(119, 83);
            label1.Name = "label1";
            label1.Size = new Size(65, 21);
            label1.TabIndex = 0;
            label1.Text = "User ID";
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.ForeColor = SystemColors.ActiveCaptionText;
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(754, 621);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(156, 36);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F);
            btnClose.ForeColor = SystemColors.ActiveCaptionText;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(592, 621);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(156, 36);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // frmAddUpdateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(930, 688);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(tabControl);
            Controls.Add(lblTitle);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddUpdateUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New User";
            Load += frmAddUpdateUser_Load;
            tabControl.ResumeLayout(false);
            tbPersonInfo.ResumeLayout(false);
            tbLoginInfo.ResumeLayout(false);
            tbLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnNext;
        private TabControl tabControl;
        private TabPage tbPersonInfo;
        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter;
        private TabPage tbLoginInfo;
        private Button btnSave;
        private Button btnClose;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox cb_isActive;
        private Label lblUserID;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private PictureBox pictureBox4;
        private ErrorProvider errorProvider;
    }
}