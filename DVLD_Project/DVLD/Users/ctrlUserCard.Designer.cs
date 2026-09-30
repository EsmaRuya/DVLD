namespace DVLD.Users
{
    partial class ctrlUserCard
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
            ctrlPersonCard1 = new DVLD.People.Controls.ctrlPersonCard();
            groupBox1 = new GroupBox();
            label1 = new Label();
            lblUserID = new Label();
            label3 = new Label();
            lblUsername = new Label();
            label5 = new Label();
            lblisActive = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlPersonCard1.Location = new Point(4, 2);
            ctrlPersonCard1.Margin = new Padding(4);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(897, 404);
            ctrlPersonCard1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblisActive);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblUsername);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblUserID);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(7, 403);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(882, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login information";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(55, 51);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 0;
            label1.Text = "UserID : ";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUserID.Location = new Point(134, 51);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(55, 21);
            lblUserID.TabIndex = 1;
            lblUserID.Text = "#####";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(304, 51);
            label3.Name = "label3";
            label3.Size = new Size(99, 21);
            label3.TabIndex = 2;
            label3.Text = "Username : ";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUsername.Location = new Point(403, 51);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(55, 21);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "#####";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(618, 51);
            label5.Name = "label5";
            label5.Size = new Size(82, 21);
            label5.TabIndex = 4;
            label5.Text = "isActive : ";
            // 
            // lblisActive
            // 
            lblisActive.AutoSize = true;
            lblisActive.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblisActive.Location = new Point(706, 51);
            lblisActive.Name = "lblisActive";
            lblisActive.Size = new Size(55, 21);
            lblisActive.TabIndex = 5;
            lblisActive.Text = "#####";
            // 
            // ctrlUserCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(ctrlPersonCard1);
            Name = "ctrlUserCard";
            Size = new Size(897, 509);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private People.Controls.ctrlPersonCard ctrlPersonCard1;
        private GroupBox groupBox1;
        private Label label5;
        private Label lblUsername;
        private Label label3;
        private Label lblUserID;
        private Label label1;
        private Label lblisActive;
    }
}
