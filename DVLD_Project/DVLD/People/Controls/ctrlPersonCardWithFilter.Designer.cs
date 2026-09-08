namespace DVLD.People.Controls
{
    partial class ctrlPersonCardWithFilter
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
            ctrlPersonCard1 = new ctrlPersonCard();
            groupBox1 = new GroupBox();
            label1 = new Label();
            cmbFilterBy = new ComboBox();
            txtFilterBy = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlPersonCard1.Location = new Point(3, 84);
            ctrlPersonCard1.Margin = new Padding(4);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(897, 404);
            ctrlPersonCard1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtFilterBy);
            groupBox1.Controls.Add(cmbFilterBy);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(884, 66);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(32, 24);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 0;
            label1.Text = "Filter by";
            // 
            // cmbFilterBy
            // 
            cmbFilterBy.FormattingEnabled = true;
            cmbFilterBy.Location = new Point(118, 26);
            cmbFilterBy.Name = "cmbFilterBy";
            cmbFilterBy.Size = new Size(220, 23);
            cmbFilterBy.TabIndex = 0;
            // 
            // txtFilterBy
            // 
            txtFilterBy.Location = new Point(344, 26);
            txtFilterBy.Name = "txtFilterBy";
            txtFilterBy.Size = new Size(259, 23);
            txtFilterBy.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Image = Properties.Resources.SearchPerson;
            btnSearch.Location = new Point(609, 22);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(38, 35);
            btnSearch.TabIndex = 6;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Image = Properties.Resources.AddPerson_32;
            btnAdd.Location = new Point(653, 22);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(38, 35);
            btnAdd.TabIndex = 7;
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // ctrlPersonCardWithFilter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(ctrlPersonCard1);
            Name = "ctrlPersonCardWithFilter";
            Size = new Size(897, 494);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlPersonCard ctrlPersonCard1;
        private GroupBox groupBox1;
        private TextBox txtFilterBy;
        private ComboBox cmbFilterBy;
        private Label label1;
        private Button btnAdd;
        private Button btnSearch;
    }
}
