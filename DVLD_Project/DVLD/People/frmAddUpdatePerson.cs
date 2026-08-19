using System;


namespace DVLD.People
{
    public partial class frmAddUpdatePerson : Form
    {
        public frmAddUpdatePerson()
        {
            InitializeComponent();
        }

        private void frmAddUpdatePerson_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(1007, 585);
        }
    }
}
