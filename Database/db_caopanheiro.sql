-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 18-Maio-2019 às 20:53
-- Versão do servidor: 10.1.38-MariaDB
-- versão do PHP: 7.3.2

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
-- Estrutura da tabela `animal`
--

CREATE TABLE `animal` (
  `id` int(11) NOT NULL,
  `nome_animal` varchar(255) NOT NULL,
  `sexo` varchar(100) NOT NULL,
  `cliente_id` int(11) NOT NULL,
  `especie` varchar(255) NOT NULL,
  `raca` varchar(255) NOT NULL,
  `identificacao` varchar(255) NOT NULL,
  `fobias` tinyint(1) NOT NULL,
  `disponivel_tosa` tinyint(1) NOT NULL,
  `pedigree` tinyint(1) NOT NULL,
  `agressivo` tinyint(1) NOT NULL,
  `hiperativo` tinyint(1) NOT NULL,
  `anti_social` tinyint(1) NOT NULL,
  `obcessivo` tinyint(1) NOT NULL,
  `relacao_vacinas` varchar(300) NOT NULL,
  `observacao_comportamentais` varchar(300) NOT NULL,
  `observacao_rotina` varchar(300) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `animal`
--

INSERT INTO `animal` (`id`, `nome_animal`, `sexo`, `cliente_id`, `especie`, `raca`, `identificacao`, `fobias`, `disponivel_tosa`, `pedigree`, `agressivo`, `hiperativo`, `anti_social`, `obcessivo`, `relacao_vacinas`, `observacao_comportamentais`, `observacao_rotina`) VALUES
(1, 'Jorge', 'Macho', 1, 'asdasda', 'dsadasdsa', 'asdasdsadsa', 1, 0, 0, 0, 0, 0, 0, 'sadasdasd', 'asdasdsad', 'sadsadasdasdsad');

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
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
-- Extraindo dados da tabela `cliente`
--

INSERT INTO `cliente` (`id`, `nome_completo`, `tipo`, `nome_apelido`, `endereco`, `bairro`, `cidade`, `uf`, `cep`, `telefone_primario`, `telefone_secundario`, `celular`, `complemento`, `email`, `cpf`, `cnpj`, `observacoes`) VALUES
(1, 'Jose luis da puta queo pariu', 'Cliente Comum', 'joselito', 'Rua da amargura n° 666888', 'Parque da tristeza', 'Ribeirão Pires', 'SP', '10101-066', '(00)0000-0000', '(  )    -', '(19)99334-4880', 'Caixão', 'ribeiraopericles@gmail.com', '000,000,000-00', '  ,   ,   /    -', 'Busque conhecimento'),
(3, 'asdadadadad', 'Cliente especial', 'asdasdasd', 'asdasdas', 'asdasdads', 'asdsadasd', 'AP', '00000-000', '(00)0000-0000', '(  )    -', '(  )     -', '', '', '000,000,000-00', '  ,   ,   /    -', ''),
(5, 'fffdfdfrrrrrrrrrrrrrrrr', 'Cliente Especial', 'dfdf', 'dfdf', 'dfdf', 'dfdf', 'BA', '00000-000', '(00)0000-0000', '(  )    -', '(  )     -', '', '', '000,000,000-00', '  ,   ,   /    -', '');

-- --------------------------------------------------------

--
-- Estrutura da tabela `fornecedor`
--

CREATE TABLE `fornecedor` (
  `id` int(11) NOT NULL,
  `nome_fornecedor` varchar(300) NOT NULL,
  `tipo_fornecimento` varchar(300) NOT NULL,
  `apelido_fornecedor` varchar(300) DEFAULT NULL,
  `endereco` varchar(300) NOT NULL,
  `bairro` varchar(300) NOT NULL,
  `cidade` varchar(300) NOT NULL,
  `uf` varchar(2) NOT NULL,
  `cep` varchar(9) DEFAULT NULL,
  `telefone` varchar(13) NOT NULL,
  `celular` varchar(14) DEFAULT NULL,
  `email` varchar(300) DEFAULT NULL,
  `cpf` varchar(14) NOT NULL,
  `cnpj` varchar(18) DEFAULT NULL,
  `observacoes` varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `fornecedor`
--

INSERT INTO `fornecedor` (`id`, `nome_fornecedor`, `tipo_fornecimento`, `apelido_fornecedor`, `endereco`, `bairro`, `cidade`, `uf`, `cep`, `telefone`, `celular`, `email`, `cpf`, `cnpj`, `observacoes`) VALUES
(1, 'John Cena', 'Porrada', 'asdasdasdsad', 'asdasdasdasdasd', 'asdasdasda', 'asdasdasdasd', 'SC', '00000-000', '(10)1010-1010', '(  )     -', 'vaitomarnoseufiofó@gmail.com', '101,010,101-01', '  ,   ,   /    -', 'Proteina de soja é proteina de viado.\n\ncade a soja'),
(2, 'Ana maria', 'Cu', '', 'Vrau', 'vrau', 'carai', 'DF', '     -', '(00)0000-0000', '(  )     -', '', '000,000,000-00', '  ,   ,   /    -', '');

-- --------------------------------------------------------

--
-- Estrutura da tabela `produto`
--

CREATE TABLE `produto` (
  `id` int(11) NOT NULL,
  `nome_produto` varchar(300) NOT NULL,
  `codigo_barras` varchar(300) DEFAULT NULL,
  `unidade` varchar(100) NOT NULL,
  `quantidade` int(11) NOT NULL,
  `referencia` varchar(300) DEFAULT NULL,
  `local_fisico` varchar(300) DEFAULT NULL,
  `data_modificacao` date NOT NULL,
  `marca` varchar(300) DEFAULT NULL,
  `categoria` varchar(300) NOT NULL,
  `estoque_minimo` double DEFAULT NULL,
  `estoque_atual` double NOT NULL,
  `data_validade` date DEFAULT NULL,
  `valor_custo` decimal(22,2) DEFAULT NULL,
  `margem_avista` int(11) DEFAULT NULL,
  `valor_produto` decimal(22,2) NOT NULL,
  `observacoes` varchar(300) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `produto`
--

INSERT INTO `produto` (`id`, `nome_produto`, `codigo_barras`, `unidade`, `quantidade`, `referencia`, `local_fisico`, `data_modificacao`, `marca`, `categoria`, `estoque_minimo`, `estoque_atual`, `data_validade`, `valor_custo`, `margem_avista`, `valor_produto`, `observacoes`) VALUES
(2, 'Ração de Urubu', '40808080', 'Kg', 20, 'testando', 'inferno', '2019-08-04', 'Urubuzeiro', 'Rações', 30, 90, '2019-08-04', '1000.00', 0, '5000.00', 'isso é um teste'),
(3, 'Ração pa', '40089078895', 'Kg', 10, 'testando', 'na puta queo pariu', '2019-04-11', 'Capivaracitubaina', 'Rações', 50, 800, '2019-11-29', '1000.00', 50, '3000.00', 'testando essa tela');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `animal`
--
ALTER TABLE `animal`
  ADD PRIMARY KEY (`id`),
  ADD KEY `cliente_id_fk` (`cliente_id`);

--
-- Indexes for table `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `fornecedor`
--
ALTER TABLE `fornecedor`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `produto`
--
ALTER TABLE `produto`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `animal`
--
ALTER TABLE `animal`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `cliente`
--
ALTER TABLE `cliente`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `fornecedor`
--
ALTER TABLE `fornecedor`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `produto`
--
ALTER TABLE `produto`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `animal`
--
ALTER TABLE `animal`
  ADD CONSTRAINT `pessoa_id_fk` FOREIGN KEY (`cliente_id`) REFERENCES `cliente` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
