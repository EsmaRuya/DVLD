using DVLD.People.Controls;
using DVLD_Business;
using System;
using System.ComponentModel;

namespace DVLD.Users
{
    public partial class frmAddUpdateUser : Form
    {
        public enum enMode { AddNewUser = 0, UpdateUser = 1 }
        enMode _Mode;
        clsUser _User;
        int _UserID = -1;

        public frmAddUpdateUser()
        {
            InitializeComponent();

            _Mode = enMode.AddNewUser;
        }

        public frmAddUpdateUser(int UserId)
        {
            InitializeComponent();
            _UserID = UserId;
            _Mode = enMode.UpdateUser;
        }

        private void _RestDefaultValues()
        {
            if (_Mode == enMode.AddNewUser)
            {
                this.Text = "Add New User";
                lblTitle.Text = "Add New User";
                _User = new clsUser();
                tbLoginInfo.Enabled = false;
            }
            else
            {
                this.Text = "Update User";
                lblTitle.Text = "Update User";
                tbLoginInfo.Enabled = true;
                btnSave.Enabled = true;
            }

            lblUserID.Text = "####";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            cb_isActive.Checked = false;
        }
        private void _LoadData()
        {
            _User = clsUser.Find(_UserID);
            ctrlPersonCardWithFilter.FilterEnabled = false;

            if (_User == null)
            {
                MessageBox.Show($"No User with ID {_UserID}", "No User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            cb_isActive.Checked = _User.isActive;
            ctrlPersonCardWithFilter.LoadPersonInfo(_User.UserID);
        }

        private void _CheckTxtIsEmpty(TextBox txt, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txt, "This field is required");
                return;
            }
            else
            {
                errorProvider.SetError(txt, null);
            }
        }

        private void _CheckIfUsernameExist(object sender, CancelEventArgs e)
        {
            if (clsUser.isUserExist(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtUserName, "This username is already used by another user");
                return;
            }
            else errorProvider.SetError(txtUserName, null);
        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _RestDefaultValues();
            if (_Mode == enMode.UpdateUser) _LoadData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.UpdateUser)
            {
                btnSave.Enabled = true;
                tbLoginInfo.Enabled = true;
                tabControl.SelectedIndex = 1;
                return;
            }

            // For New Users
            if (ctrlPersonCardWithFilter.PersonID != -1)
            {
                if (clsUser.isUserExistForPersonId(ctrlPersonCardWithFilter.PersonID))
                {
                    MessageBox.Show("This person is already a user.\nChoose another one.", "User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    btnSave.Enabled = true;
                    tbLoginInfo.Enabled = true;
                    tabControl.SelectedIndex = 1;
                }
            }

            else
                MessageBox.Show("Please select a person.", "Select a person", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid! Check again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.personID = ctrlPersonCardWithFilter.PersonID;
            _User.UserName = txtUserName.Text.Trim();
            _User.Password = txtPassword.Text.Trim();
            _User.isActive = cb_isActive.Checked;

            if (_User.Save())
            {
                lblUserID.Text = _User.UserID.ToString();
                _Mode = enMode.UpdateUser;
                this.Text = "Update User";
                lblTitle.Text = "Update User";

                MessageBox.Show("Data Saved succesfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else MessageBox.Show("Data is not Saved succesfully!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            _CheckTxtIsEmpty(txtUserName, e);

            if(_Mode == enMode.AddNewUser)
            {
                _CheckIfUsernameExist(sender, e);
            }

            // For update
            if (_User.UserName != txtUserName.Text.Trim())
            {
                _CheckIfUsernameExist(sender, e);
            }
        }

        private void txtPassword_Validating(object sender,CancelEventArgs e)
        {
            _CheckTxtIsEmpty(txtPassword, e);
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            _CheckTxtIsEmpty(txtConfirmPassword, e);

            if(txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider.SetError(txtConfirmPassword, "Password confirmation doesn't match password");
            }
            else errorProvider.SetError(txtConfirmPassword, null);
        }
    }
}
