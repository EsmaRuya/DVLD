using DVLD_Business;
using System;
using System.Data;

namespace DVLD.Tests.Test_Types
{
    public partial class frmListTestTypes : Form
    {
        static DataTable _TestTypesTable = clsTestType.GetAllTestTypes();
        DataTable _dtTestTypes = _TestTypesTable.DefaultView.ToTable(false, "TestTypeId", "TestTypeTitle", "TestTypeDescription", "TestTypeFees");

        public frmListTestTypes()
        {
            InitializeComponent();
        }

        private void _RefreshList()
        {
            _TestTypesTable = clsTestType.GetAllTestTypes();
            _dtTestTypes = _TestTypesTable.DefaultView.ToTable(false, "TestTypeId", "TestTypeTitle", "TestTypeDescription", "TestTypeFees");
            dgvListTestTypes.DataSource = _dtTestTypes;
            lblTestTypesRecord.Text = _dtTestTypes.Rows.Count.ToString();
        }

        private void frmListTestTypes_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(718, 577);
        }

        private void frmListTestTypes_Load(object sender, EventArgs e)
        {
            dgvListTestTypes.DataSource = _dtTestTypes;
            lblTestTypesRecord.Text = _dtTestTypes.Rows.Count.ToString();

            dgvListTestTypes.Columns[0].Width = 65;
            dgvListTestTypes.Columns[0].HeaderText = "ID";

            dgvListTestTypes.Columns[1].Width = 166;
            dgvListTestTypes.Columns[1].HeaderText = "Title";

            dgvListTestTypes.Columns[2].Width = 300;
            dgvListTestTypes.Columns[2].HeaderText = "Desctiption";

            dgvListTestTypes.Columns[3].Width = 100;
            dgvListTestTypes.Columns[3].HeaderText = "Fees";
        }

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditTestTypes frm = new frmEditTestTypes((clsTestType.enTestType)dgvListTestTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
