using System;
using System.Windows.Forms;

namespace LoginRegisterApp
{
    public partial class btnRegisterUser : Form
    {
        public btnRegisterUser()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            var users = UserStorage.LoadUsers();
            var user = users.Find(u => u.Username == username);

            if (user == null)
            {
                MessageBox.Show("Username tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hashedPassword = Helper.HashPassword(password);
            if (user.PasswordHash == hashedPassword)
            {
                MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // TODO: tampilkan menu utama atau form lain
            }
            else
            {
                MessageBox.Show("Password salah!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.ShowDialog(); // buka form register
        }
    }
}
