namespace RTRWMultimedia
{
    partial class frmPreviewSurat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.lblTitlePreview = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlViewer = new System.Windows.Forms.Panel();
            this.pnlPaper = new System.Windows.Forms.Panel();
            this.lblNamaTtd = new System.Windows.Forms.Label();
            this.lblJabatanTtd = new System.Windows.Forms.Label();
            this.lblTempatTgl = new System.Windows.Forms.Label();
            this.lblIsi2 = new System.Windows.Forms.Label();
            this.lblIsi1 = new System.Windows.Forms.Label();
            this.lblValKeterangan = new System.Windows.Forms.Label();
            this.lblFieldKeterangan = new System.Windows.Forms.Label();
            this.lblValKeperluan = new System.Windows.Forms.Label();
            this.lblFieldKeperluan = new System.Windows.Forms.Label();
            this.lblValAlamat = new System.Windows.Forms.Label();
            this.lblFieldAlamat = new System.Windows.Forms.Label();
            this.lblValNik = new System.Windows.Forms.Label();
            this.lblFieldNik = new System.Windows.Forms.Label();
            this.lblValNama = new System.Windows.Forms.Label();
            this.lblFieldNama = new System.Windows.Forms.Label();
            this.lblPembuka = new System.Windows.Forms.Label();
            this.lblNomorSurat = new System.Windows.Forms.Label();
            this.lblJudulSurat = new System.Windows.Forms.Label();
            this.pnlGarisKop = new System.Windows.Forms.Panel();
            this.lblKopKota = new System.Windows.Forms.Label();
            this.lblKopDesa = new System.Windows.Forms.Label();
            this.lblKopRT = new System.Windows.Forms.Label();
            this.pnlToolbar.SuspendLayout();
            this.pnlViewer.SuspendLayout();
            this.pnlPaper.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlToolbar.Controls.Add(this.lblTitlePreview);
            this.pnlToolbar.Controls.Add(this.btnPrint);
            this.pnlToolbar.Controls.Add(this.btnClose);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(834, 52);
            this.pnlToolbar.TabIndex = 0;
            // 
            // lblTitlePreview
            // 
            this.lblTitlePreview.AutoSize = true;
            this.lblTitlePreview.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTitlePreview.ForeColor = System.Drawing.Color.White;
            this.lblTitlePreview.Location = new System.Drawing.Point(16, 16);
            this.lblTitlePreview.Name = "lblTitlePreview";
            this.lblTitlePreview.Size = new System.Drawing.Size(370, 19);
            this.lblTitlePreview.TabIndex = 0;
            this.lblTitlePreview.Text = "📄 PRATINJAU DOKUMEN CETAK SURAT PENGANTAR";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(544, 8);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(160, 36);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "🖨️ CETAK SURAT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(714, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 36);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "✖️ TUTUP";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlViewer
            // 
            this.pnlViewer.AutoScroll = true;
            this.pnlViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.pnlViewer.Controls.Add(this.pnlPaper);
            this.pnlViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlViewer.Location = new System.Drawing.Point(0, 52);
            this.pnlViewer.Name = "pnlViewer";
            this.pnlViewer.Padding = new System.Windows.Forms.Padding(0, 20, 0, 30);
            this.pnlViewer.Size = new System.Drawing.Size(834, 759);
            this.pnlViewer.TabIndex = 1;
            // 
            // pnlPaper
            // 
            this.pnlPaper.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlPaper.BackColor = System.Drawing.Color.White;
            this.pnlPaper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPaper.Controls.Add(this.lblNamaTtd);
            this.pnlPaper.Controls.Add(this.lblJabatanTtd);
            this.pnlPaper.Controls.Add(this.lblTempatTgl);
            this.pnlPaper.Controls.Add(this.lblIsi2);
            this.pnlPaper.Controls.Add(this.lblIsi1);
            this.pnlPaper.Controls.Add(this.lblValKeterangan);
            this.pnlPaper.Controls.Add(this.lblFieldKeterangan);
            this.pnlPaper.Controls.Add(this.lblValKeperluan);
            this.pnlPaper.Controls.Add(this.lblFieldKeperluan);
            this.pnlPaper.Controls.Add(this.lblValAlamat);
            this.pnlPaper.Controls.Add(this.lblFieldAlamat);
            this.pnlPaper.Controls.Add(this.lblValNik);
            this.pnlPaper.Controls.Add(this.lblFieldNik);
            this.pnlPaper.Controls.Add(this.lblValNama);
            this.pnlPaper.Controls.Add(this.lblFieldNama);
            this.pnlPaper.Controls.Add(this.lblPembuka);
            this.pnlPaper.Controls.Add(this.lblNomorSurat);
            this.pnlPaper.Controls.Add(this.lblJudulSurat);
            this.pnlPaper.Controls.Add(this.pnlGarisKop);
            this.pnlPaper.Controls.Add(this.lblKopKota);
            this.pnlPaper.Controls.Add(this.lblKopDesa);
            this.pnlPaper.Controls.Add(this.lblKopRT);
            this.pnlPaper.Location = new System.Drawing.Point(67, 15);
            this.pnlPaper.Name = "pnlPaper";
            this.pnlPaper.Padding = new System.Windows.Forms.Padding(40);
            this.pnlPaper.Size = new System.Drawing.Size(700, 780);
            this.pnlPaper.TabIndex = 0;
            // 
            // lblNamaTtd
            // 
            this.lblNamaTtd.Font = new System.Drawing.Font("Times New Roman", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblNamaTtd.Location = new System.Drawing.Point(390, 715);
            this.lblNamaTtd.Name = "lblNamaTtd";
            this.lblNamaTtd.Size = new System.Drawing.Size(265, 20);
            this.lblNamaTtd.TabIndex = 21;
            this.lblNamaTtd.Text = "( Bapak Sutrisno )";
            this.lblNamaTtd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJabatanTtd
            // 
            this.lblJabatanTtd.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.lblJabatanTtd.Location = new System.Drawing.Point(390, 625);
            this.lblJabatanTtd.Name = "lblJabatanTtd";
            this.lblJabatanTtd.Size = new System.Drawing.Size(265, 20);
            this.lblJabatanTtd.TabIndex = 20;
            this.lblJabatanTtd.Text = "Ketua RT 04 / RW 02,";
            this.lblJabatanTtd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempatTgl
            // 
            this.lblTempatTgl.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.lblTempatTgl.Location = new System.Drawing.Point(390, 603);
            this.lblTempatTgl.Name = "lblTempatTgl";
            this.lblTempatTgl.Size = new System.Drawing.Size(265, 20);
            this.lblTempatTgl.TabIndex = 19;
            this.lblTempatTgl.Text = "Sukamaju, 19 Agustus 2026";
            this.lblTempatTgl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIsi2
            // 
            this.lblIsi2.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.lblIsi2.Location = new System.Drawing.Point(40, 525);
            this.lblIsi2.Name = "lblIsi2";
            this.lblIsi2.Size = new System.Drawing.Size(620, 50);
            this.lblIsi2.TabIndex = 18;
            this.lblIsi2.Text = "Demikian Surat Pengantar ini dibuat dengan sebenarnya dan penuh tanggung jawab ag" +
    "ar dapat dipergunakan sebagaimana mestinya.";
            // 
            // lblIsi1
            // 
            this.lblIsi1.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.lblIsi1.Location = new System.Drawing.Point(40, 465);
            this.lblIsi1.Name = "lblIsi1";
            this.lblIsi1.Size = new System.Drawing.Size(620, 50);
            this.lblIsi1.TabIndex = 17;
            this.lblIsi1.Text = "Orang tersebut di atas adalah benar-benar warga yang bertempat tinggal di lingkun" +
    "gan kami dan tercatat sebagai warga RT 04 / RW 02 Desa Sukamaju serta berkelakua" +
    "n baik.";
            // 
            // lblValKeterangan
            // 
            this.lblValKeterangan.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.lblValKeterangan.Location = new System.Drawing.Point(235, 415);
            this.lblValKeterangan.Name = "lblValKeterangan";
            this.lblValKeterangan.Size = new System.Drawing.Size(425, 38);
            this.lblValKeterangan.TabIndex = 16;
            this.lblValKeterangan.Text = ": Dokumen administrasi lengkap";
            // 
            // lblFieldKeterangan
            // 
            this.lblFieldKeterangan.AutoSize = true;
            this.lblFieldKeterangan.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.lblFieldKeterangan.Location = new System.Drawing.Point(55, 415);
            this.lblFieldKeterangan.Name = "lblFieldKeterangan";
            this.lblFieldKeterangan.Size = new System.Drawing.Size(139, 17);
            this.lblFieldKeterangan.TabIndex = 15;
            this.lblFieldKeterangan.Text = "Keterangan Tambahan";
            // 
            // lblValKeperluan
            // 
            this.lblValKeperluan.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.lblValKeperluan.Location = new System.Drawing.Point(235, 382);
            this.lblValKeperluan.Name = "lblValKeperluan";
            this.lblValKeperluan.Size = new System.Drawing.Size(425, 20);
            this.lblValKeperluan.TabIndex = 14;
            this.lblValKeperluan.Text = ": Pengurusan SKCK Kelurahan";
            // 
            // lblFieldKeperluan
            // 
            this.lblFieldKeperluan.AutoSize = true;
            this.lblFieldKeperluan.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.lblFieldKeperluan.Location = new System.Drawing.Point(55, 382);
            this.lblFieldKeperluan.Name = "lblFieldKeperluan";
            this.lblFieldKeperluan.Size = new System.Drawing.Size(126, 17);
            this.lblFieldKeperluan.TabIndex = 13;
            this.lblFieldKeperluan.Text = "Keperluan Pengantar";
            // 
            // lblValAlamat
            // 
            this.lblValAlamat.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.lblValAlamat.Location = new System.Drawing.Point(235, 349);
            this.lblValAlamat.Name = "lblValAlamat";
            this.lblValAlamat.Size = new System.Drawing.Size(425, 20);
            this.lblValAlamat.TabIndex = 12;
            this.lblValAlamat.Text = ": RT 04 / RW 02, Desa Sukamaju";
            // 
            // lblFieldAlamat
            // 
            this.lblFieldAlamat.AutoSize = true;
            this.lblFieldAlamat.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.lblFieldAlamat.Location = new System.Drawing.Point(55, 349);
            this.lblFieldAlamat.Name = "lblFieldAlamat";
            this.lblFieldAlamat.Size = new System.Drawing.Size(149, 17);
            this.lblFieldAlamat.TabIndex = 11;
            this.lblFieldAlamat.Text = "Alamat / Tempat Tinggal";
            // 
            // lblValNik
            // 
            this.lblValNik.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.lblValNik.Location = new System.Drawing.Point(235, 316);
            this.lblValNik.Name = "lblValNik";
            this.lblValNik.Size = new System.Drawing.Size(425, 20);
            this.lblValNik.TabIndex = 10;
            this.lblValNik.Text = ": 3201010101010003";
            // 
            // lblFieldNik
            // 
            this.lblFieldNik.AutoSize = true;
            this.lblFieldNik.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.lblFieldNik.Location = new System.Drawing.Point(55, 316);
            this.lblFieldNik.Name = "lblFieldNik";
            this.lblFieldNik.Size = new System.Drawing.Size(35, 17);
            this.lblFieldNik.TabIndex = 9;
            this.lblFieldNik.Text = "NIK";
            // 
            // lblValNama
            // 
            this.lblValNama.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.lblValNama.Location = new System.Drawing.Point(235, 283);
            this.lblValNama.Name = "lblValNama";
            this.lblValNama.Size = new System.Drawing.Size(425, 20);
            this.lblValNama.TabIndex = 8;
            this.lblValNama.Text = ": Ahmad Fauzi";
            // 
            // lblFieldNama
            // 
            this.lblFieldNama.AutoSize = true;
            this.lblFieldNama.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.lblFieldNama.Location = new System.Drawing.Point(55, 283);
            this.lblFieldNama.Name = "lblFieldNama";
            this.lblFieldNama.Size = new System.Drawing.Size(100, 17);
            this.lblFieldNama.TabIndex = 7;
            this.lblFieldNama.Text = "Nama Lengkap";
            // 
            // lblPembuka
            // 
            this.lblPembuka.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.lblPembuka.Location = new System.Drawing.Point(40, 230);
            this.lblPembuka.Name = "lblPembuka";
            this.lblPembuka.Size = new System.Drawing.Size(620, 42);
            this.lblPembuka.TabIndex = 6;
            this.lblPembuka.Text = "Yang bertanda tangan di bawah ini Ketua RT 04 / RW 02 Desa Sukamaju, Kecamatan C" +
    "iawi, Kabupaten Bogor, dengan ini menerangkan bahwa:";
            // 
            // lblNomorSurat
            // 
            this.lblNomorSurat.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.lblNomorSurat.Location = new System.Drawing.Point(40, 185);
            this.lblNomorSurat.Name = "lblNomorSurat";
            this.lblNomorSurat.Size = new System.Drawing.Size(620, 22);
            this.lblNomorSurat.TabIndex = 5;
            this.lblNomorSurat.Text = "Nomor: 003/SP-RT04/VIII/2026";
            this.lblNomorSurat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJudulSurat
            // 
            this.lblJudulSurat.Font = new System.Drawing.Font("Times New Roman", 13.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblJudulSurat.Location = new System.Drawing.Point(40, 160);
            this.lblJudulSurat.Name = "lblJudulSurat";
            this.lblJudulSurat.Size = new System.Drawing.Size(620, 25);
            this.lblJudulSurat.TabIndex = 4;
            this.lblJudulSurat.Text = "SURAT PENGANTAR";
            this.lblJudulSurat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGarisKop
            // 
            this.pnlGarisKop.BackColor = System.Drawing.Color.Black;
            this.pnlGarisKop.Location = new System.Drawing.Point(40, 125);
            this.pnlGarisKop.Name = "pnlGarisKop";
            this.pnlGarisKop.Size = new System.Drawing.Size(620, 3);
            this.pnlGarisKop.TabIndex = 3;
            // 
            // lblKopKota
            // 
            this.lblKopKota.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblKopKota.Location = new System.Drawing.Point(40, 88);
            this.lblKopKota.Name = "lblKopKota";
            this.lblKopKota.Size = new System.Drawing.Size(620, 20);
            this.lblKopKota.TabIndex = 2;
            this.lblKopKota.Text = "KABUPATEN BOGOR - PROVINSI JAWA BARAT";
            this.lblKopKota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKopDesa
            // 
            this.lblKopDesa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblKopDesa.Location = new System.Drawing.Point(40, 64);
            this.lblKopDesa.Name = "lblKopDesa";
            this.lblKopDesa.Size = new System.Drawing.Size(620, 22);
            this.lblKopDesa.TabIndex = 1;
            this.lblKopDesa.Text = "DESA SUKAMAJU - KECAMATAN CIAWI";
            this.lblKopDesa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKopRT
            // 
            this.lblKopRT.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblKopRT.Location = new System.Drawing.Point(40, 38);
            this.lblKopRT.Name = "lblKopRT";
            this.lblKopRT.Size = new System.Drawing.Size(620, 25);
            this.lblKopRT.TabIndex = 0;
            this.lblKopRT.Text = "PENGURUS RUKUN TETANGGA 04 / RUKUN WARGA 02";
            this.lblKopRT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPreviewSurat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(834, 811);
            this.Controls.Add(this.pnlViewer);
            this.Controls.Add(this.pnlToolbar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPreviewSurat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pratinjau Dokumen Cetak Surat Pengantar Resmi";
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            this.pnlViewer.ResumeLayout(false);
            this.pnlPaper.ResumeLayout(false);
            this.pnlPaper.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Label lblTitlePreview;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlViewer;
        private System.Windows.Forms.Panel pnlPaper;
        private System.Windows.Forms.Label lblKopRT;
        private System.Windows.Forms.Label lblKopDesa;
        private System.Windows.Forms.Label lblKopKota;
        private System.Windows.Forms.Panel pnlGarisKop;
        private System.Windows.Forms.Label lblJudulSurat;
        private System.Windows.Forms.Label lblNomorSurat;
        private System.Windows.Forms.Label lblPembuka;
        private System.Windows.Forms.Label lblFieldNama;
        private System.Windows.Forms.Label lblValNama;
        private System.Windows.Forms.Label lblFieldNik;
        private System.Windows.Forms.Label lblValNik;
        private System.Windows.Forms.Label lblFieldAlamat;
        private System.Windows.Forms.Label lblValAlamat;
        private System.Windows.Forms.Label lblFieldKeperluan;
        private System.Windows.Forms.Label lblValKeperluan;
        private System.Windows.Forms.Label lblFieldKeterangan;
        private System.Windows.Forms.Label lblValKeterangan;
        private System.Windows.Forms.Label lblIsi1;
        private System.Windows.Forms.Label lblIsi2;
        private System.Windows.Forms.Label lblTempatTgl;
        private System.Windows.Forms.Label lblJabatanTtd;
        private System.Windows.Forms.Label lblNamaTtd;
    }
}
