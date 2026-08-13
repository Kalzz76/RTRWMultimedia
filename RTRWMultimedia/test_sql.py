import subprocess
import os

cs_code = """using System;
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
}"""

with open("TestConn.cs", "w", encoding="utf-8") as f:
    f.write(cs_code)

res = subprocess.run(["csc", "TestConn.cs"], capture_output=True, text=True)
print("Build:", res.stdout, res.stderr)
if os.path.exists("TestConn.exe"):
    res2 = subprocess.run(["TestConn.exe"], capture_output=True, text=True)
    print("Output:", res2.stdout)
