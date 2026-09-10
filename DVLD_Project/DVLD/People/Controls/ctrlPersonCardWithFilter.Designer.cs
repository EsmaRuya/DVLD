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
            components = new System.ComponentModel.Container();
            ctrlPersonCard = new ctrlPersonCard();
            groupBoxFilter = new GroupBox();
            btnAdd = new Button();
            btnSearch = new Button();
            txtFilterBy = new TextBox();
            cmbFilterBy = new ComboBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            groupBoxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ctrlPersonCard
            // 
            ctrlPersonCard.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlPersonCard.Location = new Point(3, 84);
            ctrlPersonCard.Margin = new Padding(4);
            ctrlPersonCard.Name = "ctrlPersonCard";
            ctrlPersonCard.Size = new Size(897, 404);
            ctrlPersonCard.TabIndex = 0;
            // 
            // groupBoxFilter
            // 
            groupBoxFilter.Controls.Add(btnAdd);
            groupBoxFilter.Controls.Add(btnSearch);
            groupBoxFilter.Controls.Add(txtFilterBy);
            groupBoxFilter.Controls.Add(cmbFilterBy);
            groupBoxFilter.Location = new Point(3, 3);
            groupBoxFilter.Name = "groupBoxFilter";
            groupBoxFilter.Size = new Size(884, 66);
            groupBoxFilter.TabIndex = 1;
            groupBoxFilter.TabStop = false;
            groupBoxFilter.Text = "Filter";
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
            btnAdd.Click += btnAdd_Click;
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
            btnSearch.Click += btnSearch_Click;
            // 
            // txtFilterBy
            // 
            txtFilterBy.Location = new Point(344, 26);
            txtFilterBy.Name = "txtFilterBy";
            txtFilterBy.Size = new Size(259, 23);
            txtFilterBy.TabIndex = 1;
            txtFilterBy.KeyPress += txtFilterBy_KeyPress;
            txtFilterBy.Validating += txtFilterBy_Validating;
            // 
            // cmbFilterBy
            // 
            cmbFilterBy.FormattingEnabled = true;
            cmbFilterBy.Items.AddRange(new object[] { "Person ID", "National No." });
            cmbFilterBy.Location = new Point(118, 26);
            cmbFilterBy.Name = "cmbFilterBy";
            cmbFilterBy.Size = new Size(220, 23);
            cmbFilterBy.TabIndex = 0;
            cmbFilterBy.SelectedIndexChanged += cmbFilterBy_SelectedIndexChanged;
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
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ctrlPersonCardWithFilter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(groupBoxFilter);
            Controls.Add(ctrlPersonCard);
            Name = "ctrlPersonCardWithFilter";
            Size = new Size(897, 494);
            Load += ctrlPersonCardWithFilter_Load;
            groupBoxFilter.ResumeLayout(false);
            groupBoxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlPersonCard ctrlPersonCard;
        private GroupBox groupBoxFilter;
        private TextBox txtFilterBy;
        private ComboBox cmbFilterBy;
        private Label label1;
        private Button btnAdd;
        private Button btnSearch;
        private ErrorProvider errorProvider1;
    }
}
