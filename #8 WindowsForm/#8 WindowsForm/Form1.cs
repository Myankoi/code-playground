namespace _8_WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (tbPassword.UseSystemPasswordChar != true)
            {
                tbPassword.UseSystemPasswordChar = true;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = false;
            }
        }

        private void lkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Anjay" && tbPassword.Text == "Anjay")
            {
                Form3 form3 = new Form3(this, tbUsername.Text);
                this.Hide();
                form3.Show();
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect!", "Cihuy");
            }
        
        }
    }
}
