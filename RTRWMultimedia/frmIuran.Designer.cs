namespace RTRWMultimedia
{
    partial class frmIuran
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
            this.dgvIuran = new System.Windows.Forms.DataGridView();
            this.pnlSearchHeader = new System.Windows.Forms.Panel();
            this.lblTableTitle = new System.Windows.Forms.Label();
            this.lblTotalKas = new System.Windows.Forms.Label();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.cboFilterStatus = new System.Windows.Forms.ComboBox();
            this.lblCari = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.pnlInputCard = new System.Windows.Forms.Panel();
            this.lblCardInputTitle = new System.Windows.Forms.Label();
            this.lblNamaWarga = new System.Windows.Forms.Label();
            this.cboNamaWarga = new System.Windows.Forms.ComboBox();
            this.lblBulan = new System.Windows.Forms.Label();
            this.cboBulan = new System.Windows.Forms.ComboBox();
            this.lblNominal = new System.Windows.Forms.Label();
            this.txtNominal = new System.Windows.Forms.TextBox();
            this.lblTanggalBayar = new System.Windows.Forms.Label();
            this.dtpTanggalBayar = new System.Windows.Forms.DateTimePicker();
            this.lblStatusBayar = new System.Windows.Forms.Label();
            this.cboStatusBayar = new System.Windows.Forms.ComboBox();
            this.flpActions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.pnlTopHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlTableCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIuran)).BeginInit();
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
            this.lblHeaderTitle.Size = new System.Drawing.Size(325, 25);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "💵 DATA IURAN WARGA RT 04 / RW 02";
            // 
            // lblHeaderSub
            // 
            this.lblHeaderSub.AutoSize = true;
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblHeaderSub.Location = new System.Drawing.Point(23, 35);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Size = new System.Drawing.Size(380, 15);
            this.lblHeaderSub.TabIndex = 1;
            this.lblHeaderSub.Text = "Modul Pengelolaan Kas & Pembayaran Iuran Warga (Tambah, Edit, Hapus, & Cari)";
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
            this.pnlTableCard.Controls.Add(this.dgvIuran);
            this.pnlTableCard.Controls.Add(this.pnlSearchHeader);
            this.pnlTableCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTableCard.Location = new System.Drawing.Point(16, 217);
            this.pnlTableCard.Margin = new System.Windows.Forms.Padding(0, 16, 0, 0);
            this.pnlTableCard.Name = "pnlTableCard";
            this.pnlTableCard.Padding = new System.Windows.Forms.Padding(12);
            this.pnlTableCard.Size = new System.Drawing.Size(928, 357);
            this.pnlTableCard.TabIndex = 1;
            // 
            // dgvIuran
            // 
            this.dgvIuran.AllowUserToAddRows = false;
            this.dgvIuran.AllowUserToDeleteRows = false;
            this.dgvIuran.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIuran.BackgroundColor = System.Drawing.Color.White;
            this.dgvIuran.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIuran.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIuran.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIuran.ColumnHeadersHeight = 36;
            this.dgvIuran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIuran.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvIuran.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvIuran.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIuran.EnableHeadersVisualStyles = false;
            this.dgvIuran.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvIuran.Location = new System.Drawing.Point(12, 52);
            this.dgvIuran.MultiSelect = false;
            this.dgvIuran.Name = "dgvIuran";
            this.dgvIuran.ReadOnly = true;
            this.dgvIuran.RowHeadersVisible = false;
            this.dgvIuran.RowTemplate.Height = 32;
            this.dgvIuran.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIuran.Size = new System.Drawing.Size(904, 293);
            this.dgvIuran.TabIndex = 1;
            this.dgvIuran.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIuran_CellClick);
            // 
            // pnlSearchHeader
            // 
            this.pnlSearchHeader.Controls.Add(this.lblTableTitle);
            this.pnlSearchHeader.Controls.Add(this.lblTotalKas);
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
            this.lblTableTitle.Text = "📊 Rekap Transaksi Iuran";
            // 
            // lblTotalKas
            // 
            this.lblTotalKas.AutoSize = true;
            this.lblTotalKas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.lblTotalKas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalKas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalKas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.lblTotalKas.Location = new System.Drawing.Point(185, 7);
            this.lblTotalKas.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblTotalKas.Name = "lblTotalKas";
            this.lblTotalKas.Size = new System.Drawing.Size(115, 25);
            this.lblTotalKas.TabIndex = 1;
            this.lblTotalKas.Text = "💰 Kas Lunas: Rp 0";
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
            "Lunas",
            "Belum Lunas"});
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
            this.pnlInputCard.Controls.Add(this.lblNamaWarga);
            this.pnlInputCard.Controls.Add(this.cboNamaWarga);
            this.pnlInputCard.Controls.Add(this.lblBulan);
            this.pnlInputCard.Controls.Add(this.cboBulan);
            this.pnlInputCard.Controls.Add(this.lblNominal);
            this.pnlInputCard.Controls.Add(this.txtNominal);
            this.pnlInputCard.Controls.Add(this.lblTanggalBayar);
            this.pnlInputCard.Controls.Add(this.dtpTanggalBayar);
            this.pnlInputCard.Controls.Add(this.lblStatusBayar);
            this.pnlInputCard.Controls.Add(this.cboStatusBayar);
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
            this.lblCardInputTitle.Location = new System.Drawing.Point(15, 10);
            this.lblCardInputTitle.Name = "lblCardInputTitle";
            this.lblCardInputTitle.Size = new System.Drawing.Size(185, 19);
            this.lblCardInputTitle.TabIndex = 0;
            this.lblCardInputTitle.Text = "✏️ Form Input / Edit Iuran";
            // 
            // lblNamaWarga
            // 
            this.lblNamaWarga.AutoSize = true;
            this.lblNamaWarga.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblNamaWarga.Location = new System.Drawing.Point(15, 38);
            this.lblNamaWarga.Name = "lblNamaWarga";
            this.lblNamaWarga.Size = new System.Drawing.Size(78, 15);
            this.lblNamaWarga.TabIndex = 1;
            this.lblNamaWarga.Text = "Nama Warga";
            // 
            // cboNamaWarga
            // 
            this.cboNamaWarga.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboNamaWarga.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboNamaWarga.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboNamaWarga.FormattingEnabled = true;
            this.cboNamaWarga.Location = new System.Drawing.Point(18, 56);
            this.cboNamaWarga.Name = "cboNamaWarga";
            this.cboNamaWarga.Size = new System.Drawing.Size(220, 24);
            this.cboNamaWarga.TabIndex = 2;
            // 
            // lblBulan
            // 
            this.lblBulan.AutoSize = true;
            this.lblBulan.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblBulan.Location = new System.Drawing.Point(255, 38);
            this.lblBulan.Name = "lblBulan";
            this.lblBulan.Size = new System.Drawing.Size(38, 15);
            this.lblBulan.TabIndex = 3;
            this.lblBulan.Text = "Bulan";
            // 
            // cboBulan
            // 
            this.cboBulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBulan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboBulan.FormattingEnabled = true;
            this.cboBulan.Items.AddRange(new object[] {
            "Januari",
            "Februari",
            "Maret",
            "April",
            "Mei",
            "Juni",
            "Juli",
            "Agustus",
            "September",
            "Oktober",
            "November",
            "Desember"});
            this.cboBulan.Location = new System.Drawing.Point(258, 56);
            this.cboBulan.Name = "cboBulan";
            this.cboBulan.Size = new System.Drawing.Size(140, 24);
            this.cboBulan.TabIndex = 4;
            // 
            // lblNominal
            // 
            this.lblNominal.AutoSize = true;
            this.lblNominal.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblNominal.Location = new System.Drawing.Point(415, 38);
            this.lblNominal.Name = "lblNominal";
            this.lblNominal.Size = new System.Drawing.Size(78, 15);
            this.lblNominal.TabIndex = 5;
            this.lblNominal.Text = "Nominal (Rp)";
            // 
            // txtNominal
            // 
            this.txtNominal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNominal.Location = new System.Drawing.Point(418, 56);
            this.txtNominal.Name = "txtNominal";
            this.txtNominal.Size = new System.Drawing.Size(140, 24);
            this.txtNominal.TabIndex = 6;
            this.txtNominal.Text = "50000";
            // 
            // lblTanggalBayar
            // 
            this.lblTanggalBayar.AutoSize = true;
            this.lblTanggalBayar.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblTanggalBayar.Location = new System.Drawing.Point(575, 38);
            this.lblTanggalBayar.Name = "lblTanggalBayar";
            this.lblTanggalBayar.Size = new System.Drawing.Size(83, 15);
            this.lblTanggalBayar.TabIndex = 7;
            this.lblTanggalBayar.Text = "Tanggal Bayar";
            // 
            // dtpTanggalBayar
            // 
            this.dtpTanggalBayar.CustomFormat = "dd/MM/yyyy";
            this.dtpTanggalBayar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpTanggalBayar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalBayar.Location = new System.Drawing.Point(578, 56);
            this.dtpTanggalBayar.Name = "dtpTanggalBayar";
            this.dtpTanggalBayar.Size = new System.Drawing.Size(140, 24);
            this.dtpTanggalBayar.TabIndex = 8;
            // 
            // lblStatusBayar
            // 
            this.lblStatusBayar.AutoSize = true;
            this.lblStatusBayar.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblStatusBayar.Location = new System.Drawing.Point(735, 38);
            this.lblStatusBayar.Name = "lblStatusBayar";
            this.lblStatusBayar.Size = new System.Drawing.Size(75, 15);
            this.lblStatusBayar.TabIndex = 9;
            this.lblStatusBayar.Text = "Status Bayar";
            // 
            // cboStatusBayar
            // 
            this.cboStatusBayar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatusBayar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboStatusBayar.FormattingEnabled = true;
            this.cboStatusBayar.Items.AddRange(new object[] {
            "Lunas",
            "Belum Lunas"});
            this.cboStatusBayar.Location = new System.Drawing.Point(738, 56);
            this.cboStatusBayar.Name = "cboStatusBayar";
            this.cboStatusBayar.Size = new System.Drawing.Size(150, 24);
            this.cboStatusBayar.TabIndex = 10;
            // 
            // flpActions
            // 
            this.flpActions.Controls.Add(this.btnSimpan);
            this.flpActions.Controls.Add(this.btnEdit);
            this.flpActions.Controls.Add(this.btnHapus);
            this.flpActions.Controls.Add(this.btnBatal);
            this.flpActions.Location = new System.Drawing.Point(18, 110);
            this.flpActions.Name = "flpActions";
            this.flpActions.Size = new System.Drawing.Size(870, 60);
            this.flpActions.TabIndex = 11;
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
            this.btnSimpan.Size = new System.Drawing.Size(120, 42);
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
            this.btnEdit.Location = new System.Drawing.Point(130, 0);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 42);
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
            this.btnHapus.Location = new System.Drawing.Point(260, 0);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(120, 42);
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
            this.btnBatal.Location = new System.Drawing.Point(390, 0);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(0);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(120, 42);
            this.btnBatal.TabIndex = 3;
            this.btnBatal.Text = "🔄 BATAL";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // frmIuran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(960, 650);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTopHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIuran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Iuran";
            this.Load += new System.EventHandler(this.frmIuran_Load);
            this.pnlTopHeader.ResumeLayout(false);
            this.pnlTopHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlTableCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIuran)).EndInit();
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
        private System.Windows.Forms.Label lblNamaWarga;
        private System.Windows.Forms.ComboBox cboNamaWarga;
        private System.Windows.Forms.Label lblBulan;
        private System.Windows.Forms.ComboBox cboBulan;
        private System.Windows.Forms.Label lblNominal;
        private System.Windows.Forms.TextBox txtNominal;
        private System.Windows.Forms.Label lblTanggalBayar;
        private System.Windows.Forms.DateTimePicker dtpTanggalBayar;
        private System.Windows.Forms.Label lblStatusBayar;
        private System.Windows.Forms.ComboBox cboStatusBayar;
        private System.Windows.Forms.FlowLayoutPanel flpActions;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Panel pnlTableCard;
        private System.Windows.Forms.Panel pnlSearchHeader;
        private System.Windows.Forms.Label lblTableTitle;
        private System.Windows.Forms.Label lblTotalKas;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.ComboBox cboFilterStatus;
        private System.Windows.Forms.Label lblCari;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.DataGridView dgvIuran;
    }
}
