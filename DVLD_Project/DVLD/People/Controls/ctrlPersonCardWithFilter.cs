using DVLD_Business;
using System;

namespace DVLD.People.Controls
{
    public partial class ctrlPersonCardWithFilter : UserControl
    {
        //
        // Events & delegates
        //

        private int _PersonID = -1;
        private bool _ShowAddPerson = true;
        private bool _FilterEnabled = true;

        public int PersonID
        {
            get { return ctrlPersonCard.PersonID; }
        }
        public clsPerson SelectedPersonInfo
        {
            get { return ctrlPersonCard.SelectedPersonInfo; }
        }
        public bool ShowAddPerson
        {
            get { return _ShowAddPerson; }
            set
            {
                _ShowAddPerson = value;
                btnAdd.Visible = _ShowAddPerson;
            }
        }
        public bool FilterEnable
        {
            get { return _FilterEnabled; }
            set
            {
                _FilterEnabled = value;
                groupBoxFilter.Enabled = _FilterEnabled;
            }
        }


        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }

        private void _FindNow()
        {
            switch (cmbFilterBy.Text)
            {
                case "Person ID":
                    ctrlPersonCard.LoadPersonInfo(int.Parse(txtFilterBy.Text));
                    break;
                case "National No.":
                    ctrlPersonCard.LoadPersonInfo(int.Parse(txtFilterBy.Text));
                    break;
                default:
                    break;
            }

            ////////////// 
        }

        public void LoadPersonInfo(int PersonId)
        {
            cmbFilterBy.SelectedIndex = 1;
            txtFilterBy.Text = PersonId.ToString();
            _FindNow();
        }

        private void txtFilterBy_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterBy.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterBy, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(txtFilterBy, null);
            }
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)12) { btnSearch.PerformClick(); }

            if (cmbFilterBy.Text == "Person ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterBy.Text = "";
            txtFilterBy.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Something wrong, check your fields!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FindNow();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            /////////
            frm.ShowDialog();
        }

        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cmbFilterBy.SelectedIndex = 0;
            txtFilterBy.Focus();
        }
    }
}
