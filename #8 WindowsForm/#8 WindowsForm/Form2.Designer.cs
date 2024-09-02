namespace _8_WindowsForm
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lkLogin = new LinkLabel();
            cbPassword = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            tbPassword2 = new TextBox();
            tbPassword1 = new TextBox();
            btnRegister = new Button();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(437, 184);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "rafidan";
            // 
            // lkLogin
            // 
            lkLogin.AutoSize = true;
            lkLogin.Location = new Point(54, 406);
            lkLogin.Name = "lkLogin";
            lkLogin.Size = new Size(46, 20);
            lkLogin.TabIndex = 15;
            lkLogin.TabStop = true;
            lkLogin.Text = "Login";
            lkLogin.TextAlign = ContentAlignment.MiddleCenter;
            lkLogin.LinkClicked += lkLogin_LinkClicked;
            // 
            // cbPassword
            // 
            cbPassword.AutoSize = true;
            cbPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPassword.Location = new Point(198, 301);
            cbPassword.Name = "cbPassword";
            cbPassword.Size = new Size(132, 24);
            cbPassword.TabIndex = 14;
            cbPassword.Text = "Show Password";
            cbPassword.UseVisualStyleBackColor = true;
            cbPassword.CheckedChanged += cbPassword_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(51, 243);
            label3.Name = "label3";
            label3.Size = new Size(158, 22);
            label3.TabIndex = 13;
            label3.Text = "Confirm Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 174);
            label2.Name = "label2";
            label2.Size = new Size(88, 22);
            label2.TabIndex = 12;
            label2.Text = "Password";
            // 
            // tbPassword2
            // 
            tbPassword2.Location = new Point(54, 268);
            tbPassword2.Name = "tbPassword2";
            tbPassword2.Size = new Size(279, 27);
            tbPassword2.TabIndex = 11;
            tbPassword2.UseSystemPasswordChar = true;
            // 
            // tbPassword1
            // 
            tbPassword1.Location = new Point(54, 199);
            tbPassword1.Name = "tbPassword1";
            tbPassword1.Size = new Size(279, 27);
            tbPassword1.TabIndex = 10;
            tbPassword1.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRegister.BackColor = Color.FromArgb(0, 192, 192);
            btnRegister.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(51, 350);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(279, 53);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(132, 40);
            label4.Name = "label4";
            label4.Size = new Size(112, 32);
            label4.TabIndex = 8;
            label4.Text = "Register";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(49, 108);
            label5.Name = "label5";
            label5.Size = new Size(88, 22);
            label5.TabIndex = 17;
            label5.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(51, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(279, 27);
            textBox1.TabIndex = 16;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 453);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(lkLogin);
            Controls.Add(cbPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbPassword2);
            Controls.Add(tbPassword1);
            Controls.Add(btnRegister);
            Controls.Add(label4);
            Controls.Add(label1);
            MaximumSize = new Size(400, 500);
            MinimumSize = new Size(400, 500);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel lkLogin;
        private CheckBox cbPassword;
        private Label label3;
        private Label label2;
        private TextBox tbPassword2;
        private TextBox tbPassword1;
        private Button btnRegister;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
    }
}