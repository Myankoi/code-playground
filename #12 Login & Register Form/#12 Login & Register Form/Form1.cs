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
        string jenisKelamin;
        public Form1()
        {
            InitializeComponent();
            this.Width = 300;
            gbRegister.Visible = false;
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
    }
}
