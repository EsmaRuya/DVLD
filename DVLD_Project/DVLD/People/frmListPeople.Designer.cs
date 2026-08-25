namespace DVLD.People
{
    partial class frmListPeople
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
            pictureBox1 = new PictureBox();
            dgvListPeople = new DataGridView();
            label2 = new Label();
            cbxFilerBy = new ComboBox();
            btnAddNewPerson = new Button();
            label3 = new Label();
            lblRecordsCount = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListPeople).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(594, 125);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 0;
            label1.Text = "Manage People";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.People_64;
            pictureBox1.Location = new Point(611, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // dgvListPeople
            // 
            dgvListPeople.AllowUserToAddRows = false;
            dgvListPeople.AllowUserToDeleteRows = false;
            dgvListPeople.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListPeople.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvListPeople.BackgroundColor = Color.White;
            dgvListPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListPeople.Location = new Point(12, 195);
            dgvListPeople.Name = "dgvListPeople";
            dgvListPeople.ReadOnly = true;
            dgvListPeople.RowHeadersVisible = false;
            dgvListPeople.Size = new Size(1313, 274);
            dgvListPeople.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(12, 153);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 3;
            label2.Text = "Filter By";
            // 
            // cbxFilerBy
            // 
            cbxFilerBy.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxFilerBy.FormattingEnabled = true;
            cbxFilerBy.Items.AddRange(new object[] { "None", "Person ID", "National No.", "First Name", "Second Name", "Third Name", "Last Name", "Country", "Gender", "Phone", "Email" });
            cbxFilerBy.Location = new Point(90, 149);
            cbxFilerBy.Name = "cbxFilerBy";
            cbxFilerBy.Size = new Size(266, 29);
            cbxFilerBy.TabIndex = 4;
            cbxFilerBy.Text = "None";
            // 
            // btnAddNewPerson
            // 
            btnAddNewPerson.FlatStyle = FlatStyle.Flat;
            btnAddNewPerson.Image = Properties.Resources.AddPerson_32;
            btnAddNewPerson.Location = new Point(1264, 142);
            btnAddNewPerson.Name = "btnAddNewPerson";
            btnAddNewPerson.Size = new Size(61, 45);
            btnAddNewPerson.TabIndex = 5;
            btnAddNewPerson.UseVisualStyleBackColor = true;
            btnAddNewPerson.Click += btnAddNewPerson_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(12, 482);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 6;
            label3.Text = "# Records : ";
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRecordsCount.ForeColor = SystemColors.ActiveCaption;
            lblRecordsCount.Location = new Point(102, 482);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(37, 21);
            lblRecordsCount.TabIndex = 7;
            lblRecordsCount.Text = "###";
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(1175, 482);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(150, 37);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmListPeople
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1337, 545);
            Controls.Add(btnClose);
            Controls.Add(lblRecordsCount);
            Controls.Add(label3);
            Controls.Add(btnAddNewPerson);
            Controls.Add(cbxFilerBy);
            Controls.Add(label2);
            Controls.Add(dgvListPeople);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "frmListPeople";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage people";
            Load += frmListPeople_Load;
            Resize += frmPeopleManagement_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListPeople).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dgvListPeople;
        private Label label2;
        private ComboBox cbxFilerBy;
        private Button btnAddNewPerson;
        private Label label3;
        private Label lblRecordsCount;
        private Button btnClose;
    }
}