-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: May 02, 2018 at 11:30 AM
-- Server version: 5.6.17
-- PHP Version: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `ishodi_ucenja`
--

-- --------------------------------------------------------

--
-- Table structure for table `arhiva`
--

CREATE TABLE IF NOT EXISTS `arhiva` (
  `id_arhive` int(11) NOT NULL,
  `naziv` varchar(100) CHARACTER SET utf8 COLLATE utf8_croatian_ci NOT NULL,
  `datoteka` varchar(100) CHARACTER SET utf32 COLLATE utf32_croatian_ci NOT NULL,
  PRIMARY KEY (`id_arhive`),
  UNIQUE KEY `id_arhive_UNIQUE` (`id_arhive`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `kolegij`
--

CREATE TABLE IF NOT EXISTS `kolegij` (
  `id_kolegij` int(11) NOT NULL,
  `naziv` varchar(70) NOT NULL,
  `kratica` varchar(45) NOT NULL,
  `sifra` varchar(45) NOT NULL,
  PRIMARY KEY (`id_kolegij`),
  UNIQUE KEY `id_kolegij_UNIQUE` (`id_kolegij`),
  UNIQUE KEY `sifra_UNIQUE` (`sifra`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `kolegij ishod`
--

CREATE TABLE IF NOT EXISTS `kolegij ishod` (
  `id_ishod` bigint(20) NOT NULL AUTO_INCREMENT,
  `id_program` int(11) NOT NULL,
  `id_kolegij` int(11) NOT NULL,
  `rb` int(11) NOT NULL,
  `ishod` text NOT NULL,
  `razina` varchar(20) NOT NULL,
  PRIMARY KEY (`id_ishod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `kolegij literatura`
--

CREATE TABLE IF NOT EXISTS `kolegij literatura` (
  `id_program` int(11) NOT NULL,
  `id_kolegij` int(11) NOT NULL,
  `naziv` varchar(100) NOT NULL,
  `vrsta` tinyint(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `kolegij nastavnik`
--

CREATE TABLE IF NOT EXISTS `kolegij nastavnik` (
  `id_program` int(11) NOT NULL,
  `id_kolegij` int(11) NOT NULL,
  `id_korisnik` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `kolegij opce info`
--

CREATE TABLE IF NOT EXISTS `kolegij opce info` (
  `id_program` int(11) NOT NULL,
  `id_kolegij` int(11) NOT NULL,
  `status_kolegij` tinyint(2) NOT NULL,
  `ECTS` int(11) NOT NULL,
  `izvodenje_nastave` text NOT NULL,
  `cilj` text NOT NULL,
  `uvjeti_polaganja` text NOT NULL,
  `obaveza_studenata` text NOT NULL,
  `ocjenjivanje_vrednovanje(2.10)` text NOT NULL,
  `pracenje_kvalitete` text NOT NULL,
  `pohadanje_nastave` text NOT NULL,
  `kontakt_nastavnik` text NOT NULL,
  `info` text NOT NULL,
  `radovi` text NOT NULL,
  `ostalo` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `kolegij opterecenje`
--

CREATE TABLE IF NOT EXISTS `kolegij opterecenje` (
  `id_program` int(11) NOT NULL,
  `id_kolegij` int(11) NOT NULL,
  `naziv_opterecenja` text NOT NULL,
  `sati` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='				';

-- --------------------------------------------------------

--
-- Table structure for table `kolegij_pracenje`
--

CREATE TABLE IF NOT EXISTS `kolegij_pracenje` (
  `id_program` int(11) NOT NULL,
  `id_kolegij` int(11) NOT NULL,
  `pohadanje` int(11) NOT NULL,
  `eksperimentalni_rad` int(11) NOT NULL,
  `esej` int(11) NOT NULL,
  `kolokvij` int(11) NOT NULL,
  `aktivnost` int(11) NOT NULL,
  `pismeni` varchar(45) NOT NULL,
  `istrazivanje` int(11) NOT NULL,
  `referat` int(11) NOT NULL,
  `seminar` int(11) NOT NULL,
  `prakticni` int(11) NOT NULL,
  `usmeni` int(11) NOT NULL,
  `projekt` int(11) NOT NULL,
  `kontinuirana` int(11) NOT NULL,
  `ostalo_opis_1` varchar(45) NOT NULL,
  `ostalo_opis_1_ects` int(11) NOT NULL,
  `ostalo_opis_2` varchar(45) NOT NULL,
  `ostalo_opis_2_ects` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `kolegij_teme`
--

CREATE TABLE IF NOT EXISTS `kolegij_teme` (
  `id_program` int(11) NOT NULL,
  `id_kolegij` int(11) NOT NULL,
  `red_broj` int(11) NOT NULL,
  `predavanje` text NOT NULL,
  `vjezba` text NOT NULL,
  `literatura` text NOT NULL,
  `id_ishod` int(11) NOT NULL,
  `predavanje_sati` int(11) NOT NULL,
  `vjezbe_sati` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `kolegij_vrsta_nastave`
--

CREATE TABLE IF NOT EXISTS `kolegij_vrsta_nastave` (
  `id_program` int(11) NOT NULL,
  `id_kolegi` int(11) NOT NULL,
  `predavanje` tinyint(2) NOT NULL,
  `seminari` tinyint(2) NOT NULL,
  `vjezbe` tinyint(2) NOT NULL,
  `na_daljinu` tinyint(2) NOT NULL,
  `mjesovito` tinyint(2) NOT NULL,
  `terenska` tinyint(2) NOT NULL,
  `samostalni_rad` tinyint(2) NOT NULL,
  `multimedija` tinyint(2) NOT NULL,
  `laboratorij` tinyint(2) NOT NULL,
  `mentor` tinyint(2) NOT NULL,
  `ostalo` varchar(50) CHARACTER SET utf8 COLLATE utf8_croatian_ci NOT NULL,
  `ostalo_selekt` tinyint(2) NOT NULL,
  `komentar` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `korisnik`
--

CREATE TABLE IF NOT EXISTS `korisnik` (
  `id_korisnik` int(11) NOT NULL,
  `ime_prezime` varchar(60) NOT NULL,
  `email` varchar(45) NOT NULL,
  `lozinka` varchar(20) NOT NULL,
  `vrsta_korisnika` int(11) NOT NULL,
  `titula` varchar(15) NOT NULL,
  `id_ustanova` int(11) NOT NULL,
  `licenca` date NOT NULL,
  `aktivacijski link` varchar(45) NOT NULL,
  `aktivan` tinyint(1) NOT NULL,
  PRIMARY KEY (`id_korisnik`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `program_kolegij`
--

CREATE TABLE IF NOT EXISTS `program_kolegij` (
  `id_program` int(11) NOT NULL,
  `id_kolegij` int(11) NOT NULL,
  `semestar` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `studijski program`
--

CREATE TABLE IF NOT EXISTS `studijski program` (
  `id_program` int(10) NOT NULL AUTO_INCREMENT,
  `naziv` varchar(100) NOT NULL,
  `id_ustanova` int(11) NOT NULL,
  `ak_godina` varchar(45) NOT NULL,
  `opis` text NOT NULL,
  PRIMARY KEY (`id_program`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `ustanova`
--

CREATE TABLE IF NOT EXISTS `ustanova` (
  `id_ustanova` int(10) NOT NULL AUTO_INCREMENT,
  `naziv` varchar(120) NOT NULL,
  `adresa` varchar(150) NOT NULL,
  `grad` varchar(45) NOT NULL,
  PRIMARY KEY (`id_ustanova`),
  UNIQUE KEY `id_ustanova_UNIQUE` (`id_ustanova`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
