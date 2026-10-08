namespace DVLD.Tests.Test_Types
{
    partial class frmListTestTypes
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
            lblTestTypesRecord = new Label();
            label2 = new Label();
            dgvListTestTypes = new DataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListTestTypes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClose.ForeColor = SystemColors.ActiveCaption;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(529, 472);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(157, 34);
            btnClose.TabIndex = 12;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // lblTestTypesRecord
            // 
            lblTestTypesRecord.AutoSize = true;
            lblTestTypesRecord.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTestTypesRecord.ForeColor = SystemColors.ActiveCaption;
            lblTestTypesRecord.Location = new Point(118, 481);
            lblTestTypesRecord.Name = "lblTestTypesRecord";
            lblTestTypesRecord.Size = new Size(23, 25);
            lblTestTypesRecord.TabIndex = 11;
            lblTestTypesRecord.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(12, 481);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 10;
            label2.Text = "# Records : ";
            // 
            // dgvListTestTypes
            // 
            dgvListTestTypes.AllowUserToAddRows = false;
            dgvListTestTypes.AllowUserToDeleteRows = false;
            dgvListTestTypes.AllowUserToOrderColumns = true;
            dgvListTestTypes.BackgroundColor = Color.White;
            dgvListTestTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListTestTypes.Location = new Point(12, 200);
            dgvListTestTypes.Name = "dgvListTestTypes";
            dgvListTestTypes.ReadOnly = true;
            dgvListTestTypes.Size = new Size(674, 262);
            dgvListTestTypes.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.TestType_512;
            pictureBox1.Location = new Point(272, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(219, 137);
            label1.Name = "label1";
            label1.Size = new Size(261, 37);
            label1.TabIndex = 7;
            label1.Text = "Manage Test Types";
            // 
            // frmListTestTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(702, 538);
            Controls.Add(btnClose);
            Controls.Add(lblTestTypesRecord);
            Controls.Add(label2);
            Controls.Add(dgvListTestTypes);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmListTestTypes";
            Text = "List Test Types";
            Load += frmListTestTypes_Load;
            Resize += frmListTestTypes_Resize;
            ((System.ComponentModel.ISupportInitialize)dgvListTestTypes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label lblTestTypesRecord;
        private Label label2;
        private DataGridView dgvListTestTypes;
        private PictureBox pictureBox1;
        private Label label1;
    }
}