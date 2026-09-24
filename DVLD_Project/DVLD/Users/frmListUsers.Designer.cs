namespace DVLD.Users
{
    partial class frmListUsers
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
            txtFilter = new TextBox();
            lblRecordsCount = new Label();
            label3 = new Label();
            btnAddNewUser = new Button();
            cbxFilerBy = new ComboBox();
            label2 = new Label();
            phoneCallToolStripMenuItem = new ToolStripMenuItem();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            btnClose = new Button();
            toolStripSeparator2 = new ToolStripSeparator();
            editToolStripMenuItem = new ToolStripMenuItem();
            addNewPersonToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            dgvListUsers = new DataGridView();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(252, 229);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(230, 23);
            txtFilter.TabIndex = 19;
            txtFilter.Visible = false;
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRecordsCount.ForeColor = SystemColors.ActiveCaption;
            lblRecordsCount.Location = new Point(111, 546);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(37, 21);
            lblRecordsCount.TabIndex = 17;
            lblRecordsCount.Text = "###";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(21, 546);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 16;
            label3.Text = "# Records : ";
            // 
            // btnAddNewUser
            // 
            btnAddNewUser.FlatStyle = FlatStyle.Flat;
            btnAddNewUser.Image = Properties.Resources.Add_New_User_32;
            btnAddNewUser.Location = new Point(720, 207);
            btnAddNewUser.Name = "btnAddNewUser";
            btnAddNewUser.Size = new Size(61, 45);
            btnAddNewUser.TabIndex = 15;
            btnAddNewUser.UseVisualStyleBackColor = true;
            // 
            // cbxFilerBy
            // 
            cbxFilerBy.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxFilerBy.FormattingEnabled = true;
            cbxFilerBy.Items.AddRange(new object[] { "None", "Person ID", "National No.", "First Name", "Second Name", "Third Name", "Last Name", "Country", "Gender", "Phone", "Email" });
            cbxFilerBy.Location = new Point(99, 229);
            cbxFilerBy.Name = "cbxFilerBy";
            cbxFilerBy.Size = new Size(147, 23);
            cbxFilerBy.TabIndex = 14;
            cbxFilerBy.Text = "None";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(21, 230);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 13;
            label2.Text = "Filter By";
            // 
            // phoneCallToolStripMenuItem
            // 
            phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            phoneCallToolStripMenuItem.Size = new Size(162, 22);
            phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(162, 22);
            sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(646, 539);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(135, 28);
            btnClose.TabIndex = 18;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(159, 6);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(162, 22);
            editToolStripMenuItem.Text = "Edit";
            // 
            // addNewPersonToolStripMenuItem
            // 
            addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            addNewPersonToolStripMenuItem.Size = new Size(162, 22);
            addNewPersonToolStripMenuItem.Text = "Add New Person";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(159, 6);
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(162, 22);
            showDetailsToolStripMenuItem.Text = "Show Details";
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, toolStripSeparator1, addNewPersonToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, toolStripSeparator2, sendEmailToolStripMenuItem, phoneCallToolStripMenuItem });
            contextMenuStrip.Name = "contextMenuStrip1";
            contextMenuStrip.Size = new Size(163, 148);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(162, 22);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // dgvListUsers
            // 
            dgvListUsers.AllowUserToAddRows = false;
            dgvListUsers.AllowUserToDeleteRows = false;
            dgvListUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvListUsers.BackgroundColor = Color.White;
            dgvListUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListUsers.ContextMenuStrip = contextMenuStrip;
            dgvListUsers.Location = new Point(21, 259);
            dgvListUsers.Name = "dgvListUsers";
            dgvListUsers.ReadOnly = true;
            dgvListUsers.Size = new Size(760, 274);
            dgvListUsers.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(327, 158);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 10;
            label1.Text = "Manage People";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Users_2_64;
            pictureBox1.Location = new Point(332, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // frmListUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(814, 594);
            Controls.Add(txtFilter);
            Controls.Add(lblRecordsCount);
            Controls.Add(label3);
            Controls.Add(btnAddNewUser);
            Controls.Add(cbxFilerBy);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(dgvListUsers);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmListUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Users";
            Resize += frmListUsers_Resize;
            contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFilter;
        private Label lblRecordsCount;
        private Label label3;
        private Button btnAddNewUser;
        private ComboBox cbxFilerBy;
        private Label label2;
        private ToolStripMenuItem phoneCallToolStripMenuItem;
        private ToolStripMenuItem sendEmailToolStripMenuItem;
        private Button btnClose;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem addNewPersonToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private DataGridView dgvListUsers;
        private Label label1;
        private PictureBox pictureBox1;
    }
}