namespace _12_Login___Register_Form
{
    partial class Admin
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
            this.sayHi = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.gbUserInformation = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbGender = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.gbUserInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // sayHi
            // 
            this.sayHi.AutoSize = true;
            this.sayHi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sayHi.Location = new System.Drawing.Point(6, 9);
            this.sayHi.Name = "sayHi";
            this.sayHi.Size = new System.Drawing.Size(100, 32);
            this.sayHi.TabIndex = 0;
            this.sayHi.Text = "Admin";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 406);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 32);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvUsers.Location = new System.Drawing.Point(12, 44);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(776, 150);
            this.dgvUsers.TabIndex = 2;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // gbUserInformation
            // 
            this.gbUserInformation.Controls.Add(this.btnUpdate);
            this.gbUserInformation.Controls.Add(this.tbPhone);
            this.gbUserInformation.Controls.Add(this.label5);
            this.gbUserInformation.Controls.Add(this.tbPassword);
            this.gbUserInformation.Controls.Add(this.label6);
            this.gbUserInformation.Controls.Add(this.tbEmail);
            this.gbUserInformation.Controls.Add(this.label7);
            this.gbUserInformation.Controls.Add(this.tbGender);
            this.gbUserInformation.Controls.Add(this.label4);
            this.gbUserInformation.Controls.Add(this.tbPosition);
            this.gbUserInformation.Controls.Add(this.label3);
            this.gbUserInformation.Controls.Add(this.tbName);
            this.gbUserInformation.Controls.Add(this.label2);
            this.gbUserInformation.Controls.Add(this.tbUsername);
            this.gbUserInformation.Controls.Add(this.label1);
            this.gbUserInformation.Location = new System.Drawing.Point(12, 200);
            this.gbUserInformation.Name = "gbUserInformation";
            this.gbUserInformation.Size = new System.Drawing.Size(776, 200);
            this.gbUserInformation.TabIndex = 17;
            this.gbUserInformation.TabStop = false;
            this.gbUserInformation.Text = "groupBox1";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(661, 134);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 32);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(487, 103);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(249, 22);
            this.tbPhone.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "PhoneNumber";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(487, 75);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(249, 22);
            this.tbPassword.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Password";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(487, 47);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(249, 22);
            this.tbEmail.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(410, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Email";
            // 
            // tbGender
            // 
            this.tbGender.Location = new System.Drawing.Point(118, 131);
            this.tbGender.Name = "tbGender";
            this.tbGender.Size = new System.Drawing.Size(249, 22);
            this.tbGender.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Gender";
            // 
            // tbPosition
            // 
            this.tbPosition.Location = new System.Drawing.Point(118, 103);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(249, 22);
            this.tbPosition.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Position";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(118, 75);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(249, 22);
            this.tbName.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Name";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(118, 47);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(249, 22);
            this.tbUsername.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Username";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Username";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Position";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Gender";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Email";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Password";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Phone Number";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbUserInformation);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.sayHi);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.gbUserInformation.ResumeLayout(false);
            this.gbUserInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sayHi;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.GroupBox gbUserInformation;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}