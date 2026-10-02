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


        private clsUser _User;
        string file = "Users.txt";
        string loginInfo = "";

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _User = clsUser.Find(txtUsername.Text, txtPassword.Text);

            if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Username and Password are required!\nEnter your login info..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_User == null)
            {
                MessageBox.Show("Ops...\nWrong information. No user Found!", "No User Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_User.isActive == false)
            {
                MessageBox.Show("Couldn't login...\nThis user is not active.", "Not Active", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 

            if (cbxRememberMe.Checked)
            {
                loginInfo = txtUsername.Text + "|" + txtPassword.Text;

                if (!File.Exists(file))
                {
                    File.Create(file).Close(); 
                }

                if (!File.ReadAllText(file).Contains(loginInfo))
                { 
                    File.WriteAllText(file, loginInfo);
                }
            }

            if (!cbxRememberMe.Checked)
            {
                File.Delete(file);
            }

            frmMain frm = new frmMain();
            frm.Show();
            this.Visible = false;

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string str = "";
            string[] strArr;
          

            if (File.Exists(file))
            {
                str = File.ReadAllText(file);
                strArr = str.Split('|');

                if (clsUser.isUserExist(strArr[0]))
                {
                    txtUsername.Text = strArr[0];
                    txtPassword.Text = strArr[1];

                } 
            }
        }
    }
}
