-- MySqlBackup.NET 2.0.12
-- Dump Time: 2018-07-09 19:08:39
-- --------------------------------------
-- Server version 5.1.72-community MySQL Community Server (GPL)


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES latin1 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of alunos
-- 

DROP TABLE IF EXISTS `alunos`;
CREATE TABLE IF NOT EXISTS `alunos` (
  `IdAluno` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Nome` varchar(60) DEFAULT NULL,
  `Apelido` varchar(30) DEFAULT NULL,
  `Sexo` varchar(2) DEFAULT NULL,
  `Nascimento` date DEFAULT NULL,
  `CPF` varchar(12) DEFAULT NULL,
  `RG` varchar(10) DEFAULT NULL,
  `Cidade` varchar(30) DEFAULT NULL,
  `Logradouro` varchar(30) DEFAULT NULL,
  `Numero` varchar(6) DEFAULT NULL,
  `Bairro` varchar(30) DEFAULT NULL,
  `UF` varchar(3) DEFAULT NULL,
  `CEP` varchar(10) DEFAULT NULL,
  `Admissao` date DEFAULT NULL,
  `Telefone` varchar(11) DEFAULT NULL,
  `Celular` varchar(13) DEFAULT NULL,
  `Situacao` int(11) DEFAULT NULL,
  `dia_vencimento` int(10) unsigned DEFAULT NULL,
  PRIMARY KEY (`IdAluno`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table alunos
-- 

/*!40000 ALTER TABLE `alunos` DISABLE KEYS */;
INSERT INTO `alunos`(`IdAluno`,`Nome`,`Apelido`,`Sexo`,`Nascimento`,`CPF`,`RG`,`Cidade`,`Logradouro`,`Numero`,`Bairro`,`UF`,`CEP`,`Admissao`,`Telefone`,`Celular`,`Situacao`,`dia_vencimento`) VALUES
(14,'Diego SOUZA','SOUZA','M','2017-11-29 00:00:00','38711654848','','','','','','','','2017-12-04 00:00:00','','',0,NULL),
(15,'Joao Victor F Miranda','Bulani','M','2017-11-30 00:00:00','46847833831','531462841','Tupi Paulista','Antonia Flumian','108','Jardim Petropolis','SP','17930000','2017-11-30 00:00:00','1838513823','18997399959',0,NULL),
(16,'Joao','','M','2017-11-29 00:00:00','46847833831','','','','','','','','2017-11-29 00:00:00','','',2,NULL),
(18,'Joao Victor Teste','Bulani ','M','1999-08-15 00:00:00','46847833831','531462481','','','','','SP','','2017-12-05 00:00:00','','',0,NULL);
/*!40000 ALTER TABLE `alunos` ENABLE KEYS */;

-- 
-- Definition of caixas
-- 

DROP TABLE IF EXISTS `caixas`;
CREATE TABLE IF NOT EXISTS `caixas` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `data_abertura` datetime NOT NULL DEFAULT '0000-00-00 00:00:00',
  `data_fechamento` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table caixas
-- 

/*!40000 ALTER TABLE `caixas` DISABLE KEYS */;
INSERT INTO `caixas`(`id`,`data_abertura`,`data_fechamento`) VALUES
(1,'2018-07-02 00:00:00','2018/07/03'),
(2,'2018-07-04 00:00:00','2018-07-08 18:16:01.973014');
/*!40000 ALTER TABLE `caixas` ENABLE KEYS */;

-- 
-- Definition of contas_receber
-- 

DROP TABLE IF EXISTS `contas_receber`;
CREATE TABLE IF NOT EXISTS `contas_receber` (
  `idcontas_receber` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idcontrato` int(10) unsigned DEFAULT NULL,
  `valor` float NOT NULL DEFAULT '0',
  `data_emissao` datetime NOT NULL DEFAULT '0000-00-00 00:00:00',
  `data_vencimento` datetime NOT NULL DEFAULT '0000-00-00 00:00:00',
  `valor_juros` float NOT NULL DEFAULT '0',
  `pendente` tinyint(1) NOT NULL DEFAULT '1',
  `idaluno` int(10) unsigned DEFAULT NULL,
  PRIMARY KEY (`idcontas_receber`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table contas_receber
-- 

/*!40000 ALTER TABLE `contas_receber` DISABLE KEYS */;
INSERT INTO `contas_receber`(`idcontas_receber`,`idcontrato`,`valor`,`data_emissao`,`data_vencimento`,`valor_juros`,`pendente`,`idaluno`) VALUES
(3,7,85,'2018-06-05 22:27:39','2018-07-05 22:27:39',0,1,0);
/*!40000 ALTER TABLE `contas_receber` ENABLE KEYS */;

-- 
-- Definition of contrato_alunos
-- 

DROP TABLE IF EXISTS `contrato_alunos`;
CREATE TABLE IF NOT EXISTS `contrato_alunos` (
  `idcontrato_aluno` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idcontrato` int(10) unsigned NOT NULL DEFAULT '0',
  `idaluno` int(10) unsigned NOT NULL DEFAULT '0',
  PRIMARY KEY (`idcontrato_aluno`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table contrato_alunos
-- 

/*!40000 ALTER TABLE `contrato_alunos` DISABLE KEYS */;
INSERT INTO `contrato_alunos`(`idcontrato_aluno`,`idcontrato`,`idaluno`) VALUES
(5,7,14);
/*!40000 ALTER TABLE `contrato_alunos` ENABLE KEYS */;

-- 
-- Definition of contratos
-- 

DROP TABLE IF EXISTS `contratos`;
CREATE TABLE IF NOT EXISTS `contratos` (
  `idcontrato` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `data_emissao` varchar(45) NOT NULL DEFAULT '',
  `ativo` tinyint(1) NOT NULL DEFAULT '0',
  `idaluno_responsavel` int(10) unsigned DEFAULT NULL,
  `desconto` float DEFAULT NULL,
  `acrescimo` float DEFAULT NULL,
  `subtotal` float DEFAULT NULL,
  `dia_vencimento` int(10) unsigned DEFAULT NULL,
  `total` float NOT NULL DEFAULT '0',
  PRIMARY KEY (`idcontrato`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table contratos
-- 

/*!40000 ALTER TABLE `contratos` DISABLE KEYS */;
INSERT INTO `contratos`(`idcontrato`,`data_emissao`,`ativo`,`idaluno_responsavel`,`desconto`,`acrescimo`,`subtotal`,`dia_vencimento`,`total`) VALUES
(7,'2018-06-05 22:27:37',1,14,0,0,0,26,0);
/*!40000 ALTER TABLE `contratos` ENABLE KEYS */;

-- 
-- Definition of dia_hora_modalidade
-- 

DROP TABLE IF EXISTS `dia_hora_modalidade`;
CREATE TABLE IF NOT EXISTS `dia_hora_modalidade` (
  `IdDiaHoraM` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Dia` int(10) unsigned NOT NULL DEFAULT '0',
  `Hora_inicio` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  `IdModalidade` int(10) unsigned NOT NULL DEFAULT '0',
  `Hora_fim` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  PRIMARY KEY (`IdDiaHoraM`),
  KEY `FK_dhm_modalidade` (`IdModalidade`),
  CONSTRAINT `FK_dhm_modalidade` FOREIGN KEY (`IdModalidade`) REFERENCES `modalidades` (`IdModalidade`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table dia_hora_modalidade
-- 

/*!40000 ALTER TABLE `dia_hora_modalidade` DISABLE KEYS */;
INSERT INTO `dia_hora_modalidade`(`IdDiaHoraM`,`Dia`,`Hora_inicio`,`IdModalidade`,`Hora_fim`) VALUES
(11,1,'2017-12-10 13:00:00',5,'2017-12-10 14:00:00'),
(12,3,'2017-12-10 15:00:00',5,'2017-12-10 16:00:00'),
(13,0,'2017-12-11 09:00:00',5,'2017-12-11 10:00:00');
/*!40000 ALTER TABLE `dia_hora_modalidade` ENABLE KEYS */;

-- 
-- Definition of empresa
-- 

DROP TABLE IF EXISTS `empresa`;
CREATE TABLE IF NOT EXISTS `empresa` (
  `IdEmpresa` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `NomeFantasia` varchar(70) DEFAULT NULL,
  `Razao` varchar(70) DEFAULT NULL,
  `CNPJ` varchar(15) DEFAULT NULL,
  `IE` varchar(13) DEFAULT NULL,
  `Fundacao` date DEFAULT NULL,
  `Logradouro` varchar(30) DEFAULT NULL,
  `Bairro` varchar(30) DEFAULT NULL,
  `Cidade` varchar(30) DEFAULT NULL,
  `UF` varchar(2) DEFAULT NULL,
  `Numero` varchar(6) DEFAULT NULL,
  `CEP` varchar(10) DEFAULT NULL,
  `Telefone` varchar(11) DEFAULT NULL,
  `Celular` varchar(13) DEFAULT NULL,
  `Email` varchar(40) DEFAULT NULL,
  `Responsavel` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`IdEmpresa`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table empresa
-- 

/*!40000 ALTER TABLE `empresa` DISABLE KEYS */;
INSERT INTO `empresa`(`IdEmpresa`,`NomeFantasia`,`Razao`,`CNPJ`,`IE`,`Fundacao`,`Logradouro`,`Bairro`,`Cidade`,`UF`,`Numero`,`CEP`,`Telefone`,`Celular`,`Email`,`Responsavel`) VALUES
(2,'Cronos Academia','Academia do João & Diego - ME','','1234567890123','2017-12-04 00:00:00','Av 9 de Julho','Centro','Tupi Paulista','SP','450','17930000','1838513851','18997399959','cronosacademia@gmail.com','João Víctor Fernandes Miranda');
/*!40000 ALTER TABLE `empresa` ENABLE KEYS */;

-- 
-- Definition of equipamentos
-- 

DROP TABLE IF EXISTS `equipamentos`;
CREATE TABLE IF NOT EXISTS `equipamentos` (
  `IdEquipamento` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Nome` varchar(45) NOT NULL DEFAULT '',
  `Situacao` tinyint(3) unsigned NOT NULL DEFAULT '0',
  PRIMARY KEY (`IdEquipamento`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table equipamentos
-- 

/*!40000 ALTER TABLE `equipamentos` DISABLE KEYS */;
INSERT INTO `equipamentos`(`IdEquipamento`,`Nome`,`Situacao`) VALUES
(2,'Leg Press',0),
(3,'Alteres 10KG',1),
(4,'tapete',1);
/*!40000 ALTER TABLE `equipamentos` ENABLE KEYS */;

-- 
-- Definition of exercicios
-- 

DROP TABLE IF EXISTS `exercicios`;
CREATE TABLE IF NOT EXISTS `exercicios` (
  `IdExercicio` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `IdEquipamento` int(10) unsigned NOT NULL DEFAULT '0',
  `Nome` varchar(45) NOT NULL DEFAULT '',
  `Obs` varchar(50) NOT NULL DEFAULT '',
  `img_exercicio` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`IdExercicio`),
  KEY `FK_IdEquipamento` (`IdEquipamento`),
  CONSTRAINT `FK_IdEquipamento` FOREIGN KEY (`IdEquipamento`) REFERENCES `equipamentos` (`IdEquipamento`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table exercicios
-- 

/*!40000 ALTER TABLE `exercicios` DISABLE KEYS */;
INSERT INTO `exercicios`(`IdExercicio`,`IdEquipamento`,`Nome`,`Obs`,`img_exercicio`) VALUES
(1,4,'abdominal','no tapete',NULL);
/*!40000 ALTER TABLE `exercicios` ENABLE KEYS */;

-- 
-- Definition of formas_pgto
-- 

DROP TABLE IF EXISTS `formas_pgto`;
CREATE TABLE IF NOT EXISTS `formas_pgto` (
  `idformas_pgto` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) NOT NULL DEFAULT '',
  `descricao` varchar(45) DEFAULT NULL,
  `contas_receber` tinyint(1) DEFAULT NULL,
  `cadastra_cheque` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idformas_pgto`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table formas_pgto
-- 

/*!40000 ALTER TABLE `formas_pgto` DISABLE KEYS */;
INSERT INTO `formas_pgto`(`idformas_pgto`,`nome`,`descricao`,`contas_receber`,`cadastra_cheque`) VALUES
(1,'Dinheiro','Dinheiro',NULL,NULL),
(2,'Cartao','Cartão de débito ou crédito',NULL,NULL),
(3,'Cheque','Cheque a vista ou a prazo',NULL,1),
(4,'Ficha','Crediario',1,NULL);
/*!40000 ALTER TABLE `formas_pgto` ENABLE KEYS */;

-- 
-- Definition of funcionarios
-- 

DROP TABLE IF EXISTS `funcionarios`;
CREATE TABLE IF NOT EXISTS `funcionarios` (
  `IdFuncionario` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Nome` varchar(60) DEFAULT NULL,
  `Sexo` varchar(2) DEFAULT NULL,
  `Nascimento` date DEFAULT NULL,
  `CPF` varchar(13) DEFAULT NULL,
  `RG` varchar(11) DEFAULT NULL,
  `Cidade` varchar(30) DEFAULT NULL,
  `Logradouro` varchar(30) DEFAULT NULL,
  `Numero` varchar(6) DEFAULT NULL,
  `Bairro` varchar(30) DEFAULT NULL,
  `UF` varchar(3) DEFAULT NULL,
  `CEP` varchar(10) DEFAULT NULL,
  `Admissao` date DEFAULT NULL,
  `Demissao` date DEFAULT NULL,
  `Telefone` varchar(11) DEFAULT NULL,
  `Celular` varchar(13) DEFAULT NULL,
  `Funcao` varchar(25) DEFAULT NULL,
  `Salario` double DEFAULT NULL,
  `Situacao` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdFuncionario`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table funcionarios
-- 

/*!40000 ALTER TABLE `funcionarios` DISABLE KEYS */;
INSERT INTO `funcionarios`(`IdFuncionario`,`Nome`,`Sexo`,`Nascimento`,`CPF`,`RG`,`Cidade`,`Logradouro`,`Numero`,`Bairro`,`UF`,`CEP`,`Admissao`,`Demissao`,`Telefone`,`Celular`,`Funcao`,`Salario`,`Situacao`) VALUES
(1,'João Víctor','M','1999-08-15 00:00:00','46847833831','531462481','Tupi Paulista','Antonia Flumian','108','Jardim Petropolis','SP','17930000','2017-12-04 00:00:00','1990-01-01 00:00:00','1838513823','18997399959','',1322,0),
(3,'João Víctor Fernandes Miranda','M','1999-08-15 00:00:00','46847833831','531462481','Tupi Paulista','Antonia Flumian','108','Jardim Petropolis','SP','17930000','2017-12-04 00:00:00','1990-01-01 00:00:00','1838513823','18997399959','',1550.5,0),
(7,'Diego','M','2017-12-05 00:00:00','','','Dracena','Rua das Rosas','24','','','','2017-12-05 00:00:00','1900-01-01 00:00:00','','','',1000,0),
(8,'João','M','1999-08-15 00:00:00','46847833831','531462481','Tupi Paulista','Antonia Flumian','108','Jardim Petropolis','SP','17930000','2017-12-05 00:00:00','1900-01-01 00:00:00','1838513823','18997399959','',5000,0);
/*!40000 ALTER TABLE `funcionarios` ENABLE KEYS */;

-- 
-- Definition of grupos_treinos
-- 

DROP TABLE IF EXISTS `grupos_treinos`;
CREATE TABLE IF NOT EXISTS `grupos_treinos` (
  `IdGruposTreinos` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Nome` varchar(50) NOT NULL DEFAULT '',
  PRIMARY KEY (`IdGruposTreinos`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table grupos_treinos
-- 

/*!40000 ALTER TABLE `grupos_treinos` DISABLE KEYS */;
INSERT INTO `grupos_treinos`(`IdGruposTreinos`,`Nome`) VALUES
(3,'Avançado'),
(4,'teste 2'),
(5,'teste isnercao');
/*!40000 ALTER TABLE `grupos_treinos` ENABLE KEYS */;

-- 
-- Definition of modalidades
-- 

DROP TABLE IF EXISTS `modalidades`;
CREATE TABLE IF NOT EXISTS `modalidades` (
  `IdModalidade` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Nome` varchar(30) DEFAULT NULL,
  `ValorMensal` double DEFAULT NULL,
  `ValorAula` double DEFAULT NULL,
  PRIMARY KEY (`IdModalidade`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table modalidades
-- 

/*!40000 ALTER TABLE `modalidades` DISABLE KEYS */;
INSERT INTO `modalidades`(`IdModalidade`,`Nome`,`ValorMensal`,`ValorAula`) VALUES
(5,'Judo 2',150,15);
/*!40000 ALTER TABLE `modalidades` ENABLE KEYS */;

-- 
-- Definition of modalidades_planos
-- 

DROP TABLE IF EXISTS `modalidades_planos`;
CREATE TABLE IF NOT EXISTS `modalidades_planos` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idModalidade` int(10) unsigned NOT NULL DEFAULT '0',
  `idPlano` int(10) unsigned NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table modalidades_planos
-- 

/*!40000 ALTER TABLE `modalidades_planos` DISABLE KEYS */;

/*!40000 ALTER TABLE `modalidades_planos` ENABLE KEYS */;

-- 
-- Definition of mov_caixa
-- 

DROP TABLE IF EXISTS `mov_caixa`;
CREATE TABLE IF NOT EXISTS `mov_caixa` (
  `idmov_caixa` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `data` datetime NOT NULL DEFAULT '0000-00-00 00:00:00',
  `numero_caixa` int(10) unsigned NOT NULL DEFAULT '0',
  `valor` float NOT NULL DEFAULT '0',
  `tipo_pgto` int(10) unsigned NOT NULL DEFAULT '0',
  `id_plano_conta` int(10) unsigned DEFAULT NULL,
  PRIMARY KEY (`idmov_caixa`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table mov_caixa
-- 

/*!40000 ALTER TABLE `mov_caixa` DISABLE KEYS */;

/*!40000 ALTER TABLE `mov_caixa` ENABLE KEYS */;

-- 
-- Definition of planos
-- 

DROP TABLE IF EXISTS `planos`;
CREATE TABLE IF NOT EXISTS `planos` (
  `idPlano` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nome` varchar(55) NOT NULL DEFAULT '',
  `descricao` varchar(85) DEFAULT NULL,
  `valor` float NOT NULL DEFAULT '0',
  `qtde_alunos` int(10) unsigned NOT NULL DEFAULT '1',
  `freq_pagamento` int(10) unsigned NOT NULL DEFAULT '0',
  `taxa_inscricao` float unsigned NOT NULL DEFAULT '0',
  PRIMARY KEY (`idPlano`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table planos
-- 

/*!40000 ALTER TABLE `planos` DISABLE KEYS */;
INSERT INTO `planos`(`idPlano`,`nome`,`descricao`,`valor`,`qtde_alunos`,`freq_pagamento`,`taxa_inscricao`) VALUES
(1,'Academia mensal2','Plano individual com pagamento mensal',85,1,30,0),
(2,'Plano Familia','Plano mensal para até 3 pessoas ',250,3,30,0);
/*!40000 ALTER TABLE `planos` ENABLE KEYS */;

-- 
-- Definition of recebimentos
-- 

DROP TABLE IF EXISTS `recebimentos`;
CREATE TABLE IF NOT EXISTS `recebimentos` (
  `idrecebimentos` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `tipo_pgto` int(10) unsigned NOT NULL DEFAULT '0',
  `valor` float NOT NULL DEFAULT '0',
  `idcontas_receber` int(10) unsigned NOT NULL DEFAULT '0',
  `idaluno` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idrecebimentos`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table recebimentos
-- 

/*!40000 ALTER TABLE `recebimentos` DISABLE KEYS */;
INSERT INTO `recebimentos`(`idrecebimentos`,`tipo_pgto`,`valor`,`idcontas_receber`,`idaluno`) VALUES
(1,1,30,1,NULL);
/*!40000 ALTER TABLE `recebimentos` ENABLE KEYS */;

-- 
-- Definition of repeticoes
-- 

DROP TABLE IF EXISTS `repeticoes`;
CREATE TABLE IF NOT EXISTS `repeticoes` (
  `IdRepeticao` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `IdExercicio` int(10) unsigned NOT NULL DEFAULT '0',
  `QtdeRepeticoes` int(10) unsigned NOT NULL DEFAULT '0',
  `QtdeSeries` int(10) unsigned NOT NULL DEFAULT '0',
  `Minutos` int(10) unsigned DEFAULT '0',
  PRIMARY KEY (`IdRepeticao`),
  KEY `FK_exercicio` (`IdExercicio`),
  CONSTRAINT `FK_exercicio` FOREIGN KEY (`IdExercicio`) REFERENCES `exercicios` (`IdExercicio`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table repeticoes
-- 

/*!40000 ALTER TABLE `repeticoes` DISABLE KEYS */;
INSERT INTO `repeticoes`(`IdRepeticao`,`IdExercicio`,`QtdeRepeticoes`,`QtdeSeries`,`Minutos`) VALUES
(1,1,15,3,0),
(2,1,20,2,0),
(3,1,12,3,0);
/*!40000 ALTER TABLE `repeticoes` ENABLE KEYS */;

-- 
-- Definition of repeticoes_treinos
-- 

DROP TABLE IF EXISTS `repeticoes_treinos`;
CREATE TABLE IF NOT EXISTS `repeticoes_treinos` (
  `IdRepeticaoTreino` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `IdRepeticao` int(10) unsigned NOT NULL DEFAULT '0',
  `IdTreino` int(10) unsigned NOT NULL DEFAULT '0',
  PRIMARY KEY (`IdRepeticaoTreino`),
  KEY `FK_repeticao` (`IdRepeticao`),
  KEY `FK_treino` (`IdTreino`),
  CONSTRAINT `FK_repeticao` FOREIGN KEY (`IdRepeticao`) REFERENCES `repeticoes` (`IdRepeticao`),
  CONSTRAINT `FK_treino` FOREIGN KEY (`IdTreino`) REFERENCES `treinos` (`IdTreino`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table repeticoes_treinos
-- 

/*!40000 ALTER TABLE `repeticoes_treinos` DISABLE KEYS */;
INSERT INTO `repeticoes_treinos`(`IdRepeticaoTreino`,`IdRepeticao`,`IdTreino`) VALUES
(1,1,1),
(2,3,1);
/*!40000 ALTER TABLE `repeticoes_treinos` ENABLE KEYS */;

-- 
-- Definition of treinos
-- 

DROP TABLE IF EXISTS `treinos`;
CREATE TABLE IF NOT EXISTS `treinos` (
  `IdTreino` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Nome` varchar(45) NOT NULL DEFAULT '',
  `IdGrupoTreino` int(10) unsigned NOT NULL DEFAULT '0',
  PRIMARY KEY (`IdTreino`),
  KEY `FK_GrupoTreino` (`IdGrupoTreino`),
  CONSTRAINT `FK_GrupoTreino` FOREIGN KEY (`IdGrupoTreino`) REFERENCES `grupos_treinos` (`IdGruposTreinos`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table treinos
-- 

/*!40000 ALTER TABLE `treinos` DISABLE KEYS */;
INSERT INTO `treinos`(`IdTreino`,`Nome`,`IdGrupoTreino`) VALUES
(1,'Peito',3),
(2,'ombro',3);
/*!40000 ALTER TABLE `treinos` ENABLE KEYS */;

-- 
-- Definition of treinos_alunos
-- 

DROP TABLE IF EXISTS `treinos_alunos`;
CREATE TABLE IF NOT EXISTS `treinos_alunos` (
  `IdTreinoAluno` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `IdTreino` int(10) unsigned NOT NULL DEFAULT '0',
  `IdAluno` int(10) unsigned NOT NULL DEFAULT '0',
  PRIMARY KEY (`IdTreinoAluno`),
  KEY `FK_ta_treino` (`IdTreino`),
  KEY `FK_ta_aluno` (`IdAluno`),
  CONSTRAINT `FK_ta_aluno` FOREIGN KEY (`IdAluno`) REFERENCES `alunos` (`IdAluno`),
  CONSTRAINT `FK_ta_treino` FOREIGN KEY (`IdTreino`) REFERENCES `treinos` (`IdTreino`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table treinos_alunos
-- 

/*!40000 ALTER TABLE `treinos_alunos` DISABLE KEYS */;

/*!40000 ALTER TABLE `treinos_alunos` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2018-07-09 19:08:39
-- Total time: 0:0:0:0:408 (d:h:m:s:ms)
