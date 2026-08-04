using System;

namespace DVLD.People
{
    public partial class frmPeopleManagement : Form
    {
        public frmPeopleManagement()
        {
            InitializeComponent();
        }

        private void frmPeopleManagement_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(1353, 584);
        }
    }
}
