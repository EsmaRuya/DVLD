using DVLD_Business;
using System;

namespace DVLD.Users
{
    public partial class ctrlUserCard : UserControl
    {
        private int _UserID = -1;
        private clsUser _User;

        public int UserID { get { return _UserID; } }

        public ctrlUserCard()
        {
            InitializeComponent();
        }

        private void _FillUserInfo()
        {
            ctrlPersonCard1.LoadPersonInfo(_User.personID);
            lblUserID.Text = _User.UserID.ToString();
            lblUsername.Text = _User.UserName;
            lblisActive.Text = (_User.isActive ? "Yes" : "No");
        }

        private void _RestUserInfo()
        {
            ctrlPersonCard1.RestPersonInfo();
            lblUserID.Text = "#####";
            lblUsername.Text = "#####";
            lblisActive.Text = "#####";
        }

        public void LoadUserInfo(int UserId)
        {
            _UserID = UserId;
            _User = clsUser.Find(UserId);

            if(_User == null )
            {
                _RestUserInfo();
                MessageBox.Show($"No User with ID = {UserId} is found","Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillUserInfo();
        }
    }
}
