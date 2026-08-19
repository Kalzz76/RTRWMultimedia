using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using RTRWMultimedia.Database;

namespace RTRWMultimedia
{
    public partial class frmLaporan : Form
    {
        private SqlConnection conn;
        private SqlDataAdapter da;
        private DataTable dtLaporan = new DataTable();
        private CultureInfo cultureIndo = new CultureInfo("id-ID");
        private PrintDocument printDoc = new PrintDocument();
        private int printRowIndex = 0;

        public frmLaporan()
        {
            InitializeComponent();
            printDoc.PrintPage += PrintDoc_PrintPage;
        }

        private void frmLaporan_Load(object sender, EventArgs e)
        {
            dtpDari.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpSampai.Value = DateTime.Now;

            if (cboJenisLaporan.Items.Count > 0)
            {
                cboJenisLaporan.SelectedIndex = 0;
            }
        }

        private void cboJenisLaporan_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboFilterStatus.Items.Clear();

            int selectedIndex = cboJenisLaporan.SelectedIndex;
            if (selectedIndex == 0) // Iuran
            {
                cboFilterStatus.Items.AddRange(new object[] { "Semua Status", "Lunas", "Belum Lunas" });
            }
            else if (selectedIndex == 1) // Warga
            {
                cboFilterStatus.Items.AddRange(new object[] { "Semua Status", "Tetap", "Kontrak", "Pindah" });
            }
            else if (selectedIndex == 2) // Surat Pengantar
            {
                cboFilterStatus.Items.AddRange(new object[] { "Semua Status", "Disetujui", "Menunggu", "Selesai", "Ditolak" });
            }
            else // Pengumuman
            {
                cboFilterStatus.Items.AddRange(new object[] { "Semua Status" });
            }

            if (cboFilterStatus.Items.Count > 0)
            {
                cboFilterStatus.SelectedIndex = 0;
            }

            MuatDataLaporan();
        }

        private void btnTerapkanFilter_Click(object sender, EventArgs e)
        {
            MuatDataLaporan();
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            dtpDari.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpSampai.Value = DateTime.Now;
            txtCari.Clear();
            if (cboFilterStatus.Items.Count > 0) cboFilterStatus.SelectedIndex = 0;
            MuatDataLaporan();
        }

        private void MuatDataLaporan()
        {
            try
            {
                conn = Koneksi.GetConnection();
                int jenis = cboJenisLaporan.SelectedIndex;
                string filterStatus = cboFilterStatus.SelectedItem != null ? cboFilterStatus.SelectedItem.ToString() : "Semua Status";
                string cari = txtCari.Text.Trim();
                DateTime tglDari = dtpDari.Value.Date;
                DateTime tglSampai = dtpSampai.Value.Date.AddDays(1).AddSeconds(-1);

                string sql = "";

                if (jenis == 0) // Laporan Iuran
                {
                    sql = "SELECT id_iuran, nama_warga, bulan, nominal, tanggal_bayar, status_bayar FROM tb_iuran WHERE tanggal_bayar BETWEEN @dari AND @sampai";

                    if (filterStatus != "Semua Status")
                    {
                        sql += " AND status_bayar = @status";
                    }

                    if (!string.IsNullOrEmpty(cari))
                    {
                        sql += " AND (nama_warga LIKE @cari OR bulan LIKE @cari)";
                    }

                    sql += " ORDER BY tanggal_bayar DESC, id_iuran DESC";
                }
                else if (jenis == 1) // Laporan Warga
                {
                    sql = "SELECT id_warga, nik, nama, alamat, no_hp, status_warga FROM tb_warga WHERE 1=1";

                    if (filterStatus != "Semua Status")
                    {
                        sql += " AND status_warga = @status";
                    }

                    if (!string.IsNullOrEmpty(cari))
                    {
                        sql += " AND (nama LIKE @cari OR nik LIKE @cari OR alamat LIKE @cari)";
                    }

                    sql += " ORDER BY id_warga ASC";
                }
                else if (jenis == 2) // Laporan Surat Pengantar
                {
                    sql = "SELECT id_surat, no_surat, nik, nama_warga, keperluan, tanggal_surat, status_surat, keterangan FROM tb_surat WHERE tanggal_surat BETWEEN @dari AND @sampai";

                    if (filterStatus != "Semua Status")
                    {
                        sql += " AND status_surat = @status";
                    }

                    if (!string.IsNullOrEmpty(cari))
                    {
                        sql += " AND (nama_warga LIKE @cari OR no_surat LIKE @cari OR nik LIKE @cari OR keperluan LIKE @cari)";
                    }

                    sql += " ORDER BY tanggal_surat DESC, id_surat DESC";
                }
                else // Laporan Pengumuman
                {
                    sql = "SELECT id_pengumuman, judul, isi_pengumuman, tanggal_posting FROM tb_pengumuman WHERE tanggal_posting BETWEEN @dari AND @sampai";

                    if (!string.IsNullOrEmpty(cari))
                    {
                        sql += " AND (judul LIKE @cari OR isi_pengumuman LIKE @cari)";
                    }

                    sql += " ORDER BY tanggal_posting DESC, id_pengumuman DESC";
                }

                da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@dari", tglDari);
                da.SelectCommand.Parameters.AddWithValue("@sampai", tglSampai);

                if (filterStatus != "Semua Status")
                {
                    da.SelectCommand.Parameters.AddWithValue("@status", filterStatus);
                }

                if (!string.IsNullOrEmpty(cari))
                {
                    da.SelectCommand.Parameters.AddWithValue("@cari", "%" + cari + "%");
                }

                dtLaporan = new DataTable();
                da.Fill(dtLaporan);
                dgvLaporan.DataSource = dtLaporan;

                FormatGridAndBadges(jenis);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat memuat laporan:\n" + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatGridAndBadges(int jenis)
        {
            lblStat1.Text = "📄 Total Data: " + dtLaporan.Rows.Count;

            if (jenis == 0) // Iuran
            {
                if (dgvLaporan.Columns["id_iuran"] != null) dgvLaporan.Columns["id_iuran"].HeaderText = "ID";
                if (dgvLaporan.Columns["nama_warga"] != null) dgvLaporan.Columns["nama_warga"].HeaderText = "Nama Warga";
                if (dgvLaporan.Columns["bulan"] != null) dgvLaporan.Columns["bulan"].HeaderText = "Bulan";
                if (dgvLaporan.Columns["nominal"] != null)
                {
                    dgvLaporan.Columns["nominal"].HeaderText = "Nominal (Rp)";
                    dgvLaporan.Columns["nominal"].DefaultCellStyle.Format = "N0";
                }
                if (dgvLaporan.Columns["tanggal_bayar"] != null)
                {
                    dgvLaporan.Columns["tanggal_bayar"].HeaderText = "Tanggal Bayar";
                    dgvLaporan.Columns["tanggal_bayar"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }
                if (dgvLaporan.Columns["status_bayar"] != null) dgvLaporan.Columns["status_bayar"].HeaderText = "Status";

                decimal totalLunas = 0;
                decimal totalBelum = 0;

                foreach (DataRow row in dtLaporan.Rows)
                {
                    decimal nominal = 0;
                    if (row["nominal"] != DBNull.Value) nominal = Convert.ToDecimal(row["nominal"]);
                    string status = row["status_bayar"] != DBNull.Value ? row["status_bayar"].ToString() : "";

                    if (status.Equals("Lunas", StringComparison.OrdinalIgnoreCase))
                        totalLunas += nominal;
                    else
                        totalBelum += nominal;
                }

                lblStat2.Visible = true;
                lblStat3.Visible = true;
                lblStat2.Text = "💰 Kas Lunas: " + totalLunas.ToString("C0", cultureIndo);
                lblStat3.Text = "⏳ Belum Lunas: " + totalBelum.ToString("C0", cultureIndo);
            }
            else if (jenis == 1) // Warga
            {
                if (dgvLaporan.Columns["id_warga"] != null) dgvLaporan.Columns["id_warga"].HeaderText = "ID";
                if (dgvLaporan.Columns["nik"] != null) dgvLaporan.Columns["nik"].HeaderText = "NIK";
                if (dgvLaporan.Columns["nama"] != null) dgvLaporan.Columns["nama"].HeaderText = "Nama Warga";
                if (dgvLaporan.Columns["alamat"] != null) dgvLaporan.Columns["alamat"].HeaderText = "Alamat";
                if (dgvLaporan.Columns["no_hp"] != null) dgvLaporan.Columns["no_hp"].HeaderText = "No. HP";
                if (dgvLaporan.Columns["status_warga"] != null) dgvLaporan.Columns["status_warga"].HeaderText = "Status Warga";

                int tetap = 0;
                int kontrak = 0;
                foreach (DataRow row in dtLaporan.Rows)
                {
                    string status = row["status_warga"] != DBNull.Value ? row["status_warga"].ToString() : "";
                    if (status.Equals("Tetap", StringComparison.OrdinalIgnoreCase)) tetap++;
                    else kontrak++;
                }

                lblStat2.Visible = true;
                lblStat3.Visible = true;
                lblStat2.Text = "🏠 Warga Tetap: " + tetap;
                lblStat3.Text = "🏢 Kontrak/Lain: " + kontrak;
            }
            else if (jenis == 2) // Surat Pengantar
            {
                if (dgvLaporan.Columns["id_surat"] != null) dgvLaporan.Columns["id_surat"].HeaderText = "ID";
                if (dgvLaporan.Columns["no_surat"] != null) dgvLaporan.Columns["no_surat"].HeaderText = "No. Surat";
                if (dgvLaporan.Columns["nik"] != null) dgvLaporan.Columns["nik"].HeaderText = "NIK";
                if (dgvLaporan.Columns["nama_warga"] != null) dgvLaporan.Columns["nama_warga"].HeaderText = "Nama Pemohon";
                if (dgvLaporan.Columns["keperluan"] != null) dgvLaporan.Columns["keperluan"].HeaderText = "Keperluan";
                if (dgvLaporan.Columns["tanggal_surat"] != null)
                {
                    dgvLaporan.Columns["tanggal_surat"].HeaderText = "Tanggal";
                    dgvLaporan.Columns["tanggal_surat"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }
                if (dgvLaporan.Columns["status_surat"] != null) dgvLaporan.Columns["status_surat"].HeaderText = "Status";
                if (dgvLaporan.Columns["keterangan"] != null) dgvLaporan.Columns["keterangan"].HeaderText = "Keterangan";

                int selesai = 0;
                int proses = 0;
                foreach (DataRow row in dtLaporan.Rows)
                {
                    string status = row["status_surat"] != DBNull.Value ? row["status_surat"].ToString() : "";
                    if (status.Equals("Selesai", StringComparison.OrdinalIgnoreCase) || status.Equals("Disetujui", StringComparison.OrdinalIgnoreCase))
                        selesai++;
                    else
                        proses++;
                }

                lblStat2.Visible = true;
                lblStat3.Visible = true;
                lblStat2.Text = "✅ Selesai / Disetujui: " + selesai;
                lblStat3.Text = "⏳ Menunggu / Proses: " + proses;
            }
            else // Pengumuman
            {
                if (dgvLaporan.Columns["id_pengumuman"] != null) dgvLaporan.Columns["id_pengumuman"].HeaderText = "ID";
                if (dgvLaporan.Columns["judul"] != null) dgvLaporan.Columns["judul"].HeaderText = "Judul Pengumuman";
                if (dgvLaporan.Columns["isi_pengumuman"] != null) dgvLaporan.Columns["isi_pengumuman"].HeaderText = "Isi Pengumuman";
                if (dgvLaporan.Columns["tanggal_posting"] != null)
                {
                    dgvLaporan.Columns["tanggal_posting"].HeaderText = "Tanggal Terbit";
                    dgvLaporan.Columns["tanggal_posting"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }

                lblStat2.Visible = false;
                lblStat3.Visible = false;
            }
        }

        private void btnEksporExcel_Click(object sender, EventArgs e)
        {
            if (dtLaporan == null || dtLaporan.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada data yang dapat diekspor. Silakan tampilkan data terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV Spreadsheet (*.csv)|*.csv";
            sfd.FileName = "Laporan_" + cboJenisLaporan.Text.Replace(" ", "_") + "_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StringBuilder sb = new StringBuilder();

                    // Header Kolom
                    for (int i = 0; i < dgvLaporan.Columns.Count; i++)
                    {
                        sb.Append("\"" + dgvLaporan.Columns[i].HeaderText + "\"");
                        if (i < dgvLaporan.Columns.Count - 1) sb.Append(";");
                    }
                    sb.AppendLine();

                    // Baris Data
                    foreach (DataGridViewRow row in dgvLaporan.Rows)
                    {
                        for (int i = 0; i < dgvLaporan.Columns.Count; i++)
                        {
                            string cellVal = row.Cells[i].Value != null ? row.Cells[i].Value.ToString() : "";
                            sb.Append("\"" + cellVal.Replace("\"", "\"\"") + "\"");
                            if (i < dgvLaporan.Columns.Count - 1) sb.Append(";");
                        }
                        sb.AppendLine();
                    }

                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Laporan berhasil diekspor ke file CSV:\n" + sfd.FileName, "Ekspor Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal mengekspor data:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCetakLaporan_Click(object sender, EventArgs e)
        {
            if (dtLaporan == null || dtLaporan.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada data untuk dicetak!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                PrintDialog pd = new PrintDialog();
                pd.Document = printDoc;
                printRowIndex = 0;

                if (pd.ShowDialog() == DialogResult.OK)
                {
                    printDoc.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal melakukan pencetakan laporan:\n" + ex.Message, "Error Cetak", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fontHeader = new Font("Arial", 14, FontStyle.Bold);
            Font fontSub = new Font("Arial", 9.5f, FontStyle.Regular);
            Font fontCol = new Font("Arial", 9, FontStyle.Bold);
            Font fontRow = new Font("Arial", 8.5f, FontStyle.Regular);

            int startX = e.MarginBounds.Left;
            int startY = e.MarginBounds.Top;
            int currentY = startY;

            // Judul Dokumen
            string title = "REKAPITULASI " + cboJenisLaporan.Text.ToUpper();
            g.DrawString(title, fontHeader, Brushes.Black, startX, currentY);
            currentY += 25;

            string sub = $"Periode: {dtpDari.Value:dd/MM/yyyy} s/d {dtpSampai.Value:dd/MM/yyyy} | Dicetak pada: {DateTime.Now:dd/MM/yyyy HH:mm}";
            g.DrawString(sub, fontSub, Brushes.Gray, startX, currentY);
            currentY += 25;

            g.DrawLine(Pens.Black, startX, currentY, e.MarginBounds.Right, currentY);
            currentY += 10;

            // Header Tabel
            int numCols = dgvLaporan.Columns.Count;
            int colWidth = (e.MarginBounds.Width) / Math.Max(1, numCols);

            for (int i = 0; i < numCols; i++)
            {
                g.DrawString(dgvLaporan.Columns[i].HeaderText, fontCol, Brushes.Black, startX + (i * colWidth), currentY);
            }
            currentY += 22;
            g.DrawLine(Pens.Gray, startX, currentY, e.MarginBounds.Right, currentY);
            currentY += 5;

            // Baris Data
            while (printRowIndex < dgvLaporan.Rows.Count)
            {
                DataGridViewRow row = dgvLaporan.Rows[printRowIndex];

                for (int i = 0; i < numCols; i++)
                {
                    string text = row.Cells[i].Value != null ? row.Cells[i].Value.ToString() : "";
                    if (text.Length > 20) text = text.Substring(0, 18) + "..";
                    g.DrawString(text, fontRow, Brushes.Black, startX + (i * colWidth), currentY);
                }

                currentY += 20;
                printRowIndex++;

                if (currentY > e.MarginBounds.Bottom - 50)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            // Garis Penutup & Footer
            currentY += 10;
            g.DrawLine(Pens.Black, startX, currentY, e.MarginBounds.Right, currentY);
            currentY += 15;
            g.DrawString($"Total Rekord Data: {dtLaporan.Rows.Count}", fontCol, Brushes.Black, startX, currentY);

            printRowIndex = 0;
            e.HasMorePages = false;
        }
    }
}
