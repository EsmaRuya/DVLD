namespace DVLD.Applications.Local_Driving_License
{
    partial class frmListLocalDrivingLicenseApplications
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
            lblTitle = new Label();
            txtFilter = new TextBox();
            lblRecordsCount = new Label();
            label3 = new Label();
            cbxFilerBy = new ComboBox();
            label2 = new Label();
            btnClose = new Button();
            dgvListLDLapp = new DataGridView();
            pictureBox1 = new PictureBox();
            btnAddNewApp = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListLDLapp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ActiveCaption;
            lblTitle.Location = new Point(143, 144);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(506, 37);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "List Local Driving License Applications";
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(247, 216);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(230, 29);
            txtFilter.TabIndex = 28;
            txtFilter.Visible = false;
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRecordsCount.ForeColor = SystemColors.ActiveCaption;
            lblRecordsCount.Location = new Point(106, 546);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(37, 21);
            lblRecordsCount.TabIndex = 26;
            lblRecordsCount.Text = "###";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(16, 546);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 25;
            label3.Text = "# Records : ";
            // 
            // cbxFilerBy
            // 
            cbxFilerBy.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxFilerBy.FormattingEnabled = true;
            cbxFilerBy.Items.AddRange(new object[] { "None", "L.D.L App ID", "National No.", "Full Name", "Status" });
            cbxFilerBy.Location = new Point(94, 216);
            cbxFilerBy.Name = "cbxFilerBy";
            cbxFilerBy.Size = new Size(147, 29);
            cbxFilerBy.TabIndex = 23;
            cbxFilerBy.Text = "None";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(16, 217);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 22;
            label2.Text = "Filter By";
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(641, 539);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(135, 35);
            btnClose.TabIndex = 27;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // dgvListLDLapp
            // 
            dgvListLDLapp.AllowUserToAddRows = false;
            dgvListLDLapp.AllowUserToDeleteRows = false;
            dgvListLDLapp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListLDLapp.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvListLDLapp.BackgroundColor = Color.White;
            dgvListLDLapp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListLDLapp.Location = new Point(16, 254);
            dgvListLDLapp.Name = "dgvListLDLapp";
            dgvListLDLapp.ReadOnly = true;
            dgvListLDLapp.Size = new Size(760, 274);
            dgvListLDLapp.TabIndex = 21;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Applications;
            pictureBox1.Location = new Point(266, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // btnAddNewApp
            // 
            btnAddNewApp.FlatStyle = FlatStyle.Flat;
            btnAddNewApp.Image = Properties.Resources.papers_321;
            btnAddNewApp.Location = new Point(715, 200);
            btnAddNewApp.Name = "btnAddNewApp";
            btnAddNewApp.Size = new Size(61, 38);
            btnAddNewApp.TabIndex = 30;
            btnAddNewApp.UseVisualStyleBackColor = true;
            // 
            // frmListLocalDrivingLicenseApplications
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(791, 586);
            Controls.Add(btnAddNewApp);
            Controls.Add(pictureBox1);
            Controls.Add(txtFilter);
            Controls.Add(lblRecordsCount);
            Controls.Add(label3);
            Controls.Add(cbxFilerBy);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(dgvListLDLapp);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmListLocalDrivingLicenseApplications";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "List Local Driving License Applications";
            Resize += frmListLocalDrivingLicenseApplications_Resize;
            ((System.ComponentModel.ISupportInitialize)dgvListLDLapp).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ComboBox cbisActive;
        private TextBox txtFilter;
        private Label lblRecordsCount;
        private Label label3;
        private Button btnAddNewUser;
        private ComboBox cbxFilerBy;
        private Label label2;
        private Button btnClose;
        private DataGridView dgvListLDLapp;
        private PictureBox pictureBox1;
        private Button btnAddNewApplication;
        private Button btnAddNewApp;
    }
}