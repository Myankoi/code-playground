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
        UserRepository users;
        public Admin()
        {
            InitializeComponent();
            LoadUsers();
        }

        public Admin(Login loginForm, UserRepository user)
        {
            InitializeComponent();
            this.login = loginForm;
            this.users = user;
            LoadUsers();
        }

        private void LoadUsers()
        {
            var user = users.users;
            dgvUsers.Rows.Clear();
            foreach (var usr in user)
            {
                dgvUsers.Rows.Add(
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

        private void button1_Click(object sender, EventArgs e)
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
            tbUsername.Text = dgvUsers.CurrentRow.Cells[0].Value.ToString();
            tbName.Text = dgvUsers.CurrentRow.Cells[1].Value.ToString();
            tbPosition.Text = dgvUsers.CurrentRow.Cells[2].Value.ToString();
            tbGender.Text = dgvUsers.CurrentRow.Cells[3].Value.ToString();
            tbEmail.Text = dgvUsers.CurrentRow.Cells[4].Value.ToString();
            tbPassword.Text = dgvUsers.CurrentRow.Cells[5].Value.ToString();
            tbPhone.Text = dgvUsers.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
