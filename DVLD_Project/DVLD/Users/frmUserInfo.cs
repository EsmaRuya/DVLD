using System;

namespace DVLD.Users
{
    public partial class frmUserInfo : Form
    {
        int _UserID = -1;

        public frmUserInfo(int UserId)
        {
            InitializeComponent();
            _UserID = UserId;
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            ctrlUserCard.LoadUserInfo(_UserID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
