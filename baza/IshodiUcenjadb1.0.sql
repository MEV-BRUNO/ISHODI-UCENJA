/*
SQLyog Trial v13.0.0 (64 bit)
MySQL - 8.0.11 : Database - ishodiucenja
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`ishodiucenja` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `ishodiucenja`;

/*Table structure for table `arhiva` */

DROP TABLE IF EXISTS `arhiva`;

CREATE TABLE `arhiva` (
  `id_arhive` int(11) NOT NULL,
  `id_kolegij` int(11) NOT NULL,
  `id_korisnik` int(11) NOT NULL,
  PRIMARY KEY (`id_arhive`),
  UNIQUE KEY `id_kolegij_UNIQUE` (`id_kolegij`),
  UNIQUE KEY `id_arhive_UNIQUE` (`id_arhive`),
  UNIQUE KEY `id_korisnik_UNIQUE` (`id_korisnik`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `arhiva` */

/*Table structure for table `kolegij` */

DROP TABLE IF EXISTS `kolegij`;

CREATE TABLE `kolegij` (
  `id_kolegij` int(11) NOT NULL,
  `naziv` varchar(45) NOT NULL,
  `kratica` varchar(45) NOT NULL,
  `sifra` varchar(45) NOT NULL,
  PRIMARY KEY (`id_kolegij`),
  UNIQUE KEY `id_kolegij_UNIQUE` (`id_kolegij`),
  UNIQUE KEY `sifra_UNIQUE` (`sifra`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `kolegij` */

/*Table structure for table `kolegij ishod` */

DROP TABLE IF EXISTS `kolegij ishod`;

CREATE TABLE `kolegij ishod` (
  `id_program` int(11) NOT NULL,
  `id_kolegij` varchar(45) NOT NULL,
  `rb` varchar(45) NOT NULL,
  `ishod` varchar(45) NOT NULL,
  `kolegij ishodcol` varchar(45) NOT NULL,
  `razina (R4 - R7)` varchar(45) NOT NULL,
  PRIMARY KEY (`id_program`),
  UNIQUE KEY `id_program_UNIQUE` (`id_program`),
  UNIQUE KEY `id_kolegij_UNIQUE` (`id_kolegij`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `kolegij ishod` */

/*Table structure for table `kolegij literatura` */

DROP TABLE IF EXISTS `kolegij literatura`;

CREATE TABLE `kolegij literatura` (
  `id_program` int(11) NOT NULL,
  `id_kolegij.` int(11) NOT NULL,
  `naziv` varchar(45) NOT NULL,
  `vrsta (obavezna/dopunska)` varchar(45) NOT NULL,
  PRIMARY KEY (`id_program`),
  UNIQUE KEY `id_program_UNIQUE` (`id_program`),
  UNIQUE KEY `id_kolegij_UNIQUE` (`id_kolegij.`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `kolegij literatura` */

/*Table structure for table `kolegij nastavnik` */

DROP TABLE IF EXISTS `kolegij nastavnik`;

CREATE TABLE `kolegij nastavnik` (
  `id_program` int(11) NOT NULL,
  `id_kolegij` varchar(45) NOT NULL,
  `id_korisnik` varchar(45) NOT NULL,
  PRIMARY KEY (`id_program`),
  UNIQUE KEY `id_program_UNIQUE` (`id_program`),
  UNIQUE KEY `id_kolegij_UNIQUE` (`id_kolegij`),
  UNIQUE KEY `id_korisnik_UNIQUE` (`id_korisnik`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `kolegij nastavnik` */

/*Table structure for table `kolegij opce info` */

DROP TABLE IF EXISTS `kolegij opce info`;

CREATE TABLE `kolegij opce info` (
  `id_program` int(11) NOT NULL,
  `id_kolegij` varchar(45) NOT NULL,
  `status_kolegij(Obvezni/Izborni)` varchar(45) NOT NULL,
  `ECTS` int(11) NOT NULL,
  `izvodenje_nastave` varchar(100) NOT NULL,
  `cilj` varchar(100) NOT NULL,
  `uvjeti_polaganja` varchar(45) NOT NULL,
  `obaveza_studenata` varchar(45) NOT NULL,
  `ocjenjivanje_vednovanje(2.10)` varchar(45) NOT NULL,
  `pracenje_kvalitete (2.13)` varchar(100) NOT NULL,
  `pohadanje_nastave(3.1)` varchar(100) NOT NULL,
  `kontakt_nastavnik(3.2)` varchar(45) NOT NULL,
  `info(3.3)` varchar(100) NOT NULL,
  `radovi(3.4)` varchar(45) NOT NULL,
  `ostalo(3.5)` varchar(45) NOT NULL,
  PRIMARY KEY (`id_program`),
  UNIQUE KEY `id_program_UNIQUE` (`id_program`),
  UNIQUE KEY `id_kolegij_UNIQUE` (`id_kolegij`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `kolegij opce info` */

/*Table structure for table `kolegij opterecenje` */

DROP TABLE IF EXISTS `kolegij opterecenje`;

CREATE TABLE `kolegij opterecenje` (
  `id_program` int(11) NOT NULL,
  `id_kolegij` int(11) NOT NULL,
  `naziv_opterecenja` varchar(45) NOT NULL,
  `sati` int(11) NOT NULL,
  PRIMARY KEY (`id_program`),
  UNIQUE KEY `id_program_UNIQUE` (`id_program`),
  UNIQUE KEY `id_kolegij_UNIQUE` (`id_kolegij`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='				';

/*Data for the table `kolegij opterecenje` */

/*Table structure for table `kolegij_pracenje` */

DROP TABLE IF EXISTS `kolegij_pracenje`;

CREATE TABLE `kolegij_pracenje` (
  `id_program` int(11) NOT NULL,
  `id_kolegij` int(11) NOT NULL,
  `pohadanje` varchar(45) NOT NULL,
  `eksperimentalni_rad` varchar(45) NOT NULL,
  `esej` varchar(45) NOT NULL,
  `kolokvij` varchar(45) NOT NULL,
  `aktivnost` varchar(45) NOT NULL,
  `pismeni` varchar(45) NOT NULL,
  `istrazivanje` varchar(45) NOT NULL,
  `referat` varchar(45) NOT NULL,
  `seminar` varchar(45) NOT NULL,
  `prakticni` varchar(45) NOT NULL,
  `usmeni` varchar(45) NOT NULL,
  `projekt` varchar(45) NOT NULL,
  `kontinuirana` varchar(45) NOT NULL,
  `ostalo_opis_1` varchar(45) NOT NULL,
  `ostalo_opis_1_ects` varchar(45) NOT NULL,
  `ostalo_opis_2` varchar(45) NOT NULL,
  `ostalo_opis_2_ECTS` varchar(45) NOT NULL,
  `kolegij_pracenjecol2` varchar(45) NOT NULL,
  PRIMARY KEY (`id_program`),
  UNIQUE KEY `id_program_UNIQUE` (`id_program`),
  UNIQUE KEY `kolegij_pracenjecol_UNIQUE` (`id_kolegij`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `kolegij_pracenje` */

/*Table structure for table `kolegij_teme` */

DROP TABLE IF EXISTS `kolegij_teme`;

CREATE TABLE `kolegij_teme` (
  `id_program` int(11) NOT NULL,
  `id_kolegij` int(11) NOT NULL,
  `red_broj` int(11) NOT NULL,
  `predavanje` varchar(100) NOT NULL,
  `vjezba` varchar(100) NOT NULL,
  `literatura` varchar(100) NOT NULL,
  `ishodi` varchar(100) NOT NULL,
  `predavanje_sati` int(11) NOT NULL,
  `vjezbe_sati` int(11) NOT NULL,
  PRIMARY KEY (`id_program`),
  UNIQUE KEY `id_program_UNIQUE` (`id_kolegij`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `kolegij_teme` */

/*Table structure for table `kolegij_vrsta_nastave` */

DROP TABLE IF EXISTS `kolegij_vrsta_nastave`;

CREATE TABLE `kolegij_vrsta_nastave` (
  `id_program` int(11) NOT NULL,
  `id_kolegi` int(11) NOT NULL,
  `predavanje` varchar(45) NOT NULL,
  `seminari` varchar(45) NOT NULL,
  `vjezbe` varchar(45) NOT NULL,
  `na_daljinu` varchar(45) NOT NULL,
  `mjesovito` varchar(45) NOT NULL,
  `terenska` varchar(45) NOT NULL,
  `samostalni_rad` varchar(45) NOT NULL,
  `multimedija` varchar(45) NOT NULL,
  `laboratorij` varchar(45) NOT NULL,
  `mentor` varchar(45) NOT NULL,
  `ostalo (txt)` varchar(45) NOT NULL,
  `komentar` varchar(45) NOT NULL,
  PRIMARY KEY (`id_program`),
  UNIQUE KEY `id_program_UNIQUE` (`id_program`),
  UNIQUE KEY `id_kolegi_UNIQUE` (`id_kolegi`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `kolegij_vrsta_nastave` */

/*Table structure for table `korisnik` */

DROP TABLE IF EXISTS `korisnik`;

CREATE TABLE `korisnik` (
  `id_korisnik` int(11) NOT NULL,
  `ime_prezime` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `lozinka` varchar(45) NOT NULL,
  `vrsta_korisnika` varchar(45) NOT NULL,
  `titula` varchar(45) NOT NULL,
  `id_ustanova` varchar(45) NOT NULL,
  `licenca` varchar(45) NOT NULL,
  `aktivacijski link` varchar(45) NOT NULL,
  `aktivan (da/ne)` varchar(45) NOT NULL,
  PRIMARY KEY (`id_korisnik`),
  UNIQUE KEY `id_korisnik_UNIQUE` (`id_korisnik`),
  UNIQUE KEY `id_ustanova_UNIQUE` (`id_ustanova`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `korisnik` */

/*Table structure for table `program_kolegij` */

DROP TABLE IF EXISTS `program_kolegij`;

CREATE TABLE `program_kolegij` (
  `id_program` int(11) NOT NULL,
  `id_kolegij` int(11) NOT NULL,
  `semestar` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_program`),
  UNIQUE KEY `id_program_UNIQUE` (`id_program`),
  UNIQUE KEY `id_kolegij_UNIQUE` (`id_kolegij`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `program_kolegij` */

/*Table structure for table `studijski program` */

DROP TABLE IF EXISTS `studijski program`;

CREATE TABLE `studijski program` (
  `id_program` int(10) NOT NULL,
  `naziv` varchar(45) NOT NULL,
  `id_ustanova` int(11) NOT NULL,
  `ak_godina` varchar(45) NOT NULL,
  `opis` varchar(45) NOT NULL,
  PRIMARY KEY (`id_program`),
  UNIQUE KEY `id_ustanova_UNIQUE` (`id_ustanova`),
  UNIQUE KEY `id_program_UNIQUE` (`id_program`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `studijski program` */

/*Table structure for table `ustanova` */

DROP TABLE IF EXISTS `ustanova`;

CREATE TABLE `ustanova` (
  `id_ustanova` int(10) NOT NULL,
  `naziv` varchar(45) NOT NULL,
  `adresa` varchar(45) NOT NULL,
  `grad` varchar(45) NOT NULL,
  PRIMARY KEY (`id_ustanova`),
  UNIQUE KEY `id_ustanova_UNIQUE` (`id_ustanova`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `ustanova` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
