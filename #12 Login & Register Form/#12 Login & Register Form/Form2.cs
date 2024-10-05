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
    public partial class Form2 : Form
    {
        Form1 frm1;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string position, Form1 form1)
        {
            InitializeComponent();
            sayHi.Text = $"Halo {position}";
            this.frm1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Logout?", "Mau Logout?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) 
            { 
                this.Hide();
                frm1.Show();
            } else
            {
                return;
            }
        }
    }
}
