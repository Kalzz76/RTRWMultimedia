using System;
using System.Data.SqlClient;

class SetupDB {
    static void Main() {
        string masterConnStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        
        // 1. Create Database DB_RTRW if not exists
        using (var conn = new SqlConnection(masterConnStr)) {
            conn.Open();
            using (var cmd = conn.CreateCommand()) {
                cmd.CommandText = @"
                    IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'DB_RTRW')
                    BEGIN
                        CREATE DATABASE DB_RTRW;
                    END
                ";
                cmd.ExecuteNonQuery();
                Console.WriteLine("Database DB_RTRW ready.");
            }
        }

        string dbConnStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=DB_RTRW;Integrated Security=True";
        using (var conn = new SqlConnection(dbConnStr)) {
            conn.Open();
            using (var cmd = conn.CreateCommand()) {
                // 2. Create Tables
                cmd.CommandText = @"
                    IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tb_user')
                    BEGIN
                        CREATE TABLE tb_user (
                            id_user INT IDENTITY(1,1) PRIMARY KEY,
                            username VARCHAR(50),
                            password VARCHAR(100),
                            level_user VARCHAR(20)
                        );
                    END

                    IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tb_warga')
                    BEGIN
                        CREATE TABLE tb_warga (
                            id_warga INT IDENTITY(1,1) PRIMARY KEY,
                            nik VARCHAR(20),
                            nama VARCHAR(100),
                            alamat VARCHAR(200),
                            no_hp VARCHAR(20),
                            status_warga VARCHAR(20)
                        );
                    END

                    IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tb_iuran')
                    BEGIN
                        CREATE TABLE tb_iuran (
                            id_iuran INT IDENTITY(1,1) PRIMARY KEY,
                            nama_warga VARCHAR(100),
                            bulan VARCHAR(20),
                            nominal INT,
                            tanggal_bayar DATE,
                            status_bayar VARCHAR(20)
                        );
                    END

                    IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tb_pengumuman')
                    BEGIN
                        CREATE TABLE tb_pengumuman (
                            id_pengumuman INT IDENTITY(1,1) PRIMARY KEY,
                            judul VARCHAR(100),
                            isi_pengumuman TEXT,
                            tanggal_posting DATETIME
                        );
                    END
                ";
                cmd.ExecuteNonQuery();
                Console.WriteLine("Tables created successfully.");

                // 3. Seed Users
                cmd.CommandText = @"
                    IF NOT EXISTS (SELECT * FROM tb_user WHERE username = 'admin')
                        INSERT INTO tb_user (username, password, level_user) VALUES ('admin', '123', 'Administrator');

                    IF NOT EXISTS (SELECT * FROM tb_user WHERE username = 'operator')
                        INSERT INTO tb_user (username, password, level_user) VALUES ('operator', '123', 'Operator');

                    IF NOT EXISTS (SELECT * FROM tb_user WHERE username = 'ketua_rt')
                        INSERT INTO tb_user (username, password, level_user) VALUES ('ketua_rt', '123', 'Ketua RT');
                ";
                cmd.ExecuteNonQuery();
                Console.WriteLine("Users seeded successfully.");

                // 4. Seed Warga
                cmd.CommandText = @"
                    IF NOT EXISTS (SELECT * FROM tb_warga)
                    BEGIN
                        INSERT INTO tb_warga (nik, nama, alamat, no_hp, status_warga) VALUES
                        ('3201010101900001', 'Budi Santoso', 'Jl. Merdeka No. 12', '081234567890', 'Aktif'),
                        ('3201010101900002', 'Siti Aminah', 'Jl. Merdeka No. 14', '082345678901', 'Aktif'),
                        ('3201010101900003', 'Ahmad Dahlan', 'Jl. Mawar No. 05', '083456789012', 'Aktif'),
                        ('3201010101900004', 'Dewi Sartika', 'Jl. Melati No. 08', '084567890123', 'Aktif'),
                        ('3201010101900005', 'Eko Prasetyo', 'Jl. Anggrek No. 02', '085678901234', 'Aktif'),
                        ('3201010101900006', 'Fajar Hidayat', 'Jl. Mawar No. 10', '086789012345', 'Aktif'),
                        ('3201010101900007', 'Gita Gutawa', 'Jl. Melati No. 12', '087890123456', 'Aktif');
                    END
                ";
                cmd.ExecuteNonQuery();
                Console.WriteLine("Data Warga seeded successfully.");

                // 5. Seed Iuran
                cmd.CommandText = @"
                    IF NOT EXISTS (SELECT * FROM tb_iuran)
                    BEGIN
                        INSERT INTO tb_iuran (nama_warga, bulan, nominal, tanggal_bayar, status_bayar) VALUES
                        ('Budi Santoso', 'Januari', 50000, '2026-01-10', 'Lunas'),
                        ('Siti Aminah', 'Januari', 50000, '2026-01-15', 'Lunas'),
                        ('Ahmad Dahlan', 'Januari', 50000, '2026-01-18', 'Lunas'),
                        ('Dewi Sartika', 'Januari', 50000, '2026-01-20', 'Lunas'),
                        ('Eko Prasetyo', 'Agustus', 50000, '2026-08-05', 'Lunas'),
                        ('Fajar Hidayat', 'Agustus', 50000, '2026-08-08', 'Lunas'),
                        ('Gita Gutawa', 'Agustus', 50000, '2026-08-10', 'Lunas');
                    END
                ";
                cmd.ExecuteNonQuery();
                Console.WriteLine("Data Iuran seeded successfully.");

                // 6. Seed Pengumuman
                cmd.CommandText = @"
                    IF NOT EXISTS (SELECT * FROM tb_pengumuman)
                    BEGIN
                        INSERT INTO tb_pengumuman (judul, isi_pengumuman, tanggal_posting) VALUES
                        ('Kerja Bakti', 'Kerja bakti dilaksanakan hari Minggu pukul 07.00 WIB', GETDATE()),
                        ('Rapat RT', 'Rapat bulanan warga dilaksanakan Sabtu malam pukul 19.30 WIB di Balai Warga', GETDATE()),
                        ('Posyandu Balita', 'Jadwal Posyandu dan imunisasi dilaksanakan tanggal 15 bulan ini', GETDATE());
                    END
                ";
                cmd.ExecuteNonQuery();
                Console.WriteLine("Data Pengumuman seeded successfully.");
            }
        }
    }
}