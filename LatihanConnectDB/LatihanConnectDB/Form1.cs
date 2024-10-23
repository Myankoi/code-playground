using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanConnectDB
{
    public partial class Form1 : Form
    {
        DBEntities db = new DBEntities();
        int id;
        public Form1()
        {
            InitializeComponent();
            LoadTable();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var newData = new user
            {
                id = db.users.OrderByDescending(x => x.id).First().id = 1,
                name = tbName.Text,
                email = tbEmail.Text,
                password = tbPassword.Text,
            };

            db.users.Add(newData);
            db.SaveChanges();
        }

        private void LoadTable()
        {
            dgvUser.Rows.Clear();
            var data = db.users.ToList();

            if (tbName.Text != string.Empty)
            {
                data = data.Where(x => x.name.Contains(tbName.Text)).ToList();
            }
            foreach ( var user in data )
            {
                dgvUser.Rows.Add(user.id, user.name, user.email, user.password);
            }
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvUser.Rows[e.RowIndex].Cells[0].Value);
                var data = db.users.Find(id);
                tbId.Text = data.id.ToString();
                tbName.Text = data.name;
                tbEmail.Text = data.email;

            }
            catch { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbId.Text == string.Empty)
            {
                MessageBox.Show("Id Kosong bg");
                return;
            }
            var data = db.users.Find(id);
            db.users.Remove(data);
            db.SaveChanges();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
