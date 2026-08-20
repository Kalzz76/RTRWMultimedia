using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using RTRWMultimedia.Database;

namespace RTRWMultimedia
{
    public partial class frmPengaturan : Form
    {
        private CultureInfo idCulture = new CultureInfo("id-ID");

        public frmPengaturan()
        {
            InitializeComponent();
        }

        private void frmPengaturan_Load(object sender, EventArgs e)
        {
            if (cboNewLevel.Items.Count > 0)
            {
                cboNewLevel.SelectedIndex = 1; // Default "Operator"
            }

            LoadProfilWilayah();
            LoadUserDataGrid();
        }

        private void LoadProfilWilayah()
        {
            try
            {
                using (SqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT TOP 1 nama_rt_rw, desa_kelurahan, kecamatan, kota_kabupaten, nama_ketua_rt, nama_sekretaris, nominal_iuran, tgl_jatuh_tempo FROM tb_pengaturan";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.Read())
                            {
                                txtNamaRTRW.Text = rd["nama_rt_rw"].ToString();
                                txtDesa.Text = rd["desa_kelurahan"].ToString();
                                txtKecamatan.Text = rd["kecamatan"].ToString();
                                txtKota.Text = rd["kota_kabupaten"].ToString();
                                txtKetuaRT.Text = rd["nama_ketua_rt"].ToString();
                                txtSekretaris.Text = rd["nama_sekretaris"].ToString();

                                int nominal = Convert.ToInt32(rd["nominal_iuran"]);
                                txtNominalIuran.Text = nominal.ToString();

                                int dueDay = Convert.ToInt32(rd["tgl_jatuh_tempo"]);
                                nudJatuhTempo.Value = Math.Max(1, Math.Min(31, dueDay));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Note loading settings: " + ex.Message);
            }
        }

        private void btnSimpanProfil_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string sql = @"UPDATE tb_pengaturan SET 
                                  nama_rt_rw=@rt, 
                                  desa_kelurahan=@desa, 
                                  kecamatan=@kec, 
                                  kota_kabupaten=@kota, 
                                  nama_ketua_rt=@ketua, 
                                  nama_sekretaris=@sek";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@rt", txtNamaRTRW.Text.Trim());
                        cmd.Parameters.AddWithValue("@desa", txtDesa.Text.Trim());
                        cmd.Parameters.AddWithValue("@kec", txtKecamatan.Text.Trim());
                        cmd.Parameters.AddWithValue("@kota", txtKota.Text.Trim());
                        cmd.Parameters.AddWithValue("@ketua", txtKetuaRT.Text.Trim());
                        cmd.Parameters.AddWithValue("@sek", txtSekretaris.Text.Trim());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Identitas Profil Wilayah RT/RW berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        frmDashboard parent = Application.OpenForms["frmDashboard"] as frmDashboard;
                        if (parent != null)
                        {
                            parent.LoadSettingsHeaders();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan identitas wilayah:\n" + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSimpanIuran_Click(object sender, EventArgs e)
        {
            int nominal = 50000;
            if (!int.TryParse(txtNominalIuran.Text.Trim(), out nominal) || nominal <= 0)
            {
                MessageBox.Show("Masukkan nominal iuran yang valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string sql = @"UPDATE tb_pengaturan SET 
                                  nominal_iuran=@nom, 
                                  tgl_jatuh_tempo=@tempo";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nom", nominal);
                        cmd.Parameters.AddWithValue("@tempo", (int)nudJatuhTempo.Value);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Pengaturan Master Iuran berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan master iuran:\n" + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUserDataGrid()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID User", typeof(int));
            dt.Columns.Add("Username", typeof(string));
            dt.Columns.Add("Level User / Role", typeof(string));

            try
            {
                using (SqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT id_user, username, level_user FROM tb_user ORDER BY id_user ASC";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                dt.Rows.Add(rd["id_user"], rd["username"], rd["level_user"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading users: " + ex.Message);
            }

            dgvUser.DataSource = dt;
        }

        private void btnTambahUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewUser.Text) || string.IsNullOrWhiteSpace(txtNewPass.Text))
            {
                MessageBox.Show("Username dan Password baru tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string user = txtNewUser.Text.Trim();
            string pass = txtNewPass.Text.Trim();
            string level = cboNewLevel.SelectedItem != null ? cboNewLevel.SelectedItem.ToString() : "Operator";

            try
            {
                using (SqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string sql = "INSERT INTO tb_user (username, password, level_user) VALUES (@user, @pass, @level)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", user);
                        cmd.Parameters.AddWithValue("@pass", pass);
                        cmd.Parameters.AddWithValue("@level", level);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Pengguna '{user}' dengan role ({level}) berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtNewUser.Clear();
                        txtNewPass.Clear();
                        LoadUserDataGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambah pengguna:\n" + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapusUser_Click(object sender, EventArgs e)
        {
            if (dgvUser.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silakan pilih baris pengguna yang ingin dihapus dari tabel!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idUser = Convert.ToInt32(dgvUser.SelectedRows[0].Cells["ID User"].Value);
            string user = dgvUser.SelectedRows[0].Cells["Username"].Value.ToString();

            if (user.Equals("admin", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Akun utama 'admin' tidak boleh dihapus demi keamanan sistem!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show($"Apakah Anda yakin ingin menghapus akun '{user}'?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = Koneksi.GetConnection())
                    {
                        conn.Open();
                        string sql = "DELETE FROM tb_user WHERE id_user=@id";
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", idUser);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show($"Pengguna '{user}' berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadUserDataGrid();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus pengguna:\n" + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTesKoneksi_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    MessageBox.Show("Status Koneksi SQL Server: BERHASIL TERHUBUNG!\nDatabase: DB_RTRW\nServer: .\\SQLEXPRESS", "Uji Koneksi Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Terhubung ke Database:\n" + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBackupDB_Click(object sender, EventArgs e)
        {
            try
            {
                string backupDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Backup");
                if (!Directory.Exists(backupDir))
                {
                    Directory.CreateDirectory(backupDir);
                }

                string fileName = $"Backup_DB_RTRW_{DateTime.Now:yyyyMMdd_HHmmss}.bak";
                string fullPath = Path.Combine(backupDir, fileName);

                using (SqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string sql = $"BACKUP DATABASE DB_RTRW TO DISK = '{fullPath}' WITH FORMAT, MEDIANAME = 'RTRW_Backup', NAME = 'Full Backup of DB_RTRW'";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Backup Database DB_RTRW Berhasil!\n\nLokasi Berkas:\n{fullPath}", "Backup Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal melakukan Backup Database:\n" + ex.Message + "\n\n(Catatan: Layanan SQL Server memerlukan hak akses simpan berkas di lokasi tujuan).", "Backup Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
