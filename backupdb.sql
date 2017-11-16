-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: swilifecore
-- ------------------------------------------------------
-- Server version	5.7.20-log

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
-- Table structure for table `activity`
--

DROP TABLE IF EXISTS `activity`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `activity` (
  `ActivityId` int(11) NOT NULL AUTO_INCREMENT,
  `Regarding` int(11) DEFAULT NULL,
  `Type` int(11) DEFAULT NULL,
  `Notes` longtext CHARACTER SET utf8,
  `DateTime` datetime DEFAULT NULL,
  `ActivityOf` int(11) DEFAULT NULL,
  `JobOrderId` int(11) DEFAULT NULL,
  `CandidateId` int(11) DEFAULT NULL,
  `ContactID` int(11) DEFAULT NULL,
  `UserId` int(11) NOT NULL,
  PRIMARY KEY (`ActivityId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `activity`
--

LOCK TABLES `activity` WRITE;
/*!40000 ALTER TABLE `activity` DISABLE KEYS */;
/*!40000 ALTER TABLE `activity` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `candidate`
--

DROP TABLE IF EXISTS `candidate`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `candidate` (
  `CandidateId` int(11) NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(45) CHARACTER SET utf8 NOT NULL,
  `MiddleName` varchar(45) CHARACTER SET utf8 DEFAULT NULL,
  `LastName` varchar(45) CHARACTER SET utf8 NOT NULL,
  `Email` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `SecondaryEmail` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `SkypeIM` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `CellPhone` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `WorkPhone` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `BestTimeToCall` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `Address` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `WebSite` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `Source` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `CurrentPosition` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `DateAvailable` date DEFAULT NULL,
  `CurrentEmployer` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `KeySkills` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `CanRelocate` tinyint(4) DEFAULT NULL,
  `CurrentPay` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `DesiredPay` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `DOBMarried` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `InterviewNotes` varchar(4000) CHARACTER SET utf8 DEFAULT NULL,
  `Gender` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `MiscNotes` longtext CHARACTER SET utf8,
  `City` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `Country` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `ResumeLink` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `PositionsUpTillNow` longtext CHARACTER SET utf8,
  `Years` int(11) DEFAULT NULL,
  `ProjectDone` varchar(2000) CHARACTER SET utf8 DEFAULT NULL,
  `Industry` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `Education` varchar(2000) CHARACTER SET utf8 DEFAULT NULL,
  `Language` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `CreatedId` int(11) DEFAULT NULL,
  `IsInBlacklist` tinyint(4) DEFAULT NULL,
  `UserId` int(11) DEFAULT NULL,
  PRIMARY KEY (`CandidateId`),
  UNIQUE KEY `CandidateId_UNIQUE` (`CandidateId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `candidate`
--

LOCK TABLES `candidate` WRITE;
/*!40000 ALTER TABLE `candidate` DISABLE KEYS */;
/*!40000 ALTER TABLE `candidate` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `company`
--

DROP TABLE IF EXISTS `company`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `company` (
  `CompanyId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `PrimaryPhone` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `SecondaryPhone` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `FaxNumber` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Address` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `CountryOfOrigin` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `WebSite` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `KeyTechnologies` varchar(4000) CHARACTER SET utf8 DEFAULT NULL,
  `ServiceContractTerms` longtext CHARACTER SET utf8,
  `Industry` varchar(2000) CHARACTER SET utf8 DEFAULT NULL,
  `ABC` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `IsActive` tinyint(4) DEFAULT NULL,
  `MiscNotes` longtext CHARACTER SET utf8,
  `City` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `State` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `PostalCode` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `Department` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `IsHot` tinyint(4) DEFAULT NULL,
  `ContractSigingTime` date DEFAULT NULL,
  `Teams` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `ScanLink` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `BillingContactId` int(11) DEFAULT NULL,
  `UserId` int(11) DEFAULT NULL,
  PRIMARY KEY (`CompanyId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `company`
--

LOCK TABLES `company` WRITE;
/*!40000 ALTER TABLE `company` DISABLE KEYS */;
/*!40000 ALTER TABLE `company` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `contact`
--

DROP TABLE IF EXISTS `contact`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `contact` (
  `ContactId` int(11) NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `MiddleName` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `LastName` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `Company` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `Tittle` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `Department` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `ReportTo` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `isHot` tinyint(4) DEFAULT NULL,
  `Email` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `SecondaryEmail` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `CellPhone` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `WorkPhone` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `OtherPhone` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Address` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `City` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `State` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `PostalCode` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `ProfileLink` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `MiscNotes` longtext CHARACTER SET utf8,
  `CompanyId` int(11) DEFAULT NULL,
  `UserId` int(11) DEFAULT NULL,
  PRIMARY KEY (`ContactId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contact`
--

LOCK TABLES `contact` WRITE;
/*!40000 ALTER TABLE `contact` DISABLE KEYS */;
/*!40000 ALTER TABLE `contact` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `joborder`
--

DROP TABLE IF EXISTS `joborder`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `joborder` (
  `joborderId` int(11) NOT NULL AUTO_INCREMENT,
  `Title` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `Department` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `Salary` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `ContactId` int(11) DEFAULT NULL,
  `CompanyId` int(11) DEFAULT NULL,
  `City` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `State` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `RecruiterId` int(11) DEFAULT NULL,
  `OwnerId` int(11) DEFAULT NULL,
  `StartDate` date DEFAULT NULL,
  `Duration` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `MaximumRate` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `Type` int(11) DEFAULT NULL,
  `Openings` int(11) DEFAULT NULL,
  `CompanyJobId` int(11) DEFAULT NULL,
  `IsHot` tinyint(4) DEFAULT NULL,
  `isPublic` tinyint(4) DEFAULT NULL,
  `Description` longtext CHARACTER SET utf8,
  `InternalNotes` longtext CHARACTER SET utf8,
  `AttachmentLink` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `YearsOfExperiences` int(11) DEFAULT NULL,
  `Status` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  PRIMARY KEY (`joborderId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `joborder`
--

LOCK TABLES `joborder` WRITE;
/*!40000 ALTER TABLE `joborder` DISABLE KEYS */;
/*!40000 ALTER TABLE `joborder` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `runningtask`
--

DROP TABLE IF EXISTS `runningtask`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `runningtask` (
  `RunningtaskId` int(11) NOT NULL AUTO_INCREMENT,
  `CandidateId` int(11) DEFAULT NULL,
  `JobOrderId` int(11) DEFAULT NULL,
  `Status` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`RunningtaskId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `runningtask`
--

LOCK TABLES `runningtask` WRITE;
/*!40000 ALTER TABLE `runningtask` DISABLE KEYS */;
/*!40000 ALTER TABLE `runningtask` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `scheduleevent`
--

DROP TABLE IF EXISTS `scheduleevent`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `scheduleevent` (
  `ScheduleEventId` int(11) NOT NULL AUTO_INCREMENT,
  `Type` int(11) NOT NULL,
  `Title` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `DateTime` datetime DEFAULT NULL,
  `Duration` int(11) DEFAULT NULL,
  `IsPublicEntry` tinyint(4) DEFAULT NULL,
  `Description` longtext CHARACTER SET utf8,
  `ActivityId` int(11) NOT NULL,
  PRIMARY KEY (`ScheduleEventId`),
  UNIQUE KEY `ScheduleEventIndex_UNIQUE` (`ScheduleEventId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `scheduleevent`
--

LOCK TABLES `scheduleevent` WRITE;
/*!40000 ALTER TABLE `scheduleevent` DISABLE KEYS */;
/*!40000 ALTER TABLE `scheduleevent` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user` (
  `UserId` int(11) NOT NULL AUTO_INCREMENT,
  `UserName` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `Password` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `Salt` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Role` int(11) NOT NULL,
  `IsOnline` tinyint(4) NOT NULL,
  PRIMARY KEY (`UserId`),
  UNIQUE KEY `idStaffUser_UNIQUE` (`UserId`),
  UNIQUE KEY `UserName_UNIQUE` (`UserName`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci COMMENT='It''s for authentication. Password is md5 of raw_pass+ salt ';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'root','86EC4309A83C02FC2B514198FA93091C','123456a@',1,0),(2,'admin','86EC4309A83C02FC2B514198FA93091C','123456a@',1,0),(4,'dp','EEAFB716F93FA090D7716749A6EEFA72','123456',1,0);
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-11-16 23:59:02
