-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
<<<<<<< HEAD
-- Waktu pembuatan: 24 Jun 2021 pada 09.44
-- Versi server: 10.4.18-MariaDB
-- Versi PHP: 7.3.27
=======
-- Generation Time: Jun 23, 2021 at 06:56 PM
-- Server version: 10.4.19-MariaDB
-- PHP Version: 8.0.7
>>>>>>> d27240243b766b40c0bb9d299926671d40b85717

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
-- Table structure for table `gudang`
--

CREATE TABLE `gudang` (
  `nogudang` varchar(10) NOT NULL,
  `NamaBarang` varchar(50) NOT NULL,
  `jumlah` int(10) NOT NULL,
  `harga` int(10) NOT NULL,
  `satuan` enum('pcs','kardus','liter','kg') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `gudang`
--

INSERT INTO `gudang` (`nogudang`, `NamaBarang`, `jumlah`, `harga`, `satuan`) VALUES
('B002\r\n', 'Mie Rebus', 100, 3000, 'pcs');

-- --------------------------------------------------------

--
<<<<<<< HEAD
-- Struktur dari tabel `tbl_pelanggan`
--

CREATE TABLE `tbl_pelanggan` (
  `nopelanggan` varchar(10) NOT NULL,
  `namapelanggan` varchar(50) NOT NULL,
  `alamatpelanggan` varchar(100) NOT NULL,
  `notelp` varchar(12) NOT NULL,
  `hutang` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_pelanggan`
--

INSERT INTO `tbl_pelanggan` (`nopelanggan`, `namapelanggan`, `alamatpelanggan`, `notelp`, `hutang`) VALUES
('P001', 'Aska Erlangga', 'Komplek BAP', '089765372645', 50000);
=======
-- Table structure for table `tabeluser`
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
-- Dumping data for table `tabeluser`
--

INSERT INTO `tabeluser` (`kode_user`, `username_user`, `password_user`, `nama_user`, `alamat_user`, `no_telp_user`, `jabatan_user`, `jenis_user`) VALUES
('USER001', 'admin', 'admin', 'Admin', 'Kota Serang', '08123456789', 'Administrator', 'admin'),
('USER002', 'aska', '123456', 'Aska Erlangga', 'Kota Serang', '08123456789', 'Kuli', 'user');
>>>>>>> d27240243b766b40c0bb9d299926671d40b85717

--
-- Indexes for dumped tables
--

--
-- Indexes for table `gudang`
--
ALTER TABLE `gudang`
  ADD PRIMARY KEY (`nogudang`);

--
<<<<<<< HEAD
-- Indeks untuk tabel `tbl_pelanggan`
--
ALTER TABLE `tbl_pelanggan`
  ADD PRIMARY KEY (`nopelanggan`);
=======
-- Indexes for table `tabeluser`
--
ALTER TABLE `tabeluser`
  ADD PRIMARY KEY (`kode_user`);
>>>>>>> d27240243b766b40c0bb9d299926671d40b85717
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
