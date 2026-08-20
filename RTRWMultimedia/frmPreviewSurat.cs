using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Windows.Forms;

namespace RTRWMultimedia
{
    public partial class frmPreviewSurat : Form
    {
        private CultureInfo cultureIndo = new CultureInfo("id-ID");
        private PrintDocument printDoc = new PrintDocument();

        public frmPreviewSurat()
        {
            InitializeComponent();
            pnlGarisKop.Paint += PnlGarisKop_Paint;
            printDoc.PrintPage += PrintDoc_PrintPage;
        }

        public void SetSuratData(
            string noSurat,
            string namaWarga,
            string nik,
            string alamat,
            string keperluan,
            string keterangan,
            DateTime tanggalSurat,
            string namaRT,
            string desa,
            string kecamatan,
            string kota,
            string ketuaRT)
        {
            if (string.IsNullOrWhiteSpace(namaRT)) namaRT = "RT 04 / RW 02";
            if (string.IsNullOrWhiteSpace(desa)) desa = "Desa Sukamaju";
            if (string.IsNullOrWhiteSpace(kecamatan)) kecamatan = "Kecamatan Ciawi";
            if (string.IsNullOrWhiteSpace(kota)) kota = "Kabupaten Bogor";
            if (string.IsNullOrWhiteSpace(ketuaRT)) ketuaRT = "Bapak Sutrisno";

            // Kop Surat
            lblKopRT.Text = $"PENGURUS {namaRT.ToUpper()}";
            lblKopDesa.Text = $"{desa.ToUpper()} - {kecamatan.ToUpper()}";
            lblKopKota.Text = $"{kota.ToUpper()} - PROVINSI JAWA BARAT";

            // Nomor Surat
            lblNomorSurat.Text = $"Nomor: {noSurat.Trim()}";

            // Pembuka
            lblPembuka.Text = $"Yang bertanda tangan di bawah ini Ketua {namaRT} {desa}, {kecamatan}, {kota}, dengan ini menerangkan bahwa:";

            // Data Pemohon
            lblValNama.Text = $":  {namaWarga.Trim()}";
            lblValNik.Text = $":  {nik.Trim()}";
            lblValAlamat.Text = string.IsNullOrWhiteSpace(alamat) ? $":  {namaRT}, {desa}" : $":  {alamat.Trim()}";
            lblValKeperluan.Text = $":  {keperluan.Trim()}";
            lblValKeterangan.Text = string.IsNullOrWhiteSpace(keterangan) ? ":  -" : $":  {keterangan.Trim()}";

            // Paragraf Keterangan
            lblIsi1.Text = $"Orang tersebut di atas adalah benar-benar warga yang bertempat tinggal di lingkungan kami dan tercatat sebagai warga {namaRT} {desa} serta berkelakuan baik.";
            lblIsi2.Text = "Demikian Surat Pengantar ini dibuat dengan sebenarnya dan penuh tanggung jawab agar dapat dipergunakan sebagaimana mestinya.";

            // Tanda Tangan
            string tglStr = tanggalSurat.ToString("dd MMMM yyyy", cultureIndo);
            lblTempatTgl.Text = $"{desa}, {tglStr}";
            lblJabatanTtd.Text = $"Ketua {namaRT},";
            lblNamaTtd.Text = $"( {ketuaRT} )";
        }

        private void PnlGarisKop_Paint(object sender, PaintEventArgs e)
        {
            using (Pen penThick = new Pen(Color.Black, 2.5f))
            using (Pen penThin = new Pen(Color.Black, 1.0f))
            {
                e.Graphics.DrawLine(penThick, 0, 0, pnlGarisKop.Width, 0);
                e.Graphics.DrawLine(penThin, 0, 4, pnlGarisKop.Width, 4);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDoc;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDoc.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal melakukan pencetakan:\n" + ex.Message, "Error Cetak", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Capture visual bitmap of paper panel and print with high DPI quality
            Bitmap bmp = new Bitmap(pnlPaper.Width, pnlPaper.Height);
            pnlPaper.DrawToBitmap(bmp, new Rectangle(0, 0, pnlPaper.Width, pnlPaper.Height));

            // Scale to fit printable area while preserving aspect ratio
            Rectangle marginBounds = e.MarginBounds;
            float ratio = Math.Min((float)marginBounds.Width / bmp.Width, (float)marginBounds.Height / bmp.Height);
            int newWidth = (int)(bmp.Width * ratio);
            int newHeight = (int)(bmp.Height * ratio);
            int posX = marginBounds.Left + (marginBounds.Width - newWidth) / 2;
            int posY = marginBounds.Top;

            e.Graphics.DrawImage(bmp, posX, posY, newWidth, newHeight);
            e.HasMorePages = false;
        }
    }
}
