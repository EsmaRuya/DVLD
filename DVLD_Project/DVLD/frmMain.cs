using DVLD.People;

namespace DVLD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            frmPeopleManagement frm = new frmPeopleManagement();
            frm.ShowDialog();
        }
    }
}
