using DVLD.Global_Classes;
using DVLD_Business;
using System;
using System.ComponentModel;


namespace DVLD.People
{
    public partial class frmAddUpdatePerson : Form
    {
        public delegate void DataBackEventHandler(object sender, int PersonId);
        public event DataBackEventHandler DataBack;

        public enum enGender { Male = 0, Female = 1 };
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private int _PersonId = -1;
        clsPerson _Person;

        public frmAddUpdatePerson()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddUpdatePerson(int PersonId)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _PersonId = PersonId;
        }

        private void _FillCountriesInComboBox()
        {
            cmbCountries.Items.Clear();
            cmbCountries.DataSource = clsCountry.GetAllCountries();
            cmbCountries.ValueMember = "CountryId";
            cmbCountries.DisplayMember = "CountryName";
        }
        private void _ResetDefaultValue()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Person";
                _Person = new clsPerson();
            }
            else lblTitle.Text = "Update Person";

            _FillCountriesInComboBox();
            cmbCountries.SelectedIndex = cmbCountries.FindString("Morocco");

            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;

            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            txtNationalNo.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            rdbMale.Checked = true;

            linkRemove.Visible = (picPerson.ImageLocation != null);
        }

        private void _LoadData()
        {
            _Person = clsPerson.Find(_PersonId);

            if (_Person == null)
            {
                MessageBox.Show($"No person with {_PersonId} ID is found!");
                this.Close();
                return;
            }

            lblPersonID.Text = _PersonId.ToString();
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNo;
            txtPhone.Text = _Person.Phone;
            txtEmail.Text = _Person.Email;
            txtAddress.Text = _Person.Address;

            dtpDateOfBirth.Value = _Person.DateOfBirth;

            if (_Person.Gender == (short)enGender.Male) rdbMale.Checked = true;
            else rdbFemale.Checked = true;

            cmbCountries.SelectedItem = cmbCountries.FindString(_Person.CountryInfo.CountryName);

            if (_Person.ImagePath != "") picPerson.ImageLocation = _Person.ImagePath;

            linkRemove.Visible = (_Person.ImagePath != "");
        }
        private void frmAddUpdatePerson_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(1007, 585);
        }

        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            btnClose.Focus();
            _ResetDefaultValue();
            if (_Mode == enMode.Update) _LoadData();
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            TextBox txtbx = (TextBox)sender;
            if (string.IsNullOrEmpty(txtbx.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtbx, "This field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtbx, null);
            }
        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNationalNo, "This field is required!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtNationalNo, null);
            }

            if (txtNationalNo.Text.Trim() != _Person.NationalNo && clsPerson.isPersonExist(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNationalNo, "This National No is already exist!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtNationalNo, null);
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhone.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPhone, "This field is required!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtPhone, null);
            }

            // check if it's number
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.Trim() == "") return;

            if (!clsValidation.validateEmail(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtEmail, "Invalid email address format!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtEmail, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valide");
                return;
            }

            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.SecondName = txtSecondName.Text.Trim();
            _Person.ThirdName = txtThirdName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();
            _Person.NationalNo = txtNationalNo.Text.Trim();
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            if (rdbFemale.Checked) _Person.Gender = (short)enGender.Female;
            else _Person.Gender = (short)enGender.Male;
            _Person.Phone = txtPhone.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            int nationalityCountryId = clsCountry.Find(cmbCountries.Text).CountryID;
            _Person.CountryID = nationalityCountryId;
            _Person.Address = txtAddress.Text.Trim();
            if (picPerson.ImageLocation != null) _Person.ImagePath = picPerson.ImageLocation;
            else _Person.ImagePath = "";


            if (_Person.Save())
            {
                lblPersonID.Text = _Person.PersonID.ToString();
                _Mode = enMode.Update;
                lblTitle.Text = "Update Person";
                MessageBox.Show("Data saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataBack?.Invoke(this, _Person.PersonID);

                this.Close(); // to close window after save
            }
            else MessageBox.Show("Error!! Data is not saved successfully!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // later
        }

        private void linkRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // later
        }
    }
}
