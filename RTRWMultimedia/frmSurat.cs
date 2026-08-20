using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using RTRWMultimedia.Database;

namespace RTRWMultimedia
{
    public partial class frmSurat : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;
        private int idSurat = 0;
        private CultureInfo cultureIndo = new CultureInfo("id-ID");
        private Dictionary<string, string> dictWargaNik = new Dictionary<string, string>();

        public frmSurat()
        {
            InitializeComponent();
        }

        private void frmSurat_Load(object sender, EventArgs e)
        {
            dtpTanggalSurat.Value = DateTime.Now;
            if (cboStatusSurat.Items.Count > 0) cboStatusSurat.SelectedIndex = 0; // "Disetujui"
            if (cboFilterStatus.Items.Count > 0) cboFilterStatus.SelectedIndex = 0; // "Semua Status"
            if (cboKeperluan.Items.Count > 0) cboKeperluan.SelectedIndex = 0;

            LoadWargaCombo();
            TampilData();
            Bersih();
        }

        private void LoadWargaCombo()
        {
            try
            {
                cboNamaWarga.Items.Clear();
                dictWargaNik.Clear();

                using (SqlConnection connWarga = Koneksi.GetConnection())
                {
                    connWarga.Open();
                    string sql = "SELECT ISNULL(nama, '') AS nama, ISNULL(nik, '') AS nik FROM tb_warga ORDER BY nama ASC";
                    using (SqlCommand cmdWarga = new SqlCommand(sql, connWarga))
                    {
                        using (SqlDataReader rd = cmdWarga.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                string nama = rd["nama"].ToString().Trim();
                                string nik = rd["nik"].ToString().Trim();

                                if (!string.IsNullOrEmpty(nama))
                                {
                                    cboNamaWarga.Items.Add(nama);
                                    if (!dictWargaNik.ContainsKey(nama))
                                    {
                                        dictWargaNik.Add(nama, nik);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Note loading warga combo in surat: " + ex.Message);
            }
        }

        private void cboNamaWarga_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedNama = cboNamaWarga.Text.Trim();
            if (dictWargaNik.ContainsKey(selectedNama))
            {
                txtNik.Text = dictWargaNik[selectedNama];
            }
        }

        private void GenerateAutoNoSurat()
        {
            try
            {
                int count = 1;
                using (SqlConnection connCount = Koneksi.GetConnection())
                {
                    connCount.Open();
                    string sql = "SELECT COUNT(*) FROM tb_surat";
                    using (SqlCommand cmdCount = new SqlCommand(sql, connCount))
                    {
                        count = Convert.ToInt32(cmdCount.ExecuteScalar()) + 1;
                    }
                }

                string romanMonth = GetRomanMonth(DateTime.Now.Month);
                int year = DateTime.Now.Year;
                txtNoSurat.Text = $"{count:D3}/SP-RT04/{romanMonth}/{year}";
            }
            catch
            {
                txtNoSurat.Text = $"001/SP-RT04/VIII/{DateTime.Now.Year}";
            }
        }

        private string GetRomanMonth(int month)
        {
            string[] romans = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X", "XI", "XII" };
            if (month >= 1 && month <= 12) return romans[month - 1];
            return "VIII";
        }

        private void TampilData()
        {
            try
            {
                conn = Koneksi.GetConnection();
                da = new SqlDataAdapter("SELECT id_surat, no_surat, nik, nama_warga, keperluan, tanggal_surat, status_surat, keterangan FROM tb_surat ORDER BY id_surat DESC", conn);
                dt = new DataTable();
                da.Fill(dt);
                dgvSurat.DataSource = dt;

                // Format Header Kolom
                if (dgvSurat.Columns["id_surat"] != null)
                {
                    dgvSurat.Columns["id_surat"].HeaderText = "ID";
                    dgvSurat.Columns["id_surat"].Width = 50;
                    dgvSurat.Columns["id_surat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                }

                if (dgvSurat.Columns["no_surat"] != null)
                {
                    dgvSurat.Columns["no_surat"].HeaderText = "No. Surat";
                    dgvSurat.Columns["no_surat"].Width = 160;
                    dgvSurat.Columns["no_surat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                }

                if (dgvSurat.Columns["nik"] != null)
                {
                    dgvSurat.Columns["nik"].HeaderText = "NIK";
                    dgvSurat.Columns["nik"].Width = 140;
                    dgvSurat.Columns["nik"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                }

                if (dgvSurat.Columns["nama_warga"] != null)
                {
                    dgvSurat.Columns["nama_warga"].HeaderText = "Nama Pemohon";
                    dgvSurat.Columns["nama_warga"].Width = 160;
                    dgvSurat.Columns["nama_warga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                }

                if (dgvSurat.Columns["keperluan"] != null)
                {
                    dgvSurat.Columns["keperluan"].HeaderText = "Keperluan";
                }

                if (dgvSurat.Columns["tanggal_surat"] != null)
                {
                    dgvSurat.Columns["tanggal_surat"].HeaderText = "Tanggal";
                    dgvSurat.Columns["tanggal_surat"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgvSurat.Columns["tanggal_surat"].Width = 100;
                    dgvSurat.Columns["tanggal_surat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                }

                if (dgvSurat.Columns["status_surat"] != null)
                {
                    dgvSurat.Columns["status_surat"].HeaderText = "Status";
                    dgvSurat.Columns["status_surat"].Width = 95;
                    dgvSurat.Columns["status_surat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                }

                if (dgvSurat.Columns["keterangan"] != null)
                {
                    dgvSurat.Columns["keterangan"].HeaderText = "Keterangan";
                }

                lblTotalSurat.Text = "📄 Total: " + dt.Rows.Count + " Surat";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat memuat data surat pengantar:\n" + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bersih()
        {
            GenerateAutoNoSurat();
            cboNamaWarga.Text = "";
            txtNik.Clear();
            if (cboKeperluan.Items.Count > 0) cboKeperluan.SelectedIndex = 0;
            txtKeterangan.Clear();
            dtpTanggalSurat.Value = DateTime.Now;
            if (cboStatusSurat.Items.Count > 0) cboStatusSurat.SelectedIndex = 0;
            idSurat = 0;
            cboNamaWarga.Focus();
        }

        private bool ValidasiInput()
        {
            if (string.IsNullOrWhiteSpace(txtNoSurat.Text))
            {
                MessageBox.Show("Nomor surat tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoSurat.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cboNamaWarga.Text))
            {
                MessageBox.Show("Nama warga pemohon tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNamaWarga.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNik.Text))
            {
                MessageBox.Show("NIK pemohon tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNik.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cboKeperluan.Text))
            {
                MessageBox.Show("Keperluan surat tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboKeperluan.Focus();
                return false;
            }

            return true;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput()) return;

            try
            {
                conn = Koneksi.GetConnection();
                conn.Open();

                string sql = @"INSERT INTO tb_surat (no_surat, nik, nama_warga, keperluan, tanggal_surat, status_surat, keterangan) 
                               VALUES (@no, @nik, @nama, @kep, @tanggal, @status, @ket)";

                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@no", txtNoSurat.Text.Trim());
                cmd.Parameters.AddWithValue("@nik", txtNik.Text.Trim());
                cmd.Parameters.AddWithValue("@nama", cboNamaWarga.Text.Trim());
                cmd.Parameters.AddWithValue("@kep", cboKeperluan.Text.Trim());
                cmd.Parameters.AddWithValue("@tanggal", dtpTanggalSurat.Value.Date);
                cmd.Parameters.AddWithValue("@status", cboStatusSurat.Text.Trim());
                cmd.Parameters.AddWithValue("@ket", txtKeterangan.Text.Trim());

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data Surat Pengantar berhasil disimpan!", "Informasi Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TampilData();
                Bersih();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan surat pengantar:\n" + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSurat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSurat.Rows[e.RowIndex];

                if (row.Cells["id_surat"].Value != DBNull.Value)
                    idSurat = Convert.ToInt32(row.Cells["id_surat"].Value);

                if (row.Cells["no_surat"].Value != DBNull.Value)
                    txtNoSurat.Text = row.Cells["no_surat"].Value.ToString();

                if (row.Cells["nik"].Value != DBNull.Value)
                    txtNik.Text = row.Cells["nik"].Value.ToString();

                if (row.Cells["nama_warga"].Value != DBNull.Value)
                    cboNamaWarga.Text = row.Cells["nama_warga"].Value.ToString();

                if (row.Cells["keperluan"].Value != DBNull.Value)
                    cboKeperluan.Text = row.Cells["keperluan"].Value.ToString();

                if (row.Cells["tanggal_surat"].Value != DBNull.Value)
                    dtpTanggalSurat.Value = Convert.ToDateTime(row.Cells["tanggal_surat"].Value);

                if (row.Cells["status_surat"].Value != DBNull.Value)
                    cboStatusSurat.Text = row.Cells["status_surat"].Value.ToString();

                if (row.Cells["keterangan"].Value != DBNull.Value)
                    txtKeterangan.Text = row.Cells["keterangan"].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (idSurat == 0)
            {
                MessageBox.Show("Silakan pilih data surat pengantar dari tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidasiInput()) return;

            try
            {
                conn = Koneksi.GetConnection();
                conn.Open();

                string sql = @"UPDATE tb_surat SET 
                               no_surat=@no, 
                               nik=@nik, 
                               nama_warga=@nama, 
                               keperluan=@kep, 
                               tanggal_surat=@tanggal, 
                               status_surat=@status, 
                               keterangan=@ket 
                               WHERE id_surat=@id";

                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@no", txtNoSurat.Text.Trim());
                cmd.Parameters.AddWithValue("@nik", txtNik.Text.Trim());
                cmd.Parameters.AddWithValue("@nama", cboNamaWarga.Text.Trim());
                cmd.Parameters.AddWithValue("@kep", cboKeperluan.Text.Trim());
                cmd.Parameters.AddWithValue("@tanggal", dtpTanggalSurat.Value.Date);
                cmd.Parameters.AddWithValue("@status", cboStatusSurat.Text.Trim());
                cmd.Parameters.AddWithValue("@ket", txtKeterangan.Text.Trim());
                cmd.Parameters.AddWithValue("@id", idSurat);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data Surat Pengantar berhasil diperbarui!", "Informasi Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TampilData();
                Bersih();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengedit surat pengantar:\n" + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (idSurat == 0)
            {
                MessageBox.Show("Silakan pilih data surat yang akan dihapus dari tabel!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult jawab = MessageBox.Show("Apakah Anda yakin ingin menghapus data surat pengantar ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jawab == DialogResult.Yes)
            {
                try
                {
                    conn = Koneksi.GetConnection();
                    conn.Open();

                    string sql = "DELETE FROM tb_surat WHERE id_surat=@id";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", idSurat);

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Surat pengantar berhasil dihapus!", "Informasi Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TampilData();
                    Bersih();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus surat pengantar:\n" + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Bersih();
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboNamaWarga.Text) || string.IsNullOrWhiteSpace(txtNoSurat.Text))
            {
                MessageBox.Show("Pilih atau isi data surat pengantar terlebih dahulu untuk melihat pratinjau cetak!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ambil data identitas RT dari tb_pengaturan
            string rt = "RT 04 / RW 02";
            string desa = "Desa Sukamaju";
            string kec = "Kecamatan Ciawi";
            string kota = "Kabupaten Bogor";
            string ketuaRT = "Bapak Sutrisno";
            string alamatWarga = "";

            try
            {
                using (SqlConnection connPeng = Koneksi.GetConnection())
                {
                    connPeng.Open();
                    using (SqlCommand cmdPeng = new SqlCommand("SELECT TOP 1 nama_rt_rw, desa_kelurahan, kecamatan, kota_kabupaten, nama_ketua_rt FROM tb_pengaturan", connPeng))
                    {
                        using (SqlDataReader rd = cmdPeng.ExecuteReader())
                        {
                            if (rd.Read())
                            {
                                if (rd["nama_rt_rw"] != DBNull.Value) rt = rd["nama_rt_rw"].ToString();
                                if (rd["desa_kelurahan"] != DBNull.Value) desa = rd["desa_kelurahan"].ToString();
                                if (rd["kecamatan"] != DBNull.Value) kec = rd["kecamatan"].ToString();
                                if (rd["kota_kabupaten"] != DBNull.Value) kota = rd["kota_kabupaten"].ToString();
                                if (rd["nama_ketua_rt"] != DBNull.Value) ketuaRT = rd["nama_ketua_rt"].ToString();
                            }
                        }
                    }

                    // Ambil alamat spesifik warga jika ada di tb_warga
                    using (SqlCommand cmdWarga = new SqlCommand("SELECT TOP 1 alamat FROM tb_warga WHERE nik = @nik OR nama = @nama", connPeng))
                    {
                        cmdWarga.Parameters.AddWithValue("@nik", txtNik.Text.Trim());
                        cmdWarga.Parameters.AddWithValue("@nama", cboNamaWarga.Text.Trim());
                        object val = cmdWarga.ExecuteScalar();
                        if (val != null && val != DBNull.Value)
                        {
                            alamatWarga = val.ToString().Trim();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Note reading setting for print: " + ex.Message);
            }

            if (string.IsNullOrWhiteSpace(alamatWarga))
            {
                alamatWarga = $"{rt}, {desa}";
            }

            // Buka form pratinjau dokumen cetak resmi
            frmPreviewSurat preview = new frmPreviewSurat();
            preview.SetSuratData(
                txtNoSurat.Text.Trim(),
                cboNamaWarga.Text.Trim(),
                txtNik.Text.Trim(),
                alamatWarga,
                cboKeperluan.Text.Trim(),
                txtKeterangan.Text.Trim(),
                dtpTanggalSurat.Value.Date,
                rt,
                desa,
                kec,
                kota,
                ketuaRT
            );
            preview.ShowDialog(this);
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            try
            {
                conn = Koneksi.GetConnection();
                string sql = "SELECT id_surat, no_surat, nik, nama_warga, keperluan, tanggal_surat, status_surat, keterangan FROM tb_surat WHERE 1=1";

                string filterStatus = cboFilterStatus.SelectedItem != null ? cboFilterStatus.SelectedItem.ToString() : "Semua Status";
                if (filterStatus != "Semua Status")
                {
                    sql += " AND status_surat = @statusFilter";
                }

                if (!string.IsNullOrWhiteSpace(txtCari.Text))
                {
                    sql += " AND (nama_warga LIKE @cari OR no_surat LIKE @cari OR keperluan LIKE @cari OR nik LIKE @cari)";
                }

                sql += " ORDER BY id_surat DESC";

                da = new SqlDataAdapter(sql, conn);

                if (filterStatus != "Semua Status")
                {
                    da.SelectCommand.Parameters.AddWithValue("@statusFilter", filterStatus);
                }

                if (!string.IsNullOrWhiteSpace(txtCari.Text))
                {
                    da.SelectCommand.Parameters.AddWithValue("@cari", "%" + txtCari.Text.Trim() + "%");
                }

                dt = new DataTable();
                da.Fill(dt);
                dgvSurat.DataSource = dt;

                lblTotalSurat.Text = "📄 Total: " + dt.Rows.Count + " Surat";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Note filtering surat: " + ex.Message);
            }
        }
    }
}
