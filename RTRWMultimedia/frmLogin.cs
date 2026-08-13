using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RTRWMultimedia.Database;
using System.Data.SqlClient;

namespace RTRWMultimedia
{
    public partial class frmLogin: Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // Set initial date time
            lblDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = Koneksi.GetConnection();
                conn.Open();
                
                string sql = "SELECT * FROM tb_user " +
                             "WHERE username=@user " +
                             "AND password=@pass";
                             
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    MessageBox.Show("Login Berhasil");
                    frmDashboard f = new frmDashboard();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau Password Salah");
                }
                
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTesKoneksi_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = Koneksi.GetConnection();
                conn.Open();
                MessageBox.Show("Koneksi Berhasil");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
