CREATE DATABASE  IF NOT EXISTS `vitamedica` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `vitamedica`;
-- MySQL dump 10.13  Distrib 5.7.12, for Win64 (x86_64)
--
-- Host: localhost    Database: vitamedica
-- ------------------------------------------------------
-- Server version	5.7.17-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `vit_bad_transacciones`
--

DROP TABLE IF EXISTS `vit_bad_transacciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vit_bad_transacciones` (
  `idPropio` int(11) NOT NULL AUTO_INCREMENT,
  `idDia` int(11) NOT NULL,
  `originador` smallint(6) NOT NULL,
  `nodo` smallint(6) NOT NULL,
  `ticket` int(11) NOT NULL,
  `referTrans` varchar(20) NOT NULL,
  `fecha` date NOT NULL,
  `hora` datetime NOT NULL,
  `concepto` smallint(6) NOT NULL,
  `monto` decimal(9,2) NOT NULL DEFAULT '0.00',
  `trxtype` smallint(6) NOT NULL,
  `trxsubtype` smallint(6) NOT NULL,
  `estatus` smallint(6) NOT NULL,
  `vitidtransaccion` varchar(45) DEFAULT NULL,
  `vittype` smallint(6) NOT NULL,
  `vitaccount` varchar(50) DEFAULT NULL,
  `vitauth` varchar(50) NOT NULL DEFAULT '',
  `vitrefer` varchar(50) NOT NULL DEFAULT '',
  `referenciafg` varchar(20) NOT NULL,
  `idLote` int(11) NOT NULL,
  `idFolio` int(11) NOT NULL,
  `idColote` int(11) NOT NULL DEFAULT '0',
  `finInserta` datetime NOT NULL,
  `fEstatus` datetime NOT NULL,
  `fee` decimal(9,2) NOT NULL DEFAULT '0.00' COMMENT 'Tarifa o comision',
  `vitacount` varchar(255) NOT NULL,
  `vitcode` int(11) DEFAULT NULL,
  `afectado` char(1) DEFAULT NULL,
  PRIMARY KEY (`idPropio`),
  UNIQUE KEY `originador` (`originador`,`nodo`,`referTrans`),
  UNIQUE KEY `lote` (`idLote`,`idFolio`,`originador`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vit_bad_transacciones`
--

LOCK TABLES `vit_bad_transacciones` WRITE;
/*!40000 ALTER TABLE `vit_bad_transacciones` DISABLE KEYS */;
/*!40000 ALTER TABLE `vit_bad_transacciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vit_bit_error`
--

DROP TABLE IF EXISTS `vit_bit_error`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vit_bit_error` (
  `idPropio` int(11) NOT NULL AUTO_INCREMENT,
  `referTrans` varchar(20) CHARACTER SET utf8 NOT NULL,
  `origen` smallint(6) NOT NULL,
  `nodo` smallint(6) NOT NULL,
  `error` varchar(10) COLLATE utf8_spanish_ci DEFAULT NULL COMMENT '1 - Interno\\\\n2 - Proveedor',
  `descError` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `fecha` datetime DEFAULT NULL,
  `type` varchar(25) COLLATE utf8_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`idPropio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vit_bit_error`
--

LOCK TABLES `vit_bit_error` WRITE;
/*!40000 ALTER TABLE `vit_bit_error` DISABLE KEYS */;
/*!40000 ALTER TABLE `vit_bit_error` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vit_colotes`
--

DROP TABLE IF EXISTS `vit_colotes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vit_colotes` (
  `idPropio` int(11) NOT NULL AUTO_INCREMENT,
  `colote` int(11) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `fechaHora` datetime DEFAULT NULL,
  PRIMARY KEY (`idPropio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vit_colotes`
--

LOCK TABLES `vit_colotes` WRITE;
/*!40000 ALTER TABLE `vit_colotes` DISABLE KEYS */;
/*!40000 ALTER TABLE `vit_colotes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vit_comission`
--

DROP TABLE IF EXISTS `vit_comission`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vit_comission` (
  `idPropio` int(11) NOT NULL AUTO_INCREMENT,
  `vitatype` smallint(6) NOT NULL,
  `amount` decimal(9,2) NOT NULL,
  `startDate` datetime NOT NULL,
  PRIMARY KEY (`idPropio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vit_comission`
--

LOCK TABLES `vit_comission` WRITE;
/*!40000 ALTER TABLE `vit_comission` DISABLE KEYS */;
/*!40000 ALTER TABLE `vit_comission` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vit_consultas`
--

DROP TABLE IF EXISTS `vit_consultas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vit_consultas` (
  `id_vitconsultas` int(11) NOT NULL AUTO_INCREMENT,
  `tipoconsulta` varchar(45) NOT NULL,
  `folio` varchar(45) NOT NULL,
  `prpr_id` varchar(45) NOT NULL,
  `mensajeerror` varchar(200) DEFAULT NULL,
  `codigoerror` int(11) DEFAULT NULL,
  `fechaInsert` date DEFAULT NULL,
  `fechaUpdate` date DEFAULT NULL,
  PRIMARY KEY (`id_vitconsultas`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vit_consultas`
--

LOCK TABLES `vit_consultas` WRITE;
/*!40000 ALTER TABLE `vit_consultas` DISABLE KEYS */;
/*!40000 ALTER TABLE `vit_consultas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vit_folios`
--

DROP TABLE IF EXISTS `vit_folios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vit_folios` (
  `folio` int(11) NOT NULL AUTO_INCREMENT,
  `serFolio` varchar(3) NOT NULL,
  `estatus` varchar(1) NOT NULL DEFAULT 'A',
  `sucursal` int(11) NOT NULL,
  `fecha` date NOT NULL,
  PRIMARY KEY (`folio`,`sucursal`),
  KEY `folio01` (`folio`,`sucursal`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vit_folios`
--

LOCK TABLES `vit_folios` WRITE;
/*!40000 ALTER TABLE `vit_folios` DISABLE KEYS */;
/*!40000 ALTER TABLE `vit_folios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vit_headers`
--

DROP TABLE IF EXISTS `vit_headers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vit_headers` (
  `idPropio` int(11) NOT NULL AUTO_INCREMENT,
  `folioProceso` int(11) NOT NULL,
  `type` varchar(30) CHARACTER SET utf8 NOT NULL,
  `origen` varchar(30) COLLATE utf8_spanish_ci DEFAULT NULL,
  `nodo` varchar(20) COLLATE utf8_spanish_ci DEFAULT NULL,
  `date` datetime DEFAULT NULL,
  `txttype` varchar(5) COLLATE utf8_spanish_ci DEFAULT NULL,
  `trxsubtype` varchar(5) COLLATE utf8_spanish_ci DEFAULT NULL,
  `refertrans` varchar(20) COLLATE utf8_spanish_ci DEFAULT NULL,
  `error` varchar(15) COLLATE utf8_spanish_ci DEFAULT NULL,
  `origenresp` varchar(20) COLLATE utf8_spanish_ci DEFAULT NULL,
  `descerror` varchar(50) COLLATE utf8_spanish_ci DEFAULT NULL,
  `lote` varchar(25) COLLATE utf8_spanish_ci DEFAULT NULL,
  `transaccion` varchar(25) COLLATE utf8_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`idPropio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vit_headers`
--

LOCK TABLES `vit_headers` WRITE;
/*!40000 ALTER TABLE `vit_headers` DISABLE KEYS */;
/*!40000 ALTER TABLE `vit_headers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vit_infopaciente`
--

DROP TABLE IF EXISTS `vit_infopaciente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vit_infopaciente` (
  `id_vitinfoPaciente` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `ape_paterno` varchar(100) NOT NULL,
  `ape_materno` varchar(100) NOT NULL,
  `elegibilidad` varchar(15) NOT NULL,
  `num_receta` varchar(15) NOT NULL,
  `fecha_consulta` datetime NOT NULL,
  `tipo_empleado` int(11) NOT NULL,
  `estatus_empleado` int(11) NOT NULL,
  `numCredencial` varchar(20) NOT NULL,
  `cedula` varchar(20) NOT NULL,
  `id_persona` varchar(20) NOT NULL,
  PRIMARY KEY (`id_vitinfoPaciente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vit_infopaciente`
--

LOCK TABLES `vit_infopaciente` WRITE;
/*!40000 ALTER TABLE `vit_infopaciente` DISABLE KEYS */;
/*!40000 ALTER TABLE `vit_infopaciente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vit_lotes`
--

DROP TABLE IF EXISTS `vit_lotes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vit_lotes` (
  `lote` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date NOT NULL,
  `fechaHora` datetime NOT NULL,
  `estatus` varchar(1) NOT NULL DEFAULT 'A',
  `sucursal` int(11) NOT NULL,
  `serLote` varchar(3) NOT NULL,
  `colote` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`lote`,`sucursal`),
  KEY `lote01` (`lote`,`fecha`,`sucursal`),
  KEY `lote02` (`sucursal`,`colote`),
  KEY `lote03` (`colote`,`fecha`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vit_lotes`
--

LOCK TABLES `vit_lotes` WRITE;
/*!40000 ALTER TABLE `vit_lotes` DISABLE KEYS */;
/*!40000 ALTER TABLE `vit_lotes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vit_plantilla_paramsws`
--

DROP TABLE IF EXISTS `vit_plantilla_paramsws`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vit_plantilla_paramsws` (
  `id_plantilla_paramws` int(11) NOT NULL,
  `id_plantilla` int(11) NOT NULL,
  `REST_SERVICIOS` int(11) NOT NULL,
  `REST_URLS` int(11) NOT NULL,
  `nombreTrx` varchar(200) NOT NULL,
  `tipo` varchar(50) NOT NULL,
  `parametro` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vit_plantilla_paramsws`
--

LOCK TABLES `vit_plantilla_paramsws` WRITE;
/*!40000 ALTER TABLE `vit_plantilla_paramsws` DISABLE KEYS */;
/*!40000 ALTER TABLE `vit_plantilla_paramsws` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vit_services`
--

DROP TABLE IF EXISTS `vit_services`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vit_services` (
  `idvit_services` int(11) NOT NULL AUTO_INCREMENT,
  `idmensaje` int(11) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `url` varchar(250) DEFAULT NULL,
  `time` int(11) DEFAULT NULL,
  PRIMARY KEY (`idvit_services`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vit_services`
--

LOCK TABLES `vit_services` WRITE;
/*!40000 ALTER TABLE `vit_services` DISABLE KEYS */;
INSERT INTO `vit_services` VALUES (2,1,'Consulta de recetas y elegibilidad','https://paralelo.redvitamedica.com.mx/wsEnvioReceta/ConsultasFarmacia.asmx',30),(3,3,'Trx0 Inicio de Venta','https://paralelo.redvitamedica.com.mx/wstrx/servicios/wsAvisoTransaccion.asmx',30),(4,4,'Trx1 Datos de Receta','https://paralelo.redvitamedica.com.mx/wstrx/servicios/wsValidacionElegReceta.asmx',30),(5,5,'Trx2 Iniciar entrada de producto','https://paralelo.redvitamedica.com.mx/wstrx/servicios/wsBonificacion.asmx',30),(6,6,'Trx3 Devolucion de Producto','https://paralelo.redvitamedica.com.mx/wstrx/servicios/wsDevolucionProducto.asmx',30),(7,7,'Trx4 Finalizacion de Venta','https://paralelo.redvitamedica.com.mx/wstrx/servicios/wsConfirmacion.asmx',30),(8,8,'Trx5 Anular la Venta','https://paralelo.redvitamedica.com.mx/wstrx/servicios/wsAnularVenta.asmx',30);
/*!40000 ALTER TABLE `vit_services` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vit_servicio_params`
--

DROP TABLE IF EXISTS `vit_servicio_params`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vit_servicio_params` (
  `id_vitservicio_params` int(11) NOT NULL AUTO_INCREMENT,
  `sucursal` varchar(20) NOT NULL,
  `prpr_id_QA` varchar(20) NOT NULL,
  `prpr_id_producion` varchar(20) NOT NULL,
  `estatus` int(11) NOT NULL,
  PRIMARY KEY (`id_vitservicio_params`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vit_servicio_params`
--

LOCK TABLES `vit_servicio_params` WRITE;
/*!40000 ALTER TABLE `vit_servicio_params` DISABLE KEYS */;
/*!40000 ALTER TABLE `vit_servicio_params` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vit_transacciones`
--

DROP TABLE IF EXISTS `vit_transacciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vit_transacciones` (
  `idPropio` int(11) NOT NULL AUTO_INCREMENT,
  `idDia` int(11) NOT NULL,
  `originador` smallint(6) NOT NULL,
  `nodo` smallint(6) NOT NULL,
  `ticket` int(11) NOT NULL,
  `referTrans` varchar(20) NOT NULL,
  `fecha` date NOT NULL,
  `hora` datetime NOT NULL,
  `concepto` smallint(6) NOT NULL,
  `monto` decimal(9,2) NOT NULL DEFAULT '0.00',
  `trxtype` smallint(6) NOT NULL,
  `trxsubtype` smallint(6) NOT NULL,
  `estatus` smallint(6) NOT NULL,
  `vitidtransaccion` varchar(45) DEFAULT NULL,
  `vittype` smallint(6) NOT NULL,
  `vitaccount` varchar(50) DEFAULT NULL,
  `vitauth` varchar(50) NOT NULL DEFAULT '',
  `vitrefer` varchar(50) NOT NULL DEFAULT '',
  `referenciafg` varchar(20) NOT NULL,
  `idLote` int(11) NOT NULL,
  `idFolio` int(11) NOT NULL,
  `idColote` int(11) NOT NULL DEFAULT '0',
  `finInserta` datetime NOT NULL,
  `fEstatus` datetime NOT NULL,
  `fee` decimal(9,2) NOT NULL DEFAULT '0.00' COMMENT 'Tarifa o comision',
  `vitacount` varchar(255) NOT NULL,
  `vitcode` int(11) DEFAULT NULL,
  `afectado` char(1) DEFAULT NULL,
  PRIMARY KEY (`idPropio`),
  UNIQUE KEY `originador` (`originador`,`nodo`,`referTrans`),
  UNIQUE KEY `lote` (`idLote`,`idFolio`,`originador`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vit_transacciones`
--

LOCK TABLES `vit_transacciones` WRITE;
/*!40000 ALTER TABLE `vit_transacciones` DISABLE KEYS */;
/*!40000 ALTER TABLE `vit_transacciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vit_trx0`
--

DROP TABLE IF EXISTS `vit_trx0`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vit_trx0` (
  `id_vittrx0` int(11) NOT NULL AUTO_INCREMENT,
  `prIdenSucu` varchar(100) DEFAULT NULL,
  `prIdenCade` varchar(45) DEFAULT NULL,
  `SECINIVENTA` varchar(45) DEFAULT NULL,
  `ERROR` varchar(45) DEFAULT NULL,
  `createdAt` datetime DEFAULT NULL,
  `UpdateAt` datetime DEFAULT NULL,
  `Folio` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_vittrx0`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vit_trx0`
--

LOCK TABLES `vit_trx0` WRITE;
/*!40000 ALTER TABLE `vit_trx0` DISABLE KEYS */;
/*!40000 ALTER TABLE `vit_trx0` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vit_trx1`
--

DROP TABLE IF EXISTS `vit_trx1`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vit_trx1` (
  `id_vittrx1` int(11) NOT NULL AUTO_INCREMENT,
  `prSecuencia` varchar(45) NOT NULL,
  `prIdenCade` varchar(45) NOT NULL,
  `prIdenSucu` varchar(45) NOT NULL,
  `prNumElegibilidad` varchar(45) NOT NULL,
  `prFolioReceta` varchar(45) NOT NULL,
  `prCopia` varchar(45) DEFAULT NULL,
  `prSecIniVenta` varchar(45) DEFAULT NULL,
  `prNumPreautorizacion` varchar(45) DEFAULT NULL,
  `NOMB` varchar(45) DEFAULT NULL,
  `PRIMAPEL` varchar(45) DEFAULT NULL,
  `SEGUAPEL` varchar(45) DEFAULT NULL,
  `SEXO` varchar(45) DEFAULT NULL,
  `EDAD` varchar(45) DEFAULT NULL,
  `CLIENTE` varchar(45) DEFAULT NULL,
  `GRUPO` varchar(45) DEFAULT NULL,
  `VALIVENT` varchar(45) DEFAULT NULL,
  `CA1` varchar(45) DEFAULT NULL,
  `TIPORECETA` varchar(45) DEFAULT NULL,
  `MENS` varchar(45) DEFAULT NULL,
  `ERROR` varchar(45) DEFAULT NULL,
  `createdAt` datetime DEFAULT NULL,
  `updatedAt` datetime DEFAULT NULL,
  PRIMARY KEY (`id_vittrx1`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vit_trx1`
--

LOCK TABLES `vit_trx1` WRITE;
/*!40000 ALTER TABLE `vit_trx1` DISABLE KEYS */;
/*!40000 ALTER TABLE `vit_trx1` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vit_trx2`
--

DROP TABLE IF EXISTS `vit_trx2`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vit_trx2` (
  `id_vittrx2` int(11) NOT NULL AUTO_INCREMENT,
  `prSecuencia` varchar(45) NOT NULL,
  `prIdenCade` varchar(45) NOT NULL,
  `prIdenSucu` varchar(45) NOT NULL,
  `CA1` varchar(45) NOT NULL,
  `prIdenProd` varchar(45) DEFAULT NULL,
  `prCantToma` varchar(45) DEFAULT NULL,
  `prVecesDia` varchar(45) DEFAULT NULL,
  `prDias` varchar(45) DEFAULT NULL,
  `prCantSurt` varchar(45) DEFAULT NULL,
  `prPMP` varchar(45) DEFAULT NULL,
  `prDesc` varchar(45) DEFAULT NULL,
  `prValorUnitVenta` varchar(45) DEFAULT NULL,
  `prDesglva` varchar(45) DEFAULT NULL,
  `prValorTotalVenta` varchar(45) DEFAULT NULL,
  `CA2` varchar(45) DEFAULT NULL,
  `MtoTotalCred` varchar(45) DEFAULT NULL,
  `MtoTotalCopa` varchar(45) DEFAULT NULL,
  `CantProdAuto` varchar(45) DEFAULT NULL,
  `MensajeSeg` varchar(45) DEFAULT NULL,
  `ERROR` varchar(45) DEFAULT NULL,
  `createdAt` datetime DEFAULT NULL,
  `updatedAt` datetime DEFAULT NULL,
  PRIMARY KEY (`id_vittrx2`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vit_trx2`
--

LOCK TABLES `vit_trx2` WRITE;
/*!40000 ALTER TABLE `vit_trx2` DISABLE KEYS */;
/*!40000 ALTER TABLE `vit_trx2` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vit_trx3`
--

DROP TABLE IF EXISTS `vit_trx3`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vit_trx3` (
  `id_vittrx3` int(11) NOT NULL AUTO_INCREMENT,
  `prSecuencia` varchar(45) NOT NULL,
  `prIdenCade` varchar(45) NOT NULL,
  `prIdenSucu` varchar(45) NOT NULL,
  `CA1` varchar(45) NOT NULL,
  `CA2` varchar(45) NOT NULL,
  `CA3` varchar(45) DEFAULT NULL,
  `ERROR` varchar(45) DEFAULT NULL,
  `createdAt` datetime DEFAULT NULL,
  `updatedAt` datetime DEFAULT NULL,
  PRIMARY KEY (`id_vittrx3`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vit_trx3`
--

LOCK TABLES `vit_trx3` WRITE;
/*!40000 ALTER TABLE `vit_trx3` DISABLE KEYS */;
/*!40000 ALTER TABLE `vit_trx3` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vit_trx4`
--

DROP TABLE IF EXISTS `vit_trx4`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vit_trx4` (
  `id_vittrx4` int(11) NOT NULL AUTO_INCREMENT,
  `prSecuencia` varchar(45) NOT NULL,
  `prIdenCade` varchar(45) NOT NULL,
  `prIdenSucu` varchar(45) NOT NULL,
  `CA1` varchar(45) NOT NULL,
  `prCodiAcep` varchar(45) DEFAULT NULL,
  `prNumFact` varchar(45) DEFAULT NULL,
  `prVentTotal` varchar(45) DEFAULT NULL,
  `prDesglIva` varchar(45) DEFAULT NULL,
  `CA4` varchar(45) DEFAULT NULL,
  `ERROR` varchar(45) DEFAULT NULL,
  `createdAt` datetime DEFAULT NULL,
  `updatedAt` datetime DEFAULT NULL,
  PRIMARY KEY (`id_vittrx4`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vit_trx4`
--

LOCK TABLES `vit_trx4` WRITE;
/*!40000 ALTER TABLE `vit_trx4` DISABLE KEYS */;
/*!40000 ALTER TABLE `vit_trx4` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vit_trx5`
--

DROP TABLE IF EXISTS `vit_trx5`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vit_trx5` (
  `id_vittrx5` int(11) NOT NULL AUTO_INCREMENT,
  `prSecuencia` varchar(45) NOT NULL,
  `prIdenCade` varchar(45) NOT NULL,
  `prIdenSucu` varchar(45) NOT NULL,
  `CA4` varchar(45) NOT NULL,
  `prNumFact` varchar(45) DEFAULT NULL,
  `CA5` varchar(45) DEFAULT NULL,
  `ERROR` varchar(45) DEFAULT NULL,
  `createdAt` datetime DEFAULT NULL,
  `updatedAt` datetime DEFAULT NULL,
  PRIMARY KEY (`id_vittrx5`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vit_trx5`
--

LOCK TABLES `vit_trx5` WRITE;
/*!40000 ALTER TABLE `vit_trx5` DISABLE KEYS */;
/*!40000 ALTER TABLE `vit_trx5` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vit_vfd`
--

DROP TABLE IF EXISTS `vit_vfd`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vit_vfd` (
  `id_vitVfd` int(11) NOT NULL AUTO_INCREMENT,
  `id_proveedor` varchar(20) NOT NULL,
  `elegibilidad` varchar(20) NOT NULL,
  `firma_digital` varchar(20) NOT NULL,
  `firma_valida` bigint(20) DEFAULT NULL,
  `mensaje` varchar(200) DEFAULT NULL,
  `createdAt` datetime DEFAULT NULL,
  `updatedAt` datetime DEFAULT NULL,
  PRIMARY KEY (`id_vitVfd`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vit_vfd`
--

LOCK TABLES `vit_vfd` WRITE;
/*!40000 ALTER TABLE `vit_vfd` DISABLE KEYS */;
/*!40000 ALTER TABLE `vit_vfd` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-05-06 23:00:46
