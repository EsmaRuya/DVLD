namespace DVLD.Tests.Test_Types
{
    partial class frmEditTestTypes
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
            btnClose = new Button();
            btnSave = new Button();
            txtFees = new TextBox();
            label4 = new Label();
            label3 = new Label();
            lblTestTypeID = new Label();
            txtTitle = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            txtDescription = new TextBox();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.ForeColor = SystemColors.ActiveCaption;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(154, 347);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(123, 36);
            btnClose.TabIndex = 18;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = SystemColors.ActiveCaption;
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(313, 347);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(123, 36);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtFees
            // 
            txtFees.Location = new Point(154, 290);
            txtFees.Name = "txtFees";
            txtFees.Size = new Size(282, 23);
            txtFees.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(79, 290);
            label4.Name = "label4";
            label4.Size = new Size(51, 21);
            label4.TabIndex = 15;
            label4.Text = "Fees :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(78, 135);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 14;
            label3.Text = "Title :";
            // 
            // lblTestTypeID
            // 
            lblTestTypeID.AutoSize = true;
            lblTestTypeID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTestTypeID.Location = new Point(154, 97);
            lblTestTypeID.Name = "lblTestTypeID";
            lblTestTypeID.Size = new Size(28, 21);
            lblTestTypeID.TabIndex = 13;
            lblTestTypeID.Text = "##";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(154, 135);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(282, 23);
            txtTitle.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(145, 21);
            label1.Name = "label1";
            label1.Size = new Size(207, 37);
            label1.TabIndex = 11;
            label1.Text = "Edit Test Types";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(95, 97);
            label2.Name = "label2";
            label2.Size = new Size(35, 21);
            label2.TabIndex = 19;
            label2.Text = "ID :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(24, 175);
            label5.Name = "label5";
            label5.Size = new Size(106, 21);
            label5.TabIndex = 21;
            label5.Text = "Description :";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(154, 175);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(282, 98);
            txtDescription.TabIndex = 20;
            // 
            // frmEditTestTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(497, 426);
            Controls.Add(label5);
            Controls.Add(txtDescription);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(txtFees);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblTestTypeID);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEditTestTypes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Test Types";
            Load += frmEditTestTypes_Load;
            Resize += frmEditTestTypes_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnSave;
        private TextBox txtFees;
        private Label label4;
        private Label label3;
        private Label lblTestTypeID;
        private TextBox txtTitle;
        private Label label1;
        private Label label2;
        private Label label5;
        private TextBox txtDescription;
    }
}