using DVLD.Global_Classes;
using DVLD.People;
using DVLD_Business;
using System;

namespace DVLD.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
  
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
           // Application.Exit();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsUser User = clsUser.Find(txtUsername.Text, txtPassword.Text);

            if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Username and Password are required!\nEnter your login info..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (User == null)
            {
                txtUsername.Focus();
                MessageBox.Show("Ops...\nInvalid information. Check your info again!", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);   
                return;
            }

            if (!User.isActive)
            {
                txtUsername.Focus();
                MessageBox.Show("Couldn't login...\nThis account is not active.\nContact admin to active your account.", "Not Active", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 

            if (cbxRememberMe.Checked)
            {
                clsGlobal.RememberUsernamePassword(txtUsername.Text, txtPassword.Text);
            }

            if (!cbxRememberMe.Checked)
            {
                clsGlobal.RememberUsernamePassword("", "");
            }

            clsGlobal.CurrentUser = User;
            this.Hide();
            frmMain frm = new frmMain(this);
            frm.ShowDialog();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string Username = "", Password = "";

            if (clsGlobal.GetStoredCredential(ref Username, ref Password))
            {
                txtUsername.Text = Username;
                txtPassword.Text = Password;
                cbxRememberMe.Checked = true;
            }
            else
                cbxRememberMe.Checked = false;
        }
    }
}
