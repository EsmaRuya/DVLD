using DVLD_Business;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD.Users
{
    public partial class frmChangePassword : Form
    {
        private int _UserID = -1;
        private clsUser _User;
        public frmChangePassword(int UserId)
        {
            InitializeComponent();
            
            _UserID = UserId;
        }

        private void _RestDefaultValues()
        {
            txtCurrentPassword.Text = "";
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtCurrentPassword.Focus();
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

        private void frmChangePassword_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(908, 736);
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _RestDefaultValues();

            _User = clsUser.Find(_UserID);
            if (_User == null)
            {
                MessageBox.Show($"Could not find user with ID {_UserID}","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ctrlUserCard.LoadUserInfo(_UserID);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid! Check again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            _User.Password = txtNewPassword.Text;

            if(_User.Save())
            {
                MessageBox.Show("Password changed successfully", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error...\nPassword is NOT changed successfully", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCurrentPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _CheckTxtIsEmpty(txtCurrentPassword, e);

            if (txtCurrentPassword.Text.Trim() != _User.Password)
            {
                e.Cancel = true;
                errorProvider.SetError(txtCurrentPassword, "Wrong password! Try again");
                return;
            }
            else errorProvider.SetError(txtCurrentPassword, null);
        }

        private void txtNewPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _CheckTxtIsEmpty(txtNewPassword, e);
        }

        private void txtConfirmPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _CheckTxtIsEmpty(txtConfirmPassword, e);

            if (txtNewPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider.SetError(txtConfirmPassword, "Password confirmation doesn't match! Try again...");
            }
            else errorProvider.SetError(txtConfirmPassword, null);
        }


    }
}
