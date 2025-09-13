using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using IT09_DE1_N8.Data;

namespace IT09_DE1_N8.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string hash = PasswordHelper.HashPassword(password);

            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8U8QO0L\\SQLEXPRESS;Initial Catalog=IT09;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"))
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM NhanVien WHERE Username=@u AND Password=@p";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", hash);

                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Đăng nhập thành công!");
                        this.Hide();
                        FormQuanLy ql = new FormQuanLy();
                        ql.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                    }
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm fr = new RegisterForm();
            fr.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WaterHOU_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
