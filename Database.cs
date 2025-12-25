using System;
using System.Data;
using System.Data.SqlClient;

namespace duyanh
{
    public static class Database
    {
        // Chuỗi kết nối
        public static string connectionString =
            @"Data Source=LAPTOP-N1U01T4S\MSSQLSERVER01;Initial Catalog=QuanLyTacGia;Integrated Security=True";

        // ========================== GET DATA ==========================
        public static DataTable GetData(string sql, params SqlParameter[] pars)
        {
            // Không dùng using-declaration vì C# 7.3 không hỗ trợ
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (pars != null && pars.Length > 0)
                        cmd.Parameters.AddRange(pars);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        // ======================= EXEC STORED PROC =======================
        public static void ExecStoredProc(string procName, params SqlParameter[] pars)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(procName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (pars != null && pars.Length > 0)
                        cmd.Parameters.AddRange(pars);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
