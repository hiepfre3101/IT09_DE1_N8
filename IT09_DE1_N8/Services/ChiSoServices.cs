using System.Data;
using Microsoft.Data.SqlClient;
using IT09_DE1_N8.Models;

namespace IT09_DE1_N8.Services
{
    public class ChiSoNuocServices
    {
        private readonly string _connectionString;
        public ChiSoNuocServices(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(ChiSoNuoc cs)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_AddChiSoNuoc", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDongHo", cs.MaDongHo);
            cmd.Parameters.AddWithValue("@Thang", cs.Thang);
            cmd.Parameters.AddWithValue("@Nam", cs.Nam);
            cmd.Parameters.AddWithValue("@ChiSoCu", cs.ChiSoCu);
            cmd.Parameters.AddWithValue("@ChiSoMoi", cs.ChiSoMoi);
            cmd.Parameters.AddWithValue("@MaNV", cs.MaNV);
            cmd.ExecuteNonQuery();
        }

        public void Update(ChiSoNuoc cs)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_UpdateChiSoNuoc", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaChiSo", cs.MaChiSo);
            cmd.Parameters.AddWithValue("@ChiSoCu", cs.ChiSoCu);
            cmd.Parameters.AddWithValue("@ChiSoMoi", cs.ChiSoMoi);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int maChiSo)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_DeleteChiSoNuoc", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaChiSo", maChiSo);
            cmd.ExecuteNonQuery();
        }

        public List<ChiSoNuoc> GetAll()
        {
            List<ChiSoNuoc> list = new();
            using SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_GetChiSoNuoc", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new ChiSoNuoc
                {
                    MaChiSo = (int)reader["MaChiSo"],
                    MaDongHo = (int)reader["MaDongHo"],
                    Thang = (int)reader["Thang"],
                    Nam = (int)reader["Nam"],
                    ChiSoCu = (int)reader["ChiSoCu"],
                    ChiSoMoi = (int)reader["ChiSoMoi"],
                    SoTieuThu = (int)reader["SoTieuThu"],
                    MaNV = (int)reader["MaNV"],
                    NgayGhi = (DateTime)(reader["NgayGhi"] as DateTime?)
                });
            }
            return list;
        }
    }
}
