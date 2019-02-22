-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 22, 2019 at 11:07 PM
-- Server version: 10.1.28-MariaDB
-- PHP Version: 7.1.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_caopanheiro`
--

-- --------------------------------------------------------

--
-- Table structure for table `cliente`
--

CREATE TABLE `cliente` (
  `id` int(11) NOT NULL,
  `nome_completo` varchar(500) NOT NULL,
  `tipo` varchar(500) NOT NULL,
  `nome_apelido` varchar(500) NOT NULL,
  `endereco` varchar(500) NOT NULL,
  `bairro` varchar(500) NOT NULL,
  `cidade` varchar(500) NOT NULL,
  `uf` varchar(2) NOT NULL,
  `cep` varchar(9) NOT NULL,
  `telefone_primario` varchar(13) NOT NULL,
  `telefone_secundario` varchar(13) DEFAULT NULL,
  `celular` varchar(14) DEFAULT NULL,
  `complemento` varchar(500) DEFAULT NULL,
  `email` varchar(500) DEFAULT NULL,
  `cpf` varchar(14) NOT NULL,
  `cnpj` varchar(18) DEFAULT NULL,
  `observacoes` varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `cliente`
--

INSERT INTO `cliente` (`id`, `nome_completo`, `tipo`, `nome_apelido`, `endereco`, `bairro`, `cidade`, `uf`, `cep`, `telefone_primario`, `telefone_secundario`, `celular`, `complemento`, `email`, `cpf`, `cnpj`, `observacoes`) VALUES
(1, 'Jose luis da puta queo pariu', 'Cliente comum', 'joselito', 'Rua da amargura n° 666', 'Parque da tristeza', 'Ribeirão Pires', 'SP', '10101-066', '(00)0000-0000', '(  )    -', '(19)99334-4880', 'Caixão', 'ribeiraopericles@gmail.com', '000,000,000-00', '  ,   ,   /    -', 'Busque conhecimento'),
(3, 'asdadadadad', 'Cliente especial', 'asdasdasd', 'asdasdas', 'asdasdads', 'asdsadasd', 'AP', '00000-000', '(00)0000-0000', '(  )    -', '(  )     -', '', '', '000,000,000-00', '  ,   ,   /    -', ''),
(5, 'fffdfdf', 'Cliente comum', 'dfdf', 'dfdf', 'dfdf', 'dfdf', 'BA', '00000-000', '(00)0000-0000', '(  )    -', '(  )     -', '', '', '000,000,000-00', '  ,   ,   /    -', '');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cliente`
--
ALTER TABLE `cliente`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
