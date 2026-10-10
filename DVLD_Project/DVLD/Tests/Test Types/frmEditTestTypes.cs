using DVLD.Global_Classes;
using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.Tests.Test_Types
{
    public partial class frmEditTestTypes : Form
    {
        private clsTestType.enTestType _TestTypeID = clsTestType.enTestType.VisionTest;
        private clsTestType _TestType;

        public frmEditTestTypes(clsTestType.enTestType ID)
        {
            InitializeComponent();
            _TestTypeID = ID;
        }

        private bool _DataHasChanged()
        {
            return (txtTitle.Text != _TestType.TestTypeTitle || txtDescription.Text != _TestType.TestTypeDescription || txtFees.Text != _TestType.TestTypeFees.ToString());
        }

        private void frmEditTestTypes_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(513, 465);
        }

        private void frmEditTestTypes_Load(object sender, EventArgs e)
        {
            _TestType = clsTestType.Find(_TestTypeID);

            if (_TestType == null)
            {
                MessageBox.Show("Something wrong.....", "Error");
                return;
            }

            lblTestTypeID.Text = _TestTypeID.ToString();
            txtTitle.Text = _TestType.TestTypeTitle;
            txtDescription.Text = _TestType.TestTypeDescription;
            txtFees.Text = _TestType.TestTypeFees.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid! Check again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_DataHasChanged())
            {
                MessageBox.Show("No changes happened", "No change", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _TestType.TestTypeTitle = txtTitle.Text;
            _TestType.TestTypeDescription = txtDescription.Text;
            _TestType.TestTypeFees = Convert.ToDecimal(txtFees.Text);

            if (_TestType.Save())
            {
                MessageBox.Show("Test type is updated successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Test type is NOT updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTitle_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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

        private void txtDescription_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescription.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtDescription, "This field is requeried");
            }
            else
            {
                errorProvider.SetError(txtDescription, null);
            }
        }

        private void txtFees_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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
