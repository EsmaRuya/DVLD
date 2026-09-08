using System;
using System.Collections.Generic;
using System;
using DVLD_Business;

namespace DVLD.People
{
    public partial class frmShowPersonInfo : Form
    {

        public frmShowPersonInfo(int PersonID)
        {
            InitializeComponent();
            ctrlPersonCard.LoadPersonInfo(PersonID);
        }

        public frmShowPersonInfo(string NationalNo)
        {
            InitializeComponent();
            ctrlPersonCard.LoadPersonInfo(NationalNo);
        }

        private void frmShowPersonInfo_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(922, 523);
        }
    }
}
