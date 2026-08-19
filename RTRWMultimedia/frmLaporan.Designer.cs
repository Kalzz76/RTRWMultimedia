namespace RTRWMultimedia
{
    partial class frmLaporan
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
            this.dgvLaporan = new System.Windows.Forms.DataGridView();
            this.pnlSummaryBar = new System.Windows.Forms.Panel();
            this.lblTableTitle = new System.Windows.Forms.Label();
            this.flpSummaryBadges = new System.Windows.Forms.FlowLayoutPanel();
            this.lblStat1 = new System.Windows.Forms.Label();
            this.lblStat2 = new System.Windows.Forms.Label();
            this.lblStat3 = new System.Windows.Forms.Label();
            this.pnlFilterCard = new System.Windows.Forms.Panel();
            this.lblCardFilterTitle = new System.Windows.Forms.Label();
            this.lblJenisLaporan = new System.Windows.Forms.Label();
            this.cboJenisLaporan = new System.Windows.Forms.ComboBox();
            this.lblPeriodeDari = new System.Windows.Forms.Label();
            this.dtpDari = new System.Windows.Forms.DateTimePicker();
            this.lblPeriodeSampai = new System.Windows.Forms.Label();
            this.dtpSampai = new System.Windows.Forms.DateTimePicker();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.cboFilterStatus = new System.Windows.Forms.ComboBox();
            this.lblCari = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.flpFilterActions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTerapkanFilter = new System.Windows.Forms.Button();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.btnCetakLaporan = new System.Windows.Forms.Button();
            this.btnEksporExcel = new System.Windows.Forms.Button();
            this.pnlTopHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlTableCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).BeginInit();
            this.pnlSummaryBar.SuspendLayout();
            this.flpSummaryBadges.SuspendLayout();
            this.pnlFilterCard.SuspendLayout();
            this.flpFilterActions.SuspendLayout();
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
            this.lblHeaderTitle.Size = new System.Drawing.Size(430, 25);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "📊 PUSAT LAPORAN & REKAPITULASI RT / RW";
            // 
            // lblHeaderSub
            // 
            this.lblHeaderSub.AutoSize = true;
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblHeaderSub.Location = new System.Drawing.Point(23, 35);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Size = new System.Drawing.Size(515, 15);
            this.lblHeaderSub.TabIndex = 1;
            this.lblHeaderSub.Text = "Modul Rekapitulasi Data Keuangan Iuran, Kependudukan Warga, Surat Pengantar, & Pe" +
    "ngumuman";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlMain.Controls.Add(this.pnlTableCard);
            this.pnlMain.Controls.Add(this.pnlFilterCard);
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
            this.pnlTableCard.Controls.Add(this.dgvLaporan);
            this.pnlTableCard.Controls.Add(this.pnlSummaryBar);
            this.pnlTableCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTableCard.Location = new System.Drawing.Point(16, 170);
            this.pnlTableCard.Margin = new System.Windows.Forms.Padding(0, 16, 0, 0);
            this.pnlTableCard.Name = "pnlTableCard";
            this.pnlTableCard.Padding = new System.Windows.Forms.Padding(12);
            this.pnlTableCard.Size = new System.Drawing.Size(928, 404);
            this.pnlTableCard.TabIndex = 1;
            // 
            // dgvLaporan
            // 
            this.dgvLaporan.AllowUserToAddRows = false;
            this.dgvLaporan.AllowUserToDeleteRows = false;
            this.dgvLaporan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLaporan.BackgroundColor = System.Drawing.Color.White;
            this.dgvLaporan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLaporan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLaporan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLaporan.ColumnHeadersHeight = 36;
            this.dgvLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLaporan.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvLaporan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLaporan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLaporan.EnableHeadersVisualStyles = false;
            this.dgvLaporan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvLaporan.Location = new System.Drawing.Point(12, 52);
            this.dgvLaporan.MultiSelect = false;
            this.dgvLaporan.Name = "dgvLaporan";
            this.dgvLaporan.ReadOnly = true;
            this.dgvLaporan.RowHeadersVisible = false;
            this.dgvLaporan.RowTemplate.Height = 32;
            this.dgvLaporan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLaporan.Size = new System.Drawing.Size(904, 340);
            this.dgvLaporan.TabIndex = 1;
            // 
            // pnlSummaryBar
            // 
            this.pnlSummaryBar.Controls.Add(this.lblTableTitle);
            this.pnlSummaryBar.Controls.Add(this.flpSummaryBadges);
            this.pnlSummaryBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSummaryBar.Location = new System.Drawing.Point(12, 12);
            this.pnlSummaryBar.Name = "pnlSummaryBar";
            this.pnlSummaryBar.Size = new System.Drawing.Size(904, 40);
            this.pnlSummaryBar.TabIndex = 0;
            // 
            // lblTableTitle
            // 
            this.lblTableTitle.AutoSize = true;
            this.lblTableTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTableTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.lblTableTitle.Location = new System.Drawing.Point(0, 10);
            this.lblTableTitle.Name = "lblTableTitle";
            this.lblTableTitle.Size = new System.Drawing.Size(217, 19);
            this.lblTableTitle.TabIndex = 0;
            this.lblTableTitle.Text = "📋 Rincian Data Rekap Laporan";
            // 
            // flpSummaryBadges
            // 
            this.flpSummaryBadges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flpSummaryBadges.AutoSize = true;
            this.flpSummaryBadges.Controls.Add(this.lblStat1);
            this.flpSummaryBadges.Controls.Add(this.lblStat2);
            this.flpSummaryBadges.Controls.Add(this.lblStat3);
            this.flpSummaryBadges.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flpSummaryBadges.Location = new System.Drawing.Point(340, 5);
            this.flpSummaryBadges.Name = "flpSummaryBadges";
            this.flpSummaryBadges.Size = new System.Drawing.Size(564, 32);
            this.flpSummaryBadges.TabIndex = 1;
            this.flpSummaryBadges.WrapContents = false;
            // 
            // lblStat1
            // 
            this.lblStat1.AutoSize = true;
            this.lblStat1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.lblStat1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStat1.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblStat1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.lblStat1.Location = new System.Drawing.Point(0, 0);
            this.lblStat1.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.lblStat1.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblStat1.Name = "lblStat1";
            this.lblStat1.Size = new System.Drawing.Size(107, 25);
            this.lblStat1.TabIndex = 0;
            this.lblStat1.Text = "📄 Total: 0 Data";
            // 
            // lblStat2
            // 
            this.lblStat2.AutoSize = true;
            this.lblStat2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.lblStat2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStat2.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblStat2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.lblStat2.Location = new System.Drawing.Point(115, 0);
            this.lblStat2.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.lblStat2.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblStat2.Name = "lblStat2";
            this.lblStat2.Size = new System.Drawing.Size(126, 25);
            this.lblStat2.TabIndex = 1;
            this.lblStat2.Text = "💰 Kas Lunas: Rp 0";
            // 
            // lblStat3
            // 
            this.lblStat3.AutoSize = true;
            this.lblStat3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblStat3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStat3.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblStat3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblStat3.Location = new System.Drawing.Point(249, 0);
            this.lblStat3.Margin = new System.Windows.Forms.Padding(0);
            this.lblStat3.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblStat3.Name = "lblStat3";
            this.lblStat3.Size = new System.Drawing.Size(130, 25);
            this.lblStat3.TabIndex = 2;
            this.lblStat3.Text = "⏳ Belum Lunas: Rp 0";
            this.lblStat3.TabIndex = 3;
            this.lblStat3.Text = "⏳ Belum Lunas: Rp 0";
            // 
            // pnlFilterCard
            // 
            this.pnlFilterCard.BackColor = System.Drawing.Color.White;
            this.pnlFilterCard.Controls.Add(this.lblCardFilterTitle);
            this.pnlFilterCard.Controls.Add(this.lblJenisLaporan);
            this.pnlFilterCard.Controls.Add(this.cboJenisLaporan);
            this.pnlFilterCard.Controls.Add(this.lblPeriodeDari);
            this.pnlFilterCard.Controls.Add(this.dtpDari);
            this.pnlFilterCard.Controls.Add(this.lblPeriodeSampai);
            this.pnlFilterCard.Controls.Add(this.dtpSampai);
            this.pnlFilterCard.Controls.Add(this.lblFilterStatus);
            this.pnlFilterCard.Controls.Add(this.cboFilterStatus);
            this.pnlFilterCard.Controls.Add(this.lblCari);
            this.pnlFilterCard.Controls.Add(this.txtCari);
            this.pnlFilterCard.Controls.Add(this.flpFilterActions);
            this.pnlFilterCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterCard.Location = new System.Drawing.Point(16, 16);
            this.pnlFilterCard.Name = "pnlFilterCard";
            this.pnlFilterCard.Size = new System.Drawing.Size(928, 140);
            this.pnlFilterCard.TabIndex = 0;
            // 
            // lblCardFilterTitle
            // 
            this.lblCardFilterTitle.AutoSize = true;
            this.lblCardFilterTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCardFilterTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.lblCardFilterTitle.Location = new System.Drawing.Point(15, 8);
            this.lblCardFilterTitle.Name = "lblCardFilterTitle";
            this.lblCardFilterTitle.Size = new System.Drawing.Size(262, 19);
            this.lblCardFilterTitle.TabIndex = 0;
            this.lblCardFilterTitle.Text = "🔍 Kriteria & Parameter Filter Laporan";
            // 
            // lblJenisLaporan
            // 
            this.lblJenisLaporan.AutoSize = true;
            this.lblJenisLaporan.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblJenisLaporan.Location = new System.Drawing.Point(15, 32);
            this.lblJenisLaporan.Name = "lblJenisLaporan";
            this.lblJenisLaporan.Size = new System.Drawing.Size(84, 15);
            this.lblJenisLaporan.TabIndex = 1;
            this.lblJenisLaporan.Text = "Jenis Laporan";
            // 
            // cboJenisLaporan
            // 
            this.cboJenisLaporan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJenisLaporan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboJenisLaporan.FormattingEnabled = true;
            this.cboJenisLaporan.Items.AddRange(new object[] {
            "Laporan Keuangan & Iuran Warga",
            "Laporan Kependudukan & Warga",
            "Laporan Pengajuan Surat Pengantar",
            "Laporan Publikasi & Pengumuman"});
            this.cboJenisLaporan.Location = new System.Drawing.Point(18, 50);
            this.cboJenisLaporan.Name = "cboJenisLaporan";
            this.cboJenisLaporan.Size = new System.Drawing.Size(240, 24);
            this.cboJenisLaporan.TabIndex = 2;
            this.cboJenisLaporan.SelectedIndexChanged += new System.EventHandler(this.cboJenisLaporan_SelectedIndexChanged);
            // 
            // lblPeriodeDari
            // 
            this.lblPeriodeDari.AutoSize = true;
            this.lblPeriodeDari.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblPeriodeDari.Location = new System.Drawing.Point(267, 32);
            this.lblPeriodeDari.Name = "lblPeriodeDari";
            this.lblPeriodeDari.Size = new System.Drawing.Size(76, 15);
            this.lblPeriodeDari.TabIndex = 3;
            this.lblPeriodeDari.Text = "Periode Dari";
            // 
            // dtpDari
            // 
            this.dtpDari.CustomFormat = "dd/MM/yyyy";
            this.dtpDari.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpDari.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDari.Location = new System.Drawing.Point(270, 50);
            this.dtpDari.Name = "dtpDari";
            this.dtpDari.Size = new System.Drawing.Size(125, 24);
            this.dtpDari.TabIndex = 4;
            // 
            // lblPeriodeSampai
            // 
            this.lblPeriodeSampai.AutoSize = true;
            this.lblPeriodeSampai.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblPeriodeSampai.Location = new System.Drawing.Point(407, 32);
            this.lblPeriodeSampai.Name = "lblPeriodeSampai";
            this.lblPeriodeSampai.Size = new System.Drawing.Size(46, 15);
            this.lblPeriodeSampai.TabIndex = 5;
            this.lblPeriodeSampai.Text = "Sampai";
            // 
            // dtpSampai
            // 
            this.dtpSampai.CustomFormat = "dd/MM/yyyy";
            this.dtpSampai.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpSampai.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSampai.Location = new System.Drawing.Point(410, 50);
            this.dtpSampai.Name = "dtpSampai";
            this.dtpSampai.Size = new System.Drawing.Size(125, 24);
            this.dtpSampai.TabIndex = 6;
            // 
            // lblFilterStatus
            // 
            this.lblFilterStatus.AutoSize = true;
            this.lblFilterStatus.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblFilterStatus.Location = new System.Drawing.Point(547, 32);
            this.lblFilterStatus.Name = "lblFilterStatus";
            this.lblFilterStatus.Size = new System.Drawing.Size(76, 15);
            this.lblFilterStatus.TabIndex = 7;
            this.lblFilterStatus.Text = "Filter Status";
            // 
            // cboFilterStatus
            // 
            this.cboFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboFilterStatus.FormattingEnabled = true;
            this.cboFilterStatus.Location = new System.Drawing.Point(550, 50);
            this.cboFilterStatus.Name = "cboFilterStatus";
            this.cboFilterStatus.Size = new System.Drawing.Size(130, 24);
            this.cboFilterStatus.TabIndex = 8;
            // 
            // lblCari
            // 
            this.lblCari.AutoSize = true;
            this.lblCari.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblCari.Location = new System.Drawing.Point(693, 32);
            this.lblCari.Name = "lblCari";
            this.lblCari.Size = new System.Drawing.Size(107, 15);
            this.lblCari.TabIndex = 9;
            this.lblCari.Text = "Cari Kata Kunci / NIK";
            // 
            // txtCari
            // 
            this.txtCari.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCari.Location = new System.Drawing.Point(696, 50);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(210, 24);
            this.txtCari.TabIndex = 10;
            // 
            // flpFilterActions
            // 
            this.flpFilterActions.Controls.Add(this.btnTerapkanFilter);
            this.flpFilterActions.Controls.Add(this.btnResetFilter);
            this.flpFilterActions.Controls.Add(this.btnCetakLaporan);
            this.flpFilterActions.Controls.Add(this.btnEksporExcel);
            this.flpFilterActions.Location = new System.Drawing.Point(18, 88);
            this.flpFilterActions.Name = "flpFilterActions";
            this.flpFilterActions.Size = new System.Drawing.Size(890, 42);
            this.flpFilterActions.TabIndex = 11;
            // 
            // btnTerapkanFilter
            // 
            this.btnTerapkanFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.btnTerapkanFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTerapkanFilter.FlatAppearance.BorderSize = 0;
            this.btnTerapkanFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerapkanFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTerapkanFilter.ForeColor = System.Drawing.Color.White;
            this.btnTerapkanFilter.Location = new System.Drawing.Point(0, 0);
            this.btnTerapkanFilter.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnTerapkanFilter.Name = "btnTerapkanFilter";
            this.btnTerapkanFilter.Size = new System.Drawing.Size(165, 38);
            this.btnTerapkanFilter.TabIndex = 0;
            this.btnTerapkanFilter.Text = "🔍 TAMPILKAN DATA";
            this.btnTerapkanFilter.UseVisualStyleBackColor = false;
            this.btnTerapkanFilter.Click += new System.EventHandler(this.btnTerapkanFilter_Click);
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnResetFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetFilter.FlatAppearance.BorderSize = 0;
            this.btnResetFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnResetFilter.ForeColor = System.Drawing.Color.White;
            this.btnResetFilter.Location = new System.Drawing.Point(175, 0);
            this.btnResetFilter.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(120, 38);
            this.btnResetFilter.TabIndex = 1;
            this.btnResetFilter.Text = "🔄 RESET FILTER";
            this.btnResetFilter.UseVisualStyleBackColor = false;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
            // 
            // btnCetakLaporan
            // 
            this.btnCetakLaporan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnCetakLaporan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCetakLaporan.FlatAppearance.BorderSize = 0;
            this.btnCetakLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCetakLaporan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCetakLaporan.ForeColor = System.Drawing.Color.White;
            this.btnCetakLaporan.Location = new System.Drawing.Point(305, 0);
            this.btnCetakLaporan.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnCetakLaporan.Name = "btnCetakLaporan";
            this.btnCetakLaporan.Size = new System.Drawing.Size(185, 38);
            this.btnCetakLaporan.TabIndex = 2;
            this.btnCetakLaporan.Text = "🖨️ CETAK / PRINT";
            this.btnCetakLaporan.UseVisualStyleBackColor = false;
            this.btnCetakLaporan.Click += new System.EventHandler(this.btnCetakLaporan_Click);
            // 
            // btnEksporExcel
            // 
            this.btnEksporExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnEksporExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEksporExcel.FlatAppearance.BorderSize = 0;
            this.btnEksporExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEksporExcel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnEksporExcel.ForeColor = System.Drawing.Color.White;
            this.btnEksporExcel.Location = new System.Drawing.Point(500, 0);
            this.btnEksporExcel.Margin = new System.Windows.Forms.Padding(0);
            this.btnEksporExcel.Name = "btnEksporExcel";
            this.btnEksporExcel.Size = new System.Drawing.Size(185, 38);
            this.btnEksporExcel.TabIndex = 3;
            this.btnEksporExcel.Text = "📥 EKSPOR KE CSV";
            this.btnEksporExcel.UseVisualStyleBackColor = false;
            this.btnEksporExcel.Click += new System.EventHandler(this.btnEksporExcel_Click);
            // 
            // frmLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(960, 650);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTopHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLaporan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pusat Laporan RT RW";
            this.Load += new System.EventHandler(this.frmLaporan_Load);
            this.pnlTopHeader.ResumeLayout(false);
            this.pnlTopHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlTableCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).EndInit();
            this.pnlSummaryBar.ResumeLayout(false);
            this.pnlSummaryBar.PerformLayout();
            this.flpSummaryBadges.ResumeLayout(false);
            this.flpSummaryBadges.PerformLayout();
            this.pnlFilterCard.ResumeLayout(false);
            this.pnlFilterCard.PerformLayout();
            this.flpFilterActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSub;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlFilterCard;
        private System.Windows.Forms.Label lblCardFilterTitle;
        private System.Windows.Forms.Label lblJenisLaporan;
        private System.Windows.Forms.ComboBox cboJenisLaporan;
        private System.Windows.Forms.Label lblPeriodeDari;
        private System.Windows.Forms.DateTimePicker dtpDari;
        private System.Windows.Forms.Label lblPeriodeSampai;
        private System.Windows.Forms.DateTimePicker dtpSampai;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.ComboBox cboFilterStatus;
        private System.Windows.Forms.Label lblCari;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.FlowLayoutPanel flpFilterActions;
        private System.Windows.Forms.Button btnTerapkanFilter;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.Button btnCetakLaporan;
        private System.Windows.Forms.Button btnEksporExcel;
        private System.Windows.Forms.Panel pnlTableCard;
        private System.Windows.Forms.Panel pnlSummaryBar;
        private System.Windows.Forms.FlowLayoutPanel flpSummaryBadges;
        private System.Windows.Forms.Label lblTableTitle;
        private System.Windows.Forms.Label lblStat1;
        private System.Windows.Forms.Label lblStat2;
        private System.Windows.Forms.Label lblStat3;
        private System.Windows.Forms.DataGridView dgvLaporan;
    }
}
