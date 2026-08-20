namespace RTRWMultimedia
{
    partial class frmPengumuman
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
            this.dgvPengumuman = new System.Windows.Forms.DataGridView();
            this.pnlSearchHeader = new System.Windows.Forms.Panel();
            this.lblTableTitle = new System.Windows.Forms.Label();
            this.lblTotalPengumuman = new System.Windows.Forms.Label();
            this.lblCari = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.pnlInputCard = new System.Windows.Forms.Panel();
            this.lblCardInputTitle = new System.Windows.Forms.Label();
            this.lblJudul = new System.Windows.Forms.Label();
            this.txtJudul = new System.Windows.Forms.TextBox();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.dtpTanggalPosting = new System.Windows.Forms.DateTimePicker();
            this.lblIsi = new System.Windows.Forms.Label();
            this.txtIsi = new System.Windows.Forms.TextBox();
            this.flpActions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.pnlTopHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlTableCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengumuman)).BeginInit();
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
            this.lblHeaderTitle.Size = new System.Drawing.Size(380, 25);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "📢 PENGUMUMAN & INFORMASI WARGA";
            // 
            // lblHeaderSub
            // 
            this.lblHeaderSub.AutoSize = true;
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblHeaderSub.Location = new System.Drawing.Point(23, 35);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Size = new System.Drawing.Size(435, 15);
            this.lblHeaderSub.TabIndex = 1;
            this.lblHeaderSub.Text = "Modul Publikasi & Pengelolaan Pengumuman RT 04 / RW 02 (Tambah, Edit, Hapus, Cari" +
    ")";
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
            this.pnlTableCard.Controls.Add(this.dgvPengumuman);
            this.pnlTableCard.Controls.Add(this.pnlSearchHeader);
            this.pnlTableCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTableCard.Location = new System.Drawing.Point(16, 217);
            this.pnlTableCard.Margin = new System.Windows.Forms.Padding(0, 16, 0, 0);
            this.pnlTableCard.Name = "pnlTableCard";
            this.pnlTableCard.Padding = new System.Windows.Forms.Padding(12);
            this.pnlTableCard.Size = new System.Drawing.Size(928, 357);
            this.pnlTableCard.TabIndex = 1;
            // 
            // dgvPengumuman
            // 
            this.dgvPengumuman.AllowUserToAddRows = false;
            this.dgvPengumuman.AllowUserToDeleteRows = false;
            this.dgvPengumuman.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPengumuman.BackgroundColor = System.Drawing.Color.White;
            this.dgvPengumuman.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPengumuman.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPengumuman.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPengumuman.ColumnHeadersHeight = 36;
            this.dgvPengumuman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPengumuman.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvPengumuman.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPengumuman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPengumuman.EnableHeadersVisualStyles = false;
            this.dgvPengumuman.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvPengumuman.Location = new System.Drawing.Point(12, 52);
            this.dgvPengumuman.MultiSelect = false;
            this.dgvPengumuman.Name = "dgvPengumuman";
            this.dgvPengumuman.ReadOnly = true;
            this.dgvPengumuman.RowHeadersVisible = false;
            this.dgvPengumuman.RowTemplate.Height = 36;
            this.dgvPengumuman.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPengumuman.Size = new System.Drawing.Size(904, 293);
            this.dgvPengumuman.TabIndex = 1;
            this.dgvPengumuman.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPengumuman_CellClick);
            // 
            // pnlSearchHeader
            // 
            this.pnlSearchHeader.Controls.Add(this.lblTableTitle);
            this.pnlSearchHeader.Controls.Add(this.lblTotalPengumuman);
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
            this.lblTableTitle.Text = "📋 Rekap Pengumuman";
            // 
            // lblTotalPengumuman
            // 
            this.lblTotalPengumuman.AutoSize = true;
            this.lblTotalPengumuman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.lblTotalPengumuman.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalPengumuman.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalPengumuman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.lblTotalPengumuman.Location = new System.Drawing.Point(180, 7);
            this.lblTotalPengumuman.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblTotalPengumuman.Name = "lblTotalPengumuman";
            this.lblTotalPengumuman.Size = new System.Drawing.Size(130, 25);
            this.lblTotalPengumuman.TabIndex = 1;
            this.lblTotalPengumuman.Text = "📢 Total: 0 Berita";
            // 
            // lblCari
            // 
            this.lblCari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCari.AutoSize = true;
            this.lblCari.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCari.Location = new System.Drawing.Point(620, 12);
            this.lblCari.Name = "lblCari";
            this.lblCari.Size = new System.Drawing.Size(76, 15);
            this.lblCari.TabIndex = 2;
            this.lblCari.Text = "🔍 Cari Judul:";
            // 
            // txtCari
            // 
            this.txtCari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCari.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCari.Location = new System.Drawing.Point(704, 8);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(198, 24);
            this.txtCari.TabIndex = 3;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // pnlInputCard
            // 
            this.pnlInputCard.BackColor = System.Drawing.Color.White;
            this.pnlInputCard.Controls.Add(this.lblCardInputTitle);
            this.pnlInputCard.Controls.Add(this.lblJudul);
            this.pnlInputCard.Controls.Add(this.txtJudul);
            this.pnlInputCard.Controls.Add(this.lblTanggal);
            this.pnlInputCard.Controls.Add(this.dtpTanggalPosting);
            this.pnlInputCard.Controls.Add(this.lblIsi);
            this.pnlInputCard.Controls.Add(this.txtIsi);
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
            this.lblCardInputTitle.Size = new System.Drawing.Size(243, 19);
            this.lblCardInputTitle.TabIndex = 0;
            this.lblCardInputTitle.Text = "✏️ Form Buat / Edit Pengumuman";
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblJudul.Location = new System.Drawing.Point(15, 38);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(109, 15);
            this.lblJudul.TabIndex = 1;
            this.lblJudul.Text = "Judul Pengumuman";
            // 
            // txtJudul
            // 
            this.txtJudul.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtJudul.Location = new System.Drawing.Point(18, 56);
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.Size = new System.Drawing.Size(420, 24);
            this.txtJudul.TabIndex = 2;
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblTanggal.Location = new System.Drawing.Point(455, 38);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(89, 15);
            this.lblTanggal.TabIndex = 3;
            this.lblTanggal.Text = "Tanggal Terbit";
            // 
            // dtpTanggalPosting
            // 
            this.dtpTanggalPosting.CustomFormat = "dd MMMM yyyy";
            this.dtpTanggalPosting.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpTanggalPosting.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalPosting.Location = new System.Drawing.Point(458, 56);
            this.dtpTanggalPosting.Name = "dtpTanggalPosting";
            this.dtpTanggalPosting.Size = new System.Drawing.Size(200, 24);
            this.dtpTanggalPosting.TabIndex = 4;
            // 
            // lblIsi
            // 
            this.lblIsi.AutoSize = true;
            this.lblIsi.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblIsi.Location = new System.Drawing.Point(15, 90);
            this.lblIsi.Name = "lblIsi";
            this.lblIsi.Size = new System.Drawing.Size(91, 15);
            this.lblIsi.TabIndex = 5;
            this.lblIsi.Text = "Isi Pengumuman";
            // 
            // txtIsi
            // 
            this.txtIsi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtIsi.Location = new System.Drawing.Point(18, 108);
            this.txtIsi.Multiline = true;
            this.txtIsi.Name = "txtIsi";
            this.txtIsi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIsi.Size = new System.Drawing.Size(420, 60);
            this.txtIsi.TabIndex = 6;
            // 
            // flpActions
            // 
            this.flpActions.Controls.Add(this.btnSimpan);
            this.flpActions.Controls.Add(this.btnEdit);
            this.flpActions.Controls.Add(this.btnHapus);
            this.flpActions.Controls.Add(this.btnBatal);
            this.flpActions.Location = new System.Drawing.Point(458, 108);
            this.flpActions.Name = "flpActions";
            this.flpActions.Size = new System.Drawing.Size(450, 60);
            this.flpActions.TabIndex = 7;
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
            this.btnSimpan.Size = new System.Drawing.Size(100, 42);
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
            this.btnEdit.Location = new System.Drawing.Point(108, 0);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 42);
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
            this.btnHapus.Location = new System.Drawing.Point(216, 0);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(100, 42);
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
            this.btnBatal.Location = new System.Drawing.Point(324, 0);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(0);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(100, 42);
            this.btnBatal.TabIndex = 3;
            this.btnBatal.Text = "🔄 BATAL";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // frmPengumuman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(960, 650);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTopHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPengumuman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Pengumuman";
            this.Load += new System.EventHandler(this.frmPengumuman_Load);
            this.pnlTopHeader.ResumeLayout(false);
            this.pnlTopHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlTableCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengumuman)).EndInit();
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
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.TextBox txtJudul;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.DateTimePicker dtpTanggalPosting;
        private System.Windows.Forms.Label lblIsi;
        private System.Windows.Forms.TextBox txtIsi;
        private System.Windows.Forms.FlowLayoutPanel flpActions;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Panel pnlTableCard;
        private System.Windows.Forms.Panel pnlSearchHeader;
        private System.Windows.Forms.Label lblTableTitle;
        private System.Windows.Forms.Label lblTotalPengumuman;
        private System.Windows.Forms.Label lblCari;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.DataGridView dgvPengumuman;
    }
}
