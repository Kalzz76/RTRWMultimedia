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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.tabSettings = new System.Windows.Forms.TabControl();
            
            // Tab 1: Profil Wilayah
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

            // Tab 2: Master Iuran
            this.tabIuran = new System.Windows.Forms.TabPage();
            this.lblNominalIuran = new System.Windows.Forms.Label();
            this.txtNominalIuran = new System.Windows.Forms.TextBox();
            this.lblJatuhTempo = new System.Windows.Forms.Label();
            this.nudJatuhTempo = new System.Windows.Forms.NumericUpDown();
            this.lblNoteIuran = new System.Windows.Forms.Label();
            this.btnSimpanIuran = new System.Windows.Forms.Button();

            // Tab 3: Manajemen User
            this.tabUser = new System.Windows.Forms.TabPage();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.lblNewUser = new System.Windows.Forms.Label();
            this.txtNewUser = new System.Windows.Forms.TextBox();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.lblNewLevel = new System.Windows.Forms.Label();
            this.cboNewLevel = new System.Windows.Forms.ComboBox();
            this.btnTambahUser = new System.Windows.Forms.Button();
            this.btnHapusUser = new System.Windows.Forms.Button();

            // Tab 4: Database & Backup
            this.tabDatabase = new System.Windows.Forms.TabPage();
            this.lblDbInfo = new System.Windows.Forms.Label();
            this.lblDbServer = new System.Windows.Forms.Label();
            this.txtDbServer = new System.Windows.Forms.TextBox();
            this.lblDbName = new System.Windows.Forms.Label();
            this.txtDbName = new System.Windows.Forms.TextBox();
            this.btnTesKoneksi = new System.Windows.Forms.Button();
            this.btnBackupDB = new System.Windows.Forms.Button();

            // Form Footer Buttons
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnTutup = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabProfil.SuspendLayout();
            this.tabIuran.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudJatuhTempo)).BeginInit();
            this.tabUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.tabDatabase.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(780, 80);
            this.pnlHeader.TabIndex = 0;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(306, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "⚙️ PENGATURAN SISTEM RT/RW";

            // lblSubtitle
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.lblSubtitle.Location = new System.Drawing.Point(23, 46);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(434, 15);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Konfigurasi Identitas Wilayah, Master Iuran, Manajemen Pengguna & Database SQL";

            // tabSettings
            this.tabSettings.Controls.Add(this.tabProfil);
            this.tabSettings.Controls.Add(this.tabIuran);
            this.tabSettings.Controls.Add(this.tabUser);
            this.tabSettings.Controls.Add(this.tabDatabase);
            this.tabSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSettings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSettings.Location = new System.Drawing.Point(0, 80);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(780, 420);
            this.tabSettings.TabIndex = 1;

            // ==================== TAB 1: PROFIL WILAYAH ====================
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
            this.tabProfil.Location = new System.Drawing.Point(4, 26);
            this.tabProfil.Name = "tabProfil";
            this.tabProfil.Padding = new System.Windows.Forms.Padding(20);
            this.tabProfil.Size = new System.Drawing.Size(772, 390);
            this.tabProfil.TabIndex = 0;
            this.tabProfil.Text = " 🏡 Identitas RT/RW ";

            // Controls for Tab 1
            this.lblNamaRTRW.AutoSize = true;
            this.lblNamaRTRW.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNamaRTRW.Location = new System.Drawing.Point(25, 25);
            this.lblNamaRTRW.Text = "Nama RT / RW";
            this.txtNamaRTRW.Location = new System.Drawing.Point(28, 45);
            this.txtNamaRTRW.Size = new System.Drawing.Size(330, 25);

            this.lblDesa.AutoSize = true;
            this.lblDesa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDesa.Location = new System.Drawing.Point(390, 25);
            this.lblDesa.Text = "Desa / Kelurahan";
            this.txtDesa.Location = new System.Drawing.Point(393, 45);
            this.txtDesa.Size = new System.Drawing.Size(330, 25);

            this.lblKecamatan.AutoSize = true;
            this.lblKecamatan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKecamatan.Location = new System.Drawing.Point(25, 95);
            this.lblKecamatan.Text = "Kecamatan";
            this.txtKecamatan.Location = new System.Drawing.Point(28, 115);
            this.txtKecamatan.Size = new System.Drawing.Size(330, 25);

            this.lblKota.AutoSize = true;
            this.lblKota.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKota.Location = new System.Drawing.Point(390, 95);
            this.lblKota.Text = "Kota / Kabupaten";
            this.txtKota.Location = new System.Drawing.Point(393, 115);
            this.txtKota.Size = new System.Drawing.Size(330, 25);

            this.lblKetuaRT.AutoSize = true;
            this.lblKetuaRT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKetuaRT.Location = new System.Drawing.Point(25, 165);
            this.lblKetuaRT.Text = "Nama Ketua RT";
            this.txtKetuaRT.Location = new System.Drawing.Point(28, 185);
            this.txtKetuaRT.Size = new System.Drawing.Size(330, 25);

            this.lblSekretaris.AutoSize = true;
            this.lblSekretaris.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSekretaris.Location = new System.Drawing.Point(390, 165);
            this.lblSekretaris.Text = "Nama Sekretaris";
            this.txtSekretaris.Location = new System.Drawing.Point(393, 185);
            this.txtSekretaris.Size = new System.Drawing.Size(330, 25);

            this.btnSimpanProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.btnSimpanProfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpanProfil.FlatAppearance.BorderSize = 0;
            this.btnSimpanProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpanProfil.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSimpanProfil.ForeColor = System.Drawing.Color.White;
            this.btnSimpanProfil.Location = new System.Drawing.Point(28, 245);
            this.btnSimpanProfil.Size = new System.Drawing.Size(695, 42);
            this.btnSimpanProfil.Text = "💾 SIMPAN PROFIL WILAYAH";
            this.btnSimpanProfil.UseVisualStyleBackColor = false;
            this.btnSimpanProfil.Click += new System.EventHandler(this.btnSimpanProfil_Click);

            // ==================== TAB 2: MASTER IURAN ====================
            this.tabIuran.BackColor = System.Drawing.Color.White;
            this.tabIuran.Controls.Add(this.lblNominalIuran);
            this.tabIuran.Controls.Add(this.txtNominalIuran);
            this.tabIuran.Controls.Add(this.lblJatuhTempo);
            this.tabIuran.Controls.Add(this.nudJatuhTempo);
            this.tabIuran.Controls.Add(this.lblNoteIuran);
            this.tabIuran.Controls.Add(this.btnSimpanIuran);
            this.tabIuran.Location = new System.Drawing.Point(4, 26);
            this.tabIuran.Name = "tabIuran";
            this.tabIuran.Padding = new System.Windows.Forms.Padding(20);
            this.tabIuran.Size = new System.Drawing.Size(772, 390);
            this.tabIuran.TabIndex = 1;
            this.tabIuran.Text = " 💰 Master Iuran ";

            // Controls for Tab 2
            this.lblNominalIuran.AutoSize = true;
            this.lblNominalIuran.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNominalIuran.Location = new System.Drawing.Point(25, 30);
            this.lblNominalIuran.Text = "Nominal Iuran Wajib Bulanan (Rp)";
            this.txtNominalIuran.Location = new System.Drawing.Point(28, 52);
            this.txtNominalIuran.Size = new System.Drawing.Size(330, 25);

            this.lblJatuhTempo.AutoSize = true;
            this.lblJatuhTempo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblJatuhTempo.Location = new System.Drawing.Point(390, 30);
            this.lblJatuhTempo.Text = "Tanggal Jatuh Tempo Pembayaran (Tgl)";
            this.nudJatuhTempo.Location = new System.Drawing.Point(393, 52);
            this.nudJatuhTempo.Size = new System.Drawing.Size(150, 25);
            this.nudJatuhTempo.Minimum = 1;
            this.nudJatuhTempo.Maximum = 31;
            this.nudJatuhTempo.Value = 10;

            this.lblNoteIuran.AutoSize = true;
            this.lblNoteIuran.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblNoteIuran.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblNoteIuran.Location = new System.Drawing.Point(25, 105);
            this.lblNoteIuran.Text = "📌 Catatan: Nominal ini akan dijadikan nilai acuan saat warga melakukan pembayaran iuran bulanan.";

            this.btnSimpanIuran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.btnSimpanIuran.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpanIuran.FlatAppearance.BorderSize = 0;
            this.btnSimpanIuran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpanIuran.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSimpanIuran.ForeColor = System.Drawing.Color.White;
            this.btnSimpanIuran.Location = new System.Drawing.Point(28, 160);
            this.btnSimpanIuran.Size = new System.Drawing.Size(515, 42);
            this.btnSimpanIuran.Text = "💾 SIMPAN PENGATURAN IURAN";
            this.btnSimpanIuran.UseVisualStyleBackColor = false;
            this.btnSimpanIuran.Click += new System.EventHandler(this.btnSimpanIuran_Click);

            // ==================== TAB 3: MANAJEMEN USER ====================
            this.tabUser.BackColor = System.Drawing.Color.White;
            this.tabUser.Controls.Add(this.dgvUser);
            this.tabUser.Controls.Add(this.lblNewUser);
            this.tabUser.Controls.Add(this.txtNewUser);
            this.tabUser.Controls.Add(this.lblNewPass);
            this.tabUser.Controls.Add(this.txtNewPass);
            this.tabUser.Controls.Add(this.lblNewLevel);
            this.tabUser.Controls.Add(this.cboNewLevel);
            this.tabUser.Controls.Add(this.btnTambahUser);
            this.tabUser.Controls.Add(this.btnHapusUser);
            this.tabUser.Location = new System.Drawing.Point(4, 26);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(15);
            this.tabUser.Size = new System.Drawing.Size(772, 390);
            this.tabUser.TabIndex = 2;
            this.tabUser.Text = " 👥 Manajemen Pengguna ";

            // dgvUser
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.dgvUser.Location = new System.Drawing.Point(15, 15);
            this.dgvUser.MultiSelect = false;
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new System.Drawing.Size(430, 290);
            this.dgvUser.TabIndex = 0;

            // Form inputs on right side of Tab 3
            this.lblNewUser.AutoSize = true;
            this.lblNewUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNewUser.Location = new System.Drawing.Point(460, 15);
            this.lblNewUser.Text = "Username Baru";
            this.txtNewUser.Location = new System.Drawing.Point(463, 35);
            this.txtNewUser.Size = new System.Drawing.Size(280, 25);

            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNewPass.Location = new System.Drawing.Point(460, 75);
            this.lblNewPass.Text = "Password";
            this.txtNewPass.Location = new System.Drawing.Point(463, 95);
            this.txtNewPass.Size = new System.Drawing.Size(280, 25);

            this.lblNewLevel.AutoSize = true;
            this.lblNewLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNewLevel.Location = new System.Drawing.Point(460, 135);
            this.lblNewLevel.Text = "Hak Akses / Role";
            this.cboNewLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNewLevel.Items.AddRange(new object[] { "Administrator", "Operator", "Ketua RT" });
            this.cboNewLevel.Location = new System.Drawing.Point(463, 155);
            this.cboNewLevel.Size = new System.Drawing.Size(280, 25);

            this.btnTambahUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.btnTambahUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambahUser.FlatAppearance.BorderSize = 0;
            this.btnTambahUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahUser.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTambahUser.ForeColor = System.Drawing.Color.White;
            this.btnTambahUser.Location = new System.Drawing.Point(463, 205);
            this.btnTambahUser.Size = new System.Drawing.Size(280, 40);
            this.btnTambahUser.Text = "➕ TAMBAH USER";
            this.btnTambahUser.UseVisualStyleBackColor = false;
            this.btnTambahUser.Click += new System.EventHandler(this.btnTambahUser_Click);

            this.btnHapusUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnHapusUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapusUser.FlatAppearance.BorderSize = 0;
            this.btnHapusUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapusUser.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnHapusUser.ForeColor = System.Drawing.Color.White;
            this.btnHapusUser.Location = new System.Drawing.Point(463, 255);
            this.btnHapusUser.Size = new System.Drawing.Size(280, 40);
            this.btnHapusUser.Text = "🗑️ HAPUS USER TERPILIH";
            this.btnHapusUser.UseVisualStyleBackColor = false;
            this.btnHapusUser.Click += new System.EventHandler(this.btnHapusUser_Click);

            // ==================== TAB 4: DATABASE & BACKUP ====================
            this.tabDatabase.BackColor = System.Drawing.Color.White;
            this.tabDatabase.Controls.Add(this.lblDbInfo);
            this.tabDatabase.Controls.Add(this.lblDbServer);
            this.tabDatabase.Controls.Add(this.txtDbServer);
            this.tabDatabase.Controls.Add(this.lblDbName);
            this.tabDatabase.Controls.Add(this.txtDbName);
            this.tabDatabase.Controls.Add(this.btnTesKoneksi);
            this.tabDatabase.Controls.Add(this.btnBackupDB);
            this.tabDatabase.Location = new System.Drawing.Point(4, 26);
            this.tabDatabase.Name = "tabDatabase";
            this.tabDatabase.Padding = new System.Windows.Forms.Padding(20);
            this.tabDatabase.Size = new System.Drawing.Size(772, 390);
            this.tabDatabase.TabIndex = 3;
            this.tabDatabase.Text = " 💾 Database & Backup ";

            // Controls for Tab 4
            this.lblDbInfo.AutoSize = true;
            this.lblDbInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDbInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.lblDbInfo.Location = new System.Drawing.Point(25, 20);
            this.lblDbInfo.Text = "Status Koneksi SQL Server: TERHUBUNG (DB_RTRW)";

            this.lblDbServer.AutoSize = true;
            this.lblDbServer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDbServer.Location = new System.Drawing.Point(25, 60);
            this.lblDbServer.Text = "Data Source / Server SQL";
            this.txtDbServer.Location = new System.Drawing.Point(28, 80);
            this.txtDbServer.Size = new System.Drawing.Size(330, 25);
            this.txtDbServer.Text = ".\\SQLEXPRESS";
            this.txtDbServer.ReadOnly = true;

            this.lblDbName.AutoSize = true;
            this.lblDbName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDbName.Location = new System.Drawing.Point(390, 60);
            this.lblDbName.Text = "Database Name";
            this.txtDbName.Location = new System.Drawing.Point(393, 80);
            this.txtDbName.Size = new System.Drawing.Size(330, 25);
            this.txtDbName.Text = "DB_RTRW";
            this.txtDbName.ReadOnly = true;

            this.btnTesKoneksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnTesKoneksi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTesKoneksi.FlatAppearance.BorderSize = 0;
            this.btnTesKoneksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTesKoneksi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTesKoneksi.ForeColor = System.Drawing.Color.White;
            this.btnTesKoneksi.Location = new System.Drawing.Point(28, 140);
            this.btnTesKoneksi.Size = new System.Drawing.Size(330, 42);
            this.btnTesKoneksi.Text = "⚡ UJI KONEKSI DATABASE";
            this.btnTesKoneksi.UseVisualStyleBackColor = false;
            this.btnTesKoneksi.Click += new System.EventHandler(this.btnTesKoneksi_Click);

            this.btnBackupDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.btnBackupDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackupDB.FlatAppearance.BorderSize = 0;
            this.btnBackupDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackupDB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBackupDB.ForeColor = System.Drawing.Color.White;
            this.btnBackupDB.Location = new System.Drawing.Point(393, 140);
            this.btnBackupDB.Size = new System.Drawing.Size(330, 42);
            this.btnBackupDB.Text = "💾 BACKUP DATABASE SEKARANG";
            this.btnBackupDB.UseVisualStyleBackColor = false;
            this.btnBackupDB.Click += new System.EventHandler(this.btnBackupDB_Click);

            // pnlFooter
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlFooter.Controls.Add(this.btnTutup);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 500);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(780, 60);
            this.pnlFooter.TabIndex = 2;

            // btnTutup
            this.btnTutup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnTutup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTutup.FlatAppearance.BorderSize = 0;
            this.btnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTutup.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTutup.ForeColor = System.Drawing.Color.White;
            this.btnTutup.Location = new System.Drawing.Point(630, 10);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(130, 40);
            this.btnTutup.TabIndex = 0;
            this.btnTutup.Text = "✖ TUTUP";
            this.btnTutup.UseVisualStyleBackColor = false;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);

            // 
            // frmPengaturan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 560);
            this.Controls.Add(this.tabSettings);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmPengaturan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pengaturan Sistem RT/RW";
            this.Load += new System.EventHandler(this.frmPengaturan_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabProfil.ResumeLayout(false);
            this.tabProfil.PerformLayout();
            this.tabIuran.ResumeLayout(false);
            this.tabIuran.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudJatuhTempo)).EndInit();
            this.tabUser.ResumeLayout(false);
            this.tabUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.tabDatabase.ResumeLayout(false);
            this.tabDatabase.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
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
        private System.Windows.Forms.Label lblNoteIuran;
        private System.Windows.Forms.Button btnSimpanIuran;

        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Label lblNewUser;
        private System.Windows.Forms.TextBox txtNewUser;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label lblNewLevel;
        private System.Windows.Forms.ComboBox cboNewLevel;
        private System.Windows.Forms.Button btnTambahUser;
        private System.Windows.Forms.Button btnHapusUser;

        private System.Windows.Forms.TabPage tabDatabase;
        private System.Windows.Forms.Label lblDbInfo;
        private System.Windows.Forms.Label lblDbServer;
        private System.Windows.Forms.TextBox txtDbServer;
        private System.Windows.Forms.Label lblDbName;
        private System.Windows.Forms.TextBox txtDbName;
        private System.Windows.Forms.Button btnTesKoneksi;
        private System.Windows.Forms.Button btnBackupDB;

        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnTutup;
    }
}
