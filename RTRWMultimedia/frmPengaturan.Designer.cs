namespace RTRWMultimedia
{
    partial class frmPengaturan
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
            this.pnlSettingsCard = new System.Windows.Forms.Panel();
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.tabProfil = new System.Windows.Forms.TabPage();
            this.lblNamaRTRW = new System.Windows.Forms.Label();
            this.txtNamaRTRW = new System.Windows.Forms.TextBox();
            this.lblDesa = new System.Windows.Forms.Label();
            this.txtDesa = new System.Windows.Forms.TextBox();
            this.lblKecamatan = new System.Windows.Forms.Label();
            this.txtKecamatan = new System.Windows.Forms.TextBox();
            this.lblKota = new System.Windows.Forms.Label();
            this.txtKota = new System.Windows.Forms.TextBox();
            this.lblKetuaRT = new System.Windows.Forms.Label();
            this.txtKetuaRT = new System.Windows.Forms.TextBox();
            this.lblSekretaris = new System.Windows.Forms.Label();
            this.txtSekretaris = new System.Windows.Forms.TextBox();
            this.btnSimpanProfil = new System.Windows.Forms.Button();
            this.tabIuran = new System.Windows.Forms.TabPage();
            this.pnlNoteIuran = new System.Windows.Forms.Panel();
            this.lblNoteIuran = new System.Windows.Forms.Label();
            this.lblNominalIuran = new System.Windows.Forms.Label();
            this.txtNominalIuran = new System.Windows.Forms.TextBox();
            this.lblJatuhTempo = new System.Windows.Forms.Label();
            this.nudJatuhTempo = new System.Windows.Forms.NumericUpDown();
            this.btnSimpanIuran = new System.Windows.Forms.Button();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.pnlUserRight = new System.Windows.Forms.Panel();
            this.lblUserFormTitle = new System.Windows.Forms.Label();
            this.lblNewUser = new System.Windows.Forms.Label();
            this.txtNewUser = new System.Windows.Forms.TextBox();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.lblNewLevel = new System.Windows.Forms.Label();
            this.cboNewLevel = new System.Windows.Forms.ComboBox();
            this.btnTambahUser = new System.Windows.Forms.Button();
            this.btnHapusUser = new System.Windows.Forms.Button();
            this.pnlUserLeft = new System.Windows.Forms.Panel();
            this.lblUserListTitle = new System.Windows.Forms.Label();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.tabDatabase = new System.Windows.Forms.TabPage();
            this.pnlDbStatus = new System.Windows.Forms.Panel();
            this.lblDbInfo = new System.Windows.Forms.Label();
            this.lblDbServer = new System.Windows.Forms.Label();
            this.txtDbServer = new System.Windows.Forms.TextBox();
            this.lblDbName = new System.Windows.Forms.Label();
            this.txtDbName = new System.Windows.Forms.TextBox();
            this.btnTesKoneksi = new System.Windows.Forms.Button();
            this.btnBackupDB = new System.Windows.Forms.Button();
            this.pnlTopHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlSettingsCard.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabProfil.SuspendLayout();
            this.tabIuran.SuspendLayout();
            this.pnlNoteIuran.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudJatuhTempo)).BeginInit();
            this.tabUser.SuspendLayout();
            this.pnlUserRight.SuspendLayout();
            this.pnlUserLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.tabDatabase.SuspendLayout();
            this.pnlDbStatus.SuspendLayout();
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

            // lblHeaderTitle
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.lblHeaderTitle.Location = new System.Drawing.Point(20, 10);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(306, 25);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "⚙️ PENGATURAN SISTEM RT/RW";

            // lblHeaderSub
            this.lblHeaderSub.AutoSize = true;
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblHeaderSub.Location = new System.Drawing.Point(23, 35);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Size = new System.Drawing.Size(434, 15);
            this.lblHeaderSub.TabIndex = 1;
            this.lblHeaderSub.Text = "Konfigurasi Identitas Wilayah, Master Iuran, Manajemen Pengguna & Database SQL";

            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlMain.Controls.Add(this.pnlSettingsCard);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 60);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(16);
            this.pnlMain.Size = new System.Drawing.Size(960, 590);
            this.pnlMain.TabIndex = 1;

            // 
            // pnlSettingsCard
            // 
            this.pnlSettingsCard.BackColor = System.Drawing.Color.White;
            this.pnlSettingsCard.Controls.Add(this.tabSettings);
            this.pnlSettingsCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSettingsCard.Location = new System.Drawing.Point(16, 16);
            this.pnlSettingsCard.Name = "pnlSettingsCard";
            this.pnlSettingsCard.Padding = new System.Windows.Forms.Padding(12);
            this.pnlSettingsCard.Size = new System.Drawing.Size(928, 558);
            this.pnlSettingsCard.TabIndex = 0;

            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.tabProfil);
            this.tabSettings.Controls.Add(this.tabIuran);
            this.tabSettings.Controls.Add(this.tabUser);
            this.tabSettings.Controls.Add(this.tabDatabase);
            this.tabSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSettings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSettings.ItemSize = new System.Drawing.Size(180, 36);
            this.tabSettings.Location = new System.Drawing.Point(12, 12);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(904, 534);
            this.tabSettings.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabSettings.TabIndex = 0;

            // 
            // tabProfil
            // 
            this.tabProfil.BackColor = System.Drawing.Color.White;
            this.tabProfil.Controls.Add(this.lblNamaRTRW);
            this.tabProfil.Controls.Add(this.txtNamaRTRW);
            this.tabProfil.Controls.Add(this.lblDesa);
            this.tabProfil.Controls.Add(this.txtDesa);
            this.tabProfil.Controls.Add(this.lblKecamatan);
            this.tabProfil.Controls.Add(this.txtKecamatan);
            this.tabProfil.Controls.Add(this.lblKota);
            this.tabProfil.Controls.Add(this.txtKota);
            this.tabProfil.Controls.Add(this.lblKetuaRT);
            this.tabProfil.Controls.Add(this.txtKetuaRT);
            this.tabProfil.Controls.Add(this.lblSekretaris);
            this.tabProfil.Controls.Add(this.txtSekretaris);
            this.tabProfil.Controls.Add(this.btnSimpanProfil);
            this.tabProfil.Location = new System.Drawing.Point(4, 40);
            this.tabProfil.Name = "tabProfil";
            this.tabProfil.Padding = new System.Windows.Forms.Padding(24);
            this.tabProfil.Size = new System.Drawing.Size(896, 490);
            this.tabProfil.TabIndex = 0;
            this.tabProfil.Text = "🏡 Identitas RT/RW";

            // Controls for Tab 1
            this.lblNamaRTRW.AutoSize = true;
            this.lblNamaRTRW.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNamaRTRW.Location = new System.Drawing.Point(24, 24);
            this.lblNamaRTRW.Name = "lblNamaRTRW";
            this.lblNamaRTRW.Size = new System.Drawing.Size(90, 15);
            this.lblNamaRTRW.Text = "Nama RT / RW";

            this.txtNamaRTRW.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNamaRTRW.Location = new System.Drawing.Point(27, 44);
            this.txtNamaRTRW.Name = "txtNamaRTRW";
            this.txtNamaRTRW.Size = new System.Drawing.Size(400, 25);
            this.txtNamaRTRW.TabIndex = 0;

            this.lblDesa.AutoSize = true;
            this.lblDesa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDesa.Location = new System.Drawing.Point(464, 24);
            this.lblDesa.Name = "lblDesa";
            this.lblDesa.Size = new System.Drawing.Size(102, 15);
            this.lblDesa.Text = "Desa / Kelurahan";

            this.txtDesa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDesa.Location = new System.Drawing.Point(467, 44);
            this.txtDesa.Name = "txtDesa";
            this.txtDesa.Size = new System.Drawing.Size(400, 25);
            this.txtDesa.TabIndex = 1;

            this.lblKecamatan.AutoSize = true;
            this.lblKecamatan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKecamatan.Location = new System.Drawing.Point(24, 94);
            this.lblKecamatan.Name = "lblKecamatan";
            this.lblKecamatan.Size = new System.Drawing.Size(68, 15);
            this.lblKecamatan.Text = "Kecamatan";

            this.txtKecamatan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtKecamatan.Location = new System.Drawing.Point(27, 114);
            this.txtKecamatan.Name = "txtKecamatan";
            this.txtKecamatan.Size = new System.Drawing.Size(400, 25);
            this.txtKecamatan.TabIndex = 2;

            this.lblKota.AutoSize = true;
            this.lblKota.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKota.Location = new System.Drawing.Point(464, 94);
            this.lblKota.Name = "lblKota";
            this.lblKota.Size = new System.Drawing.Size(101, 15);
            this.lblKota.Text = "Kota / Kabupaten";

            this.txtKota.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtKota.Location = new System.Drawing.Point(467, 114);
            this.txtKota.Name = "txtKota";
            this.txtKota.Size = new System.Drawing.Size(400, 25);
            this.txtKota.TabIndex = 3;

            this.lblKetuaRT.AutoSize = true;
            this.lblKetuaRT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKetuaRT.Location = new System.Drawing.Point(24, 164);
            this.lblKetuaRT.Name = "lblKetuaRT";
            this.lblKetuaRT.Size = new System.Drawing.Size(91, 15);
            this.lblKetuaRT.Text = "Nama Ketua RT";

            this.txtKetuaRT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtKetuaRT.Location = new System.Drawing.Point(27, 184);
            this.txtKetuaRT.Name = "txtKetuaRT";
            this.txtKetuaRT.Size = new System.Drawing.Size(400, 25);
            this.txtKetuaRT.TabIndex = 4;

            this.lblSekretaris.AutoSize = true;
            this.lblSekretaris.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSekretaris.Location = new System.Drawing.Point(464, 164);
            this.lblSekretaris.Name = "lblSekretaris";
            this.lblSekretaris.Size = new System.Drawing.Size(98, 15);
            this.lblSekretaris.Text = "Nama Sekretaris";

            this.txtSekretaris.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSekretaris.Location = new System.Drawing.Point(467, 184);
            this.txtSekretaris.Name = "txtSekretaris";
            this.txtSekretaris.Size = new System.Drawing.Size(400, 25);
            this.txtSekretaris.TabIndex = 5;

            this.btnSimpanProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.btnSimpanProfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpanProfil.FlatAppearance.BorderSize = 0;
            this.btnSimpanProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpanProfil.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSimpanProfil.ForeColor = System.Drawing.Color.White;
            this.btnSimpanProfil.Location = new System.Drawing.Point(27, 245);
            this.btnSimpanProfil.Name = "btnSimpanProfil";
            this.btnSimpanProfil.Size = new System.Drawing.Size(840, 44);
            this.btnSimpanProfil.TabIndex = 6;
            this.btnSimpanProfil.Text = "💾 SIMPAN PROFIL WILAYAH";
            this.btnSimpanProfil.UseVisualStyleBackColor = false;
            this.btnSimpanProfil.Click += new System.EventHandler(this.btnSimpanProfil_Click);

            // 
            // tabIuran
            // 
            this.tabIuran.BackColor = System.Drawing.Color.White;
            this.tabIuran.Controls.Add(this.pnlNoteIuran);
            this.tabIuran.Controls.Add(this.lblNominalIuran);
            this.tabIuran.Controls.Add(this.txtNominalIuran);
            this.tabIuran.Controls.Add(this.lblJatuhTempo);
            this.tabIuran.Controls.Add(this.nudJatuhTempo);
            this.tabIuran.Controls.Add(this.btnSimpanIuran);
            this.tabIuran.Location = new System.Drawing.Point(4, 40);
            this.tabIuran.Name = "tabIuran";
            this.tabIuran.Padding = new System.Windows.Forms.Padding(24);
            this.tabIuran.Size = new System.Drawing.Size(896, 490);
            this.tabIuran.TabIndex = 1;
            this.tabIuran.Text = "💰 Master Iuran";

            // Controls for Tab 2
            this.lblNominalIuran.AutoSize = true;
            this.lblNominalIuran.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNominalIuran.Location = new System.Drawing.Point(24, 24);
            this.lblNominalIuran.Name = "lblNominalIuran";
            this.lblNominalIuran.Size = new System.Drawing.Size(199, 15);
            this.lblNominalIuran.Text = "Nominal Iuran Wajib Bulanan (Rp)";

            this.txtNominalIuran.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNominalIuran.Location = new System.Drawing.Point(27, 46);
            this.txtNominalIuran.Name = "txtNominalIuran";
            this.txtNominalIuran.Size = new System.Drawing.Size(400, 25);
            this.txtNominalIuran.TabIndex = 0;

            this.lblJatuhTempo.AutoSize = true;
            this.lblJatuhTempo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblJatuhTempo.Location = new System.Drawing.Point(464, 24);
            this.lblJatuhTempo.Name = "lblJatuhTempo";
            this.lblJatuhTempo.Size = new System.Drawing.Size(232, 15);
            this.lblJatuhTempo.Text = "Tanggal Jatuh Tempo Pembayaran (Tgl)";

            this.nudJatuhTempo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudJatuhTempo.Location = new System.Drawing.Point(467, 46);
            this.nudJatuhTempo.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            this.nudJatuhTempo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudJatuhTempo.Name = "nudJatuhTempo";
            this.nudJatuhTempo.Size = new System.Drawing.Size(180, 25);
            this.nudJatuhTempo.TabIndex = 1;
            this.nudJatuhTempo.Value = new decimal(new int[] { 10, 0, 0, 0 });

            // pnlNoteIuran (Alert box)
            this.pnlNoteIuran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.pnlNoteIuran.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNoteIuran.Controls.Add(this.lblNoteIuran);
            this.pnlNoteIuran.Location = new System.Drawing.Point(27, 95);
            this.pnlNoteIuran.Name = "pnlNoteIuran";
            this.pnlNoteIuran.Size = new System.Drawing.Size(840, 50);
            this.pnlNoteIuran.TabIndex = 2;

            this.lblNoteIuran.AutoSize = true;
            this.lblNoteIuran.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblNoteIuran.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.lblNoteIuran.Location = new System.Drawing.Point(12, 16);
            this.lblNoteIuran.Name = "lblNoteIuran";
            this.lblNoteIuran.Size = new System.Drawing.Size(564, 15);
            this.lblNoteIuran.TabIndex = 0;
            this.lblNoteIuran.Text = "💡 Informasional: Nominal iuran ini akan dijadikan acuan otomatis saat warga melakukan pembayaran bulanan.";

            this.btnSimpanIuran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.btnSimpanIuran.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpanIuran.FlatAppearance.BorderSize = 0;
            this.btnSimpanIuran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpanIuran.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSimpanIuran.ForeColor = System.Drawing.Color.White;
            this.btnSimpanIuran.Location = new System.Drawing.Point(27, 165);
            this.btnSimpanIuran.Name = "btnSimpanIuran";
            this.btnSimpanIuran.Size = new System.Drawing.Size(620, 44);
            this.btnSimpanIuran.TabIndex = 3;
            this.btnSimpanIuran.Text = "💾 SIMPAN PENGATURAN IURAN";
            this.btnSimpanIuran.UseVisualStyleBackColor = false;
            this.btnSimpanIuran.Click += new System.EventHandler(this.btnSimpanIuran_Click);

            // 
            // tabUser
            // 
            this.tabUser.BackColor = System.Drawing.Color.White;
            this.tabUser.Controls.Add(this.pnlUserLeft);
            this.tabUser.Controls.Add(this.pnlUserRight);
            this.tabUser.Location = new System.Drawing.Point(4, 40);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(16);
            this.tabUser.Size = new System.Drawing.Size(896, 490);
            this.tabUser.TabIndex = 2;
            this.tabUser.Text = "👥 Manajemen Pengguna";

            // pnlUserLeft (DataGridView List)
            this.pnlUserLeft.Controls.Add(this.dgvUser);
            this.pnlUserLeft.Controls.Add(this.lblUserListTitle);
            this.pnlUserLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlUserLeft.Location = new System.Drawing.Point(16, 16);
            this.pnlUserLeft.Name = "pnlUserLeft";
            this.pnlUserLeft.Size = new System.Drawing.Size(480, 458);
            this.pnlUserLeft.TabIndex = 0;

            this.lblUserListTitle.AutoSize = true;
            this.lblUserListTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblUserListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.lblUserListTitle.Location = new System.Drawing.Point(0, 0);
            this.lblUserListTitle.Name = "lblUserListTitle";
            this.lblUserListTitle.Size = new System.Drawing.Size(176, 17);
            this.lblUserListTitle.TabIndex = 0;
            this.lblUserListTitle.Text = "📊 Daftar Akun Pengguna";

            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.BackgroundColor = System.Drawing.Color.White;
            this.dgvUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;

            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUser.ColumnHeadersHeight = 34;

            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUser.DefaultCellStyle = dataGridViewCellStyle2;

            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;

            this.dgvUser.EnableHeadersVisualStyles = false;
            this.dgvUser.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvUser.Location = new System.Drawing.Point(0, 24);
            this.dgvUser.MultiSelect = false;
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.RowHeadersVisible = false;
            this.dgvUser.RowTemplate.Height = 32;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new System.Drawing.Size(470, 420);
            this.dgvUser.TabIndex = 1;

            // pnlUserRight (Add User Form)
            this.pnlUserRight.Controls.Add(this.lblUserFormTitle);
            this.pnlUserRight.Controls.Add(this.lblNewUser);
            this.pnlUserRight.Controls.Add(this.txtNewUser);
            this.pnlUserRight.Controls.Add(this.lblNewPass);
            this.pnlUserRight.Controls.Add(this.txtNewPass);
            this.pnlUserRight.Controls.Add(this.lblNewLevel);
            this.pnlUserRight.Controls.Add(this.cboNewLevel);
            this.pnlUserRight.Controls.Add(this.btnTambahUser);
            this.pnlUserRight.Controls.Add(this.btnHapusUser);
            this.pnlUserRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlUserRight.Location = new System.Drawing.Point(510, 16);
            this.pnlUserRight.Name = "pnlUserRight";
            this.pnlUserRight.Size = new System.Drawing.Size(370, 458);
            this.pnlUserRight.TabIndex = 1;

            this.lblUserFormTitle.AutoSize = true;
            this.lblUserFormTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblUserFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.lblUserFormTitle.Location = new System.Drawing.Point(0, 0);
            this.lblUserFormTitle.Name = "lblUserFormTitle";
            this.lblUserFormTitle.Size = new System.Drawing.Size(163, 17);
            this.lblUserFormTitle.TabIndex = 0;
            this.lblUserFormTitle.Text = "➕ Form Tambah User";

            this.lblNewUser.AutoSize = true;
            this.lblNewUser.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblNewUser.Location = new System.Drawing.Point(0, 30);
            this.lblNewUser.Name = "lblNewUser";
            this.lblNewUser.Size = new System.Drawing.Size(92, 15);
            this.lblNewUser.TabIndex = 1;
            this.lblNewUser.Text = "Username Baru";

            this.txtNewUser.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNewUser.Location = new System.Drawing.Point(3, 48);
            this.txtNewUser.Name = "txtNewUser";
            this.txtNewUser.Size = new System.Drawing.Size(350, 24);
            this.txtNewUser.TabIndex = 2;

            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblNewPass.Location = new System.Drawing.Point(0, 84);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(59, 15);
            this.lblNewPass.TabIndex = 3;
            this.lblNewPass.Text = "Password";

            this.txtNewPass.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNewPass.Location = new System.Drawing.Point(3, 102);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(350, 24);
            this.txtNewPass.TabIndex = 4;

            this.lblNewLevel.AutoSize = true;
            this.lblNewLevel.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblNewLevel.Location = new System.Drawing.Point(0, 138);
            this.lblNewLevel.Name = "lblNewLevel";
            this.lblNewLevel.Size = new System.Drawing.Size(102, 15);
            this.lblNewLevel.TabIndex = 5;
            this.lblNewLevel.Text = "Hak Akses / Role";

            this.cboNewLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNewLevel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboNewLevel.FormattingEnabled = true;
            this.cboNewLevel.Items.AddRange(new object[] {
            "Administrator",
            "Operator",
            "Ketua RT"});
            this.cboNewLevel.Location = new System.Drawing.Point(3, 156);
            this.cboNewLevel.Name = "cboNewLevel";
            this.cboNewLevel.Size = new System.Drawing.Size(350, 24);
            this.cboNewLevel.TabIndex = 6;

            this.btnTambahUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.btnTambahUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambahUser.FlatAppearance.BorderSize = 0;
            this.btnTambahUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahUser.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTambahUser.ForeColor = System.Drawing.Color.White;
            this.btnTambahUser.Location = new System.Drawing.Point(3, 204);
            this.btnTambahUser.Name = "btnTambahUser";
            this.btnTambahUser.Size = new System.Drawing.Size(350, 42);
            this.btnTambahUser.TabIndex = 7;
            this.btnTambahUser.Text = "➕ TAMBAH PENGGUNA BARU";
            this.btnTambahUser.UseVisualStyleBackColor = false;
            this.btnTambahUser.Click += new System.EventHandler(this.btnTambahUser_Click);

            this.btnHapusUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnHapusUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapusUser.FlatAppearance.BorderSize = 0;
            this.btnHapusUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapusUser.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnHapusUser.ForeColor = System.Drawing.Color.White;
            this.btnHapusUser.Location = new System.Drawing.Point(3, 258);
            this.btnHapusUser.Name = "btnHapusUser";
            this.btnHapusUser.Size = new System.Drawing.Size(350, 42);
            this.btnHapusUser.TabIndex = 8;
            this.btnHapusUser.Text = "🗑️ HAPUS AKUN TERPILIH";
            this.btnHapusUser.UseVisualStyleBackColor = false;
            this.btnHapusUser.Click += new System.EventHandler(this.btnHapusUser_Click);

            // 
            // tabDatabase
            // 
            this.tabDatabase.BackColor = System.Drawing.Color.White;
            this.tabDatabase.Controls.Add(this.pnlDbStatus);
            this.tabDatabase.Controls.Add(this.lblDbServer);
            this.tabDatabase.Controls.Add(this.txtDbServer);
            this.tabDatabase.Controls.Add(this.lblDbName);
            this.tabDatabase.Controls.Add(this.txtDbName);
            this.tabDatabase.Controls.Add(this.btnTesKoneksi);
            this.tabDatabase.Controls.Add(this.btnBackupDB);
            this.tabDatabase.Location = new System.Drawing.Point(4, 40);
            this.tabDatabase.Name = "tabDatabase";
            this.tabDatabase.Padding = new System.Windows.Forms.Padding(24);
            this.tabDatabase.Size = new System.Drawing.Size(896, 490);
            this.tabDatabase.TabIndex = 3;
            this.tabDatabase.Text = "💾 Database & Backup";

            // pnlDbStatus
            this.pnlDbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.pnlDbStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDbStatus.Controls.Add(this.lblDbInfo);
            this.pnlDbStatus.Location = new System.Drawing.Point(24, 20);
            this.pnlDbStatus.Name = "pnlDbStatus";
            this.pnlDbStatus.Size = new System.Drawing.Size(840, 46);
            this.pnlDbStatus.TabIndex = 0;

            this.lblDbInfo.AutoSize = true;
            this.lblDbInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDbInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.lblDbInfo.Location = new System.Drawing.Point(12, 13);
            this.lblDbInfo.Name = "lblDbInfo";
            this.lblDbInfo.Size = new System.Drawing.Size(395, 17);
            this.lblDbInfo.TabIndex = 0;
            this.lblDbInfo.Text = "⚡ Status Database: BERHASIL TERHUBUNG (SQL Server Express)";

            this.lblDbServer.AutoSize = true;
            this.lblDbServer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDbServer.Location = new System.Drawing.Point(24, 85);
            this.lblDbServer.Name = "lblDbServer";
            this.lblDbServer.Size = new System.Drawing.Size(147, 15);
            this.lblDbServer.TabIndex = 1;
            this.lblDbServer.Text = "Data Source / Server SQL";

            this.txtDbServer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDbServer.Location = new System.Drawing.Point(27, 105);
            this.txtDbServer.Name = "txtDbServer";
            this.txtDbServer.ReadOnly = true;
            this.txtDbServer.Size = new System.Drawing.Size(400, 25);
            this.txtDbServer.TabIndex = 2;
            this.txtDbServer.Text = ".\\SQLEXPRESS";

            this.lblDbName.AutoSize = true;
            this.lblDbName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDbName.Location = new System.Drawing.Point(464, 85);
            this.lblDbName.Name = "lblDbName";
            this.lblDbName.Size = new System.Drawing.Size(95, 15);
            this.lblDbName.TabIndex = 3;
            this.lblDbName.Text = "Database Name";

            this.txtDbName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDbName.Location = new System.Drawing.Point(467, 105);
            this.txtDbName.Name = "txtDbName";
            this.txtDbName.ReadOnly = true;
            this.txtDbName.Size = new System.Drawing.Size(400, 25);
            this.txtDbName.TabIndex = 4;
            this.txtDbName.Text = "DB_RTRW";

            this.btnTesKoneksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnTesKoneksi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTesKoneksi.FlatAppearance.BorderSize = 0;
            this.btnTesKoneksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTesKoneksi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTesKoneksi.ForeColor = System.Drawing.Color.White;
            this.btnTesKoneksi.Location = new System.Drawing.Point(27, 155);
            this.btnTesKoneksi.Name = "btnTesKoneksi";
            this.btnTesKoneksi.Size = new System.Drawing.Size(400, 44);
            this.btnTesKoneksi.TabIndex = 5;
            this.btnTesKoneksi.Text = "⚡ UJI KONEKSI DATABASE";
            this.btnTesKoneksi.UseVisualStyleBackColor = false;
            this.btnTesKoneksi.Click += new System.EventHandler(this.btnTesKoneksi_Click);

            this.btnBackupDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.btnBackupDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackupDB.FlatAppearance.BorderSize = 0;
            this.btnBackupDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackupDB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBackupDB.ForeColor = System.Drawing.Color.White;
            this.btnBackupDB.Location = new System.Drawing.Point(467, 155);
            this.btnBackupDB.Name = "btnBackupDB";
            this.btnBackupDB.Size = new System.Drawing.Size(400, 44);
            this.btnBackupDB.TabIndex = 6;
            this.btnBackupDB.Text = "💾 BACKUP DATABASE SEKARANG (.BAK)";
            this.btnBackupDB.UseVisualStyleBackColor = false;
            this.btnBackupDB.Click += new System.EventHandler(this.btnBackupDB_Click);

            // 
            // frmPengaturan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(960, 650);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTopHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPengaturan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pengaturan Sistem";
            this.Load += new System.EventHandler(this.frmPengaturan_Load);
            this.pnlTopHeader.ResumeLayout(false);
            this.pnlTopHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlSettingsCard.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabProfil.ResumeLayout(false);
            this.tabProfil.PerformLayout();
            this.tabIuran.ResumeLayout(false);
            this.tabIuran.PerformLayout();
            this.pnlNoteIuran.ResumeLayout(false);
            this.pnlNoteIuran.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudJatuhTempo)).EndInit();
            this.tabUser.ResumeLayout(false);
            this.pnlUserRight.ResumeLayout(false);
            this.pnlUserRight.PerformLayout();
            this.pnlUserLeft.ResumeLayout(false);
            this.pnlUserLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.tabDatabase.ResumeLayout(false);
            this.tabDatabase.PerformLayout();
            this.pnlDbStatus.ResumeLayout(false);
            this.pnlDbStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSub;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlSettingsCard;
        private System.Windows.Forms.TabControl tabSettings;

        private System.Windows.Forms.TabPage tabProfil;
        private System.Windows.Forms.Label lblNamaRTRW;
        private System.Windows.Forms.TextBox txtNamaRTRW;
        private System.Windows.Forms.Label lblDesa;
        private System.Windows.Forms.TextBox txtDesa;
        private System.Windows.Forms.Label lblKecamatan;
        private System.Windows.Forms.TextBox txtKecamatan;
        private System.Windows.Forms.Label lblKota;
        private System.Windows.Forms.TextBox txtKota;
        private System.Windows.Forms.Label lblKetuaRT;
        private System.Windows.Forms.TextBox txtKetuaRT;
        private System.Windows.Forms.Label lblSekretaris;
        private System.Windows.Forms.TextBox txtSekretaris;
        private System.Windows.Forms.Button btnSimpanProfil;

        private System.Windows.Forms.TabPage tabIuran;
        private System.Windows.Forms.Label lblNominalIuran;
        private System.Windows.Forms.TextBox txtNominalIuran;
        private System.Windows.Forms.Label lblJatuhTempo;
        private System.Windows.Forms.NumericUpDown nudJatuhTempo;
        private System.Windows.Forms.Panel pnlNoteIuran;
        private System.Windows.Forms.Label lblNoteIuran;
        private System.Windows.Forms.Button btnSimpanIuran;

        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.Panel pnlUserLeft;
        private System.Windows.Forms.Label lblUserListTitle;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Panel pnlUserRight;
        private System.Windows.Forms.Label lblUserFormTitle;
        private System.Windows.Forms.Label lblNewUser;
        private System.Windows.Forms.TextBox txtNewUser;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label lblNewLevel;
        private System.Windows.Forms.ComboBox cboNewLevel;
        private System.Windows.Forms.Button btnTambahUser;
        private System.Windows.Forms.Button btnHapusUser;

        private System.Windows.Forms.TabPage tabDatabase;
        private System.Windows.Forms.Panel pnlDbStatus;
        private System.Windows.Forms.Label lblDbInfo;
        private System.Windows.Forms.Label lblDbServer;
        private System.Windows.Forms.TextBox txtDbServer;
        private System.Windows.Forms.Label lblDbName;
        private System.Windows.Forms.TextBox txtDbName;
        private System.Windows.Forms.Button btnTesKoneksi;
        private System.Windows.Forms.Button btnBackupDB;
    }
}
