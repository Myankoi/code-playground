using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_WITH_ARRAY_AND_LIST
{
    public partial class Form1 : Form
    {
        List<string> admin = new List<string>();
        List<string> kasir = new List<string>();
        List<string> owner = new List<string>();
        Class1 c1 = new Class1();
        int indexdata;

        public Form1()
        {
            InitializeComponent();
            groupBox2.Visible = false;
        }

        public Form1(List<string> admin, List<string> kasir, List<string> owner)
        {
            InitializeComponent();
            groupBox2.Visible = false;

            this.admin = admin; 
            this.kasir = kasir;
            this.owner = owner; 

            c1.dataqu(0, admin[0], admin[6], admin[4], admin[1], admin[2], admin[3], admin[5]);
            c1.dataqu(1, kasir[0], kasir[6], kasir[4], kasir[1], kasir[2], kasir[3], kasir[5]);
            c1.dataqu(2, owner[0], owner[6], owner[4], owner[1], owner[2], owner[3], owner[5]);
        }


        // Show password
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                textBox2.PasswordChar = '*';
            }
            else
            {
                textBox2.PasswordChar = '\0';
            }
        }

        // Show register
        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox1.Visible = false;
        }


        // JK
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.man_icon;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.women_icon;
        }

        // Login Button
        private void button1_Click(object sender, EventArgs e)
        {
            int indexdata = Array.FindIndex(c1.uname, x => x.Contains(textBox1.Text));
            MessageBox.Show($"indeks: {indexdata}");
            if (indexdata != -1)
            {
                if (c1.uname[indexdata] == textBox1.Text && c1.pass[indexdata] == textBox2.Text)
                {
                    switch (c1.level[indexdata])
                    {
                        case "Admin":
                            MessageBox.Show($"Ke laman {c1.level[indexdata]}");
                            GenerateList("Admin"); GenerateList("Kasir"); GenerateList("Owner");
                            Form2 f2 = new Form2(this, admin, kasir, owner);
                            f2.Show();
                            this.Hide();
                            break;
                        case "Kasir":
                            MessageBox.Show($"Ke laman {c1.level[indexdata]}");
                            GenerateList("Kasir");
                            Form3 f3 = new Form3(this);
                            f3.Show();
                            this.Hide();
                            break;
                        case "Owner":
                            MessageBox.Show($"Ke laman {c1.level[indexdata]}");
                            GenerateList("Owner");
                            Form4 f4 = new Form4(this);
                            f4.Show();
                            this.Hide();
                            break;
                        default:
                            MessageBox.Show($"LEVEL Tidak Ada yang cocok\ndata yang ada pd indeks ini:\nindeks = {indexdata}\nuname = {c1.uname[indexdata]}\nlevel: {c1.level[indexdata]}");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show($"Username/password salah!");
                }
            }
            else
            {
                MessageBox.Show("Username tidak ditemukan");
            }
        }

        // Submit Register
        private void button3_Click(object sender, EventArgs e)
        {
            string jk;
            string cbox = comboBox1.Text;

            switch(cbox)
            {
                case "Admin":
                    indexdata = 0;
                    break;
                case "Kasir":
                    indexdata = 1;
                    break;
                case "Owner":
                    indexdata = 2;
                    break;
                default:
                    indexdata = 5;
                    break;
            }

            if (indexdata < 3)
            {
                if (textBox6.Text == textBox7.Text)
                {
                    int neu = Array.FindIndex(c1.level, x => x.Contains(comboBox1.Text));
                    if (neu != -1)
                    {
                        MessageBox.Show($"index {indexdata} level is taken, silahkan pilih level lainnya");
                    }
                    else
                    {
                        if (radioButton1.Checked)
                        {
                            jk = radioButton1.Text;
                        }
                        else
                        {
                            jk = radioButton2.Text;
                        }
                        c1.dataqu(indexdata, textBox3.Text, comboBox1.Text, textBox6.Text, textBox4.Text, jk, textBox5.Text, textBox8.Text);
                        MessageBox.Show($"Index: {indexdata}\nNama: {c1.namanya[indexdata]}\nusername: {c1.uname[indexdata]}\nPass: {c1.pass[indexdata]}\nLevel: {c1.level[indexdata]}");
                        groupBox2.Visible = false;
                        groupBox1.Visible = true;
                        //indexdata++;
                    }
                }
                else
                {
                    MessageBox.Show("Password dan Verify Password harus sama!");
                }
            }
            else
            {
                MessageBox.Show($"Data array sudah maksimum, index= {indexdata} ");
            }
        }

        private void GenerateList(string level)
        {
            int n = 0;
            switch (level)
            {
                case "Admin":
                    n = 0;
                    admin.Clear();
                    admin.Add(c1.uname[n]);
                    admin.Add(c1.namanya[n]);
                    admin.Add(c1.jk[n]);
                    admin.Add(c1.email[n]);
                    admin.Add(c1.pass[n]);
                    admin.Add(c1.nohp[n]);
                    admin.Add(c1.level[n]);
                    break;
                case "Kasir":
                    n = 1;
                    kasir.Clear();
                    kasir.Add(c1.uname[n]);
                    kasir.Add(c1.namanya[n]);
                    kasir.Add(c1.jk[n]);
                    kasir.Add(c1.email[n]);
                    kasir.Add(c1.pass[n]);
                    kasir.Add(c1.nohp[n]);
                    kasir.Add(c1.level[n]);
                    break;
                case "Owner":
                    n = 2;
                    owner.Clear();
                    owner.Add(c1.uname[n]);
                    owner.Add(c1.namanya[n]);
                    owner.Add(c1.jk[n]);
                    owner.Add(c1.email[n]);
                    owner.Add(c1.pass[n]);
                    owner.Add(c1.nohp[n]);
                    owner.Add(c1.level[n]);
                    break;
            }
        }
    }
}
