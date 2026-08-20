namespace RTRWMultimedia
{
    partial class frmGaleri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTopHeader = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblHeaderSub = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlTableCard = new System.Windows.Forms.Panel();
            this.dgvGaleri = new System.Windows.Forms.DataGridView();
            this.pnlSearchHeader = new System.Windows.Forms.Panel();
            this.lblTableTitle = new System.Windows.Forms.Label();
            this.lblTotalGaleri = new System.Windows.Forms.Label();
            this.lblFilterKategori = new System.Windows.Forms.Label();
            this.cboFilterKategori = new System.Windows.Forms.ComboBox();
            this.lblCari = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.pnlInputCard = new System.Windows.Forms.Panel();
            this.lblCardInputTitle = new System.Windows.Forms.Label();
            this.lblJudul = new System.Windows.Forms.Label();
            this.txtJudul = new System.Windows.Forms.TextBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.cboKategori = new System.Windows.Forms.ComboBox();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.lblLokasi = new System.Windows.Forms.Label();
            this.txtLokasi = new System.Windows.Forms.TextBox();
            this.lblDeskripsi = new System.Windows.Forms.Label();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.txtFotoPath = new System.Windows.Forms.TextBox();
            this.btnBrowseFoto = new System.Windows.Forms.Button();
            this.lblPreview = new System.Windows.Forms.Label();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.flpActions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.pnlTopHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlTableCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGaleri)).BeginInit();
            this.pnlSearchHeader.SuspendLayout();
            this.pnlInputCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.flpActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopHeader
            // 
            this.pnlTopHeader.BackColor = System.Drawing.Color.White;
            this.pnlTopHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlTopHeader.Controls.Add(this.lblHeaderSub);
            this.pnlTopHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlTopHeader.Name = "pnlTopHeader";
            this.pnlTopHeader.Size = new System.Drawing.Size(960, 60);
            this.pnlTopHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.lblHeaderTitle.Location = new System.Drawing.Point(20, 10);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(435, 25);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "🖼️ GALERI & DOKUMENTASI KEGIATAN RT / RW";
            // 
            // lblHeaderSub
            // 
            this.lblHeaderSub.AutoSize = true;
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblHeaderSub.Location = new System.Drawing.Point(23, 35);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Size = new System.Drawing.Size(535, 15);
            this.lblHeaderSub.TabIndex = 1;
            this.lblHeaderSub.Text = "Modul Dokumentasi & Pengarsipan Kegiatan Warga (Gotong Royong, Rapat, Posyandu, O" +
    "lahraga, dll.)";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlMain.Controls.Add(this.pnlTableCard);
            this.pnlMain.Controls.Add(this.pnlInputCard);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 60);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(16);
            this.pnlMain.Size = new System.Drawing.Size(960, 590);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlTableCard
            // 
            this.pnlTableCard.BackColor = System.Drawing.Color.White;
            this.pnlTableCard.Controls.Add(this.dgvGaleri);
            this.pnlTableCard.Controls.Add(this.pnlSearchHeader);
            this.pnlTableCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTableCard.Location = new System.Drawing.Point(16, 215);
            this.pnlTableCard.Margin = new System.Windows.Forms.Padding(0, 16, 0, 0);
            this.pnlTableCard.Name = "pnlTableCard";
            this.pnlTableCard.Padding = new System.Windows.Forms.Padding(12);
            this.pnlTableCard.Size = new System.Drawing.Size(928, 359);
            this.pnlTableCard.TabIndex = 1;
            // 
            // dgvGaleri
            // 
            this.dgvGaleri.AllowUserToAddRows = false;
            this.dgvGaleri.AllowUserToDeleteRows = false;
            this.dgvGaleri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGaleri.BackgroundColor = System.Drawing.Color.White;
            this.dgvGaleri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGaleri.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGaleri.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGaleri.ColumnHeadersHeight = 36;
            this.dgvGaleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGaleri.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvGaleri.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGaleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGaleri.EnableHeadersVisualStyles = false;
            this.dgvGaleri.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvGaleri.Location = new System.Drawing.Point(12, 52);
            this.dgvGaleri.MultiSelect = false;
            this.dgvGaleri.Name = "dgvGaleri";
            this.dgvGaleri.ReadOnly = true;
            this.dgvGaleri.RowHeadersVisible = false;
            this.dgvGaleri.RowTemplate.Height = 32;
            this.dgvGaleri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGaleri.Size = new System.Drawing.Size(904, 295);
            this.dgvGaleri.TabIndex = 1;
            this.dgvGaleri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGaleri_CellClick);
            // 
            // pnlSearchHeader
            // 
            this.pnlSearchHeader.Controls.Add(this.lblTableTitle);
            this.pnlSearchHeader.Controls.Add(this.lblTotalGaleri);
            this.pnlSearchHeader.Controls.Add(this.lblFilterKategori);
            this.pnlSearchHeader.Controls.Add(this.cboFilterKategori);
            this.pnlSearchHeader.Controls.Add(this.lblCari);
            this.pnlSearchHeader.Controls.Add(this.txtCari);
            this.pnlSearchHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchHeader.Location = new System.Drawing.Point(12, 12);
            this.pnlSearchHeader.Name = "pnlSearchHeader";
            this.pnlSearchHeader.Size = new System.Drawing.Size(904, 40);
            this.pnlSearchHeader.TabIndex = 0;
            // 
            // lblTableTitle
            // 
            this.lblTableTitle.AutoSize = true;
            this.lblTableTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTableTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.lblTableTitle.Location = new System.Drawing.Point(0, 10);
            this.lblTableTitle.Name = "lblTableTitle";
            this.lblTableTitle.Size = new System.Drawing.Size(165, 19);
            this.lblTableTitle.TabIndex = 0;
            this.lblTableTitle.Text = "📸 Data Galeri Kegiatan";
            // 
            // lblTotalGaleri
            // 
            this.lblTotalGaleri.AutoSize = true;
            this.lblTotalGaleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.lblTotalGaleri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalGaleri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalGaleri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.lblTotalGaleri.Location = new System.Drawing.Point(185, 7);
            this.lblTotalGaleri.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblTotalGaleri.Name = "lblTotalGaleri";
            this.lblTotalGaleri.Size = new System.Drawing.Size(130, 25);
            this.lblTotalGaleri.TabIndex = 1;
            this.lblTotalGaleri.Text = "🖼️ Total: 0 Kegiatan";
            // 
            // lblFilterKategori
            // 
            this.lblFilterKategori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilterKategori.AutoSize = true;
            this.lblFilterKategori.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFilterKategori.Location = new System.Drawing.Point(490, 12);
            this.lblFilterKategori.Name = "lblFilterKategori";
            this.lblFilterKategori.Size = new System.Drawing.Size(58, 15);
            this.lblFilterKategori.TabIndex = 2;
            this.lblFilterKategori.Text = "Kategori:";
            // 
            // cboFilterKategori
            // 
            this.cboFilterKategori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFilterKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterKategori.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboFilterKategori.FormattingEnabled = true;
            this.cboFilterKategori.Items.AddRange(new object[] {
            "Semua Kategori",
            "Kerja Bakti",
            "Rapat Warga",
            "Perayaan HUT RI",
            "Posyandu & Kesehatan",
            "Olahraga & Seni",
            "Sosial & Keagamaan"});
            this.cboFilterKategori.Location = new System.Drawing.Point(552, 8);
            this.cboFilterKategori.Name = "cboFilterKategori";
            this.cboFilterKategori.Size = new System.Drawing.Size(135, 24);
            this.cboFilterKategori.TabIndex = 3;
            this.cboFilterKategori.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // lblCari
            // 
            this.lblCari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCari.AutoSize = true;
            this.lblCari.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCari.Location = new System.Drawing.Point(698, 12);
            this.lblCari.Name = "lblCari";
            this.lblCari.Size = new System.Drawing.Size(39, 15);
            this.lblCari.TabIndex = 4;
            this.lblCari.Text = "🔍 Cari:";
            // 
            // txtCari
            // 
            this.txtCari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCari.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCari.Location = new System.Drawing.Point(740, 8);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(162, 24);
            this.txtCari.TabIndex = 5;
            this.txtCari.TextChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // pnlInputCard
            // 
            this.pnlInputCard.BackColor = System.Drawing.Color.White;
            this.pnlInputCard.Controls.Add(this.lblCardInputTitle);
            this.pnlInputCard.Controls.Add(this.lblJudul);
            this.pnlInputCard.Controls.Add(this.txtJudul);
            this.pnlInputCard.Controls.Add(this.lblKategori);
            this.pnlInputCard.Controls.Add(this.cboKategori);
            this.pnlInputCard.Controls.Add(this.lblTanggal);
            this.pnlInputCard.Controls.Add(this.dtpTanggal);
            this.pnlInputCard.Controls.Add(this.lblLokasi);
            this.pnlInputCard.Controls.Add(this.txtLokasi);
            this.pnlInputCard.Controls.Add(this.lblDeskripsi);
            this.pnlInputCard.Controls.Add(this.txtDeskripsi);
            this.pnlInputCard.Controls.Add(this.lblFoto);
            this.pnlInputCard.Controls.Add(this.txtFotoPath);
            this.pnlInputCard.Controls.Add(this.btnBrowseFoto);
            this.pnlInputCard.Controls.Add(this.lblPreview);
            this.pnlInputCard.Controls.Add(this.picPreview);
            this.pnlInputCard.Controls.Add(this.flpActions);
            this.pnlInputCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInputCard.Location = new System.Drawing.Point(16, 16);
            this.pnlInputCard.Name = "pnlInputCard";
            this.pnlInputCard.Size = new System.Drawing.Size(928, 185);
            this.pnlInputCard.TabIndex = 0;
            // 
            // lblCardInputTitle
            // 
            this.lblCardInputTitle.AutoSize = true;
            this.lblCardInputTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCardInputTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.lblCardInputTitle.Location = new System.Drawing.Point(15, 8);
            this.lblCardInputTitle.Name = "lblCardInputTitle";
            this.lblCardInputTitle.Size = new System.Drawing.Size(262, 19);
            this.lblCardInputTitle.TabIndex = 0;
            this.lblCardInputTitle.Text = "✏️ Form Tambah / Edit Dokumentasi";
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblJudul.Location = new System.Drawing.Point(15, 32);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(89, 15);
            this.lblJudul.TabIndex = 1;
            this.lblJudul.Text = "Nama Kegiatan";
            // 
            // txtJudul
            // 
            this.txtJudul.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtJudul.Location = new System.Drawing.Point(18, 50);
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.Size = new System.Drawing.Size(320, 24);
            this.txtJudul.TabIndex = 2;
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblKategori.Location = new System.Drawing.Point(348, 32);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(54, 15);
            this.lblKategori.TabIndex = 3;
            this.lblKategori.Text = "Kategori";
            // 
            // cboKategori
            // 
            this.cboKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKategori.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboKategori.FormattingEnabled = true;
            this.cboKategori.Items.AddRange(new object[] {
            "Kerja Bakti",
            "Rapat Warga",
            "Perayaan HUT RI",
            "Posyandu & Kesehatan",
            "Olahraga & Seni",
            "Sosial & Keagamaan"});
            this.cboKategori.Location = new System.Drawing.Point(351, 50);
            this.cboKategori.Name = "cboKategori";
            this.cboKategori.Size = new System.Drawing.Size(175, 24);
            this.cboKategori.TabIndex = 4;
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblTanggal.Location = new System.Drawing.Point(537, 32);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(102, 15);
            this.lblTanggal.TabIndex = 5;
            this.lblTanggal.Text = "Tanggal Kegiatan";
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.CustomFormat = "dd/MM/yyyy";
            this.dtpTanggal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggal.Location = new System.Drawing.Point(540, 50);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(155, 24);
            this.dtpTanggal.TabIndex = 6;
            // 
            // lblLokasi
            // 
            this.lblLokasi.AutoSize = true;
            this.lblLokasi.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblLokasi.Location = new System.Drawing.Point(707, 32);
            this.lblLokasi.Name = "lblLokasi";
            this.lblLokasi.Size = new System.Drawing.Size(91, 15);
            this.lblLokasi.TabIndex = 7;
            this.lblLokasi.Text = "Lokasi Kegiatan";
            // 
            // txtLokasi
            // 
            this.txtLokasi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtLokasi.Location = new System.Drawing.Point(710, 50);
            this.txtLokasi.Name = "txtLokasi";
            this.txtLokasi.Size = new System.Drawing.Size(198, 24);
            this.txtLokasi.TabIndex = 8;
            // 
            // lblDeskripsi
            // 
            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblDeskripsi.Location = new System.Drawing.Point(15, 82);
            this.lblDeskripsi.Name = "lblDeskripsi";
            this.lblDeskripsi.Size = new System.Drawing.Size(153, 15);
            this.lblDeskripsi.TabIndex = 9;
            this.lblDeskripsi.Text = "Deskripsi / Catatan Acara";
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDeskripsi.Location = new System.Drawing.Point(18, 100);
            this.txtDeskripsi.Multiline = true;
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDeskripsi.Size = new System.Drawing.Size(315, 68);
            this.txtDeskripsi.TabIndex = 10;
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblFoto.Location = new System.Drawing.Point(348, 82);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(130, 15);
            this.lblFoto.TabIndex = 11;
            this.lblFoto.Text = "Lampiran Foto / Berkas";
            // 
            // txtFotoPath
            // 
            this.txtFotoPath.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtFotoPath.Location = new System.Drawing.Point(351, 100);
            this.txtFotoPath.Name = "txtFotoPath";
            this.txtFotoPath.Size = new System.Drawing.Size(175, 24);
            this.txtFotoPath.TabIndex = 12;
            this.txtFotoPath.TextChanged += new System.EventHandler(this.txtFotoPath_TextChanged);
            // 
            // btnBrowseFoto
            // 
            this.btnBrowseFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnBrowseFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseFoto.FlatAppearance.BorderSize = 0;
            this.btnBrowseFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseFoto.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnBrowseFoto.ForeColor = System.Drawing.Color.White;
            this.btnBrowseFoto.Location = new System.Drawing.Point(532, 99);
            this.btnBrowseFoto.Name = "btnBrowseFoto";
            this.btnBrowseFoto.Size = new System.Drawing.Size(94, 26);
            this.btnBrowseFoto.TabIndex = 13;
            this.btnBrowseFoto.Text = "📁 Pilih Foto";
            this.btnBrowseFoto.UseVisualStyleBackColor = false;
            this.btnBrowseFoto.Click += new System.EventHandler(this.btnBrowseFoto_Click);
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblPreview.Location = new System.Drawing.Point(642, 82);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(93, 15);
            this.lblPreview.TabIndex = 15;
            this.lblPreview.Text = "🖼️ Preview Foto";
            // 
            // picPreview
            // 
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPreview.Location = new System.Drawing.Point(645, 100);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(263, 68);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 16;
            this.picPreview.TabStop = false;
            this.picPreview.Click += new System.EventHandler(this.picPreview_Click);
            // 
            // flpActions
            // 
            this.flpActions.Controls.Add(this.btnSimpan);
            this.flpActions.Controls.Add(this.btnEdit);
            this.flpActions.Controls.Add(this.btnHapus);
            this.flpActions.Controls.Add(this.btnBatal);
            this.flpActions.Location = new System.Drawing.Point(351, 132);
            this.flpActions.Name = "flpActions";
            this.flpActions.Size = new System.Drawing.Size(285, 36);
            this.flpActions.TabIndex = 14;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(0, 0);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(94, 38);
            this.btnSimpan.TabIndex = 0;
            this.btnSimpan.Text = "💾 SIMPAN";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(102, 0);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 38);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "✏️ EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(204, 0);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(94, 38);
            this.btnHapus.TabIndex = 2;
            this.btnHapus.Text = "🗑️ HAPUS";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatal.FlatAppearance.BorderSize = 0;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnBatal.ForeColor = System.Drawing.Color.White;
            this.btnBatal.Location = new System.Drawing.Point(306, 0);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(0);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(94, 38);
            this.btnBatal.TabIndex = 3;
            this.btnBatal.Text = "🔄 BATAL";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // frmGaleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(960, 650);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTopHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGaleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Galeri Kegiatan Warga";
            this.Load += new System.EventHandler(this.frmGaleri_Load);
            this.pnlTopHeader.ResumeLayout(false);
            this.pnlTopHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlTableCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGaleri)).EndInit();
            this.pnlSearchHeader.ResumeLayout(false);
            this.pnlSearchHeader.PerformLayout();
            this.pnlInputCard.ResumeLayout(false);
            this.pnlInputCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.flpActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSub;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlTableCard;
        private System.Windows.Forms.DataGridView dgvGaleri;
        private System.Windows.Forms.Panel pnlSearchHeader;
        private System.Windows.Forms.Label lblTableTitle;
        private System.Windows.Forms.Label lblTotalGaleri;
        private System.Windows.Forms.Label lblFilterKategori;
        private System.Windows.Forms.ComboBox cboFilterKategori;
        private System.Windows.Forms.Label lblCari;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Panel pnlInputCard;
        private System.Windows.Forms.Label lblCardInputTitle;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.TextBox txtJudul;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.ComboBox cboKategori;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.Label lblLokasi;
        private System.Windows.Forms.TextBox txtLokasi;
        private System.Windows.Forms.Label lblDeskripsi;
        private System.Windows.Forms.TextBox txtDeskripsi;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.TextBox txtFotoPath;
        private System.Windows.Forms.Button btnBrowseFoto;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.FlowLayoutPanel flpActions;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBatal;
    }
}
