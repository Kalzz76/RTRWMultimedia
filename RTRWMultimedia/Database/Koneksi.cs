using System.Data.SqlClient;
namespace RTRWMultimedia.Database
{
    public class Koneksi
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection conn =
            new SqlConnection(
                @"Data Source=.\SQLEXPRESS;
                Initial Catalog=DB_RTRW;
                Integrated Security=True");
            return conn;
        }
    }
}