using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LoginRegisterApp
{
    public partial class RegisterForm : Form
    {
        private Label label1;
        private TextBox txtUsernameRegister;
        private TextBox txtPasswordRegister;
        private Label Password;
        private Button btnRegisterUser;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            string username = txtUsernameRegister.Text.Trim();
            string password = txtPasswordRegister.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan Password wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var users = UserStorage.LoadUsers();
            if (users.Exists(u => u.Username == username))
            {
                MessageBox.Show("Username sudah terdaftar!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hashedPassword = Helper.HashPassword(password);
            users.Add(new User { Username = username, PasswordHash = hashedPassword });
            UserStorage.SaveUsers(users);

            MessageBox.Show("Registrasi berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // tutup form register
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsernameRegister = new System.Windows.Forms.TextBox();
            this.txtPasswordRegister = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.btnRegisterUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // txtUsernameRegister
            // 
            this.txtUsernameRegister.Location = new System.Drawing.Point(169, 162);
            this.txtUsernameRegister.Name = "txtUsernameRegister";
            this.txtUsernameRegister.Size = new System.Drawing.Size(100, 22);
            this.txtUsernameRegister.TabIndex = 1;
            // 
            // txtPasswordRegister
            // 
            this.txtPasswordRegister.Location = new System.Drawing.Point(355, 162);
            this.txtPasswordRegister.Name = "txtPasswordRegister";
            this.txtPasswordRegister.Size = new System.Drawing.Size(100, 22);
            this.txtPasswordRegister.TabIndex = 2;
            this.txtPasswordRegister.UseSystemPasswordChar = true;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(379, 127);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(44, 16);
            this.Password.TabIndex = 3;
            this.Password.Text = "label2";
            // 
            // btnRegisterUser
            // 
            this.btnRegisterUser.Location = new System.Drawing.Point(268, 235);
            this.btnRegisterUser.Name = "btnRegisterUser";
            this.btnRegisterUser.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterUser.TabIndex = 4;
            this.btnRegisterUser.Text = "Register";
            this.btnRegisterUser.UseVisualStyleBackColor = true;
            this.btnRegisterUser.Click += new System.EventHandler(this.btnRegisterUser_Click_1);
            // 
            // RegisterForm
            // 
            this.ClientSize = new System.Drawing.Size(727, 387);
            this.Controls.Add(this.btnRegisterUser);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.txtPasswordRegister);
            this.Controls.Add(this.txtUsernameRegister);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnRegisterUser_Click_1(object sender, EventArgs e)
        {

        }
    }
}
