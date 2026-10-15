namespace DVLD.Applications.Local_Driving_License
{
    partial class frmAddUpdateLocalDrivingLicenseApplications
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
            tabControl = new TabControl();
            tbPersonalinfo = new TabPage();
            btnNext = new Button();
            ctrlPersonCardWithFilter = new DVLD.People.Controls.ctrlPersonCardWithFilter();
            tpApplicationInfo = new TabPage();
            btnClose = new Button();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            lblDLAppID = new Label();
            lblAppDate = new Label();
            lblAppFees = new Label();
            lblCreatedBy = new Label();
            cbLicenseClass = new ComboBox();
            tabControl.SuspendLayout();
            tbPersonalinfo.SuspendLayout();
            tpApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ActiveCaption;
            lblTitle.Location = new Point(215, 20);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(507, 37);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "New Local Driving License Application";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tbPersonalinfo);
            tabControl.Controls.Add(tpApplicationInfo);
            tabControl.Location = new Point(12, 56);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(912, 588);
            tabControl.TabIndex = 3;
            // 
            // tbPersonalinfo
            // 
            tbPersonalinfo.Controls.Add(btnNext);
            tbPersonalinfo.Controls.Add(ctrlPersonCardWithFilter);
            tbPersonalinfo.Location = new Point(4, 30);
            tbPersonalinfo.Name = "tbPersonalinfo";
            tbPersonalinfo.Padding = new Padding(3);
            tbPersonalinfo.Size = new Size(904, 554);
            tbPersonalinfo.TabIndex = 1;
            tbPersonalinfo.Text = "Personal Info";
            tbPersonalinfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 12F);
            btnNext.ForeColor = SystemColors.ActiveCaptionText;
            btnNext.Image = Properties.Resources.Next_32;
            btnNext.ImageAlign = ContentAlignment.MiddleLeft;
            btnNext.Location = new Point(735, 502);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(156, 36);
            btnNext.TabIndex = 8;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // ctrlPersonCardWithFilter
            // 
            ctrlPersonCardWithFilter.BackColor = Color.White;
            ctrlPersonCardWithFilter.FilterEnabled = true;
            ctrlPersonCardWithFilter.Location = new Point(6, 6);
            ctrlPersonCardWithFilter.Name = "ctrlPersonCardWithFilter";
            ctrlPersonCardWithFilter.ShowAddPerson = true;
            ctrlPersonCardWithFilter.Size = new Size(897, 490);
            ctrlPersonCardWithFilter.TabIndex = 7;
            // 
            // tpApplicationInfo
            // 
            tpApplicationInfo.Controls.Add(cbLicenseClass);
            tpApplicationInfo.Controls.Add(lblCreatedBy);
            tpApplicationInfo.Controls.Add(lblAppFees);
            tpApplicationInfo.Controls.Add(lblAppDate);
            tpApplicationInfo.Controls.Add(lblDLAppID);
            tpApplicationInfo.Controls.Add(pictureBox5);
            tpApplicationInfo.Controls.Add(pictureBox4);
            tpApplicationInfo.Controls.Add(pictureBox3);
            tpApplicationInfo.Controls.Add(pictureBox2);
            tpApplicationInfo.Controls.Add(pictureBox1);
            tpApplicationInfo.Controls.Add(label5);
            tpApplicationInfo.Controls.Add(label4);
            tpApplicationInfo.Controls.Add(label3);
            tpApplicationInfo.Controls.Add(label2);
            tpApplicationInfo.Controls.Add(label1);
            tpApplicationInfo.Location = new Point(4, 30);
            tpApplicationInfo.Name = "tpApplicationInfo";
            tpApplicationInfo.Size = new Size(904, 554);
            tpApplicationInfo.TabIndex = 2;
            tpApplicationInfo.Text = "Application Info";
            tpApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F);
            btnClose.ForeColor = SystemColors.ActiveCaptionText;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(602, 662);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(156, 36);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.ForeColor = SystemColors.ActiveCaptionText;
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(764, 662);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(156, 36);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(76, 95);
            label1.Name = "label1";
            label1.Size = new Size(147, 21);
            label1.TabIndex = 0;
            label1.Text = "D.L Application ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(76, 142);
            label2.Name = "label2";
            label2.Size = new Size(139, 21);
            label2.TabIndex = 1;
            label2.Text = "Application Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(76, 189);
            label3.Name = "label3";
            label3.Size = new Size(108, 21);
            label3.TabIndex = 2;
            label3.Text = "License Class";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(76, 236);
            label4.Name = "label4";
            label4.Size = new Size(136, 21);
            label4.TabIndex = 3;
            label4.Text = "Application Fees";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(76, 283);
            label5.Name = "label5";
            label5.Size = new Size(92, 21);
            label5.TabIndex = 4;
            label5.Text = "Created By";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Number_32;
            pictureBox1.Location = new Point(229, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Calendar_32;
            pictureBox2.Location = new Point(229, 136);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.LocalDriving_License;
            pictureBox3.Location = new Point(229, 183);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(28, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.bill_32;
            pictureBox4.Location = new Point(229, 230);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(28, 27);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Person_32;
            pictureBox5.Location = new Point(229, 277);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(28, 27);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // lblDLAppID
            // 
            lblDLAppID.AutoSize = true;
            lblDLAppID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDLAppID.Location = new Point(289, 95);
            lblDLAppID.Name = "lblDLAppID";
            lblDLAppID.Size = new Size(46, 21);
            lblDLAppID.TabIndex = 10;
            lblDLAppID.Text = "####";
            // 
            // lblAppDate
            // 
            lblAppDate.AutoSize = true;
            lblAppDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAppDate.Location = new Point(289, 136);
            lblAppDate.Name = "lblAppDate";
            lblAppDate.Size = new Size(46, 21);
            lblAppDate.TabIndex = 11;
            lblAppDate.Text = "####";
            // 
            // lblAppFees
            // 
            lblAppFees.AutoSize = true;
            lblAppFees.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAppFees.Location = new Point(289, 236);
            lblAppFees.Name = "lblAppFees";
            lblAppFees.Size = new Size(46, 21);
            lblAppFees.TabIndex = 12;
            lblAppFees.Text = "####";
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize = true;
            lblCreatedBy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCreatedBy.Location = new Point(289, 283);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(46, 21);
            lblCreatedBy.TabIndex = 13;
            lblCreatedBy.Text = "####";
            // 
            // cbLicenseClass
            // 
            cbLicenseClass.FormattingEnabled = true;
            cbLicenseClass.Location = new Point(289, 186);
            cbLicenseClass.Name = "cbLicenseClass";
            cbLicenseClass.Size = new Size(223, 29);
            cbLicenseClass.TabIndex = 14;
            // 
            // frmAddUpdateLocalDrivingLicenseApplications
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(935, 710);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(tabControl);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddUpdateLocalDrivingLicenseApplications";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Local Driving License Application";
            Resize += frmAddUpdateLocalDrivingLicenseApplications_Resize;
            tabControl.ResumeLayout(false);
            tbPersonalinfo.ResumeLayout(false);
            tpApplicationInfo.ResumeLayout(false);
            tpApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TabControl tabControl;
        private TabPage tbPersonalinfo;
        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter;
        private TabPage tpApplicationInfo;
        private Button btnNext;
        private Button btnClose;
        private Button btnSave;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblDLAppID;
        private ComboBox cbLicenseClass;
        private Label lblCreatedBy;
        private Label lblAppFees;
        private Label lblAppDate;
    }
}