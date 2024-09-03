namespace _8_WindowsForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnLogin = new Button();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cbPassword = new CheckBox();
            lkRegister = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(142, 23);
            label1.Name = "label1";
            label1.Size = new Size(85, 32);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogin.BackColor = Color.FromArgb(0, 192, 192);
            btnLogin.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(51, 338);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(279, 53);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(51, 187);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(279, 27);
            tbUsername.TabIndex = 2;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(51, 258);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(279, 27);
            tbPassword.TabIndex = 3;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 162);
            label2.Name = "label2";
            label2.Size = new Size(88, 22);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(48, 233);
            label3.Name = "label3";
            label3.Size = new Size(88, 22);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // cbPassword
            // 
            cbPassword.AutoSize = true;
            cbPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPassword.Location = new Point(198, 290);
            cbPassword.Name = "cbPassword";
            cbPassword.Size = new Size(132, 24);
            cbPassword.TabIndex = 6;
            cbPassword.Text = "Show Password";
            cbPassword.UseVisualStyleBackColor = true;
            cbPassword.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // lkRegister
            // 
            lkRegister.AutoSize = true;
            lkRegister.Location = new Point(54, 394);
            lkRegister.Name = "lkRegister";
            lkRegister.Size = new Size(63, 20);
            lkRegister.TabIndex = 7;
            lkRegister.TabStop = true;
            lkRegister.Text = "Register";
            lkRegister.TextAlign = ContentAlignment.MiddleCenter;
            lkRegister.LinkClicked += lkRegister_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ATM04588;
            pictureBox1.Location = new Point(123, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 453);
            Controls.Add(pictureBox1);
            Controls.Add(lkRegister);
            Controls.Add(cbPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            MaximumSize = new Size(400, 500);
            MinimumSize = new Size(400, 500);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLogin;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Label label2;
        private Label label3;
        private CheckBox cbPassword;
        private LinkLabel lkRegister;
        private PictureBox pictureBox1;
    }
}
