using DVLD_Business;
using DVLD_DataAccess;
using System;

namespace DVLD.Applications.Application_Types
{
    public partial class frmEditApplicationTypes : Form
    {
        private int _ID = -1;
        private clsApplicationType _AppType;
        public frmEditApplicationTypes()
        {
            InitializeComponent();
        }

        public frmEditApplicationTypes(int ID)
        {
            InitializeComponent();
            _ID = ID;
        }

        private bool _isTxtEmpty()
        {
            return (txtTitle.Text.Trim() == "" && txtFees.Text.Trim() == "");
        }

        private bool _DataHasChanged()
        {
            return (txtTitle.Text != _AppType.ApplicationTitle || txtFees.Text != _AppType.ApplicationFees.ToString());
        }


        private void _LoadData()
        {
            _AppType = clsApplicationType.Find(_ID);

            if( _AppType == null )
            {
                MessageBox.Show("Something wrong.....","Error");
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
            if(_DataHasChanged() && !_isTxtEmpty())
            {
                _AppType.ApplicationTitle = txtTitle.Text;
                _AppType.ApplicationFees = Convert.ToDecimal(txtFees.Text);

                if(_AppType.Save())
                {
                    MessageBox.Show("Application type is updated successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Application type is NOT updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
