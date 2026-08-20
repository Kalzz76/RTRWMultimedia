using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using RTRWMultimedia.Database;

namespace RTRWMultimedia
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            UpdateClockAndDate();
            LoadAssets();

            // Otomatis cek & buat database + tabel jika belum ada di komputer ini
            System.Threading.ThreadPool.QueueUserWorkItem(_ =>
            {
                string msg;
                DbInitializer.EnsureDatabaseAndTablesExist(out msg);
            });
        }

        private void LoadAssets()
        {
            try
            {
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                string pathRt = Path.Combine(baseDir, "logo_rt.png");

                if (File.Exists(pathRt))
                {
                    using (FileStream fs = new FileStream(pathRt, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    using (Image img = Image.FromStream(fs))
                    {
                        picLogo.Image = new Bitmap(img);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Note loading assets: " + ex.Message);
            }
        }

        private void timerJam_Tick(object sender, EventArgs e)
        {
            UpdateClockAndDate();
        }

        private void UpdateClockAndDate()
        {
            DateTime now = DateTime.Now;
            lblJam.Text = now.ToString("HH:mm:ss");

            var culture = new System.Globalization.CultureInfo("id-ID");
            lblTanggal.Text = "- " + now.ToString("dddd, d MMMM yyyy", culture);
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Hilangkan suara beep sistem Windows
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Hilangkan suara beep sistem Windows
                btnLogin.PerformClick();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Silakan masukkan Username dan Password!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool loginSuccess = false;
            string levelUser = "";

            try
            {
                using (SqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();

                    string sql = "SELECT * FROM tb_user WHERE username=@user AND password=@pass";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());

                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.Read())
                            {
                                loginSuccess = true;
                                levelUser = rd["level_user"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Username atau Password Salah", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Kesalahan Koneksi Database:\n" + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (loginSuccess)
            {
                try
                {
                    MessageBox.Show("Login Berhasil! Selamat Datang (" + levelUser + ")", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmDashboard f = new frmDashboard(txtUsername.Text.Trim(), levelUser);
                    f.Show();

                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal Membuka Dashboard:\n" + ex.Message, "Error Form Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnTesKoneksi_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string msg;
                bool ok = DbInitializer.EnsureDatabaseAndTablesExist(out msg);

                if (ok)
                {
                    MessageBox.Show("Status Koneksi & Database:\n" + msg + "\n\nSemua tabel siap digunakan!", "Uji & Inisialisasi Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Koneksi / Inisialisasi Gagal:\n" + msg, "Uji Koneksi Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Kesalahan:\n" + ex.Message, "Uji Koneksi Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
