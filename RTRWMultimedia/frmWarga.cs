using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using RTRWMultimedia.Database;

namespace RTRWMultimedia
{
    public partial class frmWarga : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;
        private int idWarga = 0;

        public frmWarga()
        {
            InitializeComponent();
        }

        private void frmWarga_Load(object sender, EventArgs e)
        {
            if (cboStatus.Items.Count > 0)
            {
                cboStatus.SelectedIndex = 0; // Default "Aktif"
            }
            TampilData();
            Bersih();
        }

        private void TampilData()
        {
            try
            {
                conn = Koneksi.GetConnection();
                da = new SqlDataAdapter("SELECT * FROM tb_warga ORDER BY id_warga DESC", conn);
                dt = new DataTable();
                da.Fill(dt);
                dgvWarga.DataSource = dt;

                // Rename headers for better presentation
                if (dgvWarga.Columns["id_warga"] != null) dgvWarga.Columns["id_warga"].HeaderText = "ID Warga";
                if (dgvWarga.Columns["nik"] != null) dgvWarga.Columns["nik"].HeaderText = "NIK";
                if (dgvWarga.Columns["nama_warga"] != null) dgvWarga.Columns["nama_warga"].HeaderText = "Nama Warga";
                if (dgvWarga.Columns["nama"] != null) dgvWarga.Columns["nama"].HeaderText = "Nama Warga";
                if (dgvWarga.Columns["alamat"] != null) dgvWarga.Columns["alamat"].HeaderText = "Alamat";
                if (dgvWarga.Columns["no_hp"] != null) dgvWarga.Columns["no_hp"].HeaderText = "No HP";
                if (dgvWarga.Columns["status_warga"] != null) dgvWarga.Columns["status_warga"].HeaderText = "Status Warga";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat memuat data warga:\n" + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bersih()
        {
            txtNik.Clear();
            txtNama.Clear();
            txtAlamat.Clear();
            txtHp.Clear();
            if (cboStatus.Items.Count > 0) cboStatus.SelectedIndex = 0;
            idWarga = 0;
            txtNik.Focus();
        }

        private bool ValidasiInput()
        {
            if (string.IsNullOrWhiteSpace(txtNik.Text))
            {
                MessageBox.Show("NIK tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNik.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Nama Warga tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNama.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtHp.Text) && !Regex.IsMatch(txtHp.Text.Trim(), @"^[0-9]+$"))
            {
                MessageBox.Show("Nomor HP hanya boleh diisi angka!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHp.Focus();
                return false;
            }

            return true;
        }

        private string GetColumnName(DataTable table, params string[] candidates)
        {
            foreach (string col in candidates)
            {
                if (table.Columns.Contains(col)) return col;
            }
            return candidates[0];
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput()) return;

            try
            {
                conn = Koneksi.GetConnection();
                conn.Open();

                string namaCol = GetColumnName(dt, "nama_warga", "nama");
                string sql = $@"INSERT INTO tb_warga (nik, {namaCol}, alamat, no_hp, status_warga) 
                               VALUES (@nik, @nama, @alamat, @hp, @status)";

                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nik", txtNik.Text.Trim());
                cmd.Parameters.AddWithValue("@nama", txtNama.Text.Trim());
                cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text.Trim());
                cmd.Parameters.AddWithValue("@hp", txtHp.Text.Trim());
                cmd.Parameters.AddWithValue("@status", cboStatus.Text);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data Warga Berhasil Disimpan!", "Informasi Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TampilData();
                Bersih();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data warga:\n" + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvWarga_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvWarga.Rows[e.RowIndex];

                if (row.Cells["id_warga"].Value != DBNull.Value)
                    idWarga = Convert.ToInt32(row.Cells["id_warga"].Value);

                if (dgvWarga.Columns.Contains("nik") && row.Cells["nik"].Value != DBNull.Value)
                    txtNik.Text = row.Cells["nik"].Value.ToString();

                string namaCol = dgvWarga.Columns.Contains("nama_warga") ? "nama_warga" : "nama";
                if (dgvWarga.Columns.Contains(namaCol) && row.Cells[namaCol].Value != DBNull.Value)
                    txtNama.Text = row.Cells[namaCol].Value.ToString();

                if (dgvWarga.Columns.Contains("alamat") && row.Cells["alamat"].Value != DBNull.Value)
                    txtAlamat.Text = row.Cells["alamat"].Value.ToString();

                if (dgvWarga.Columns.Contains("no_hp") && row.Cells["no_hp"].Value != DBNull.Value)
                    txtHp.Text = row.Cells["no_hp"].Value.ToString();

                if (dgvWarga.Columns.Contains("status_warga") && row.Cells["status_warga"].Value != DBNull.Value)
                    cboStatus.Text = row.Cells["status_warga"].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (idWarga == 0)
            {
                MessageBox.Show("Silakan pilih data warga dari tabel DataGridView terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidasiInput()) return;

            try
            {
                conn = Koneksi.GetConnection();
                conn.Open();

                string namaCol = GetColumnName(dt, "nama_warga", "nama");
                string sql = $@"UPDATE tb_warga SET 
                               nik=@nik, 
                               {namaCol}=@nama, 
                               alamat=@alamat, 
                               no_hp=@hp, 
                               status_warga=@status 
                               WHERE id_warga=@id";

                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nik", txtNik.Text.Trim());
                cmd.Parameters.AddWithValue("@nama", txtNama.Text.Trim());
                cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text.Trim());
                cmd.Parameters.AddWithValue("@hp", txtHp.Text.Trim());
                cmd.Parameters.AddWithValue("@status", cboStatus.Text);
                cmd.Parameters.AddWithValue("@id", idWarga);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data Warga Berhasil Diubah!", "Informasi Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TampilData();
                Bersih();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengedit data warga:\n" + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (idWarga == 0)
            {
                MessageBox.Show("Silakan pilih data warga yang akan dihapus dari tabel!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult jawab = MessageBox.Show("Apakah Anda yakin ingin menghapus data warga ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jawab == DialogResult.Yes)
            {
                try
                {
                    conn = Koneksi.GetConnection();
                    conn.Open();

                    string sql = "DELETE FROM tb_warga WHERE id_warga=@id";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", idWarga);

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Data Warga Berhasil Dihapus!", "Informasi Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TampilData();
                    Bersih();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus data warga:\n" + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string namaCol = GetColumnName(dt, "nama_warga", "nama");
                string sql = $"SELECT * FROM tb_warga WHERE {namaCol} LIKE @cari OR nik LIKE @cari ORDER BY id_warga DESC";

                da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@cari", "%" + txtCari.Text.Trim() + "%");

                dt = new DataTable();
                da.Fill(dt);
                dgvWarga.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Note filtering search: " + ex.Message);
            }
        }
    }
}
