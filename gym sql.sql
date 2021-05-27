-- --------------------------------------------------------
-- Värd:                         127.0.0.1
-- Serverversion:                10.5.8-MariaDB - mariadb.org binary distribution
-- Server-OS:                    Win64
-- HeidiSQL Version:             11.2.0.6213
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumpar databasstruktur för gym
CREATE DATABASE IF NOT EXISTS `gym` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `gym`;

-- Dumpar struktur för tabell gym.medlemmar
CREATE TABLE IF NOT EXISTS `medlemmar` (
  `MID` int(11) NOT NULL AUTO_INCREMENT,
  `Förnamn` varchar(50) DEFAULT NULL,
  `Efternamn` varchar(50) DEFAULT NULL,
  `Kön` varchar(50) DEFAULT NULL,
  `Födelsedag` varchar(50) DEFAULT NULL,
  `Nummer` int(11) DEFAULT NULL,
  `Mail` varchar(50) DEFAULT NULL,
  `Tecknat` varchar(50) DEFAULT NULL,
  `Nivå` varchar(50) DEFAULT NULL,
  `Period` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`MID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- Dataexport var bortvalt.

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
