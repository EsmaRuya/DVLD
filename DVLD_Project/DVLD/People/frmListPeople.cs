using System;
using System.Data;
using DVLD_Business;

namespace DVLD.People
{
    public partial class frmListPeople : Form
    {
        public frmListPeople()
        {
            InitializeComponent();
        }

        private static DataTable _PeopleTable = clsPerson.GetAllPeople();

        private DataTable _dtPeopleList = _PeopleTable.DefaultView.ToTable(false, "PersonId", "NationalNo", "FirstName", "SecondName", "ThirdName", "LastName", "capGender", "DateOfBirth", "CountryName", "Phone", "Email");

        private void _RefreshPeopleList()
        {
            _PeopleTable = clsPerson.GetAllPeople();

            _dtPeopleList = _PeopleTable.DefaultView.ToTable(false, "PersonId", "NationalNo", "FirstName", "SecondName", "ThirdName", "LastName", "capGender", "DateOfBirth", "CountryName", "Phone", "Email");

            dgvListPeople.DataSource = _dtPeopleList;
            lblRecordsCount.Text = dgvListPeople.Rows.Count.ToString();
            cbxFilerBy.SelectedIndex = 0;
        }

        private void frmPeopleManagement_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(1353, 584);
        }

        private void frmListPeople_Load(object sender, EventArgs e)
        {

            dgvListPeople.DataSource = _dtPeopleList;
            cbxFilerBy.SelectedIndex = 0;
            lblRecordsCount.Text = _dtPeopleList.Rows.Count.ToString();

            if (dgvListPeople.Rows.Count > 0)
            {
                dgvListPeople.Columns[0].HeaderText = "Person ID";
                dgvListPeople.Columns[1].HeaderText = "National No.";
                dgvListPeople.Columns[2].HeaderText = "First Name";
                dgvListPeople.Columns[3].HeaderText = "Second Name";
                dgvListPeople.Columns[4].HeaderText = "Third Name";
                dgvListPeople.Columns[5].HeaderText = "Last Name";
                dgvListPeople.Columns[6].HeaderText = "Gender";
                dgvListPeople.Columns[7].HeaderText = "Date of birth";
                dgvListPeople.Columns[8].HeaderText = "Country";
                dgvListPeople.Columns[9].HeaderText = "Phone";
                dgvListPeople.Columns[10].HeaderText = "Email";

                dgvListPeople.Columns[6].Width = 80;
            }

        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            _RefreshPeopleList();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonId = (int)dgvListPeople.CurrentRow.Cells[0].Value;

            frmAddUpdatePerson frm = new frmAddUpdatePerson(PersonId);
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonId = (int)dgvListPeople.CurrentRow.Cells[0].Value;

            if (MessageBox.Show($"Are you sure you want to delete person with ID = ( {PersonId} ) ?", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                if (clsPerson.DeletePerson(PersonId))
                {
                    MessageBox.Show("Person is deleted successfully!", "Delete Person", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshPeopleList();
                }
                else MessageBox.Show("Person is not deleted because it has data linked to it", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonId = (int)dgvListPeople.CurrentRow.Cells[0].Value;

            frmShowPersonInfo frm = new frmShowPersonInfo(PersonId);
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not implemented yat!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not implemented yat!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbxFilerBy.Text == "Person ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbxFilerBy.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonId";
                    break;
                case "National No.":
                    FilterColumn = "NationalNo";
                    break;
                case "First Name":
                    FilterColumn = "FirstName";
                    break;
                case "Second Name":
                    FilterColumn = "SecondName";
                    break;
                case "Third Name":
                    FilterColumn = "ThirdName";
                    break;
                case "Last Name":
                    FilterColumn = "LastName";
                    break;
                case "Gender":
                    FilterColumn = "capGender";
                    break;
                case "Date of birth":
                    FilterColumn = "DateOfBirth";
                    break;
                case "Country":
                    FilterColumn = "CountryName";
                    break;
                case "Phone":
                    FilterColumn = "Phone";
                    break;
                case "Email":
                    FilterColumn = "Email";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtFilter.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtPeopleList.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvListPeople.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "PersonId")
            {
                _dtPeopleList.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text.Trim());
            }
            else
            {
                _dtPeopleList.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text.Trim());
            }

            lblRecordsCount.Text = dgvListPeople.Rows.Count.ToString();
        }

        private void cbxFilerBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Visible = (cbxFilerBy.Text != "None");
            if (txtFilter.Visible)
            {
                txtFilter.Text = "";
                txtFilter.Focus();
            }
        }

        private void dgvListPeople_DoubleClick(object sender, EventArgs e)
        {
            Form frm = new frmShowPersonInfo((int)dgvListPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
