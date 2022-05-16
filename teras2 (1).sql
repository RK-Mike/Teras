-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 17.05.2022 klo 01:01
-- Palvelimen versio: 10.4.21-MariaDB
-- PHP Version: 8.0.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `teras2`
--

-- --------------------------------------------------------

--
-- Rakenne taululle `gridi`
--

CREATE TABLE `gridi` (
  `id` int(11) NOT NULL,
  `Nimike` varchar(25) DEFAULT NULL,
  `Tiedot` varchar(255) DEFAULT NULL,
  `Kuittaus` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `gridi`
--

INSERT INTO `gridi` (`id`, `Nimike`, `Tiedot`, `Kuittaus`) VALUES
(7, 's', 's', 's');

-- --------------------------------------------------------

--
-- Rakenne taululle `gridi2`
--

CREATE TABLE `gridi2` (
  `id` int(11) NOT NULL,
  `Nimike` varchar(25) DEFAULT NULL,
  `Tiedot` varchar(255) DEFAULT NULL,
  `Kuittaus` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `gridi2`
--

INSERT INTO `gridi2` (`id`, `Nimike`, `Tiedot`, `Kuittaus`) VALUES
(17, 's', 's', 's'),
(18, 'k', 'k', 'k'),
(19, 'ö', NULL, NULL);

-- --------------------------------------------------------

--
-- Rakenne taululle `gridi3`
--

CREATE TABLE `gridi3` (
  `id` int(11) NOT NULL,
  `Nimike` varchar(25) DEFAULT NULL,
  `Tiedot` varchar(255) DEFAULT NULL,
  `Kuittaus` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `gridi3`
--

INSERT INTO `gridi3` (`id`, `Nimike`, `Tiedot`, `Kuittaus`) VALUES
(49, 'g', 'g', 'g');

-- --------------------------------------------------------

--
-- Rakenne taululle `users`
--

CREATE TABLE `users` (
  `ID` int(10) DEFAULT NULL,
  `Password` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `users`
--

INSERT INTO `users` (`ID`, `Password`) VALUES
(1, 'admin123');

-- --------------------------------------------------------

--
-- Rakenne taululle `yhteenveto`
--

CREATE TABLE `yhteenveto` (
  `id` int(11) NOT NULL,
  `Nimike` varchar(25) DEFAULT NULL,
  `Tiedot` varchar(255) DEFAULT NULL,
  `Kuittaus` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `yhteenveto`
--

INSERT INTO `yhteenveto` (`id`, `Nimike`, `Tiedot`, `Kuittaus`) VALUES
(1, 'Mikael', 'Raine', 'LOL'),
(2, 'ö', NULL, NULL);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `gridi`
--
ALTER TABLE `gridi`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `gridi2`
--
ALTER TABLE `gridi2`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `gridi3`
--
ALTER TABLE `gridi3`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `yhteenveto`
--
ALTER TABLE `yhteenveto`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `gridi`
--
ALTER TABLE `gridi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `gridi2`
--
ALTER TABLE `gridi2`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `gridi3`
--
ALTER TABLE `gridi3`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=50;

--
-- AUTO_INCREMENT for table `yhteenveto`
--
ALTER TABLE `yhteenveto`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
