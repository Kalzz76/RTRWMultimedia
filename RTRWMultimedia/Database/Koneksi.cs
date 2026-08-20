using System.Data.SqlClient;

namespace RTRWMultimedia.Database
{
    public class Koneksi
    {
        private static string dataSource = @".\SQLEXPRESS";

        public static void SetDataSource(string server)
        {
            if (!string.IsNullOrWhiteSpace(server))
            {
                dataSource = server;
            }
        }

        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(
                string.Format(@"Data Source={0};Initial Catalog=DB_RTRW;Integrated Security=True;MultipleActiveResultSets=True", dataSource));

            return conn;
        }
    }
}

