namespace DVLD.Applications.Application_Types
{
    partial class frmListApplicationTypes
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dgvListAppTypes = new DataGridView();
            label2 = new Label();
            lblAppTypesRecord = new Label();
            btnClose = new Button();
            contextMenuStrip = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListAppTypes).BeginInit();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(175, 150);
            label1.Name = "label1";
            label1.Size = new Size(246, 25);
            label1.TabIndex = 1;
            label1.Text = "Manage Application Types";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Application_Types_64;
            pictureBox1.Location = new Point(221, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // dgvListAppTypes
            // 
            dgvListAppTypes.AllowUserToAddRows = false;
            dgvListAppTypes.AllowUserToDeleteRows = false;
            dgvListAppTypes.AllowUserToOrderColumns = true;
            dgvListAppTypes.BackgroundColor = Color.White;
            dgvListAppTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListAppTypes.ContextMenuStrip = contextMenuStrip;
            dgvListAppTypes.Location = new Point(12, 221);
            dgvListAppTypes.Name = "dgvListAppTypes";
            dgvListAppTypes.ReadOnly = true;
            dgvListAppTypes.Size = new Size(572, 262);
            dgvListAppTypes.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(12, 498);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 4;
            label2.Text = "# Records : ";
            // 
            // lblAppTypesRecord
            // 
            lblAppTypesRecord.AutoSize = true;
            lblAppTypesRecord.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppTypesRecord.ForeColor = SystemColors.ActiveCaption;
            lblAppTypesRecord.Location = new Point(118, 498);
            lblAppTypesRecord.Name = "lblAppTypesRecord";
            lblAppTypesRecord.Size = new Size(23, 25);
            lblAppTypesRecord.TabIndex = 5;
            lblAppTypesRecord.Text = "0";
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClose.ForeColor = SystemColors.ActiveCaption;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(427, 493);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(157, 34);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem });
            contextMenuStrip.Name = "contextMenuStrip1";
            contextMenuStrip.Size = new Size(182, 26);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(181, 22);
            editToolStripMenuItem.Text = "Edit Apllication Type";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // frmListApplicationTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(596, 550);
            Controls.Add(btnClose);
            Controls.Add(lblAppTypesRecord);
            Controls.Add(label2);
            Controls.Add(dgvListAppTypes);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmListApplicationTypes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Application Types";
            Load += frmListApplicationTypes_Load;
            Resize += frmListApplicationTypes_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListAppTypes).EndInit();
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dgvListAppTypes;
        private Label label2;
        private Label lblAppTypesRecord;
        private Button btnClose;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem editToolStripMenuItem;
    }
}