using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using RTRWMultimedia.Database;

namespace RTRWMultimedia
{
    public partial class frmPengumuman : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;
        private int idPengumuman = 0;
        private CultureInfo cultureIndo = new CultureInfo("id-ID");

        public frmPengumuman()
        {
            InitializeComponent();
        }

        private void frmPengumuman_Load(object sender, EventArgs e)
        {
            dtpTanggalPosting.Value = DateTime.Now;
            TampilData();
            Bersih();
        }

        private void TampilData()
        {
            try
            {
                conn = Koneksi.GetConnection();
                da = new SqlDataAdapter("SELECT id_pengumuman, judul, isi_pengumuman, tanggal_posting FROM tb_pengumuman ORDER BY id_pengumuman DESC", conn);
                dt = new DataTable();
                da.Fill(dt);
                dgvPengumuman.DataSource = dt;

                // Format Header Kolom
                if (dgvPengumuman.Columns["id_pengumuman"] != null)
                {
                    dgvPengumuman.Columns["id_pengumuman"].HeaderText = "ID";
                    dgvPengumuman.Columns["id_pengumuman"].Width = 60;
                    dgvPengumuman.Columns["id_pengumuman"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                }

                if (dgvPengumuman.Columns["judul"] != null)
                {
                    dgvPengumuman.Columns["judul"].HeaderText = "Judul Pengumuman";
                    dgvPengumuman.Columns["judul"].Width = 220;
                    dgvPengumuman.Columns["judul"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                }

                if (dgvPengumuman.Columns["isi_pengumuman"] != null)
                {
                    dgvPengumuman.Columns["isi_pengumuman"].HeaderText = "Isi Pengumuman";
                }

                if (dgvPengumuman.Columns["tanggal_posting"] != null)
                {
                    dgvPengumuman.Columns["tanggal_posting"].HeaderText = "Tanggal Terbit";
                    dgvPengumuman.Columns["tanggal_posting"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgvPengumuman.Columns["tanggal_posting"].Width = 120;
                    dgvPengumuman.Columns["tanggal_posting"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                }

                lblTotalPengumuman.Text = "📢 Total: " + dt.Rows.Count + " Berita";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat memuat data pengumuman:\n" + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bersih()
        {
            txtJudul.Clear();
            txtIsi.Clear();
            dtpTanggalPosting.Value = DateTime.Now;
            idPengumuman = 0;
            txtJudul.Focus();
        }

        private bool ValidasiInput()
        {
            if (string.IsNullOrWhiteSpace(txtJudul.Text))
            {
                MessageBox.Show("Judul pengumuman tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJudul.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtIsi.Text))
            {
                MessageBox.Show("Isi pengumuman tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIsi.Focus();
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

                string sql = @"INSERT INTO tb_pengumuman (judul, isi_pengumuman, tanggal_posting) 
                               VALUES (@judul, @isi, @tanggal)";

                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@judul", txtJudul.Text.Trim());
                cmd.Parameters.AddWithValue("@isi", txtIsi.Text.Trim());
                cmd.Parameters.AddWithValue("@tanggal", dtpTanggalPosting.Value.Date);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Pengumuman berhasil diterbitkan!", "Informasi Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TampilData();
                Bersih();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan pengumuman:\n" + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPengumuman_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPengumuman.Rows[e.RowIndex];

                if (row.Cells["id_pengumuman"].Value != DBNull.Value)
                    idPengumuman = Convert.ToInt32(row.Cells["id_pengumuman"].Value);

                if (row.Cells["judul"].Value != DBNull.Value)
                    txtJudul.Text = row.Cells["judul"].Value.ToString();

                if (row.Cells["isi_pengumuman"].Value != DBNull.Value)
                    txtIsi.Text = row.Cells["isi_pengumuman"].Value.ToString();

                if (row.Cells["tanggal_posting"].Value != DBNull.Value)
                    dtpTanggalPosting.Value = Convert.ToDateTime(row.Cells["tanggal_posting"].Value);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (idPengumuman == 0)
            {
                MessageBox.Show("Silakan pilih data pengumuman dari tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidasiInput()) return;

            try
            {
                conn = Koneksi.GetConnection();
                conn.Open();

                string sql = @"UPDATE tb_pengumuman SET 
                               judul=@judul, 
                               isi_pengumuman=@isi, 
                               tanggal_posting=@tanggal 
                               WHERE id_pengumuman=@id";

                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@judul", txtJudul.Text.Trim());
                cmd.Parameters.AddWithValue("@isi", txtIsi.Text.Trim());
                cmd.Parameters.AddWithValue("@tanggal", dtpTanggalPosting.Value.Date);
                cmd.Parameters.AddWithValue("@id", idPengumuman);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Pengumuman berhasil diperbarui!", "Informasi Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TampilData();
                Bersih();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengedit pengumuman:\n" + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (idPengumuman == 0)
            {
                MessageBox.Show("Silakan pilih data pengumuman yang akan dihapus dari tabel!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult jawab = MessageBox.Show("Apakah Anda yakin ingin menghapus pengumuman ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jawab == DialogResult.Yes)
            {
                try
                {
                    conn = Koneksi.GetConnection();
                    conn.Open();

                    string sql = "DELETE FROM tb_pengumuman WHERE id_pengumuman=@id";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", idPengumuman);

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Pengumuman berhasil dihapus!", "Informasi Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TampilData();
                    Bersih();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus pengumuman:\n" + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Bersih();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn = Koneksi.GetConnection();
                string sql = "SELECT id_pengumuman, judul, isi_pengumuman, tanggal_posting FROM tb_pengumuman WHERE judul LIKE @cari OR isi_pengumuman LIKE @cari ORDER BY id_pengumuman DESC";

                da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@cari", "%" + txtCari.Text.Trim() + "%");

                dt = new DataTable();
                da.Fill(dt);
                dgvPengumuman.DataSource = dt;

                lblTotalPengumuman.Text = "📢 Total: " + dt.Rows.Count + " Berita";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Note filtering pengumuman: " + ex.Message);
            }
        }
    }
}
