using System.Data;
using Microsoft.Data.SqlClient;
using IT09_DE1_N8.Models;

namespace IT09_DE1_N8.Services
{
    public class KhachHangServices
    {
        private readonly string _connectionString;
        public KhachHangServices(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(KhachHang kh)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_AddKhachHang", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@HoTenChuHo", kh.HoTenChuHo);
            cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi);
            cmd.Parameters.AddWithValue("@DienThoai", kh.DienThoai);
            cmd.Parameters.AddWithValue("@SoHopDong", kh.SoHopDong);
            cmd.ExecuteNonQuery();
        }

        public void Update(KhachHang kh)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_UpdateKhachHang", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaKH", kh.MaKH);
            cmd.Parameters.AddWithValue("@HoTenChuHo", kh.HoTenChuHo);
            cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi);
            cmd.Parameters.AddWithValue("@DienThoai", kh.DienThoai);
            cmd.Parameters.AddWithValue("@SoHopDong", kh.SoHopDong);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int maKH)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_DeleteKhachHang", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaKH", maKH);
            cmd.ExecuteNonQuery();
        }

        public List<KhachHang> GetAll()
        {
            List<KhachHang> list = new();
            using SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_GetKhachHang", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new KhachHang
                {
                    MaKH = (int)reader["MaKH"],
                    HoTenChuHo = reader["HoTenChuHo"].ToString() ?? "",
                    DiaChi = reader["DiaChi"].ToString() ?? "",
                    DienThoai = reader["DienThoai"].ToString() ?? "",
                    NgayDangKy = (DateTime)(reader["NgayDangKy"] as DateTime?),
                    SoHopDong = reader["SoHopDong"].ToString() ?? ""
                });
            }
            return list;
        }
    }
}
