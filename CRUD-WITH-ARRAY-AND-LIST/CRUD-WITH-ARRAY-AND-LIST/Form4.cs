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
    public partial class Form4 : Form
    {
        Form1 f1;
        public Form4(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
            label8.Text = "Hai Owner";
        }
    }
}
