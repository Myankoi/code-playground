using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_WindowsForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (tbPassword2.UseSystemPasswordChar != true || tbPassword1.UseSystemPasswordChar != true)
            {
                tbPassword1.UseSystemPasswordChar = true;
                tbPassword2.UseSystemPasswordChar = true;
            }
            else
            {
                tbPassword1.UseSystemPasswordChar = false;
                tbPassword2.UseSystemPasswordChar = false;
            }
        }
    }
}
