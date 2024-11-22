using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_Login___Register_Form
{
    public partial class Admin : Form
    {
        Login login;
        List<User> usersList;
        Utils utils;
        int id = 0;

        public Admin(Login loginForm, Identity identity, List<User> usersList)
        {
            InitializeComponent();
            utils = new Utils();
            this.login = loginForm;
            this.usersList = usersList;
            gbUserInformation.Enabled = false;
            lblIdentity.Text = identity.getIdentity();
            LoadUsers();
        }

        private void LoadUsers()
        {
            dgvUsers.Rows.Clear();
            foreach (var usr in usersList)
            {
                if (usr != null)
                {
                    dgvUsers.Rows.Add(
                        usr.Id,
                        usr.Username,
                        usr.Name,
                        usr.Position,
                        usr.Gender,
                        usr.Email,
                        usr.Password,
                        usr.PhoneNumber
                );
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Logout?", "Mau Logout?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                login.Show();
            }
            else
            {
                return;
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dgvUsers.CurrentRow.Cells[0].Value.ToString());
            tbUsername.Text = dgvUsers.CurrentRow.Cells[1].Value.ToString();
            tbName.Text = dgvUsers.CurrentRow.Cells[2].Value.ToString();
            tbGender.Text = dgvUsers.CurrentRow.Cells[4].Value.ToString();
            tbEmail.Text = dgvUsers.CurrentRow.Cells[5].Value.ToString();
            tbPassword.Text = dgvUsers.CurrentRow.Cells[6].Value.ToString();
            tbPhone.Text = dgvUsers.CurrentRow.Cells[7].Value.ToString();
            gbUserInformation.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var currentUser = usersList.FirstOrDefault(x => x.Id == id);

            if (currentUser != null)
            {
                currentUser.Username = tbUsername.Text;
                currentUser.Name = tbName.Text;
                currentUser.Gender = tbGender.Text;
                currentUser.Email = tbEmail.Text;
                currentUser.PhoneNumber = tbPhone.Text;
                MessageBox.Show("User data is updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                utils.ClearAllTextBoxes(this);
                gbUserInformation.Enabled = false;
                LoadUsers();
            }
        }
    }
}
