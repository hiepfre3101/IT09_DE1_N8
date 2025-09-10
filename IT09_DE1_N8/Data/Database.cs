using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace IT09_DE1_N8.Data
{
    public class DatabaseHelper : IDisposable
    {
        private readonly SqlConnection _connection;

        private readonly string _connectionString =
            "Data Source=DESKTOP-8U8QO0L\\SQLEXPRESS;Initial Catalog=IT09;Integrated Security=True;Trust Server Certificate=True";

        public DatabaseHelper()
        {
            _connection = new SqlConnection(_connectionString);
        }

        private void OpenConnection()
        {
            if (_connection.State == ConnectionState.Closed)
                _connection.Open();
        }

        private void CloseConnection()
        {
            if (_connection.State == ConnectionState.Open)
                _connection.Close();
        }

        // SELECT (returns DataTable)
        public DataTable ExecuteQuery(string sql, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand(sql, _connection))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            finally
            {
                CloseConnection();
            }
            return dt;
        }

        // INSERT, UPDATE, DELETE (returns affected rows)
        public int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            int rowsAffected = 0;
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand(sql, _connection))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                CloseConnection();
            }
            return rowsAffected;
        }

        // ExecuteScalar (returns single value)
        public object ExecuteScalar(string sql, params SqlParameter[] parameters)
        {
            object result = null;
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand(sql, _connection))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    result = cmd.ExecuteScalar();
                }
            }
            finally
            {
                CloseConnection();
            }
            return result;
        }

        public void Dispose()
        {
            _connection.Dispose();
        }
    }
}
