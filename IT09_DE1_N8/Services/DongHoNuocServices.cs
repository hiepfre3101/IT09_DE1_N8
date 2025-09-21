using System.Data;
using Microsoft.Data.SqlClient;
using IT09_DE1_N8.Models;

namespace IT09_DE1_N8.Services
{
    public class DongHoNuocServices
    {
        private readonly string _connectionString;
        public DongHoNuocServices(string connectionString)
        {
            _connectionString = connectionString;
        }

        private void ShowToast(string message, string title = "Thông báo")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public void Add(DongHoNuoc dh)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(_connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_AddDongHoNuoc", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaKH", dh.MaKH);
                cmd.Parameters.AddWithValue("@SoHieu", dh.SoHieu);
                cmd.Parameters.AddWithValue("@NgayLapDat", dh.NgayLapDat ?? (object)DBNull.Value);
                cmd.ExecuteNonQuery();
                ShowToast("Thêm Đồng hồ nước thành công!");
            }
            catch(Exception ex)
            {
                ShowToast($"Lỗi khi thêm Đồng hồ nước: {ex.Message}", "Lỗi");
            }
        
        }

        public void Update(DongHoNuoc dh)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(_connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_UpdateDongHoNuoc", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaDongHo", dh.MaDongHo);
                cmd.Parameters.AddWithValue("@MaKH", dh.MaKH);
                cmd.Parameters.AddWithValue("@SoHieu", dh.SoHieu);
                cmd.Parameters.AddWithValue("@NgayLapDat", dh.NgayLapDat ?? (object)DBNull.Value);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ShowToast($"Lỗi khi cập nhật Đồng hồ nước: {ex.Message}", "Lỗi");
            }
         
        }

        public void Delete(int maDongHo)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(_connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_DeleteDongHoNuoc", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaDongHo", maDongHo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ShowToast($"Lỗi khi xóa Đồng hồ nước: {ex.Message}", "Lỗi");
            }
      
        }

        public List<DongHoNuoc> GetAll()
        {
            List<DongHoNuoc> list = new();
            using SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_GetDongHoNuoc", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new DongHoNuoc
                {
                    MaDongHo = (int)reader["MaDongHo"],
                    MaKH = (int)reader["MaKH"],
                    TenKH = reader["TenKH"].ToString() ?? "",
                    SoHieu = reader["SoHieu"].ToString() ?? "",
                    NgayLapDat = reader["NgayLapDat"] as DateTime?
                });
            }
            return list;
        }
        public DongHoNuoc? GetOne(int maDongHo)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_GetDongHoNuocById", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDongHo", maDongHo);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new DongHoNuoc
                {
                    MaDongHo = (int)reader["MaDongHo"],
                    SoHieu = reader["SoHieu"].ToString() ?? "",
                    NgayLapDat = reader["NgayLapDat"] as DateTime?
                };
            }

            return null; // không tìm thấy
        }
    }
}
