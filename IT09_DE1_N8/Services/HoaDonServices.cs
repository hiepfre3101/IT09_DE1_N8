using System.Data;
using Microsoft.Data.SqlClient;
using IT09_DE1_N8.Models;

namespace IT09_DE1_N8.Services
{
    public class HoaDonServices
    {
        private readonly string _connectionString;
        public HoaDonServices(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(HoaDon hd)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_AddHoaDon", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaChiSo", hd.MaChiSo);
            cmd.Parameters.AddWithValue("@SoTien", hd.SoTien);
            cmd.ExecuteNonQuery();
        }

        public void Update(HoaDon hd)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_UpdateHoaDon", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHD", hd.MaHD);
            cmd.Parameters.AddWithValue("@TrangThai", hd.TrangThai);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int maHD)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_DeleteHoaDon", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHD", maHD);
            cmd.ExecuteNonQuery();
        }

        public List<HoaDon> GetAll()
        {
            List<HoaDon> list = new();
            using SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_GetHoaDon", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new HoaDon
                {
                    MaHD = (int)reader["MaHD"],
                    MaChiSo = (int)reader["MaChiSo"],
                    NgayLap = (DateTime)(reader["NgayLap"] as DateTime?),
                    SoTien = (decimal)reader["SoTien"],
                    TrangThai = reader["TrangThai"].ToString() ?? ""
                });
            }
            return list;
        }
    }
}
