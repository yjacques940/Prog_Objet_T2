CREATE DATABASE  IF NOT EXISTS `cuisine` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `cuisine`;
-- MySQL dump 10.13  Distrib 8.0.11, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: cuisine
-- ------------------------------------------------------
-- Server version	8.0.11

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `cours`
--

DROP TABLE IF EXISTS `cours`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `cours` (
  `codeCours` varchar(10) NOT NULL,
  `titreCours` varchar(45) DEFAULT NULL,
  `prixCours` float DEFAULT '0',
  `dureeCours` int(11) DEFAULT '0',
  `niveauDifficulte` int(11) DEFAULT '0',
  `commentaires` varchar(100) DEFAULT NULL,
  `technique` varchar(100) DEFAULT NULL,
  `descriptionTechnique` varchar(100) DEFAULT NULL,
  `prerequis` varchar(75) DEFAULT NULL,
  `typeCours` int(11) DEFAULT NULL,
  PRIMARY KEY (`codeCours`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cours`
--

LOCK TABLES `cours` WRITE;
/*!40000 ALTER TABLE `cours` DISABLE KEYS */;
INSERT INTO `cours` VALUES ('Pate101','Pâtes de base',30,90,1,'Recettes pour tous les jours','Cuisson des pâtes','Cuisson idéale. Comment conserver.','',1),('Pate201','Pâtes maison',40,90,3,'Les ustensiles essentiels seront présentés',NULL,NULL,'Connaître la cuisson des pâtes.',2),('Salade101','Vinaigrette de base',30,90,1,'Vinaigrette convenant à tous types de salade','Ingrédients indispensable pour vinaigrette','Quels ingrédients sont nécessaires pour la vinaigrette et la mayonnaise maison.','',1),('Sauce101','Préparation des sauces',40,90,1,'Pour viande rouge et poulet','Bases des sauces','Une bonne suace n\'est pas compliquée, il faut juste respecter quelques règles.','',1),('Sauce201','Sauce relevée et onctueuse',50,105,2,'Les règles pour faire le bon choix de sauce en fonction de la viande seront aussi abordées.','',NULL,'savoir préparer un fond',2),('Viande101','Cuisson des viandes',45,120,3,'Dégustation des recettes effectuées.','Comment cuire une viande','Griller, braiser, bouillir, saisir,...','',1);
/*!40000 ALTER TABLE `cours` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `evaluation`
--

DROP TABLE IF EXISTS `evaluation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `evaluation` (
  `idEvaluation` int(11) NOT NULL AUTO_INCREMENT,
  `noteDifficulte` int(11) DEFAULT '0',
  `noteUtilite` int(11) DEFAULT '0',
  `noteAppreciaiton` int(11) DEFAULT '0',
  `codeCours` varchar(10) NOT NULL,
  PRIMARY KEY (`idEvaluation`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `evaluation`
--

LOCK TABLES `evaluation` WRITE;
/*!40000 ALTER TABLE `evaluation` DISABLE KEYS */;
INSERT INTO `evaluation` VALUES (1,8,7,7,'Sauce101'),(2,8,9,7,'Sauce101'),(3,8,8,8,'Sauce101'),(4,8,8,9,'Sauce101'),(5,8,6,7,'Sauce101'),(6,8,8,6,'Sauce101'),(7,8,9,8,'Sauce101'),(8,8,10,10,'Sauce101'),(9,8,9,9,'Sauce101'),(10,8,8,8,'Sauce101'),(11,5,7,8,'Sauce201'),(12,5,7,7,'Sauce201'),(13,5,7,9,'Sauce201'),(14,5,7,10,'Sauce201'),(15,5,7,9,'Sauce201'),(16,5,8,8,'Sauce201');
/*!40000 ALTER TABLE `evaluation` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-11-27  8:07:25
