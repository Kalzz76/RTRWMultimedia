using System;
using System.Data.SqlClient;

class Program {
    static void Main() {
        string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        try {
            using (var conn = new SqlConnection(connStr)) {
                conn.Open();
                Console.WriteLine("SQL Connection SUCCESSFUL! State: " + conn.State);
            }
        } catch (Exception ex) {
            Console.WriteLine("SQL Connection Error: " + ex.Message);
        }
    }
}