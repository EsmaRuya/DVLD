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

        private DataTable _dtPeopleList = _PeopleTable.DefaultView.ToTable(false, "PersonId", "NationalNo", "FirstName", "SecondName", "ThirdName", "LastName", "Gender", "DateOfBirth", "CountryName", "Phone", "Email");

        private void _RefreshPeopleList()
        {
            _PeopleTable = clsPerson.GetAllPeople();

            _dtPeopleList = _PeopleTable.DefaultView.ToTable(false, "PersonId", "NationalNo", "FirstName", "SecondName", "ThirdName", "LastName", "Gender", "DateOfBirth", "CountryName", "Phone", "Email");

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

            frmShowPersonInfo frm = new frmShowPersonInfo();
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
    }
}
