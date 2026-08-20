using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using RTRWMultimedia.Database;

namespace RTRWMultimedia
{
    public partial class frmProfil : Form
    {
        private string currentUser;
        private string currentRole;

        public frmProfil()
        {
            InitializeComponent();
            this.currentUser = "admin";
            this.currentRole = "Administrator";
        }

        public frmProfil(string username, string role)
        {
            InitializeComponent();
            this.currentUser = string.IsNullOrEmpty(username) ? "admin" : username;
            this.currentRole = string.IsNullOrEmpty(role) ? "Administrator" : role;
        }

        private void frmProfil_Load(object sender, EventArgs e)
        {
            txtUsername.Text = currentUser;
            txtRole.Text = currentRole;
            this.Text = "Profil Pengguna - " + currentUser + " (" + currentRole + ")";

            LoadAvatar();
            LoadUserDataFromDB();
        }

        private void LoadAvatar()
        {
            try
            {
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                string avatarPath = Path.Combine(baseDir, "logo_sekolah.png");
                if (File.Exists(avatarPath))
                {
                    using (FileStream fs = new FileStream(avatarPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    using (Image img = Image.FromStream(fs))
                    {
                        picAvatar.Image = new Bitmap(img);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Note loading avatar: " + ex.Message);
            }
        }

        private void LoadUserDataFromDB()
        {
            try
            {
                using (SqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT password FROM tb_user WHERE username=@user";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", currentUser);
                        object res = cmd.ExecuteScalar();
                        if (res != null)
                        {
                            txtPassword.Text = res.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading user profile: " + ex.Message);
            }
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPass.Checked ? '\0' : '*';
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string sql = "UPDATE tb_user SET password=@pass WHERE username=@user";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());
                        cmd.Parameters.AddWithValue("@user", currentUser);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Password berhasil diperbarui di database!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Gagal mengupdate password pengguna.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Kesalahan:\n" + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
