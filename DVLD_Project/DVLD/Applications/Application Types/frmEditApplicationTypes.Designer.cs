namespace DVLD.Applications.Application_Types
{
    partial class frmEditApplicationTypes
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
            label1 = new Label();
            txtTitle = new TextBox();
            label2 = new Label();
            lblAppTypeID = new Label();
            label3 = new Label();
            label4 = new Label();
            txtFees = new TextBox();
            btnSave = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(136, 18);
            label1.Name = "label1";
            label1.Size = new Size(208, 25);
            label1.TabIndex = 2;
            label1.Text = "Edit Application Types";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(108, 140);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(282, 34);
            txtTitle.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(50, 101);
            label2.Name = "label2";
            label2.Size = new Size(35, 21);
            label2.TabIndex = 4;
            label2.Text = "ID :";
            // 
            // lblAppTypeID
            // 
            lblAppTypeID.AutoSize = true;
            lblAppTypeID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAppTypeID.Location = new Point(108, 101);
            lblAppTypeID.Name = "lblAppTypeID";
            lblAppTypeID.Size = new Size(28, 21);
            lblAppTypeID.TabIndex = 5;
            lblAppTypeID.Text = "##";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(50, 147);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 6;
            label3.Text = "Title :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(50, 193);
            label4.Name = "label4";
            label4.Size = new Size(51, 21);
            label4.TabIndex = 7;
            label4.Text = "Fees :";
            // 
            // txtFees
            // 
            txtFees.Location = new Point(108, 186);
            txtFees.Multiline = true;
            txtFees.Name = "txtFees";
            txtFees.Size = new Size(282, 34);
            txtFees.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = SystemColors.ActiveCaption;
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(267, 249);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(123, 36);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.ForeColor = SystemColors.ActiveCaption;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(108, 249);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(123, 36);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmEditApplicationTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(485, 326);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(txtFees);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblAppTypeID);
            Controls.Add(label2);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEditApplicationTypes";
            Text = "Edit Application Types";
            Load += frmEditApplicationTypes_Load;
            Resize += frmEditApplicationTypes_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTitle;
        private Label label2;
        private Label lblAppTypeID;
        private Label label3;
        private Label label4;
        private TextBox txtFees;
        private Button btnSave;
        private Button btnClose;
    }
}