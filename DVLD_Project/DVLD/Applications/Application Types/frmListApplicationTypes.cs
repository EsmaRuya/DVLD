using DVLD_Business;
using System;
using System.Data;

namespace DVLD.Applications.Application_Types
{
    public partial class frmListApplicationTypes : Form
    {
        static DataTable _AppTypesTable = clsApplicationType.GetAllApplicationTypes();
        DataTable _dtAppTypes = _AppTypesTable.DefaultView.ToTable(false, "ApplicationTypesId", "ApplicationTitle", "ApplicationFees");

        public frmListApplicationTypes()
        {
            InitializeComponent();
        }

        private void _RefreshList()
        {
            _AppTypesTable = clsApplicationType.GetAllApplicationTypes();
            _dtAppTypes = _AppTypesTable.DefaultView.ToTable(false, "ApplicationTypesId", "ApplicationTitle", "ApplicationFees");
            dgvListAppTypes.DataSource = _dtAppTypes;
            lblAppTypesRecord.Text = _dtAppTypes.Rows.Count.ToString();
        }

        private void frmListApplicationTypes_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(612, 589);
        }

        private void frmListApplicationTypes_Load(object sender, EventArgs e)
        {
            dgvListAppTypes.DataSource = _dtAppTypes;
            lblAppTypesRecord.Text = _dtAppTypes.Rows.Count.ToString();

            dgvListAppTypes.Columns[0].Width = 75;
            dgvListAppTypes.Columns[0].HeaderText = "ID";
            dgvListAppTypes.Columns[1].Width = 360;
            dgvListAppTypes.Columns[1].HeaderText = "Title";
            dgvListAppTypes.Columns[2].Width = 92;
            dgvListAppTypes.Columns[2].HeaderText = "Fees";
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmEditApplicationTypes frm = new frmEditApplicationTypes((int)dgvListAppTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
           // frmListApplicationTypes_Load(null,null);
            _RefreshList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
