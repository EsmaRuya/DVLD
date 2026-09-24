using System;

namespace DVLD.Users
{
    public partial class frmListUsers : Form
    {
        public frmListUsers()
        {
            InitializeComponent();
        }

        private void frmListUsers_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(830, 633);
        }
    }
}
