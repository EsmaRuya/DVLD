using System;

namespace DVLD.People
{
    public partial class frmShowPersonInfo : Form
    {
        public frmShowPersonInfo()
        {
            InitializeComponent();
        }

        private void frmShowPersonInfo_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(921, 530);
        }
    }
}
