namespace DVLD.Users
{
    partial class frmChangePassword
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
            ctrlUserCard = new ctrlUserCard();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            txtCurrentPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnSave = new Button();
            btnClose = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // ctrlUserCard
            // 
            ctrlUserCard.Location = new Point(-2, -3);
            ctrlUserCard.Name = "ctrlUserCard";
            ctrlUserCard.Size = new Size(897, 509);
            ctrlUserCard.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(62, 525);
            label1.Name = "label1";
            label1.Size = new Size(143, 21);
            label1.TabIndex = 1;
            label1.Text = "Current Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(84, 566);
            label2.Name = "label2";
            label2.Size = new Size(121, 21);
            label2.TabIndex = 2;
            label2.Text = "New Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(57, 608);
            label3.Name = "label3";
            label3.Size = new Size(148, 21);
            label3.TabIndex = 3;
            label3.Text = "Confirm Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Number_32;
            pictureBox1.Location = new Point(211, 518);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Number_32;
            pictureBox2.Location = new Point(211, 559);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Number_32;
            pictureBox3.Location = new Point(211, 601);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Location = new Point(253, 521);
            txtCurrentPassword.Multiline = true;
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.PasswordChar = '*';
            txtCurrentPassword.Size = new Size(215, 29);
            txtCurrentPassword.TabIndex = 7;
            txtCurrentPassword.Validating += txtCurrentPassword_Validating;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(253, 562);
            txtNewPassword.Multiline = true;
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(215, 29);
            txtNewPassword.TabIndex = 8;
            txtNewPassword.Validating += txtNewPassword_Validating;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(253, 604);
            txtConfirmPassword.Multiline = true;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(215, 29);
            txtConfirmPassword.TabIndex = 9;
            txtConfirmPassword.Validating += txtConfirmPassword_Validating;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSave.ForeColor = SystemColors.ActiveCaption;
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(727, 645);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(153, 40);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClose.ForeColor = SystemColors.ActiveCaption;
            btnClose.Image = Properties.Resources.Close_321;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(568, 645);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(153, 40);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // frmChangePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(892, 697);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtCurrentPassword);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ctrlUserCard);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change Password";
            Load += frmChangePassword_Load;
            Resize += frmChangePassword_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlUserCard ctrlUserCard;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox txtCurrentPassword;
        private TextBox txtNewPassword;
        private TextBox txtConfirmPassword;
        private Button btnSave;
        private Button btnClose;
        private ErrorProvider errorProvider;
    }
}