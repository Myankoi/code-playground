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
    public partial class Form1 : Form
    {
        UserRepository user = new UserRepository();

        private string jenisKelamin;
        public Form1()
        {
            InitializeComponent();
            this.Width = 300;
            gbRegister.Visible = false;

            listPosition.Items.Add("Manager");
            listPosition.Items.Add("Employee");
            listPosition.Items.Add("Customer");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!gbRegister.Visible)
            {
                gbRegister.Visible = true;
                this.Width = 620;
            } else
            {
                gbRegister.Visible = false;
                 this.Width = 300;
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                tbLoginPassword.UseSystemPasswordChar = false;
            }
            else 
            { 
                tbLoginPassword.UseSystemPasswordChar = true;
            }
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            pbJenisKelamin.Image = Properties.Resources.Male;
            jenisKelamin = "Laki-Laki";
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            pbJenisKelamin.Image = Properties.Resources.Female;
            jenisKelamin = "Perempuan";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //validasi
            if (IsEmpty(tbRegisterUsername, "Username") ||
                IsEmpty(tbName, "Your Name") ||
                IsEmpty(tbRegisterPassword, "Password") ||
                IsEmpty(tbEmail, "Email") ||
                IsEmpty(tbHandphoneNumber, "Phone Number"))
            {
                return;
            }

            if (!rbMale.Checked && !rbFemale.Checked)
            {
                MessageBox.Show("Please Select Your Gender!");
                return;
            }

            if (tbRegisterPassword.Text != tbRegisterVerifyPassword.Text)
            {
                MessageBox.Show("Verify Password is Incorrect!");
            }

            if (listPosition.Text == string.Empty)
            {
                MessageBox.Show("Please Select Your Position!");
                return;
            }


            bool isValid = user.RegisterUser(tbRegisterUsername.Text, tbName.Text, jenisKelamin, tbEmail.Text, tbRegisterPassword.Text, tbHandphoneNumber.Text, listPosition.Text);

            if (isValid)
            {
                MessageBox.Show("Registration Success!", "Registration");
                tbRegisterUsername.Clear();
                tbName.Clear();
                rbMale.Checked = false;
                rbFemale.Checked = false;
                tbRegisterPassword.Clear();
                tbEmail.Clear();
                tbRegisterPassword.Clear();
                tbRegisterVerifyPassword.Clear();
                tbHandphoneNumber.Clear();
                listPosition.SelectedIndex = 2;
                return;
            } else
            {
                MessageBox.Show("Registration Failed!", "Registration");
                return;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbLoginUsername.Text == string.Empty ||  tbLoginPassword.Text == string.Empty)
            {
                MessageBox.Show("Jangan Kosong woi!");
                return;
            }

            bool isValid = user.LoginUser(tbLoginUsername.Text, tbLoginPassword.Text);
            string userPosition = user.UserPosition(tbLoginUsername.Text, tbLoginPassword.Text);

            if (isValid)
            {
                Form2 frm2 = new Form2(userPosition, this);
                frm2.Show();
                this.Hide();
                return;
            } else
            {
                MessageBox.Show("Salah woi!");
            }
            return;
        }
        private bool IsEmpty(TextBox tb, string fieldName)
        {
            if (tb.Text == string.Empty)
            {
                MessageBox.Show($"Please Insert {fieldName}!");
                return true;
            }
            return false;
        }

    }
}
