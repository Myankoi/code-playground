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
    public partial class Kasir : Form
    {
        Login frm1;
        public Kasir(Login form1, Identity identity)
        {
            InitializeComponent();
            this.frm1 = form1;
            lblIdentity.Text = identity.getIdentity();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Logout?", "Mau Logout?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                frm1.Show();
            }
            else
            {
                return;
            }
        }
    }
}
