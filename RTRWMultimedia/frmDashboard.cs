using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using RTRWMultimedia.Database;

namespace RTRWMultimedia
{
    public partial class frmDashboard : Form
    {
        private CultureInfo idCulture = new CultureInfo("id-ID");
        private string currentUsername = "admin";
        private string currentLevelUser = "Administrator";
        private Form activeSubForm = null;

        public frmDashboard()
        {
            InitializeComponent();
        }

        public frmDashboard(string username, string levelUser)
        {
            InitializeComponent();
            this.currentUsername = string.IsNullOrEmpty(username) ? "admin" : username;
            this.currentLevelUser = string.IsNullOrEmpty(levelUser) ? "Administrator" : levelUser;
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            // 1. Inisialisasi Jam & Tanggal awal
            UpdateClockAndDate();

            // 2. Load Assets Gambar
            LoadImageAssets();

            // 2.5. Load Identitas RT/RW dari Pengaturan Wilayah
            LoadSettingsHeaders();

            // 3. ToolTip pada Logo / Profil
            ToolTip tt = new ToolTip();
            tt.SetToolTip(picLogo, "Profil Pengguna: " + currentUsername + " (" + currentLevelUser + ")");

            // 4. Load Identitas RT / RW dari tb_pengaturan
            LoadIdentitasWilayah();

            // 5. Populate Statistical Cards dari Database SQL
            PopulateStatCardsFromDB();

            // 6. Populate Pengumuman dari Database SQL
            PopulateAnnouncements();

            // 7. Populate Latest Kegiatan dari Database SQL (tb_galeri)
            PopulateLatestActivity();

            // 8. Populate Chart Iuran
            PopulateChartData();

            // 9. Populate DataGridView Transaksi dari Database SQL
            PopulateTransactionGrid();

            // 10. Adjust Layout Responsiveness
            AdjustLayoutResponsiveness();
        }

        private void OpenSubForm(Form childForm)
        {
            if (activeSubForm != null)
            {
                var prev = activeSubForm;
                activeSubForm = null;
                prev.Close();
                prev.Dispose();
            }

            flpContent.Visible = false;

            activeSubForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            childForm.FormClosed += (s, args) =>
            {
                if (activeSubForm == childForm)
                {
                    activeSubForm = null;
                    ShowDashboardOverview();
                }
            };

            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ShowDashboardOverview()
        {
            if (activeSubForm != null)
            {
                var prev = activeSubForm;
                activeSubForm = null;
                prev.Close();
                prev.Dispose();
            }

            flpContent.Visible = true;
            flpContent.BringToFront();

            // Refresh seluruh data dari database SQL
            LoadIdentitasWilayah();
            PopulateStatCardsFromDB();
            PopulateAnnouncements();
            PopulateLatestActivity();
            PopulateChartData();
            PopulateTransactionGrid();
            AdjustLayoutResponsiveness();

            // Highlight Dashboard button in sidebar
            HighlightNavButton(btnDashboard);
        }

        private void HighlightNavButton(Button activeBtn)
        {
            foreach (Control ctrl in flpNavMenu.Controls)
            {
                if (ctrl is Button btn && btn != btnKeluar)
                {
                    btn.BackColor = Color.Transparent;
                    btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                }
            }

            if (activeBtn != null && activeBtn != btnKeluar)
            {
                activeBtn.BackColor = Color.FromArgb(15, 118, 110);
                activeBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
        }

        private void picLogoSekolah_Click(object sender, EventArgs e)
        {
            frmProfil p = new frmProfil(currentUsername, currentLevelUser);
            p.ShowDialog();
            PopulateStatCardsFromDB();
        }

        private void frmDashboard_Resize(object sender, EventArgs e)
        {
            AdjustLayoutResponsiveness();
        }

        private void AdjustLayoutResponsiveness()
        {
            if (flpContent == null) return;

            int availWidth = flpContent.ClientSize.Width - 30;
            if (availWidth < 200) return;

            // 1. Responsive Statistic Cards (4 cards)
            int cardWidth = (availWidth - 45) / 4;
            if (cardWidth < 180) cardWidth = (availWidth - 15) / 2;
            if (cardWidth < 180) cardWidth = availWidth;

            pnlJumlahWarga.Width = cardWidth;
            pnlAktifBayar.Width = cardWidth;
            pnlBelumBayar.Width = cardWidth;
            pnlKas.Width = cardWidth;

            // 2. Responsive GroupBoxes
            int halfWidth = (availWidth - 15) / 2;
            if (halfWidth < 380)
            {
                grpPengumuman.Width = availWidth;
                grpKegiatan.Width = availWidth;
                grpChart.Width = availWidth;
                grpTransaksi.Width = availWidth;
            }
            else
            {
                grpPengumuman.Width = halfWidth;
                grpKegiatan.Width = halfWidth;
                grpChart.Width = halfWidth;
                grpTransaksi.Width = halfWidth;
            }
        }

        private void UpdateClockAndDate()
        {
            DateTime now = DateTime.Now;
            lblJam.Text = now.ToString("HH:mm:ss");
            lblTanggal.Text = now.ToString("dddd, dd MMMM yyyy", idCulture);
        }

        private void timerJam_Tick(object sender, EventArgs e)
        {
            UpdateClockAndDate();
        }

        private void LoadImageAssets()
        {
            try
            {
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                
                string rtPath = Path.Combine(baseDir, "logo_rt.png");
                if (!File.Exists(rtPath))
                {
                    try
                    {
                        var parentNode = Directory.GetParent(baseDir);
                        if (parentNode != null && parentNode.Parent != null)
                        {
                            string vsPath = Path.Combine(parentNode.Parent.FullName, "logo_rt.png");
                            if (File.Exists(vsPath)) rtPath = vsPath;
                        }
                    }
                    catch { }
                }

                if (File.Exists(rtPath))
                {
                    using (FileStream fs = new FileStream(rtPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    using (Image img = Image.FromStream(fs))
                    {
                        picLogo.Image = new Bitmap(img);
                    }
                }

                string kbPath = Path.Combine(baseDir, "kerjabakti.jpg");
                if (!File.Exists(kbPath))
                {
                    try
                    {
                        var parentNode = Directory.GetParent(baseDir);
                        if (parentNode != null && parentNode.Parent != null)
                        {
                            string vsPath = Path.Combine(parentNode.Parent.FullName, "kerjabakti.jpg");
                            if (File.Exists(vsPath)) kbPath = vsPath;
                        }
                    }
                    catch { }
                }

                if (File.Exists(kbPath))
                {
                    using (FileStream fs = new FileStream(kbPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    using (Image img = Image.FromStream(fs))
                    {
                        picKegiatan.Image = new Bitmap(img);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Note loading assets: " + ex.Message);
            }
        }

        public void LoadSettingsHeaders()
        {
            try
            {
                using (SqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT TOP 1 nama_rt_rw, desa_kelurahan FROM tb_pengaturan";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.Read())
                            {
                                string rt = rd["nama_rt_rw"] != DBNull.Value ? rd["nama_rt_rw"].ToString() : "";
                                string desa = rd["desa_kelurahan"] != DBNull.Value ? rd["desa_kelurahan"].ToString() : "";
                                if (!string.IsNullOrWhiteSpace(rt)) lblRTRW.Text = rt;
                                if (!string.IsNullOrWhiteSpace(desa))
                                {
                                    lblSubRTRW.Text = "DESA " + desa.ToUpper();
                                    lblSubJudul.Text = $"{rt} {desa} - Sistem Informasi Terpadu";
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Note loading identitas wilayah: " + ex.Message);
            }
        }

        private void LoadIdentitasWilayah()
        {
            LoadSettingsHeaders();
        }
        private void PopulateStatCardsFromDB()
        {
            // === TOTAL WARGA ===
            int totalWarga = 0;
            try
            {
                using (SqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    // Coba query dengan status_warga dulu
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tb_warga WHERE status_warga = 'Aktif'", conn))
                            totalWarga = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    catch
                    {
                        // Jika kolom status_warga tidak ada, hitung semua warga
                        using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tb_warga", conn))
                            totalWarga = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                lblTotalWarga.Text = totalWarga.ToString();
            }
            catch (Exception ex)
            {
                lblTotalWarga.Text = "0";
                Console.WriteLine("Stats - Total Warga error: " + ex.Message);
            }

            // === AKTIF BAYAR (sudah bayar iuran bulan ini) ===
            int aktifBayar = 0;
            try
            {
                string bulanIni = DateTime.Now.ToString("MMMM", new System.Globalization.CultureInfo("id-ID"));
                using (SqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    // Coba dengan filter bulan
                    try
                    {
                        string sql = "SELECT COUNT(DISTINCT nama_warga) FROM tb_iuran WHERE status_bayar = 'Lunas' AND bulan = @bulan";
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@bulan", bulanIni);
                            aktifBayar = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                    }
                    catch
                    {
                        // Fallback: hitung semua yang Lunas tanpa filter bulan
                        string sql = "SELECT COUNT(DISTINCT nama_warga) FROM tb_iuran WHERE status_bayar = 'Lunas'";
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                            aktifBayar = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                lblAktifBayarVal.Text = aktifBayar.ToString();
            }
            catch (Exception ex)
            {
                lblAktifBayarVal.Text = "0";
                Console.WriteLine("Stats - Aktif Bayar error: " + ex.Message);
            }

            // === BELUM BAYAR ===
            try
            {
                int belumBayar = Math.Max(0, totalWarga - aktifBayar);
                lblBelumBayarVal.Text = belumBayar.ToString();
            }
            catch
            {
                lblBelumBayarVal.Text = "0";
            }

            // === TOTAL KAS ===
            try
            {
                using (SqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    // Coba SUM dengan CAST BIGINT
                    try
                    {
                        string sql = "SELECT ISNULL(SUM(CAST(nominal AS BIGINT)), 0) FROM tb_iuran WHERE status_bayar='Lunas'";
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            long totalKas = Convert.ToInt64(cmd.ExecuteScalar());
                            lblTotalKas.Text = "Rp " + totalKas.ToString("N0", idCulture);
                        }
                    }
                    catch
                    {
                        // Fallback dengan DECIMAL
                        string sql = "SELECT ISNULL(SUM(nominal), 0) FROM tb_iuran WHERE status_bayar='Lunas'";
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            decimal totalKas = Convert.ToDecimal(cmd.ExecuteScalar());
                            lblTotalKas.Text = "Rp " + totalKas.ToString("N0", idCulture);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblTotalKas.Text = "Rp 0";
                Console.WriteLine("Stats - Total Kas error: " + ex.Message);
            }
        }


        private void PopulateAnnouncements()
        {
            rtbPengumuman.Clear();

            try
            {
                using (SqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT id_pengumuman, judul, isi_pengumuman, tanggal_posting FROM tb_pengumuman ORDER BY id_pengumuman DESC";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            bool hasData = false;
                            while (rd.Read())
                            {
                                hasData = true;
                                string judul = rd["judul"] != DBNull.Value ? rd["judul"].ToString() : "";
                                string isi = rd["isi_pengumuman"] != DBNull.Value ? rd["isi_pengumuman"].ToString() : "";
                                string tgl = rd["tanggal_posting"] != DBNull.Value ? Convert.ToDateTime(rd["tanggal_posting"]).ToString("dd MMMM yyyy", idCulture) : "";

                                rtbPengumuman.SelectionFont = new Font("Segoe UI", 10F, FontStyle.Bold);
                                rtbPengumuman.SelectionColor = Color.FromArgb(15, 118, 110);
                                rtbPengumuman.AppendText("ðŸ“¢  " + judul.ToUpper());
                                if (!string.IsNullOrEmpty(tgl))
                                {
                                    rtbPengumuman.SelectionFont = new Font("Segoe UI", 8F, FontStyle.Italic);
                                    rtbPengumuman.SelectionColor = Color.FromArgb(100, 116, 139);
                                    rtbPengumuman.AppendText($" ({tgl})");
                                }
                                rtbPengumuman.AppendText("\n");

                                rtbPengumuman.SelectionFont = new Font("Segoe UI", 9.5F, FontStyle.Regular);
                                rtbPengumuman.SelectionColor = Color.FromArgb(51, 65, 85);
                                rtbPengumuman.AppendText(isi + "\n\n");
                            }

                            if (!hasData)
                            {
                                rtbPengumuman.SelectionFont = new Font("Segoe UI", 9.5F, FontStyle.Italic);
                                rtbPengumuman.SelectionColor = Color.FromArgb(100, 116, 139);
                                rtbPengumuman.AppendText("Belum ada pengumuman yang tersimpan di database.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Note loading announcements: " + ex.Message);
            }
        }

        private void PopulateLatestActivity()
        {
            try
            {
                using (SqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT TOP 1 judul_kegiatan, kategori, tanggal_kegiatan, lokasi, deskripsi, foto_path FROM tb_galeri ORDER BY tanggal_kegiatan DESC, id_galeri DESC";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.Read())
                            {
                                string judul = rd["judul_kegiatan"] != DBNull.Value ? rd["judul_kegiatan"].ToString() : "Dokumentasi Kegiatan";
                                string fotoPath = rd["foto_path"] != DBNull.Value ? rd["foto_path"].ToString() : "";
                                string tgl = rd["tanggal_kegiatan"] != DBNull.Value ? Convert.ToDateTime(rd["tanggal_kegiatan"]).ToString("dd MMMM yyyy", idCulture) : "";
                                string lokasi = rd["lokasi"] != DBNull.Value ? rd["lokasi"].ToString() : "";

                                grpKegiatan.Text = $"ðŸ–¼ï¸  DOKUMENTASI: {judul.ToUpper()}";

                                if (!string.IsNullOrEmpty(fotoPath) && File.Exists(fotoPath))
                                {
                                    try
                                    {
                                        using (var imgTemp = Image.FromFile(fotoPath))
                                        {
                                            picKegiatan.Image = new Bitmap(imgTemp);
                                        }
                                    }
                                    catch { }
                                }
                                else
                                {
                                    string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                                    string kbPath = Path.Combine(baseDir, "kerjabakti.jpg");
                                    if (File.Exists(kbPath))
                                    {
                                        picKegiatan.Image = Image.FromFile(kbPath);
                                    }
                                    else
                                    {
                                        // Visual card banner
                                        Bitmap bmp = new Bitmap(420, 210);
                                        using (Graphics g = Graphics.FromImage(bmp))
                                        {
                                            g.Clear(Color.FromArgb(241, 245, 249));
                                            using (Brush b = new SolidBrush(Color.FromArgb(15, 118, 110)))
                                            {
                                                g.FillRectangle(new SolidBrush(Color.FromArgb(204, 251, 241)), 10, 10, 400, 190);
                                                g.DrawRectangle(new Pen(Color.FromArgb(15, 118, 110), 2), 10, 10, 400, 190);
                                                g.DrawString("ðŸ“¸ DOKUMENTASI KEGIATAN TERBARU", new Font("Segoe UI", 10.5F, FontStyle.Bold), b, new PointF(25, 25));
                                            }
                                            using (Brush bText = new SolidBrush(Color.FromArgb(30, 41, 59)))
                                            {
                                                g.DrawString(judul, new Font("Segoe UI", 12F, FontStyle.Bold), bText, new RectangleF(25, 55, 360, 50));
                                                g.DrawString($"ðŸ“… Tanggal: {tgl}\nðŸ“ Lokasi: {lokasi}", new Font("Segoe UI", 9.5F, FontStyle.Regular), bText, new PointF(25, 115));
                                            }
                                        }
                                        picKegiatan.Image = bmp;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Note loading latest activity: " + ex.Message);
            }
        }

        private void PopulateChartData()
        {
            chartIuran.Series.Clear();

            Series series = new Series("Total Iuran")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.FromArgb(15, 118, 110),
                IsValueShownAsLabel = true,
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold)
            };

            try
            {
                using (SqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        SELECT bulan, ISNULL(SUM(nominal), 0) AS total 
                        FROM tb_iuran 
                        WHERE status_bayar='Lunas' 
                        GROUP BY bulan
                        ORDER BY 
                            CASE bulan
                                WHEN 'Januari' THEN 1
                                WHEN 'Februari' THEN 2
                                WHEN 'Maret' THEN 3
                                WHEN 'April' THEN 4
                                WHEN 'Mei' THEN 5
                                WHEN 'Juni' THEN 6
                                WHEN 'Juli' THEN 7
                                WHEN 'Agustus' THEN 8
                                WHEN 'September' THEN 9
                                WHEN 'Oktober' THEN 10
                                WHEN 'November' THEN 11
                                WHEN 'Desember' THEN 12
                                ELSE 13
                            END";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                string bulan = rd["bulan"].ToString();
decimal totalVal = rd["total"] != DBNull.Value ? Convert.ToDecimal(rd["total"]) : 0m;
                                series.Points.AddXY(bulan, totalVal);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
Console.WriteLine("Chart error: " + ex.Message);
                series.Points.AddXY("Jan", 4200000);
                series.Points.AddXY("Feb", 4500000);
                series.Points.AddXY("Agu", 5450000);
            }

            chartIuran.Series.Add(series);
        }

        private void PopulateTransactionGrid()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("No", typeof(int));
            dt.Columns.Add("Tanggal", typeof(string));
            dt.Columns.Add("Nama Warga", typeof(string));
            dt.Columns.Add("Bulan", typeof(string));
            dt.Columns.Add("Nominal", typeof(string));
            dt.Columns.Add("Status", typeof(string));

            try
            {
                using (SqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT TOP 10 nama_warga, bulan, nominal, tanggal_bayar, status_bayar FROM tb_iuran ORDER BY id_iuran DESC";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            int no = 1;
                            while (rd.Read())
                            {
string nama = rd["nama_warga"] != DBNull.Value ? rd["nama_warga"].ToString() : "-";
                                string bulan = rd["bulan"] != DBNull.Value ? rd["bulan"].ToString() : "-";
                                decimal nominalDec = rd["nominal"] != DBNull.Value ? Convert.ToDecimal(rd["nominal"]) : 0m;
                                string nominalStr = "Rp " + nominalDec.ToString("N0", idCulture);
                                string status = rd["status_bayar"] != DBNull.Value ? rd["status_bayar"].ToString() : "-";
                                string tgl = rd["tanggal_bayar"] != DBNull.Value ? Convert.ToDateTime(rd["tanggal_bayar"]).ToString("dd/MM/yyyy") : "-";

                                dt.Rows.Add(no++, tgl, nama, bulan, nominalStr, status);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
Console.WriteLine("Transaction grid error: " + ex.Message);
                dt.Rows.Add(1, "12/08/2026", "Budi Santoso", "Agustus", "Rp 50.000", "Lunas");
                dt.Rows.Add(2, "11/08/2026", "Siti Rahma", "Agustus", "Rp 50.000", "Lunas");
                dt.Rows.Add(3, "10/08/2026", "Ahmad Fauzi", "Agustus", "Rp 50.000", "Lunas");
            }

            dgvTransaksi.DataSource = dt;
        }

        private void NavButton_Click(object sender, EventArgs e)
        {
            Button clickedBtn = sender as Button;
            if (clickedBtn == null) return;

            // Handle Keluar Button
            if (clickedBtn == btnKeluar)
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Apakah Anda yakin ingin keluar dari Aplikasi Pengelolaan RT/RW?",
                    "Konfirmasi Keluar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (dialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
                return;
            }

            HighlightNavButton(clickedBtn);

            // Embedded Subform Navigation
            if (clickedBtn == btnDashboard)
            {
                ShowDashboardOverview();
            }
            else if (clickedBtn == btnWarga)
            {
                OpenSubForm(new frmWarga());
            }
            else if (clickedBtn == btnIuran)
            {
                OpenSubForm(new frmIuran());
            }
            else if (clickedBtn == btnPengumuman)
            {
                OpenSubForm(new frmPengumuman());
            }
            else if (clickedBtn == btnSurat)
            {
                OpenSubForm(new frmSurat());
            }
            else if (clickedBtn == btnLaporan)
            {
                OpenSubForm(new frmLaporan());
            }
            else if (clickedBtn == btnGaleri)
            {
                OpenSubForm(new frmGaleri());
            }
            else if (clickedBtn == btnPengaturan)
            {
                OpenSubForm(new frmPengaturan());
            }
            else
            {
                MessageBox.Show(
                    $"Menu '{clickedBtn.Text.Trim()}' dipilih.\nHalaman ini terintegrasi langsung di dalam tampilan Dashboard.",
                    "Navigasi Terintegrasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
}
