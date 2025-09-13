using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace IT09_DE1_N8.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string ho = txtHo.Text.Trim();
            string ten = txtTen.Text.Trim();
            string fullname = ho + " " + ten;
            string chucvu = txtChucVu.Text.Trim();

            // Mật khẩu mặc định
            string defaultPassword = "123456";
            string hash = PasswordHelper.HashPassword(defaultPassword);

            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8U8QO0L\\SQLEXPRESS;Initial Catalog=IT09;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"))
            {
                conn.Open();
                string sql = @"
                    INSERT INTO NhanVien (Password, HoTen, ChucVu) 
                    OUTPUT INSERTED.Username
                    VALUES (@p, @f, @c)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@p", hash);
                    cmd.Parameters.AddWithValue("@f", fullname);
                    cmd.Parameters.AddWithValue("@c", chucvu);

                    try
                    {
                        // Lấy Username được sinh ra tự động
                        var username = cmd.ExecuteScalar()?.ToString();

                        MessageBox.Show($"Đăng ký thành công!\n\nUsername: {username}\nMật khẩu mặc định: {defaultPassword}",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }
    }
}
