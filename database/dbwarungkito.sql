-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 24 Jun 2021 pada 18.46
-- Versi server: 10.4.18-MariaDB
-- Versi PHP: 7.3.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbwarungkito`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `gudang`
--

CREATE TABLE `gudang` (
  `nogudang` varchar(10) NOT NULL,
  `NamaBarang` varchar(50) NOT NULL,
  `jumlah` int(10) NOT NULL,
  `harga` int(10) NOT NULL,
  `satuan` enum('pcs','kardus','liter','kg') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `gudang`
--

INSERT INTO `gudang` (`nogudang`, `NamaBarang`, `jumlah`, `harga`, `satuan`) VALUES
('B001', 'Indomie Goreng', 100, 2500, 'pcs'),
('B002', 'Indomie Ayam Barang', 100, 3000, 'pcs'),
('B003', 'Sunlight', 100, 1000, 'pcs'),
('B004', 'Beras Pandan', 100, 7000, 'liter'),
('B005', 'Minyak', 100, 12000, 'liter'),
('B006', 'Gula', 100, 14000, 'kg'),
('B007', 'Telur', 200, 1500, 'pcs');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tabeluser`
--

CREATE TABLE `tabeluser` (
  `kode_user` varchar(10) NOT NULL,
  `username_user` text NOT NULL,
  `password_user` text NOT NULL,
  `nama_user` text NOT NULL,
  `alamat_user` text NOT NULL,
  `no_telp_user` text NOT NULL,
  `jabatan_user` text NOT NULL,
  `jenis_user` enum('admin','user') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tabeluser`
--

INSERT INTO `tabeluser` (`kode_user`, `username_user`, `password_user`, `nama_user`, `alamat_user`, `no_telp_user`, `jabatan_user`, `jenis_user`) VALUES
('K002', 'edofr', '203387123', 'edo fitri rifai', 'komplek rsspemda', '08960626752431', 'admin', 'admin'),
('K001', 'edofr', '203387123', 'edo fitri rifai', 'komplek rsspemda', '08960626752431', 'admin', 'admin'),
('K004', '', '', '', '', '', '', ''),
('K004', 'fajarf', '12345', 'Fajar Nurfauzan', 'Pamarayan', '09239017', 'Gudang', 'user'),
('K005', 'askae', '12345', 'Aska Erlangga', 'Komplek BAP', '08978074874', 'kasir', 'admin');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_barang`
--

CREATE TABLE `tbl_barang` (
  `nonota` varchar(10) NOT NULL,
  `namabarang` varchar(50) NOT NULL,
  `qty` int(10) NOT NULL,
  `satuan` varchar(50) NOT NULL,
  `harga` int(10) NOT NULL,
  `total` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_detailbarang`
--

CREATE TABLE `tbl_detailbarang` (
  `nonota` varchar(10) NOT NULL,
  `tglbarang` date NOT NULL,
  `itembarang` int(10) NOT NULL,
  `totaljual` int(10) NOT NULL,
  `dibayar` int(10) NOT NULL,
  `kembali` int(10) NOT NULL,
  `jenis_user` varchar(50) NOT NULL,
  `kode_user` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_pelanggan`
--

CREATE TABLE `tbl_pelanggan` (
  `nopelanggan` varchar(10) NOT NULL,
  `namapelanggan` varchar(50) NOT NULL,
  `alamatpelanggan` varchar(100) NOT NULL,
  `notelp` varchar(12) NOT NULL,
  `hutang` int(10) NOT NULL,
  `keterangan` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_pelanggan`
--

INSERT INTO `tbl_pelanggan` (`nopelanggan`, `namapelanggan`, `alamatpelanggan`, `notelp`, `hutang`, `keterangan`) VALUES
('p002', 'edofr', 'komplek rsspemda', '089606267524', 0, 'LUNAS');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `gudang`
--
ALTER TABLE `gudang`
  ADD PRIMARY KEY (`nogudang`);

--
-- Indeks untuk tabel `tbl_pelanggan`
--
ALTER TABLE `tbl_pelanggan`
  ADD PRIMARY KEY (`nopelanggan`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
