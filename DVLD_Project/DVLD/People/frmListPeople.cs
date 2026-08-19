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

        private void frmPeopleManagement_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(1353, 584);
        }

        private void frmListPeople_Load(object sender, EventArgs e)
        {
            dgvListPeople.DataSource = _dtPeopleList;
            lblRecordsCount.Text = _dtPeopleList.Rows.Count.ToString();
            
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
