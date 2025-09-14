using IT09_DE1_N8.Models;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms; // để gọi MessageBox

namespace IT09_DE1_N8.Services
{
    public class NhanVienService
    {
        private readonly string connectionString =
            "Data Source=DESKTOP-8U8QO0L\\SQLEXPRESS;Initial Catalog=IT09;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        private void ShowToast(string message, string title = "Thông báo")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Add(NhanVien nv)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("sp_AddNhanVien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@HoTen", nv.HoTen);
                    cmd.Parameters.AddWithValue("@NgaySinh", (object)nv.NgaySinh ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@DiaChi", nv.DiaChi ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@DienThoai", nv.DienThoai ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ChucVu", nv.ChucVu ?? (object)DBNull.Value);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                ShowToast("Thêm nhân viên thành công!");
            }
            catch (Exception ex)
            {
                ShowToast($"Lỗi khi thêm nhân viên: {ex.Message}", "Lỗi");
            }
        }

        public void Update(NhanVien nv)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("sp_UpdateNhanVien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
                    cmd.Parameters.AddWithValue("@HoTen", nv.HoTen);
                    cmd.Parameters.AddWithValue("@NgaySinh", (object)nv.NgaySinh ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@DiaChi", nv.DiaChi ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@DienThoai", nv.DienThoai ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ChucVu", nv.ChucVu ?? (object)DBNull.Value);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                ShowToast("Cập nhật nhân viên thành công!");
            }
            catch (Exception ex)
            {
                ShowToast($"Lỗi khi cập nhật nhân viên: {ex.Message}", "Lỗi");
            }
        }

        public void Delete(int maNV)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("sp_DeleteNhanVien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                ShowToast("Xóa nhân viên thành công!");
            }
            catch (Exception ex)
            {
                ShowToast($"Lỗi khi xóa nhân viên: {ex.Message}", "Lỗi");
            }
        }

        public List<NhanVien> GetAll()
        {
            List<NhanVien> list = new List<NhanVien>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("sp_GetNhanVien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new NhanVien
                            {
                                MaNV = reader.GetInt32(reader.GetOrdinal("MaNV")),
                                HoTen = reader["HoTen"].ToString(),
                                NgaySinh = reader["NgaySinh"] as DateTime?,
                                GioiTinh = reader["GioiTinh"].ToString(),
                                DiaChi = reader["DiaChi"].ToString(),
                                DienThoai = reader["DienThoai"].ToString(),
                                ChucVu = reader["ChucVu"].ToString(),
                                Username = reader["Username"].ToString(),
                                Password = reader["Password"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ShowToast($"Lỗi khi tải danh sách nhân viên: {ex.Message}", "Lỗi");
            }
            return list;
        }
    }
}
