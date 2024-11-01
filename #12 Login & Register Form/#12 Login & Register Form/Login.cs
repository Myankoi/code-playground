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
    public partial class Login : Form
    {
        UserRepository user = new UserRepository();

        private string jenisKelamin;
        public Login()
        {
            InitializeComponent();
            this.Width = 300;
            gbRegister.Visible = false;

            listPosition.Items.Add("Admin");
            listPosition.Items.Add("Owner");
            listPosition.Items.Add("Kasir");
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
                MessageBox.Show("Verify Password Is Not Same!");
                return;
            }

            if (listPosition.Text == string.Empty)
            {
                MessageBox.Show("Please Select Your Position!");
                return;
            }


            bool isFull = user.isArrayFull();
            if (!isFull)
            {
                MessageBox.Show("Array is full, cannot insert new account!", "Registration Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                gbRegister.Visible = false;
                this.Width = 300;
                return;
            } else
            {
                MessageBox.Show("Username Is Taken!", "Registration");
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
                MessageBox.Show($"Login Success! to {userPosition}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                switch (userPosition)
                {
                    case "Admin" :
                        Admin admin = new Admin(this, user);
                        admin.Show();
                        this.Hide();
                        break;
                    case "Owner" :
                        Owner owner = new Owner(this);
                        owner.Show();
                        this.Hide();
                        break;
                    case "Kasir" :
                        Kasir kasir = new Kasir(this);
                        kasir.Show();
                        this.Hide();
                        break;
                    
                }
                tbLoginUsername.Clear();
                tbLoginPassword.Clear();
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
