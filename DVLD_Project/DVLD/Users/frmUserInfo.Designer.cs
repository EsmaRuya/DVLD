namespace DVLD.Users
{
    partial class frmUserInfo
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
            ctrlUserCard = new ctrlUserCard();
            button1 = new Button();
            SuspendLayout();
            // 
            // ctrlUserCard
            // 
            ctrlUserCard.Location = new Point(0, 12);
            ctrlUserCard.Name = "ctrlUserCard";
            ctrlUserCard.Size = new Size(897, 509);
            ctrlUserCard.TabIndex = 0;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ActiveCaption;
            button1.Image = Properties.Resources.Close_32;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(724, 530);
            button1.Name = "button1";
            button1.Size = new Size(163, 40);
            button1.TabIndex = 1;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmUserInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(894, 584);
            Controls.Add(button1);
            Controls.Add(ctrlUserCard);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmUserInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Info";
            Load += frmUserInfo_Load;
            ResumeLayout(false);
        }

        #endregion

        private ctrlUserCard ctrlUserCard;
        private Button button1;
    }
}