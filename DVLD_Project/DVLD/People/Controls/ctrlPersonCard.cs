using DVLD.Properties;
using DVLD_Business;
using System;
using System.ComponentModel;

namespace DVLD.People.Controls
{
    public partial class ctrlPersonCard : UserControl
    {
        private clsPerson _Person;
        private int _PersonID = -1;

        public int PersonID
        {
            get { return PersonID; }
        }
        public clsPerson SelectedPersonInfo
        {
            get { return _Person; }
        }

        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        private void _LoadPersonImage()
        {
            string ImagePath = _Person.ImagePath;

            if (ImagePath != "")
            {
                if (File.Exists(ImagePath)) picPerson.ImageLocation = ImagePath;
                else MessageBox.Show($"Cound not find this image :\n{ImagePath}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _FillPersonInfo()
        {
            linkEditPersonInfo.Enabled = true;

            txtPersonID.Text = _Person.PersonID.ToString();
            txtName.Text = _Person.FullName;
            txtNationalNo.Text = _Person.NationalNo;
            txtDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString(); ;
            txtGender.Text = _Person.Gender == 0 ? "Male" : "Female";
            txtCountry.Text = clsCountry.Find(_Person.CountryID).CountryName;
            txtEmail.Text = _Person.Email;
            txtPhone.Text = _Person.Phone;
            txtAddress.Text = _Person.Address;

            _LoadPersonImage();
        }

        public void LoadPersonInfo(int PersonId)
        {
            _Person = clsPerson.Find(PersonId);

            if (_Person != null)
            {
                _FillPersonInfo();
                return;
            }

            RestPersonInfo();
            MessageBox.Show($"No Person with ID = {PersonId} is found", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void LoadPersonInfo(string NationalNo)
        {
            _Person = clsPerson.Find(NationalNo);

            if (_Person != null)
            {
                _FillPersonInfo();
                return;
            }

            RestPersonInfo();
            MessageBox.Show($"No Person with NationalNo. = {NationalNo} is found", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void RestPersonInfo()
        {
            txtPersonID.Text = "[??????????]";
            txtName.Text = "[??????????]";
            txtNationalNo.Text = "[??????????]";
            txtDateOfBirth.Text = "[??????????]";
            txtGender.Text = "[??????????]";
            txtCountry.Text = "[??????????]";
            txtEmail.Text = "[??????????]";
            txtPhone.Text = "[??????????]";
            txtAddress.Text = "[??????????]";

            picPerson.Image = Resources.person_man_72;
        }

        private void linkEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(_PersonID);
            frm.ShowDialog();

            LoadPersonInfo(_PersonID);
        }
    }
}
