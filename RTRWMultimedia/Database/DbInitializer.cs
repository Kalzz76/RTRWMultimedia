using System;
using System.Data.SqlClient;

namespace RTRWMultimedia.Database
{
    public static class DbInitializer
    {
        private static string[] candidateServers = new string[]
        {
            @".\SQLEXPRESS",
            @"(localdb)\MSSQLLocalDB",
            @"localhost",
            @"127.0.0.1",
            @"(local)"
        };

        private static string workingDataSource = @".\SQLEXPRESS";
        private static bool isInitialized = false;

        public static string WorkingDataSource
        {
            get { return workingDataSource; }
        }

        /// <summary>
        /// Memeriksa dan otomatis membuat database DB_RTRW serta seluruh tabelnya jika belum ada.
        /// </summary>
        public static bool EnsureDatabaseAndTablesExist(out string message)
        {
            if (isInitialized)
            {
                message = "Database sudah terinisialisasi.";
                return true;
            }

            // 1. Temukan server SQL yang aktif
            bool serverConnected = false;
            string connectedServer = "";

            foreach (var server in candidateServers)
            {
                string masterConnStr = string.Format(@"Data Source={0};Initial Catalog=master;Integrated Security=True;Connect Timeout=3", server);
                try
                {
                    using (SqlConnection conn = new SqlConnection(masterConnStr))
                    {
                        conn.Open();
                        serverConnected = true;
                        connectedServer = server;
                        workingDataSource = server;
                        Koneksi.SetDataSource(server);
                        break;
                    }
                }
                catch
                {
                    // Coba server berikutnya
                }
            }

            if (!serverConnected)
            {
                message = "Gagal terhubung ke SQL Server (SQLEXPRESS / LocalDB / localhost). Pastikan service SQL Server aktif.";
                return false;
            }

            try
            {
                // 2. Buat database DB_RTRW jika belum ada
                string masterConnStr = string.Format(@"Data Source={0};Initial Catalog=master;Integrated Security=True", connectedServer);
                using (SqlConnection masterConn = new SqlConnection(masterConnStr))
                {
                    masterConn.Open();
                    string checkDbSql = @"IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'DB_RTRW')
                                         BEGIN
                                             CREATE DATABASE DB_RTRW;
                                         END";
                    using (SqlCommand cmd = new SqlCommand(checkDbSql, masterConn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                // 3. Buat seluruh tabel & sample data pada DB_RTRW
                string dbConnStr = string.Format(@"Data Source={0};Initial Catalog=DB_RTRW;Integrated Security=True", connectedServer);
                using (SqlConnection dbConn = new SqlConnection(dbConnStr))
                {
                    dbConn.Open();

                    string ddlScript = @"
                    IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = N'tb_user')
                    BEGIN
                        CREATE TABLE tb_user (
                            id_user INT IDENTITY(1,1) PRIMARY KEY,
                            username VARCHAR(50) NOT NULL UNIQUE,
                            password VARCHAR(100) NOT NULL,
                            level_user VARCHAR(30) NOT NULL DEFAULT 'Administrator'
                        );
                    END;

                    IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = N'tb_warga')
                    BEGIN
                        CREATE TABLE tb_warga (
                            id_warga INT IDENTITY(1,1) PRIMARY KEY,
                            nik VARCHAR(20) NOT NULL UNIQUE,
                            no_kk VARCHAR(20),
                            nama VARCHAR(100),
                            nama_warga VARCHAR(100),
                            jenis_kelamin VARCHAR(20),
                            tempat_lahir VARCHAR(50),
                            tanggal_lahir DATE,
                            agama VARCHAR(20),
                            pekerjaan VARCHAR(50),
                            alamat TEXT,
                            no_hp VARCHAR(20),
                            status_warga VARCHAR(30) DEFAULT 'Tetap',
                            foto VARCHAR(255)
                        );
                    END;

                    IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = N'tb_iuran')
                    BEGIN
                        CREATE TABLE tb_iuran (
                            id_iuran INT IDENTITY(1,1) PRIMARY KEY,
                            id_warga INT,
                            nama_warga VARCHAR(100),
                            jenis_iuran VARCHAR(50) DEFAULT 'Iuran Bulanan',
                            bulan VARCHAR(20),
                            tahun INT,
                            nominal DECIMAL(18,2) DEFAULT 0,
                            tanggal_bayar DATE,
                            status_bayar VARCHAR(30) DEFAULT 'Lunas',
                            keterangan TEXT
                        );
                    END;

                    IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = N'tb_pengumuman')
                    BEGIN
                        CREATE TABLE tb_pengumuman (
                            id_pengumuman INT IDENTITY(1,1) PRIMARY KEY,
                            judul VARCHAR(150) NOT NULL,
                            kategori VARCHAR(50) DEFAULT 'Umum',
                            isi_pengumuman TEXT,
                            tanggal_posting DATE DEFAULT GETDATE(),
                            status VARCHAR(30) DEFAULT 'Aktif'
                        );
                    END;

                    IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = N'tb_surat')
                    BEGIN
                        CREATE TABLE tb_surat (
                            id_surat INT IDENTITY(1,1) PRIMARY KEY,
                            no_surat VARCHAR(100) NOT NULL,
                            jenis_surat VARCHAR(100) DEFAULT 'Surat Pengantar',
                            nik VARCHAR(20),
                            nama_warga VARCHAR(100),
                            keperluan TEXT,
                            tanggal_surat DATE DEFAULT GETDATE(),
                            status_surat VARCHAR(30) DEFAULT 'Disetujui',
                            keterangan TEXT
                        );
                    END;

                    IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = N'tb_galeri')
                    BEGIN
                        CREATE TABLE tb_galeri (
                            id_galeri INT IDENTITY(1,1) PRIMARY KEY,
                            judul_kegiatan VARCHAR(150) NOT NULL,
                            kategori VARCHAR(50) DEFAULT 'Gotong Royong',
                            tanggal_kegiatan DATE DEFAULT GETDATE(),
                            lokasi VARCHAR(100),
                            deskripsi TEXT,
                            foto_path VARCHAR(255)
                        );
                    END;

                    IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = N'tb_pengaturan')
                    BEGIN
                        CREATE TABLE tb_pengaturan (
                            id INT IDENTITY(1,1) PRIMARY KEY,
                            nama_rt_rw VARCHAR(100) DEFAULT 'RT 02 / RW 03',
                            desa_kelurahan VARCHAR(100) DEFAULT 'Sukamaju',
                            kecamatan VARCHAR(100) DEFAULT 'Cilodong',
                            kota_kabupaten VARCHAR(100) DEFAULT 'Depok',
                            nama_ketua_rt VARCHAR(100) DEFAULT 'Bpk. Ahmad Fauzi',
                            nama_sekretaris VARCHAR(100) DEFAULT 'Ibu Siti Rahma',
                            nominal_iuran INT DEFAULT 25000,
                            tgl_jatuh_tempo INT DEFAULT 10
                        );
                    END;

                    -- Hapus kolom nama_lengkap dari tb_user jika ada (kompatibilitas)
                    IF EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('tb_user') AND name = 'nama_lengkap')
                    BEGIN
                        ALTER TABLE tb_user DROP COLUMN nama_lengkap;
                    END;

                    -- Insert default admin jika belum ada
                    IF NOT EXISTS (SELECT 1 FROM tb_user WHERE username = 'admin')
                    BEGIN
                        INSERT INTO tb_user (username, password, level_user)
                        VALUES ('admin', 'admin', 'Administrator');
                    END;

                    -- Insert default pengaturan jika belum ada
                    IF NOT EXISTS (SELECT 1 FROM tb_pengaturan)
                    BEGIN
                        INSERT INTO tb_pengaturan (nama_rt_rw, desa_kelurahan, kecamatan, kota_kabupaten, nama_ketua_rt, nama_sekretaris, nominal_iuran, tgl_jatuh_tempo)
                        VALUES ('RT 02 / RW 03', 'Sukamaju', 'Cilodong', 'Depok', 'Bpk. Ahmad Fauzi', 'Ibu Siti Rahma', 25000, 10);
                    END;
                    ";

                    using (SqlCommand cmd = new SqlCommand(ddlScript, dbConn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                isInitialized = true;
                message = string.Format("Database DB_RTRW dan seluruh tabel berhasil dibuat/diperiksa pada server '{0}'.", connectedServer);
                return true;
            }
            catch (Exception ex)
            {
                message = "Gagal menginisialisasi database:\n" + ex.Message;
                return false;
            }
        }
    }
}
