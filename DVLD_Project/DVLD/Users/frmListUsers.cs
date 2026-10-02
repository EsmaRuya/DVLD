using DVLD_Business;
using System;
using System.Data;

namespace DVLD.Users
{
    public partial class frmListUsers : Form
    {
        private static DataTable _UsersTable = clsUser.GetAllUsers();
        private DataTable _dtUsersList = _UsersTable.DefaultView.ToTable(false, "UserId", "PersonId", "FullName", "UserName", "isActive");

        public frmListUsers()
        {
            InitializeComponent();
        }

        private void _RefreshUsersList()
        {
            _UsersTable = clsUser.GetAllUsers();
            _dtUsersList = _UsersTable.DefaultView.ToTable(false, "UserId", "PersonId", "FullName", "UserName", "isActive");

            dgvListUsers.DataSource = _dtUsersList;
            cbxFilerBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvListUsers.Rows.Count.ToString();
        }

        private void frmListUsers_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(830, 633);
        }

        private void frmListUsers_Load(object sender, EventArgs e)
        {
            dgvListUsers.DataSource = _dtUsersList;
            cbxFilerBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvListUsers.Rows.Count.ToString();

            if (dgvListUsers.Rows.Count > 0)
            {
                dgvListUsers.Columns[0].HeaderText = "User ID";
                dgvListUsers.Columns[0].Width = 100;

                dgvListUsers.Columns[1].HeaderText = "Person ID";
                dgvListUsers.Columns[1].Width = 100;

                dgvListUsers.Columns[2].HeaderText = "Full Name";
                dgvListUsers.Columns[2].Width = 250;

                dgvListUsers.Columns[3].HeaderText = "Username";
                dgvListUsers.Columns[3].Width = 100;

                dgvListUsers.Columns[4].HeaderText = "isActive";
                dgvListUsers.Columns[4].Width = 100;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.ShowDialog();
            _RefreshUsersList();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.ShowDialog();
            _RefreshUsersList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser((int)dgvListUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshUsersList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userID = (int)dgvListUsers.CurrentRow.Cells[0].Value;

            if (MessageBox.Show($"Are you sure you want to delete the user with ID {userID} ?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsUser.DeleteUser(userID))
                {
                    MessageBox.Show($"User with ID {userID} is deleted successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshUsersList();
                }

                else MessageBox.Show("User is not deleted successfully!\nSomething goes wrong...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo((int)dgvListUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword((int)dgvListUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not implemented yat!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not implemented yat!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void cbxFilerBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFilerBy.Text != "None")
            {
                if (cbxFilerBy.Text == "is Active")
                {
                    txtFilter.Visible = false;
                    cbisActive.Visible = true;
                    cbisActive.SelectedItem = "All";
                }
                else
                {
                    txtFilter.Visible = true;
                    txtFilter.Text = "";
                    txtFilter.Focus();

                    cbisActive.Visible = false;
                }
            }
            else
            {
                txtFilter.Visible = false;
                cbisActive.Visible = false;
            }
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbxFilerBy.Text == "Person ID" || cbxFilerBy.Text == "User ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }

            if (cbxFilerBy.Text == "Full Name")
            {
                e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
            }

            if(cbxFilerBy.Text == "Username")
            {
                e.Handled = char.IsWhiteSpace(e.KeyChar);
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbxFilerBy.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonId";
                    break;
                case "User ID":
                    FilterColumn = "UserId";
                    break;
                case "Username":
                    FilterColumn = "UserName";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                case "is Active":
                    FilterColumn = "isActive";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            if(txtFilter.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtUsersList.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvListUsers.Rows.Count.ToString();
                return; 
            }

            if(FilterColumn == "PersonId" || FilterColumn == "UserId")
                _dtUsersList.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text);
            else
                _dtUsersList.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text);

            lblRecordsCount.Text = dgvListUsers.Rows.Count.ToString();
        }

        private void cbisActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "isActive";
            string FilterValue = cbisActive.Text;

            switch(FilterValue)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
            }

            if (FilterValue == "All")
                _dtUsersList.DefaultView.RowFilter = "";
            else
                _dtUsersList.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            lblRecordsCount.Text = dgvListUsers.Rows.Count.ToString();
        }
    }
}
