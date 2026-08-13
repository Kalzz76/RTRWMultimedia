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

            // 3. ToolTip pada Profile Avatar
            ToolTip tt = new ToolTip();
            tt.SetToolTip(picLogoSekolah, "Klik untuk membuka Profil Pengguna: " + currentUsername + " (" + currentLevelUser + ")");

            // 4. Populate Statistical Cards dari Database SQL
            PopulateStatCardsFromDB();

            // 5. Populate Pengumuman dari Database SQL
            PopulateAnnouncements();

            // 6. Populate Chart Iuran
            PopulateChartData();

            // 7. Populate DataGridView Transaksi dari Database SQL
            PopulateTransactionGrid();

            // 8. Adjust Layout Responsiveness
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
            PopulateStatCardsFromDB();
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
                if (File.Exists(rtPath)) picLogo.Image = Image.FromFile(rtPath);

                string schPath = Path.Combine(baseDir, "logo_sekolah.png");
                if (File.Exists(schPath)) picLogoSekolah.Image = Image.FromFile(schPath);

                string kbPath = Path.Combine(baseDir, "kerjabakti.jpg");
                if (File.Exists(kbPath)) picKegiatan.Image = Image.FromFile(kbPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Note loading assets: " + ex.Message);
            }
        }

        private void PopulateStatCardsFromDB()
        {
            try
            {
                using (SqlConnection conn = Koneksi.GetConnection())
                {
                    conn.Open();

                    // Total Warga
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tb_warga", conn))
                    {
                        int totalWarga = Convert.ToInt32(cmd.ExecuteScalar());
                        lblTotalWarga.Text = totalWarga.ToString();
                    }

                    // Aktif Bayar (Distinct warga that paid)
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(DISTINCT nama_warga) FROM tb_iuran WHERE status_bayar='Lunas'", conn))
                    {
                        int aktifBayar = Convert.ToInt32(cmd.ExecuteScalar());
                        lblAktifBayarVal.Text = aktifBayar.ToString();
                    }

                    // Belum Bayar
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tb_warga WHERE status_warga != 'Aktif'", conn))
                    {
                        int belumBayar = Convert.ToInt32(cmd.ExecuteScalar());
                        if (belumBayar == 0)
                        {
                            int total = Convert.ToInt32(lblTotalWarga.Text);
                            int paid = Convert.ToInt32(lblAktifBayarVal.Text);
                            lblBelumBayarVal.Text = Math.Max(0, total - paid).ToString();
                        }
                        else
                        {
                            lblBelumBayarVal.Text = belumBayar.ToString();
                        }
                    }

                    // Total Kas
                    using (SqlCommand cmd = new SqlCommand("SELECT ISNULL(SUM(CAST(nominal AS BIGINT)), 0) FROM tb_iuran WHERE status_bayar='Lunas'", conn))
                    {
                        long totalKas = Convert.ToInt64(cmd.ExecuteScalar());
                        lblTotalKas.Text = "Rp " + totalKas.ToString("N0", idCulture);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Note loading stats: " + ex.Message);
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
                    string sql = "SELECT TOP 5 judul, isi_pengumuman, tanggal_posting FROM tb_pengumuman ORDER BY id_pengumuman DESC";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            bool hasData = false;
                            while (rd.Read())
                            {
                                hasData = true;
                                string judul = rd["judul"].ToString();
                                string isi = rd["isi_pengumuman"].ToString();

                                rtbPengumuman.SelectionFont = new Font("Segoe UI", 10.5F, FontStyle.Bold);
                                rtbPengumuman.SelectionColor = Color.FromArgb(15, 118, 110);
                                rtbPengumuman.AppendText("📢  " + judul.ToUpper() + "\n");

                                rtbPengumuman.SelectionFont = new Font("Segoe UI", 9.5F, FontStyle.Regular);
                                rtbPengumuman.SelectionColor = Color.FromArgb(51, 65, 85);
                                rtbPengumuman.AppendText(isi + "\n\n");
                            }

                            if (!hasData)
                            {
                                AddDefaultAnnouncements();
                            }
                        }
                    }
                }
            }
            catch
            {
                AddDefaultAnnouncements();
            }
        }

        private void AddDefaultAnnouncements()
        {
            rtbPengumuman.SelectionFont = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            rtbPengumuman.SelectionColor = Color.FromArgb(15, 118, 110);
            rtbPengumuman.AppendText("📌  KERJA BAKTI LINGKUNGAN RT 04\n");
            rtbPengumuman.SelectionFont = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            rtbPengumuman.SelectionColor = Color.FromArgb(51, 65, 85);
            rtbPengumuman.AppendText("Pelaksanaan: Minggu, 16 Agustus 2026 (07.00 WIB)\nKegiatan: Pembersihan saluran air dan persiapan dekorasi HUT RI.\n\n");

            rtbPengumuman.SelectionFont = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            rtbPengumuman.SelectionColor = Color.FromArgb(37, 99, 235);
            rtbPengumuman.AppendText("📢  RAPAT BULANAN WARGA\n");
            rtbPengumuman.SelectionFont = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            rtbPengumuman.SelectionColor = Color.FromArgb(51, 65, 85);
            rtbPengumuman.AppendText("Hari/Tgl: Sabtu, 22 Agustus 2026 di Balai Warga RT 04.\nAgenda: Pembahasan Kas & Pembangunan Taman Warga.\n\n");
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
                    string sql = "SELECT bulan, SUM(nominal) as total FROM tb_iuran GROUP BY bulan";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            bool hasData = false;
                            while (rd.Read())
                            {
                                hasData = true;
                                string bulan = rd["bulan"].ToString();
                                int total = Convert.ToInt32(rd["total"]);
                                series.Points.AddXY(bulan, total);
                            }

                            if (!hasData)
                            {
                                series.Points.AddXY("Jan", 4200000);
                                series.Points.AddXY("Feb", 4500000);
                                series.Points.AddXY("Agu", 5450000);
                            }
                        }
                    }
                }
            }
            catch
            {
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
                                string nama = rd["nama_warga"].ToString();
                                string bulan = rd["bulan"].ToString();
                                int nominalInt = Convert.ToInt32(rd["nominal"]);
                                string nominalStr = "Rp " + nominalInt.ToString("N0", idCulture);
                                string status = rd["status_bayar"].ToString();
                                string tgl = rd["tanggal_bayar"] != DBNull.Value ? Convert.ToDateTime(rd["tanggal_bayar"]).ToString("dd/MM/yyyy") : "-";

                                dt.Rows.Add(no++, tgl, nama, bulan, nominalStr, status);
                            }
                        }
                    }
                }
            }
            catch
            {
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
