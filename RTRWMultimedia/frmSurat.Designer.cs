namespace RTRWMultimedia
{
    partial class frmSurat
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
            this.dgvSurat = new System.Windows.Forms.DataGridView();
            this.pnlSearchHeader = new System.Windows.Forms.Panel();
            this.lblTableTitle = new System.Windows.Forms.Label();
            this.lblTotalSurat = new System.Windows.Forms.Label();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.cboFilterStatus = new System.Windows.Forms.ComboBox();
            this.lblCari = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.pnlInputCard = new System.Windows.Forms.Panel();
            this.lblCardInputTitle = new System.Windows.Forms.Label();
            this.lblNoSurat = new System.Windows.Forms.Label();
            this.txtNoSurat = new System.Windows.Forms.TextBox();
            this.lblNamaWarga = new System.Windows.Forms.Label();
            this.cboNamaWarga = new System.Windows.Forms.ComboBox();
            this.lblNik = new System.Windows.Forms.Label();
            this.txtNik = new System.Windows.Forms.TextBox();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.dtpTanggalSurat = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatusSurat = new System.Windows.Forms.ComboBox();
            this.lblKeperluan = new System.Windows.Forms.Label();
            this.cboKeperluan = new System.Windows.Forms.ComboBox();
            this.lblKeterangan = new System.Windows.Forms.Label();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.flpActions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnCetak = new System.Windows.Forms.Button();
            this.pnlTopHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlTableCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSurat)).BeginInit();
            this.pnlSearchHeader.SuspendLayout();
            this.pnlInputCard.SuspendLayout();
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
            this.lblHeaderTitle.Size = new System.Drawing.Size(340, 25);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "📄 SURAT PENGANTAR RT / RW";
            // 
            // lblHeaderSub
            // 
            this.lblHeaderSub.AutoSize = true;
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblHeaderSub.Location = new System.Drawing.Point(23, 35);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Size = new System.Drawing.Size(490, 15);
            this.lblHeaderSub.TabIndex = 1;
            this.lblHeaderSub.Text = "Modul Pembuatan & Rekap Surat Pengantar Administrasi Warga (KTP, KK, SKCK, SKTM, d" +
    "ll.)";
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
            this.pnlTableCard.Controls.Add(this.dgvSurat);
            this.pnlTableCard.Controls.Add(this.pnlSearchHeader);
            this.pnlTableCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTableCard.Location = new System.Drawing.Point(16, 235);
            this.pnlTableCard.Margin = new System.Windows.Forms.Padding(0, 16, 0, 0);
            this.pnlTableCard.Name = "pnlTableCard";
            this.pnlTableCard.Padding = new System.Windows.Forms.Padding(12);
            this.pnlTableCard.Size = new System.Drawing.Size(928, 339);
            this.pnlTableCard.TabIndex = 1;
            // 
            // dgvSurat
            // 
            this.dgvSurat.AllowUserToAddRows = false;
            this.dgvSurat.AllowUserToDeleteRows = false;
            this.dgvSurat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSurat.BackgroundColor = System.Drawing.Color.White;
            this.dgvSurat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSurat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSurat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSurat.ColumnHeadersHeight = 36;
            this.dgvSurat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSurat.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvSurat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSurat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSurat.EnableHeadersVisualStyles = false;
            this.dgvSurat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvSurat.Location = new System.Drawing.Point(12, 52);
            this.dgvSurat.MultiSelect = false;
            this.dgvSurat.Name = "dgvSurat";
            this.dgvSurat.ReadOnly = true;
            this.dgvSurat.RowHeadersVisible = false;
            this.dgvSurat.RowTemplate.Height = 32;
            this.dgvSurat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSurat.Size = new System.Drawing.Size(904, 275);
            this.dgvSurat.TabIndex = 1;
            this.dgvSurat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSurat_CellClick);
            // 
            // pnlSearchHeader
            // 
            this.pnlSearchHeader.Controls.Add(this.lblTableTitle);
            this.pnlSearchHeader.Controls.Add(this.lblTotalSurat);
            this.pnlSearchHeader.Controls.Add(this.lblFilterStatus);
            this.pnlSearchHeader.Controls.Add(this.cboFilterStatus);
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
            this.lblTableTitle.Size = new System.Drawing.Size(175, 19);
            this.lblTableTitle.TabIndex = 0;
            this.lblTableTitle.Text = "📊 Riwayat Surat Pengantar";
            // 
            // lblTotalSurat
            // 
            this.lblTotalSurat.AutoSize = true;
            this.lblTotalSurat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.lblTotalSurat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalSurat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalSurat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.lblTotalSurat.Location = new System.Drawing.Point(190, 7);
            this.lblTotalSurat.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblTotalSurat.Name = "lblTotalSurat";
            this.lblTotalSurat.Size = new System.Drawing.Size(120, 25);
            this.lblTotalSurat.TabIndex = 1;
            this.lblTotalSurat.Text = "📄 Total: 0 Surat";
            // 
            // lblFilterStatus
            // 
            this.lblFilterStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilterStatus.AutoSize = true;
            this.lblFilterStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFilterStatus.Location = new System.Drawing.Point(500, 12);
            this.lblFilterStatus.Name = "lblFilterStatus";
            this.lblFilterStatus.Size = new System.Drawing.Size(46, 15);
            this.lblFilterStatus.TabIndex = 2;
            this.lblFilterStatus.Text = "Status:";
            // 
            // cboFilterStatus
            // 
            this.cboFilterStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboFilterStatus.FormattingEnabled = true;
            this.cboFilterStatus.Items.AddRange(new object[] {
            "Semua Status",
            "Disetujui",
            "Menunggu",
            "Selesai",
            "Ditolak"});
            this.cboFilterStatus.Location = new System.Drawing.Point(550, 8);
            this.cboFilterStatus.Name = "cboFilterStatus";
            this.cboFilterStatus.Size = new System.Drawing.Size(115, 24);
            this.cboFilterStatus.TabIndex = 3;
            this.cboFilterStatus.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // lblCari
            // 
            this.lblCari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCari.AutoSize = true;
            this.lblCari.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCari.Location = new System.Drawing.Point(678, 12);
            this.lblCari.Name = "lblCari";
            this.lblCari.Size = new System.Drawing.Size(39, 15);
            this.lblCari.TabIndex = 4;
            this.lblCari.Text = "🔍 Cari:";
            // 
            // txtCari
            // 
            this.txtCari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCari.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCari.Location = new System.Drawing.Point(722, 8);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(180, 24);
            this.txtCari.TabIndex = 5;
            this.txtCari.TextChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // pnlInputCard
            // 
            this.pnlInputCard.BackColor = System.Drawing.Color.White;
            this.pnlInputCard.Controls.Add(this.lblCardInputTitle);
            this.pnlInputCard.Controls.Add(this.lblNoSurat);
            this.pnlInputCard.Controls.Add(this.txtNoSurat);
            this.pnlInputCard.Controls.Add(this.lblNamaWarga);
            this.pnlInputCard.Controls.Add(this.cboNamaWarga);
            this.pnlInputCard.Controls.Add(this.lblNik);
            this.pnlInputCard.Controls.Add(this.txtNik);
            this.pnlInputCard.Controls.Add(this.lblTanggal);
            this.pnlInputCard.Controls.Add(this.dtpTanggalSurat);
            this.pnlInputCard.Controls.Add(this.lblStatus);
            this.pnlInputCard.Controls.Add(this.cboStatusSurat);
            this.pnlInputCard.Controls.Add(this.lblKeperluan);
            this.pnlInputCard.Controls.Add(this.cboKeperluan);
            this.pnlInputCard.Controls.Add(this.lblKeterangan);
            this.pnlInputCard.Controls.Add(this.txtKeterangan);
            this.pnlInputCard.Controls.Add(this.flpActions);
            this.pnlInputCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInputCard.Location = new System.Drawing.Point(16, 16);
            this.pnlInputCard.Name = "pnlInputCard";
            this.pnlInputCard.Size = new System.Drawing.Size(928, 205);
            this.pnlInputCard.TabIndex = 0;
            // 
            // lblCardInputTitle
            // 
            this.lblCardInputTitle.AutoSize = true;
            this.lblCardInputTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCardInputTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.lblCardInputTitle.Location = new System.Drawing.Point(15, 8);
            this.lblCardInputTitle.Name = "lblCardInputTitle";
            this.lblCardInputTitle.Size = new System.Drawing.Size(252, 19);
            this.lblCardInputTitle.TabIndex = 0;
            this.lblCardInputTitle.Text = "✏️ Form Buat / Edit Surat Pengantar";
            // 
            // lblNoSurat
            // 
            this.lblNoSurat.AutoSize = true;
            this.lblNoSurat.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblNoSurat.Location = new System.Drawing.Point(15, 34);
            this.lblNoSurat.Name = "lblNoSurat";
            this.lblNoSurat.Size = new System.Drawing.Size(79, 15);
            this.lblNoSurat.TabIndex = 1;
            this.lblNoSurat.Text = "Nomor Surat";
            // 
            // txtNoSurat
            // 
            this.txtNoSurat.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNoSurat.Location = new System.Drawing.Point(18, 52);
            this.txtNoSurat.Name = "txtNoSurat";
            this.txtNoSurat.Size = new System.Drawing.Size(180, 24);
            this.txtNoSurat.TabIndex = 2;
            // 
            // lblNamaWarga
            // 
            this.lblNamaWarga.AutoSize = true;
            this.lblNamaWarga.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblNamaWarga.Location = new System.Drawing.Point(210, 34);
            this.lblNamaWarga.Name = "lblNamaWarga";
            this.lblNamaWarga.Size = new System.Drawing.Size(78, 15);
            this.lblNamaWarga.TabIndex = 3;
            this.lblNamaWarga.Text = "Nama Warga";
            // 
            // cboNamaWarga
            // 
            this.cboNamaWarga.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboNamaWarga.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboNamaWarga.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboNamaWarga.FormattingEnabled = true;
            this.cboNamaWarga.Location = new System.Drawing.Point(213, 52);
            this.cboNamaWarga.Name = "cboNamaWarga";
            this.cboNamaWarga.Size = new System.Drawing.Size(210, 24);
            this.cboNamaWarga.TabIndex = 4;
            this.cboNamaWarga.SelectedIndexChanged += new System.EventHandler(this.cboNamaWarga_SelectedIndexChanged);
            // 
            // lblNik
            // 
            this.lblNik.AutoSize = true;
            this.lblNik.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblNik.Location = new System.Drawing.Point(435, 34);
            this.lblNik.Name = "lblNik";
            this.lblNik.Size = new System.Drawing.Size(28, 15);
            this.lblNik.TabIndex = 5;
            this.lblNik.Text = "NIK";
            // 
            // txtNik
            // 
            this.txtNik.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNik.Location = new System.Drawing.Point(438, 52);
            this.txtNik.Name = "txtNik";
            this.txtNik.Size = new System.Drawing.Size(165, 24);
            this.txtNik.TabIndex = 6;
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblTanggal.Location = new System.Drawing.Point(618, 34);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(81, 15);
            this.lblTanggal.TabIndex = 7;
            this.lblTanggal.Text = "Tanggal Surat";
            // 
            // dtpTanggalSurat
            // 
            this.dtpTanggalSurat.CustomFormat = "dd/MM/yyyy";
            this.dtpTanggalSurat.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpTanggalSurat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalSurat.Location = new System.Drawing.Point(621, 52);
            this.dtpTanggalSurat.Name = "dtpTanggalSurat";
            this.dtpTanggalSurat.Size = new System.Drawing.Size(130, 24);
            this.dtpTanggalSurat.TabIndex = 8;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(768, 34);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 15);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status";
            // 
            // cboStatusSurat
            // 
            this.cboStatusSurat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatusSurat.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboStatusSurat.FormattingEnabled = true;
            this.cboStatusSurat.Items.AddRange(new object[] {
            "Disetujui",
            "Menunggu",
            "Selesai",
            "Ditolak"});
            this.cboStatusSurat.Location = new System.Drawing.Point(771, 52);
            this.cboStatusSurat.Name = "cboStatusSurat";
            this.cboStatusSurat.Size = new System.Drawing.Size(130, 24);
            this.cboStatusSurat.TabIndex = 10;
            // 
            // lblKeperluan
            // 
            this.lblKeperluan.AutoSize = true;
            this.lblKeperluan.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblKeperluan.Location = new System.Drawing.Point(15, 86);
            this.lblKeperluan.Name = "lblKeperluan";
            this.lblKeperluan.Size = new System.Drawing.Size(126, 15);
            this.lblKeperluan.TabIndex = 11;
            this.lblKeperluan.Text = "Keperluan Pengantar";
            // 
            // cboKeperluan
            // 
            this.cboKeperluan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboKeperluan.FormattingEnabled = true;
            this.cboKeperluan.Items.AddRange(new object[] {
            "Pengurusan KTP / e-KTP",
            "Pengurusan Kartu Keluarga (KK)",
            "Surat Keterangan Domisili",
            "Surat Keterangan Tidak Mampu (SKTM)",
            "Pengurusan SKCK Kepolisian",
            "Surat Keterangan Belum Menikah",
            "Surat Pengantar Nikah (Model N1-N4)",
            "Pengurusan Surat Kematian",
            "Surat Keterangan Usaha (SKU)"});
            this.cboKeperluan.Location = new System.Drawing.Point(18, 104);
            this.cboKeperluan.Name = "cboKeperluan";
            this.cboKeperluan.Size = new System.Drawing.Size(405, 24);
            this.cboKeperluan.TabIndex = 12;
            // 
            // lblKeterangan
            // 
            this.lblKeterangan.AutoSize = true;
            this.lblKeterangan.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblKeterangan.Location = new System.Drawing.Point(435, 86);
            this.lblKeterangan.Name = "lblKeterangan";
            this.lblKeterangan.Size = new System.Drawing.Size(128, 15);
            this.lblKeterangan.TabIndex = 13;
            this.lblKeterangan.Text = "Keterangan Tambahan";
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtKeterangan.Location = new System.Drawing.Point(438, 104);
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(463, 24);
            this.txtKeterangan.TabIndex = 14;
            // 
            // flpActions
            // 
            this.flpActions.Controls.Add(this.btnSimpan);
            this.flpActions.Controls.Add(this.btnEdit);
            this.flpActions.Controls.Add(this.btnHapus);
            this.flpActions.Controls.Add(this.btnBatal);
            this.flpActions.Controls.Add(this.btnCetak);
            this.flpActions.Location = new System.Drawing.Point(18, 145);
            this.flpActions.Name = "flpActions";
            this.flpActions.Size = new System.Drawing.Size(883, 50);
            this.flpActions.TabIndex = 15;
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
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(110, 40);
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
            this.btnEdit.Location = new System.Drawing.Point(120, 0);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 40);
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
            this.btnHapus.Location = new System.Drawing.Point(240, 0);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(110, 40);
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
            this.btnBatal.Location = new System.Drawing.Point(360, 0);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(110, 40);
            this.btnBatal.TabIndex = 3;
            this.btnBatal.Text = "🔄 BATAL";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnCetak
            // 
            this.btnCetak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnCetak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCetak.FlatAppearance.BorderSize = 0;
            this.btnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCetak.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCetak.ForeColor = System.Drawing.Color.White;
            this.btnCetak.Location = new System.Drawing.Point(480, 0);
            this.btnCetak.Margin = new System.Windows.Forms.Padding(0);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(170, 40);
            this.btnCetak.TabIndex = 4;
            this.btnCetak.Text = "🖨️ PREVIEW / CETAK";
            this.btnCetak.UseVisualStyleBackColor = false;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // frmSurat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(960, 650);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTopHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSurat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Surat Pengantar";
            this.Load += new System.EventHandler(this.frmSurat_Load);
            this.pnlTopHeader.ResumeLayout(false);
            this.pnlTopHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlTableCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSurat)).EndInit();
            this.pnlSearchHeader.ResumeLayout(false);
            this.pnlSearchHeader.PerformLayout();
            this.pnlInputCard.ResumeLayout(false);
            this.pnlInputCard.PerformLayout();
            this.flpActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSub;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlInputCard;
        private System.Windows.Forms.Label lblCardInputTitle;
        private System.Windows.Forms.Label lblNoSurat;
        private System.Windows.Forms.TextBox txtNoSurat;
        private System.Windows.Forms.Label lblNamaWarga;
        private System.Windows.Forms.ComboBox cboNamaWarga;
        private System.Windows.Forms.Label lblNik;
        private System.Windows.Forms.TextBox txtNik;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.DateTimePicker dtpTanggalSurat;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatusSurat;
        private System.Windows.Forms.Label lblKeperluan;
        private System.Windows.Forms.ComboBox cboKeperluan;
        private System.Windows.Forms.Label lblKeterangan;
        private System.Windows.Forms.TextBox txtKeterangan;
        private System.Windows.Forms.FlowLayoutPanel flpActions;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnCetak;
        private System.Windows.Forms.Panel pnlTableCard;
        private System.Windows.Forms.Panel pnlSearchHeader;
        private System.Windows.Forms.Label lblTableTitle;
        private System.Windows.Forms.Label lblTotalSurat;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.ComboBox cboFilterStatus;
        private System.Windows.Forms.Label lblCari;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.DataGridView dgvSurat;
    }
}
