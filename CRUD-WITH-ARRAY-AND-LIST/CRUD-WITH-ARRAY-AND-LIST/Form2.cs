using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_WITH_ARRAY_AND_LIST
{
    public partial class Form2 : Form
    {
        List<string> admin = new List<string>();
        List<string> kasir = new List<string>();
        List<string> owner = new List<string>();
        int ix;
        public Form2(Form1 f1, List<string> admin, List<string> kasir, List<string> owner)
        {
            InitializeComponent();
            groupBox1.Visible = false;
            this.admin = admin;
            this.kasir = kasir;
            this.owner = owner;

            isiDataGrid(this.admin, 0);
            isiDataGrid(this.kasir, 1);
            isiDataGrid(this.owner, 2);
        }

        // Log Out
        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(admin, kasir, owner);
            f1.Show();
            this.Hide();
        }

        // Tambah data
        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(admin, kasir, owner);
            f1.Show();
            this.Hide();
        }

        // Isi datagrid
        private void isiDataGrid(List<string> level, int n)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[n].Clone();
            row.Cells[0].Value = level[0];
            row.Cells[1].Value = level[1];
            row.Cells[2].Value = level[2];
            row.Cells[3].Value = level[3];
            row.Cells[4].Value = level[4];
            row.Cells[5].Value = level[5];
            dataGridView1.Rows.Add(row);
        }

        // Isi textbox
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBox1.Visible = true;
            ix = e.RowIndex;
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[ix];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
            textBox5.Text = row.Cells[4].Value.ToString();
            textBox6.Text = row.Cells[5].Value.ToString();
        }

        // Button Update
        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[ix].Clone();
            switch(ix)
            {
                case 0:
                    admin[0] = textBox1.Text;
                    admin[1] = textBox2.Text;
                    admin[2] = textBox3.Text;
                    admin[3] = textBox4.Text;
                    admin[4] = textBox5.Text;
                    admin[5] = textBox6.Text;
                    break;
                case 1:
                    kasir[0] = textBox1.Text;
                    kasir[1] = textBox2.Text;
                    kasir[2] = textBox3.Text;
                    kasir[3] = textBox4.Text;
                    kasir[4] = textBox5.Text;
                    kasir[5] = textBox6.Text;
                    break;
                case 2:
                    owner[0] = textBox1.Text;
                    owner[1] = textBox2.Text;
                    owner[2] = textBox3.Text;
                    owner[3] = textBox4.Text;
                    owner[4] = textBox5.Text;
                    owner[5] = textBox6.Text;
                    break;
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            isiDataGrid(this.admin, 0);
            isiDataGrid(this.kasir, 1);
            isiDataGrid(this.owner, 2);
        }
        
        // Button Delete
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Anda yakin akan menghapus data?", "Warning!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach(DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(item.Index);
                }
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                groupBox1.Visible = false;
                switch(ix)
                {
                    case 0:
                        hapusList(admin);
                        break;
                    case 1:
                        hapusList(kasir);
                        break;
                    case 2:
                        hapusList(owner);
                        break;
                }
                isiDataGrid(admin, 0);
                isiDataGrid(kasir, 1);
                isiDataGrid(owner, 2);
            } else
            {
                return;
            }
        }

        // Hapus List
        private void hapusList(List<string> a)
        {
            a[0] = a[1] = a[2] = a[3] = a[4] = a[5] = a[6] = "";
        }
    }
}
