using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_Login___Register_Form
{
    public class Utils
    {
        public bool IsEmpty(TextBox tb, string fieldName)
        {
            if (tb.Text == string.Empty)
            {
                MessageBox.Show($"Please Insert {fieldName}!");
                return true;
            }
            return false;
        }

        public void ClearTextBox(TextBox tb, string fieldName)
        {
            if ( tb.Text != string.Empty )
            {
                tb.Clear();
            }
        }

        public void ClearAllTextBoxes(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control.HasChildren)
                {
                    ClearAllTextBoxes(control);
                }
            }
        }
    }
}
