using DVLD_Business;
using System.ComponentModel;
using System;
using DVLD.Global_Classes;

namespace DVLD.Applications.Application_Types
{
    public partial class frmEditApplicationTypes : Form
    {
        private int _ID = -1;
        private clsApplicationType _AppType;

        public frmEditApplicationTypes(int ID)
        {
            InitializeComponent();
            _ID = ID;
        }

        private bool _DataHasChanged()
        {
            return (txtTitle.Text != _AppType.ApplicationTitle || txtFees.Text != _AppType.ApplicationFees.ToString());
        }

        private void _LoadData()
        {
            _AppType = clsApplicationType.Find(_ID);

            if (_AppType == null)
            {
                MessageBox.Show("Something wrong.....", "Error");
                return;
            }

            lblAppTypeID.Text = _ID.ToString();
            txtTitle.Text = _AppType.ApplicationTitle;
            txtFees.Text = _AppType.ApplicationFees.ToString();
        }

        private void frmEditApplicationTypes_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(501, 365);
        }

        private void frmEditApplicationTypes_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid! Check again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_DataHasChanged())
            {
                MessageBox.Show("No changes happened", "No change", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _AppType.ApplicationTitle = txtTitle.Text;
            _AppType.ApplicationFees = Convert.ToDecimal(txtFees.Text);

            if (_AppType.Save())
            {
                MessageBox.Show("Application type is updated successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Application type is NOT updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtTitle, "This field is requeried");
            }
            else
            {
                errorProvider.SetError(txtTitle, null);
            }
        }

        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtFees, "This field is requeried");
            }
            if (!clsValidation.isNumber(txtFees.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtFees, "Invalid Number");
            }
            else
            {
                errorProvider.SetError(txtFees, null);
            }
        }
    }
}
