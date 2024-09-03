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
    public partial class Form3 : Form
    {
        private string username;
        Form1 form1;
        public Form3(Form1 form1, string username)
        {
            InitializeComponent();
            this.form1 = form1;
            this.username = username;

            welcomeText.Text = $"WELCOME {username}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to logout?", "Logout?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) 
            { 
                form1 = new Form1();
                this.Close();
                form1.Show();
            } else
            {
                return;
            }



        }
    }
}
