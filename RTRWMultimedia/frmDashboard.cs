using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data;
using System.Data.SqlClient;

namespace RTRWMultimedia
{
    public partial class frmDashboard : Form
    {
        private CultureInfo idCulture = new CultureInfo("id-ID");

        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            // 1. Inisialisasi Jam & Tanggal awal
            UpdateClockAndDate();

            // 2. Load Assets Gambar
            LoadImageAssets();

            // 3. Populate Pengumuman
            PopulateAnnouncements();

            // 4. Populate Chart Iuran
            PopulateChartData();

            // 5. Populate DataGridView Transaksi
            PopulateTransactionGrid();
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

            }
            catch (Exception ex)
            {
                // Soft fallback logging
                Console.WriteLine("Note loading assets: " + ex.Message);
            }
        }

        private void PopulateAnnouncements()
        {
            //rtbPengumuman.Clear();
            
            //rtbPengumuman.SelectionFont = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            //rtbPengumuman.SelectionColor = Color.FromArgb(15, 118, 110);
            //rtbPengumuman.AppendText("📌  KERJA BAKTI LINGKUNGAN RT 04\n");
            //rtbPengumuman.SelectionFont = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            //rtbPengumuman.SelectionColor = Color.FromArgb(51, 65, 85);
            //rtbPengumuman.AppendText("Pelaksanaan: Minggu, 16 Agustus 2026 (07.00 WIB)\nKegiatan: Pembersihan saluran air dan persiapan dekorasi HUT RI.\n\n");

            //rtbPengumuman.SelectionFont = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            //rtbPengumuman.SelectionColor = Color.FromArgb(37, 99, 235);
            //rtbPengumuman.AppendText("📢  RAPAT BULANAN WARGA\n");
            //rtbPengumuman.SelectionFont = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            //rtbPengumuman.SelectionColor = Color.FromArgb(51, 65, 85);
            //rtbPengumuman.AppendText("Hari/Tgl: Sabtu, 22 Agustus 2026 di Balai Warga RT 04.\nAgenda: Pembahasan Kas & Pembangunan Taman Warga.\n\n");

            //rtbPengumuman.SelectionFont = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            //rtbPengumuman.SelectionColor = Color.FromArgb(217, 119, 6);
            //rtbPengumuman.AppendText("👶  POSYANDU BALITA & LANSIA\n");
            //rtbPengumuman.SelectionFont = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            //rtbPengumuman.SelectionColor = Color.FromArgb(51, 65, 85);
            //rtbPengumuman.AppendText("Rabu, 26 Agustus 2026 di Pos Ronda Utama RT 04.");
        }

        private void PopulateChartData()
        {
            chartIuran.Series.Clear();

            //Series series = new Series("Total Iuran")
            //{
            //    ChartType = SeriesChartType.Column,
            //    Color = Color.FromArgb(15, 118, 110),
            //    IsValueShownAsLabel = true,
            //    Font = new Font("Segoe UI", 8.5F, FontStyle.Bold)
            //};

            //series.Points.AddXY("Jan", 4200000);
            //series.Points.AddXY("Feb", 4500000);
            //series.Points.AddXY("Mar", 4800000);
            //series.Points.AddXY("Apr", 5100000);
            //series.Points.AddXY("Mei", 4900000);
            //series.Points.AddXY("Jun", 5300000);
            //series.Points.AddXY("Jul", 5200000);
            //series.Points.AddXY("Agu", 5450000);

            //chartIuran.Series.Add(series);
        }

        private void PopulateTransactionGrid()
        {
            //DataTable dt = new DataTable();
            //dt.Columns.Add("No", typeof(int));
            //dt.Columns.Add("Tanggal", typeof(string));
            //dt.Columns.Add("Nama Warga", typeof(string));
            //dt.Columns.Add("Bulan", typeof(string));
            //dt.Columns.Add("Nominal", typeof(string));
            //dt.Columns.Add("Status", typeof(string));

            //dt.Rows.Add(1, "12/08/2026", "Budi Santoso", "Agustus", "Rp 50.000", "Lunas");
            //dt.Rows.Add(2, "11/08/2026", "Siti Rahma", "Agustus", "Rp 50.000", "Lunas");
            //dt.Rows.Add(3, "10/08/2026", "Ahmad Fauzi", "Agustus", "Rp 50.000", "Lunas");
            //dt.Rows.Add(4, "09/08/2026", "Dede Kurniawan", "Agustus", "Rp 50.000", "Lunas");
            //dt.Rows.Add(5, "08/08/2026", "Eka Wijaya", "Agustus", "Rp 50.000", "Lunas");
            //dt.Rows.Add(6, "07/08/2026", "Hendra Pratama", "Juli", "Rp 50.000", "Lunas");

            //dgvTransaksi.DataSource = dt;
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

            // Highlight Active Button
            foreach (Control ctrl in flpNavMenu.Controls)
            {
                if (ctrl is Button btn && btn != btnKeluar)
                {
                    btn.BackColor = Color.Transparent;
                    btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                }
            }

            clickedBtn.BackColor = Color.FromArgb(15, 118, 110);
            clickedBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // Optional Toast Feedback for menu navigation
            if (clickedBtn != btnDashboard)
            {
                MessageBox.Show(
                    $"Menu '{clickedBtn.Text.Trim()}' berhasil dipilih.\nHalaman ini siap untuk pengembangan modul selanjutnya.",
                    "Navigasi Menu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        private void picKegiatan_Click(object sender, EventArgs e)
        {

        }

        private void lblSubJudul_Click(object sender, EventArgs e)
        {

        }
    }
}
