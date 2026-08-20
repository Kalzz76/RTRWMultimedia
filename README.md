# 🏢 Sistem Informasi & Multimedia Pengelolaan Lingkungan Warga RT/RW

Aplikasi Desktop Berbasis **C# Windows Forms (.NET Framework 4.8)** dan **Microsoft SQL Server** untuk memodernisasi administrasi, keuangan, kependudukan, pengumuman, permohonan surat, dan dokumentasi multimedia di tingkat Rukun Tetangga (RT) / Rukun Warga (RW).

---

## 📑 Daftar Isi
- [Tentang Aplikasi](#-tentang-aplikasi)
- [Fitur Utama](#-fitur-utama)
- [Teknologi & Kebutuhan Sistem](#-teknologi--kebutuhan-sistem)
- [Struktur Database](#-struktur-database)
- [Panduan Instalasi & Menjalankan](#-panduan-instalasi--menjalankan)
- [Akun Pengguna Default](#-akun-pengguna-default)
- [Struktur Direktori Proyek](#-struktur-direktori-proyek)
- [Lisensi & Pengembang](#-lisensi--pengembang)

---

## 🌟 Tentang Aplikasi
**RTRWMultimedia** dirancang dengan konsep *Modern Clean Dashboard UI* dan *Single-Window Embedded Form Navigation*, di mana setiap modul (Warga, Iuran, Pengumuman, Surat, Laporan, Galeri, dan Pengaturan) dimuat langsung ke dalam container panel utama secara mulus dan responsif tanpa membuka jendela baru yang bertumpuk.

---

## ✨ Fitur Utama

### 1. 🔐 Autentikasi & Hak Akses
- Login terproteksi multi-level pengguna (**Administrator**, **Pengurus/Operator**, dll.).
- Navigasi cepat dengan tombol `Enter` dari Username ke Password.
- Fitur **Uji Koneksi Database** langsung dari form login.
- Waktu (jam dan tanggal berbahasa Indonesia) real-time.

### 2. 📊 Dashboard Interaktif & Statistik
- **Ringkasan Kartu Statistik:** Total Warga, Total Kepala Keluarga (KK), Total Kas/Saldo Iuran Masuk, dan Jumlah Pengumuman Aktif.
- **Grafik Dinamis (Chart Visualization):** Visualisasi tren pembayaran iuran warga per bulan.
- **Tabel Transaksi Terbaru:** Pemantauan data pembayaran iuran warga terkini.
- **Widget Agenda & Informasi:** Menampilkan kegiatan terbaru dari modul Galeri & Pengumuman.

### 3. 👥 Manajemen Kependudukan (Warga)
- Pendataan lengkap: NIK, No. KK, Nama Lengkap, Jenis Kelamin, Tempat & Tanggal Lahir, Alamat, No. HP/Telepon, Pekerjaan, Agama, dan Status Tempat Tinggal (Tetap / Kontrak).
- Operasi lengkap **CRUD** (Tambah, Ubah, Hapus data warga).
- Fitur pencarian instan (berdasarkan NIK atau Nama).

### 4. 💰 Pengelolaan Kas & Iuran Warga
- Pencatatan iuran bulanan warga (Kebersihan, Keamanan, Kas Sosial, dll.).
- Pencatatan status pembayaran (**Lunas** / **Belum Lunas**), nominal iuran, bulan, tahun, dan tanggal setor.
- Filter data berdasarkan bulan dan status pembayaran.
- Rekapitulasi total iuran terkumpul secara otomatis.

### 5. 📢 Pengumuman & Agenda Lingkungan
- Publikasi agenda kerja bakti, rapat warga, ronda malam, dan informasi penting lainnya.
- Pengelompokan berdasarkan kategori pengumuman dan tanggal pelaksanaan.

### 6. ✉️ Layanan Administrasi & Pembuatan Surat Pengantar
- Pembuatan surat pengantar warga otomatis:
  - Surat Pengantar Pembuatan KTP / KK
  - Surat Pengantar SKCK
  - Surat Keterangan Domisili
  - Surat Keterangan Tidak Mampu (SKTM)
  - Surat Keterangan Kematian / Kelahiran
  - Surat Keterangan Usaha (SKU)
- Penomoran surat otomatis dengan format resmi.
- **Pratinjau & Cetak Surat (frmPreviewSurat):** Dilengkapi kop surat RT/RW, detail pemohon, tanda tangan elektronik/cetak Ketua RT/RW.

### 7. 📈 Laporan & Rekapitulasi
- Rekap data warga, kas iuran, dan riwayat surat masuk/keluar.
- Filter laporan berdasarkan rentang tanggal dan periode waktu tertentu.
- Opsi cetak / pratinjau dokumen laporan resmi.

### 8. 📸 Galeri & Dokumentasi Kegiatan
- Pengarsipan foto kegiatan lingkungan (Kerja Bakti, Peringatan HUT RI, Posyandu, dll.).
- Upload foto, input judul kegiatan, deskripsi, dan tanggal pelaksanaan.

### 9. ⚙️ Pengaturan Wilayah & Akun
- Konfigurasi data RT/RW, Kelurahan/Desa, Kecamatan, Kota/Kabupaten, serta nama Ketua & Sekretaris RT.
- Penyesuaian nominal iuran standar & tanggal jatuh tempo.
- Manajemen akun login dan hak akses pengguna.

---

## 🛠 Teknologi & Kebutuhan Sistem

### Teknologi yang Digunakan
- **Bahasa Pemrograman:** C# (.NET Framework 4.8)
- **Framework UI:** Windows Forms (WinForms) + Charting Data Visualization
- **Database Management System:** Microsoft SQL Server (SQL Express / LocalDB)
- **Akses Data:** ADO.NET (`System.Data.SqlClient`)
- **IDE:** Visual Studio 2019 / 2022

### Kebutuhan Sistem Minimum
- **Sistem Operasi:** Windows 10 / Windows 11 (64-bit disarankan)
- **.NET Framework:** Versi 4.8 atau lebih baru
- **Database Engine:** Microsoft SQL Server 2014 / 2016 / 2019 / 2022 atau SQL Server Express

---

## 🗄 Struktur Database

Nama Database: `DB_RTRW`  
Koneksi Default: `Data Source=.\SQLEXPRESS;Initial Catalog=DB_RTRW;Integrated Security=True`

### Skrip SQL Pembuatan Database & Tabel

Jalankan skrip berikut pada SQL Server Management Studio (SSMS):

```sql
-- 1. Buat Database
CREATE DATABASE DB_RTRW;
GO

USE DB_RTRW;
GO

-- 2. Tabel Pengguna / User
CREATE TABLE tb_user (
    id_user INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(100) NOT NULL,
    nama_lengkap VARCHAR(100) NOT NULL,
    level_user VARCHAR(30) NOT NULL DEFAULT 'Administrator'
);
GO

-- 3. Tabel Data Warga
CREATE TABLE tb_warga (
    id_warga INT IDENTITY(1,1) PRIMARY KEY,
    nik VARCHAR(20) NOT NULL UNIQUE,
    no_kk VARCHAR(20),
    nama VARCHAR(100) NOT NULL,
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
GO

-- 4. Tabel Iuran Kas Warga
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
GO

-- 5. Tabel Pengumuman & Agenda
CREATE TABLE tb_pengumuman (
    id_pengumuman INT IDENTITY(1,1) PRIMARY KEY,
    judul VARCHAR(150) NOT NULL,
    kategori VARCHAR(50),
    isi TEXT,
    tanggal DATE DEFAULT GETDATE(),
    status VARCHAR(30) DEFAULT 'Aktif'
);
GO

-- 6. Tabel Surat Pengantar
CREATE TABLE tb_surat (
    id_surat INT IDENTITY(1,1) PRIMARY KEY,
    nomor_surat VARCHAR(100) NOT NULL,
    jenis_surat VARCHAR(100) NOT NULL,
    nik VARCHAR(20),
    nama_warga VARCHAR(100),
    keperluan TEXT,
    tanggal_surat DATE DEFAULT GETDATE(),
    status VARCHAR(30) DEFAULT 'Selesai'
);
GO

-- 7. Tabel Galeri Kegiatan
CREATE TABLE tb_galeri (
    id_galeri INT IDENTITY(1,1) PRIMARY KEY,
    judul_kegiatan VARCHAR(150) NOT NULL,
    deskripsi TEXT,
    tanggal_kegiatan DATE,
    foto VARCHAR(255)
);
GO

-- 8. Tabel Pengaturan Wilayah
CREATE TABLE tb_pengaturan (
    id INT IDENTITY(1,1) PRIMARY KEY,
    nama_rt_rw VARCHAR(100) DEFAULT 'RT 02 / RW 03',
    desa_kelurahan VARCHAR(100),
    kecamatan VARCHAR(100),
    kota_kabupaten VARCHAR(100),
    nama_ketua_rt VARCHAR(100),
    nama_sekretaris VARCHAR(100),
    nominal_iuran INT DEFAULT 25000,
    tgl_jatuh_tempo INT DEFAULT 10
);
GO

-- Data Awal Pengguna & Pengaturan Default
INSERT INTO tb_user (username, password, nama_lengkap, level_user)
VALUES ('admin', 'admin', 'Administrator Sistem', 'Administrator');

INSERT INTO tb_pengaturan (nama_rt_rw, desa_kelurahan, kecamatan, kota_kabupaten, nama_ketua_rt, nama_sekretaris, nominal_iuran, tgl_jatuh_tempo)
VALUES ('RT 02 / RW 03', 'Sukamaju', 'Cilodong', 'Depok', 'Bpk. Ahmad Fauzi', 'Ibu Siti Rahma', 25000, 10);
GO
```

---

## 🚀 Panduan Instalasi & Menjalankan

### Langkah 1: Clone Repository
```bash
git clone https://github.com/Kalzz76/RTRWMultimedia.git
cd RTRWMultimedia
```

### Langkah 2: Konfigurasi Database
1. Buka **SQL Server Management Studio (SSMS)**.
2. Jalankan query skrip SQL di atas untuk membuat database `DB_RTRW` beserta tabel dan data awalnya.
3. Periksa file konfigurasi koneksi pada `RTRWMultimedia/Database/Koneksi.cs`:
   ```csharp
   @"Data Source=.\SQLEXPRESS;Initial Catalog=DB_RTRW;Integrated Security=True"
   ```
   *(Sesuaikan `Data Source` dengan instance SQL Server lokal Anda jika berbeda, misalnya `(localdb)\MSSQLLocalDB` atau `localhost`).*

### Langkah 3: Buka & Jalankan Project di Visual Studio
1. Buka solusi `RTRWMultimedia.slnx` atau file project `RTRWMultimedia/RTRWMultimedia.csproj` menggunakan **Visual Studio**.
2. Pastikan target framework terpasang ke **.NET Framework 4.8**.
3. Lakukan **Build Solution** (`Ctrl + Shift + B`).
4. Tekan tombol **Start / F5** untuk menjalankan aplikasi.

---

## 🔑 Akun Pengguna Default

| Level | Username | Password |
|---|---|---|
| **Administrator** | `admin` | `admin` |

*(Pengguna dapat menambahkan dan mengelola akun operator lain melalui menu **Pengaturan** setelah login).*

---

## 📂 Struktur Direktori Proyek

```text
RTRWMultimedia/
├── Database/
│   └── Koneksi.cs                     # Kelas helper koneksi database SQL Server
├── Properties/
│   ├── AssemblyInfo.cs                # Metadata aplikasi
│   ├── Resources.resx                 # Asset resource proyek
│   └── Settings.settings              # Pengaturan aplikasi
├── Resources/                         # Gambar, icon, dan logo sistem
├── frmLogin.cs                        # Form autentikasi & login
├── frmDashboard.cs                    # Dashboard utama, navigasi embedded, & grafik
├── frmWarga.cs                        # Form manajemen data kependudukan
├── frmIuran.cs                        # Form pencatatan kas & iuran warga
├── frmPengumuman.cs                   # Form publikasi pengumuman/agenda
├── frmSurat.cs                        # Form pembuatan surat pengantar warga
├── frmPreviewSurat.cs                 # Form pratinjau & cetak surat pengantar
├── frmLaporan.cs                      # Form rekapitulasi & cetak laporan
├── frmGaleri.cs                       # Form galeri multimedia kegiatan warga
├── frmPengaturan.cs                   # Form konfigurasi wilayah & manajemen user
├── frmProfil.cs                       # Form profil pengembang / user
├── Program.cs                         # Titik masuk utama aplikasi (Main entry)
├── App.config                         # File konfigurasi XML aplikasi
└── RTRWMultimedia.csproj              # File konfigurasi proyek C# .NET
```

---

## 👨‍💻 Lisensi & Kontributor
Dikembangkan untuk mendukung digitalisasi dan administrasi lingkungan warga yang transparan, modern, dan efisien.
