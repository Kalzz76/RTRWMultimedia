using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using RTRWMultimedia.Database;

namespace RTRWMultimedia
{
    public partial class frmIuran : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;
        private int idIuran = 0;
        private CultureInfo cultureIndo = new CultureInfo("id-ID");

        public frmIuran()
        {
            InitializeComponent();
        }

        private void frmIuran_Load(object sender, EventArgs e)
        {
            SetCurrentMonthDefault();
            if (cboStatusBayar.Items.Count > 0) cboStatusBayar.SelectedIndex = 0; // Default "Lunas"
            if (cboFilterStatus.Items.Count > 0) cboFilterStatus.SelectedIndex = 0; // Default "Semua Status"

            LoadWargaCombo();
            TampilData();
            Bersih();
        }

        private void SetCurrentMonthDefault()
        {
            string[] bulanIndo = {
                "Januari", "Februari", "Maret", "April", "Mei", "Juni",
                "Juli", "Agustus", "September", "Oktober", "November", "Desember"
            };

            int currentMonthIndex = DateTime.Now.Month - 1;
            if (currentMonthIndex >= 0 && currentMonthIndex < bulanIndo.Length)
            {
                cboBulan.SelectedItem = bulanIndo[currentMonthIndex];
            }
        }

        private void LoadWargaCombo()
        {
            try
            {
                cboNamaWarga.Items.Clear();
                using (SqlConnection connWarga = Koneksi.GetConnection())
                {
                    connWarga.Open();
                    string sql = "SELECT ISNULL(nama, '') AS nama FROM tb_warga ORDER BY nama ASC";
                    using (SqlCommand cmdWarga = new SqlCommand(sql, connWarga))
                    {
                        using (SqlDataReader rd = cmdWarga.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                string nama = rd["nama"].ToString().Trim();
                                if (!string.IsNullOrEmpty(nama))
                                {
                                    cboNamaWarga.Items.Add(nama);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Note loading warga combo: " + ex.Message);
            }
        }

        private void TampilData()
        {
            try
            {
                conn = Koneksi.GetConnection();
                da = new SqlDataAdapter("SELECT id_iuran, nama_warga, bulan, nominal, tanggal_bayar, status_bayar FROM tb_iuran ORDER BY id_iuran DESC", conn);
                dt = new DataTable();
                da.Fill(dt);
                dgvIuran.DataSource = dt;

                // Format Header Kolom
                if (dgvIuran.Columns["id_iuran"] != null) dgvIuran.Columns["id_iuran"].HeaderText = "ID Iuran";
                if (dgvIuran.Columns["nama_warga"] != null) dgvIuran.Columns["nama_warga"].HeaderText = "Nama Warga";
                if (dgvIuran.Columns["bulan"] != null) dgvIuran.Columns["bulan"].HeaderText = "Bulan";
                if (dgvIuran.Columns["nominal"] != null)
                {
                    dgvIuran.Columns["nominal"].HeaderText = "Nominal";
                    dgvIuran.Columns["nominal"].DefaultCellStyle.Format = "C0";
                    dgvIuran.Columns["nominal"].DefaultCellStyle.FormatProvider = cultureIndo;
                    dgvIuran.Columns["nominal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgvIuran.Columns["tanggal_bayar"] != null)
                {
                    dgvIuran.Columns["tanggal_bayar"].HeaderText = "Tanggal Bayar";
                    dgvIuran.Columns["tanggal_bayar"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }
                if (dgvIuran.Columns["status_bayar"] != null) dgvIuran.Columns["status_bayar"].HeaderText = "Status Bayar";

                UpdateTotalKas(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat memuat data iuran:\n" + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTotalKas(DataTable dataTable)
        {
            try
            {
                decimal total = 0;
                if (dataTable != null)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        if (row["status_bayar"] != null && row["status_bayar"].ToString().Equals("Lunas", StringComparison.OrdinalIgnoreCase))
                        {
                            if (row["nominal"] != DBNull.Value)
                            {
                                total += Convert.ToDecimal(row["nominal"]);
                            }
                        }
                    }
                }
                lblTotalKas.Text = "💰 Kas Lunas: " + total.ToString("C0", cultureIndo);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Note updating total kas: " + ex.Message);
            }
        }

        private void Bersih()
        {
            cboNamaWarga.Text = "";
            SetCurrentMonthDefault();
            txtNominal.Text = "50000";
            dtpTanggalBayar.Value = DateTime.Now;
            if (cboStatusBayar.Items.Count > 0) cboStatusBayar.SelectedIndex = 0;
            idIuran = 0;
            cboNamaWarga.Focus();
        }

        private bool ValidasiInput()
        {
            if (string.IsNullOrWhiteSpace(cboNamaWarga.Text))
            {
                MessageBox.Show("Nama Warga tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNamaWarga.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cboBulan.Text))
            {
                MessageBox.Show("Silakan pilih Bulan Iuran!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboBulan.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNominal.Text))
            {
                MessageBox.Show("Nominal tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNominal.Focus();
                return false;
            }

            decimal nominalVal;
            string cleanNominal = txtNominal.Text.Replace("Rp", "").Replace(".", "").Replace(",", "").Trim();
            if (!decimal.TryParse(cleanNominal, out nominalVal) || nominalVal <= 0)
            {
                MessageBox.Show("Nominal harus berupa angka yang valid dan lebih besar dari 0!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNominal.Focus();
                return false;
            }

            return true;
        }

        private decimal GetParsedNominal()
        {
            string cleanNominal = txtNominal.Text.Replace("Rp", "").Replace(".", "").Replace(",", "").Trim();
            decimal nominalVal;
            if (decimal.TryParse(cleanNominal, out nominalVal))
            {
                return nominalVal;
            }
            return 50000;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput()) return;

            try
            {
                conn = Koneksi.GetConnection();
                conn.Open();

                string sql = @"INSERT INTO tb_iuran (nama_warga, bulan, nominal, tanggal_bayar, status_bayar) 
                               VALUES (@nama, @bulan, @nominal, @tanggal, @status)";

                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nama", cboNamaWarga.Text.Trim());
                cmd.Parameters.AddWithValue("@bulan", cboBulan.Text.Trim());
                cmd.Parameters.AddWithValue("@nominal", GetParsedNominal());
                cmd.Parameters.AddWithValue("@tanggal", dtpTanggalBayar.Value.Date);
                cmd.Parameters.AddWithValue("@status", cboStatusBayar.Text.Trim());

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data Iuran Berhasil Disimpan!", "Informasi Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TampilData();
                Bersih();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data iuran:\n" + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvIuran_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvIuran.Rows[e.RowIndex];

                if (row.Cells["id_iuran"].Value != DBNull.Value)
                    idIuran = Convert.ToInt32(row.Cells["id_iuran"].Value);

                if (row.Cells["nama_warga"].Value != DBNull.Value)
                    cboNamaWarga.Text = row.Cells["nama_warga"].Value.ToString();

                if (row.Cells["bulan"].Value != DBNull.Value)
                    cboBulan.Text = row.Cells["bulan"].Value.ToString();

                if (row.Cells["nominal"].Value != DBNull.Value)
                {
                    decimal nom = Convert.ToDecimal(row.Cells["nominal"].Value);
                    txtNominal.Text = ((long)nom).ToString();
                }

                if (row.Cells["tanggal_bayar"].Value != DBNull.Value)
                    dtpTanggalBayar.Value = Convert.ToDateTime(row.Cells["tanggal_bayar"].Value);

                if (row.Cells["status_bayar"].Value != DBNull.Value)
                    cboStatusBayar.Text = row.Cells["status_bayar"].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (idIuran == 0)
            {
                MessageBox.Show("Silakan pilih data iuran dari tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidasiInput()) return;

            try
            {
                conn = Koneksi.GetConnection();
                conn.Open();

                string sql = @"UPDATE tb_iuran SET 
                               nama_warga=@nama, 
                               bulan=@bulan, 
                               nominal=@nominal, 
                               tanggal_bayar=@tanggal, 
                               status_bayar=@status 
                               WHERE id_iuran=@id";

                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nama", cboNamaWarga.Text.Trim());
                cmd.Parameters.AddWithValue("@bulan", cboBulan.Text.Trim());
                cmd.Parameters.AddWithValue("@nominal", GetParsedNominal());
                cmd.Parameters.AddWithValue("@tanggal", dtpTanggalBayar.Value.Date);
                cmd.Parameters.AddWithValue("@status", cboStatusBayar.Text.Trim());
                cmd.Parameters.AddWithValue("@id", idIuran);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data Iuran Berhasil Diperbarui!", "Informasi Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TampilData();
                Bersih();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengedit data iuran:\n" + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (idIuran == 0)
            {
                MessageBox.Show("Silakan pilih data iuran yang akan dihapus dari tabel!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult jawab = MessageBox.Show("Apakah Anda yakin ingin menghapus data transaksi iuran ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jawab == DialogResult.Yes)
            {
                try
                {
                    conn = Koneksi.GetConnection();
                    conn.Open();

                    string sql = "DELETE FROM tb_iuran WHERE id_iuran=@id";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", idIuran);

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Data Iuran Berhasil Dihapus!", "Informasi Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TampilData();
                    Bersih();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus data iuran:\n" + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string sql = "SELECT id_iuran, nama_warga, bulan, nominal, tanggal_bayar, status_bayar FROM tb_iuran WHERE 1=1";

                string filterStatus = cboFilterStatus.SelectedItem != null ? cboFilterStatus.SelectedItem.ToString() : "Semua Status";
                if (filterStatus != "Semua Status")
                {
                    sql += " AND status_bayar = @statusFilter";
                }

                if (!string.IsNullOrWhiteSpace(txtCari.Text))
                {
                    sql += " AND (nama_warga LIKE @cari OR bulan LIKE @cari)";
                }

                sql += " ORDER BY id_iuran DESC";

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
                dgvIuran.DataSource = dt;

                UpdateTotalKas(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Note filtering search: " + ex.Message);
            }
        }
    }
}
