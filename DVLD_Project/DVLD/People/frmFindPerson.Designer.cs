namespace DVLD.People
{
    partial class frmFindPerson
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
            ctrlPersonCardWithFilter = new DVLD.People.Controls.ctrlPersonCardWithFilter();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(377, 20);
            label1.Name = "label1";
            label1.Size = new Size(166, 37);
            label1.TabIndex = 0;
            label1.Text = "Find Person";
            // 
            // ctrlPersonCardWithFilter
            // 
            ctrlPersonCardWithFilter.BackColor = Color.White;
            ctrlPersonCardWithFilter.FilterEnable = true;
            ctrlPersonCardWithFilter.Location = new Point(12, 72);
            ctrlPersonCardWithFilter.Name = "ctrlPersonCardWithFilter";
            ctrlPersonCardWithFilter.ShowAddPerson = true;
            ctrlPersonCardWithFilter.Size = new Size(901, 496);
            ctrlPersonCardWithFilter.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClose.ForeColor = SystemColors.ActiveCaption;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(749, 568);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(149, 38);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmFindPerson
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(925, 624);
            Controls.Add(btnClose);
            Controls.Add(ctrlPersonCardWithFilter);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmFindPerson";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Find Person";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter;
        private Button btnClose;
    }
}