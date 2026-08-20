using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using RTRWMultimedia.Database;

namespace RTRWMultimedia
{
    public partial class frmGaleri : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;
        private int idGaleri = 0;
        private CultureInfo cultureIndo = new CultureInfo("id-ID");

        public frmGaleri()
        {
            InitializeComponent();
        }

        private void frmGaleri_Load(object sender, EventArgs e)
        {
            dtpTanggal.Value = DateTime.Now;
            if (cboKategori.Items.Count > 0) cboKategori.SelectedIndex = 0;
            if (cboFilterKategori.Items.Count > 0) cboFilterKategori.SelectedIndex = 0;

            TampilData();
            Bersih();
        }

        private void TampilData()
        {
            try
            {
                conn = Koneksi.GetConnection();
                da = new SqlDataAdapter("SELECT id_galeri, judul_kegiatan, kategori, tanggal_kegiatan, lokasi, deskripsi, foto_path FROM tb_galeri ORDER BY tanggal_kegiatan DESC, id_galeri DESC", conn);
                dt = new DataTable();
                da.Fill(dt);
                dgvGaleri.DataSource = dt;

                // Format Header Kolom
                if (dgvGaleri.Columns["id_galeri"] != null)
                {
                    dgvGaleri.Columns["id_galeri"].HeaderText = "ID";
                    dgvGaleri.Columns["id_galeri"].Width = 50;
                    dgvGaleri.Columns["id_galeri"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                }

                if (dgvGaleri.Columns["judul_kegiatan"] != null)
                {
                    dgvGaleri.Columns["judul_kegiatan"].HeaderText = "Nama / Judul Kegiatan";
                    dgvGaleri.Columns["judul_kegiatan"].Width = 220;
                    dgvGaleri.Columns["judul_kegiatan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                }

                if (dgvGaleri.Columns["kategori"] != null)
                {
                    dgvGaleri.Columns["kategori"].HeaderText = "Kategori";
                    dgvGaleri.Columns["kategori"].Width = 140;
                    dgvGaleri.Columns["kategori"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                }

                if (dgvGaleri.Columns["tanggal_kegiatan"] != null)
                {
                    dgvGaleri.Columns["tanggal_kegiatan"].HeaderText = "Tanggal";
                    dgvGaleri.Columns["tanggal_kegiatan"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgvGaleri.Columns["tanggal_kegiatan"].Width = 95;
                    dgvGaleri.Columns["tanggal_kegiatan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                }

                if (dgvGaleri.Columns["lokasi"] != null)
                {
                    dgvGaleri.Columns["lokasi"].HeaderText = "Lokasi";
                    dgvGaleri.Columns["lokasi"].Width = 160;
                    dgvGaleri.Columns["lokasi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                }

                if (dgvGaleri.Columns["deskripsi"] != null)
                {
                    dgvGaleri.Columns["deskripsi"].HeaderText = "Deskripsi / Catatan";
                }

                if (dgvGaleri.Columns["foto_path"] != null)
                {
                    dgvGaleri.Columns["foto_path"].HeaderText = "Lampiran Foto";
                    dgvGaleri.Columns["foto_path"].Width = 120;
                }

                lblTotalGaleri.Text = "🖼️ Total: " + dt.Rows.Count + " Kegiatan";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat memuat data galeri:\n" + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bersih()
        {
            txtJudul.Clear();
            if (cboKategori.Items.Count > 0) cboKategori.SelectedIndex = 0;
            dtpTanggal.Value = DateTime.Now;
            txtLokasi.Clear();
            txtDeskripsi.Clear();
            txtFotoPath.Clear();
            idGaleri = 0;
            txtJudul.Focus();
        }

        private bool ValidasiInput()
        {
            if (string.IsNullOrWhiteSpace(txtJudul.Text))
            {
                MessageBox.Show("Nama kegiatan tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJudul.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cboKategori.Text))
            {
                MessageBox.Show("Silakan pilih kategori kegiatan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboKategori.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLokasi.Text))
            {
                MessageBox.Show("Lokasi kegiatan tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLokasi.Focus();
                return false;
            }

            return true;
        }

        private void btnBrowseFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "File Gambar (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|Semua File (*.*)|*.*";
            ofd.Title = "Pilih Foto Kegiatan";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFotoPath.Text = ofd.FileName;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput()) return;

            try
            {
                conn = Koneksi.GetConnection();
                conn.Open();

                string sql = @"INSERT INTO tb_galeri (judul_kegiatan, kategori, tanggal_kegiatan, lokasi, deskripsi, foto_path) 
                               VALUES (@judul, @kategori, @tanggal, @lokasi, @deskripsi, @foto)";

                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@judul", txtJudul.Text.Trim());
                cmd.Parameters.AddWithValue("@kategori", cboKategori.Text.Trim());
                cmd.Parameters.AddWithValue("@tanggal", dtpTanggal.Value.Date);
                cmd.Parameters.AddWithValue("@lokasi", txtLokasi.Text.Trim());
                cmd.Parameters.AddWithValue("@deskripsi", txtDeskripsi.Text.Trim());
                cmd.Parameters.AddWithValue("@foto", txtFotoPath.Text.Trim());

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data dokumentasi kegiatan berhasil disimpan!", "Informasi Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TampilData();
                Bersih();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan galeri kegiatan:\n" + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvGaleri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvGaleri.Rows[e.RowIndex];

                if (row.Cells["id_galeri"].Value != DBNull.Value)
                    idGaleri = Convert.ToInt32(row.Cells["id_galeri"].Value);

                if (row.Cells["judul_kegiatan"].Value != DBNull.Value)
                    txtJudul.Text = row.Cells["judul_kegiatan"].Value.ToString();

                if (row.Cells["kategori"].Value != DBNull.Value)
                    cboKategori.Text = row.Cells["kategori"].Value.ToString();

                if (row.Cells["tanggal_kegiatan"].Value != DBNull.Value)
                    dtpTanggal.Value = Convert.ToDateTime(row.Cells["tanggal_kegiatan"].Value);

                if (row.Cells["lokasi"].Value != DBNull.Value)
                    txtLokasi.Text = row.Cells["lokasi"].Value.ToString();

                if (row.Cells["deskripsi"].Value != DBNull.Value)
                    txtDeskripsi.Text = row.Cells["deskripsi"].Value.ToString();

                if (row.Cells["foto_path"].Value != DBNull.Value)
                    txtFotoPath.Text = row.Cells["foto_path"].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (idGaleri == 0)
            {
                MessageBox.Show("Silakan pilih data kegiatan dari tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidasiInput()) return;

            try
            {
                conn = Koneksi.GetConnection();
                conn.Open();

                string sql = @"UPDATE tb_galeri SET 
                               judul_kegiatan=@judul, 
                               kategori=@kategori, 
                               tanggal_kegiatan=@tanggal, 
                               lokasi=@lokasi, 
                               deskripsi=@deskripsi, 
                               foto_path=@foto 
                               WHERE id_galeri=@id";

                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@judul", txtJudul.Text.Trim());
                cmd.Parameters.AddWithValue("@kategori", cboKategori.Text.Trim());
                cmd.Parameters.AddWithValue("@tanggal", dtpTanggal.Value.Date);
                cmd.Parameters.AddWithValue("@lokasi", txtLokasi.Text.Trim());
                cmd.Parameters.AddWithValue("@deskripsi", txtDeskripsi.Text.Trim());
                cmd.Parameters.AddWithValue("@foto", txtFotoPath.Text.Trim());
                cmd.Parameters.AddWithValue("@id", idGaleri);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Dokumentasi kegiatan berhasil diperbarui!", "Informasi Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TampilData();
                Bersih();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengedit galeri kegiatan:\n" + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (idGaleri == 0)
            {
                MessageBox.Show("Silakan pilih data kegiatan yang akan dihapus dari tabel!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult jawab = MessageBox.Show("Apakah Anda yakin ingin menghapus data dokumentasi kegiatan ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jawab == DialogResult.Yes)
            {
                try
                {
                    conn = Koneksi.GetConnection();
                    conn.Open();

                    string sql = "DELETE FROM tb_galeri WHERE id_galeri=@id";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", idGaleri);

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Dokumentasi kegiatan berhasil dihapus!", "Informasi Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TampilData();
                    Bersih();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus galeri kegiatan:\n" + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Bersih();
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            try
            {
                conn = Koneksi.GetConnection();
                string sql = "SELECT id_galeri, judul_kegiatan, kategori, tanggal_kegiatan, lokasi, deskripsi, foto_path FROM tb_galeri WHERE 1=1";

                string filterKategori = cboFilterKategori.SelectedItem != null ? cboFilterKategori.SelectedItem.ToString() : "Semua Kategori";
                if (filterKategori != "Semua Kategori")
                {
                    sql += " AND kategori = @kategori";
                }

                if (!string.IsNullOrWhiteSpace(txtCari.Text))
                {
                    sql += " AND (judul_kegiatan LIKE @cari OR lokasi LIKE @cari OR deskripsi LIKE @cari)";
                }

                sql += " ORDER BY tanggal_kegiatan DESC, id_galeri DESC";

                da = new SqlDataAdapter(sql, conn);

                if (filterKategori != "Semua Kategori")
                {
                    da.SelectCommand.Parameters.AddWithValue("@kategori", filterKategori);
                }

                if (!string.IsNullOrWhiteSpace(txtCari.Text))
                {
                    da.SelectCommand.Parameters.AddWithValue("@cari", "%" + txtCari.Text.Trim() + "%");
                }

                dt = new DataTable();
                da.Fill(dt);
                dgvGaleri.DataSource = dt;

                lblTotalGaleri.Text = "🖼️ Total: " + dt.Rows.Count + " Kegiatan";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Note filtering galeri: " + ex.Message);
            }
        }
    }
}
