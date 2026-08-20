-- ==========================================================
-- SKRIP DATABASE & TABEL: SISTEM PENGELOLAAN LINGKUNGAN RT/RW
-- Database: DB_RTRW
-- ==========================================================

-- 1. Buat Database jika belum ada
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'DB_RTRW')
BEGIN
    CREATE DATABASE DB_RTRW;
END
GO

USE DB_RTRW;
GO

-- 2. Tabel Pengguna (User / Admin / Operator)
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = N'tb_user')
BEGIN
    CREATE TABLE tb_user (
        id_user INT IDENTITY(1,1) PRIMARY KEY,
        username VARCHAR(50) NOT NULL UNIQUE,
        password VARCHAR(100) NOT NULL,
        nama_lengkap VARCHAR(100) NOT NULL,
        level_user VARCHAR(30) NOT NULL DEFAULT 'Administrator'
    );
END
GO

-- 3. Tabel Data Warga / Penduduk
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
END
GO

-- 4. Tabel Iuran & Kas Warga
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
END
GO

-- 5. Tabel Pengumuman & Agenda
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
END
GO

-- 6. Tabel Permohonan & Surat Pengantar
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
END
GO

-- 7. Tabel Galeri & Dokumentasi Kegiatan
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
END
GO

-- 8. Tabel Pengaturan Profil Wilayah
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
END
GO

-- ==========================================================
-- DATA AWAL & SAMPLE SEED DATA
-- ==========================================================

-- Seed Akun Default (admin / admin)
IF NOT EXISTS (SELECT 1 FROM tb_user WHERE username = 'admin')
BEGIN
    INSERT INTO tb_user (username, password, nama_lengkap, level_user)
    VALUES ('admin', 'admin', 'Administrator Sistem', 'Administrator');
END
GO

-- Seed Profil Wilayah Default
IF NOT EXISTS (SELECT 1 FROM tb_pengaturan)
BEGIN
    INSERT INTO tb_pengaturan (nama_rt_rw, desa_kelurahan, kecamatan, kota_kabupaten, nama_ketua_rt, nama_sekretaris, nominal_iuran, tgl_jatuh_tempo)
    VALUES ('RT 02 / RW 03', 'Sukamaju', 'Cilodong', 'Depok', 'Bpk. Ahmad Fauzi', 'Ibu Siti Rahma', 25000, 10);
END
GO

-- Seed Sample Warga jika tabel masih kosong
IF NOT EXISTS (SELECT 1 FROM tb_warga)
BEGIN
    INSERT INTO tb_warga (nik, no_kk, nama, nama_warga, jenis_kelamin, tempat_lahir, tanggal_lahir, agama, pekerjaan, alamat, no_hp, status_warga)
    VALUES 
    ('3276010101900001', '3276010101900000', 'Budi Santoso', 'Budi Santoso', 'Laki-laki', 'Jakarta', '1990-01-15', 'Islam', 'Karyawan Swasta', 'Jl. Mawar No. 12 RT 02/03', '081234567890', 'Tetap'),
    ('3276010202920002', '3276010202920000', 'Siti Aminah', 'Siti Aminah', 'Perempuan', 'Depok', '1992-05-20', 'Islam', 'Guru', 'Jl. Melati No. 05 RT 02/03', '081298765432', 'Tetap'),
    ('3276010303880003', '3276010303880000', 'Hendro Wijaya', 'Hendro Wijaya', 'Laki-laki', 'Bandung', '1988-11-10', 'Kristen', 'Wiraswasta', 'Jl. Kenanga No. 08 RT 02/03', '085612345678', 'Tetap');
END
GO

-- Seed Sample Iuran jika kosong
IF NOT EXISTS (SELECT 1 FROM tb_iuran)
BEGIN
    INSERT INTO tb_iuran (nama_warga, jenis_iuran, bulan, tahun, nominal, tanggal_bayar, status_bayar, keterangan)
    VALUES 
    ('Budi Santoso', 'Iuran Bulanan', 'Agustus', 2026, 25000, GETDATE(), 'Lunas', 'Iuran Kebersihan & Keamanan'),
    ('Siti Aminah', 'Iuran Bulanan', 'Agustus', 2026, 25000, GETDATE(), 'Lunas', 'Iuran Kebersihan & Keamanan'),
    ('Hendro Wijaya', 'Iuran Bulanan', 'Agustus', 2026, 25000, NULL, 'Belum Lunas', 'Belum bayar');
END
GO

-- Seed Sample Pengumuman jika kosong
IF NOT EXISTS (SELECT 1 FROM tb_pengumuman)
BEGIN
    INSERT INTO tb_pengumuman (judul, kategori, isi_pengumuman, tanggal_posting, status)
    VALUES 
    ('Kerja Bakti Lingkungan Bersih', 'Kegiatan', 'Diberitahukan kepada seluruh warga RT 02 / RW 03 untuk mengikuti kerja bakti membersihkan saluran air dan lingkungan pada hari Minggu pagi pukul 07.00 WIB.', GETDATE(), 'Aktif'),
    ('Jadwal Ronda Malam Bulan Ini', 'Keamanan', 'Jadwal ronda malam telah diperbarui. Mohon seluruh warga yang bertugas hadir tepat waktu di Pos Ronda.', GETDATE(), 'Aktif');
END
GO

-- Seed Sample Galeri jika kosong
IF NOT EXISTS (SELECT 1 FROM tb_galeri)
BEGIN
    INSERT INTO tb_galeri (judul_kegiatan, kategori, tanggal_kegiatan, lokasi, deskripsi, foto_path)
    VALUES 
    ('Kerja Bakti Saluran Air', 'Gotong Royong', GETDATE(), 'Sepanjang Jl. Mawar RT 02', 'Warga bersama-sama membersihkan drainase dan memotong rumput liar untuk mencegah genangan air.', '');
END
GO
