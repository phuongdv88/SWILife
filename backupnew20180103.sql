CREATE DATABASE  IF NOT EXISTS `swilifecore` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci */;

USE `swilifecore`;

-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: 192.168.1.100    Database: swilifecore
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
  `ActivityId` bigint(20) NOT NULL AUTO_INCREMENT,
  `Regarding` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Type` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Notes` longtext CHARACTER SET utf8,
  `Created` datetime DEFAULT NULL,
  `ActivityOf` int(11) DEFAULT NULL,
  `JobOrderId` int(11) DEFAULT NULL,
  `CandidateId` int(11) DEFAULT NULL,
  `ContactID` int(11) DEFAULT NULL,
  `UserId` int(11) NOT NULL,
  `ScheduleEventId` int(11) DEFAULT NULL,
  `RunningTaskId` int(11) DEFAULT NULL,
  PRIMARY KEY (`ActivityId`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `activity`
--

LOCK TABLES `activity` WRITE;
/*!40000 ALTER TABLE `activity` DISABLE KEYS */;
INSERT INTO `activity` VALUES (1,'0','Call','ghi chu 1','2017-12-11 12:00:05',1,0,1,0,1,1,NULL),(2,'1','Call','ghi chu ','2017-12-10 11:11:05',1,0,2,0,2,2,NULL),(3,'C++ senior','Call','a','2017-12-11 10:21:20',2,-1,2,-1,5,7,NULL),(4,'C++ senior','Call','sgsdg','2017-12-11 11:11:42',2,-1,1,-1,5,6,NULL),(5,'Sale','Cv Submitted','mhgku','2017-12-17 06:33:10',2,-1,2,-1,5,-1,NULL),(6,'General','Add Candidate to Job Pipeline','','2017-12-26 10:39:02',3,2,3,-1,5,-1,NULL),(7,'General','Add Candidate to Job Pipeline','','2017-12-26 11:22:16',3,2,2,-1,5,-1,NULL),(8,'General','Add Candidate to Job Pipeline','','2017-12-27 00:07:26',3,1,1,-1,5,-1,NULL),(9,'General','Add Candidate to Job Pipeline','','2017-12-27 00:09:42',3,1,2,-1,5,-1,NULL),(10,'General','Add Candidate to Job Pipeline','','2017-12-27 00:27:18',3,2,2,-1,5,-1,NULL),(11,'General','Add Candidate to Job Pipeline','','2017-12-27 00:27:35',3,2,2,-1,5,-1,NULL),(12,'General','Add Candidate to Job Pipeline','','2017-12-27 01:13:15',3,1,1,-1,5,-1,17),(13,'General','Add New Job Order','','2017-12-28 00:54:50',0,4,-1,-1,5,-1,-1),(14,'General','Add New Job Order','','2017-12-28 01:05:24',0,5,-1,-1,5,-1,-1),(15,'General','Add Candidate to Job Pipeline','','2017-12-31 17:25:12',3,3,2,-1,2,-1,18),(16,'General','Add Candidate to Job Pipeline','','2017-12-31 17:25:16',3,3,3,-1,2,-1,19),(17,'General','Add New Job Order','','2018-01-01 22:20:53',0,4,-1,-1,5,-1,-1);
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
  `Modified` datetime DEFAULT NULL,
  `ImageLink` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `IsQualified` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`CandidateId`),
  UNIQUE KEY `CandidateId_UNIQUE` (`CandidateId`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `candidate`
--

LOCK TABLES `candidate` WRITE;
/*!40000 ALTER TABLE `candidate` DISABLE KEYS */;
INSERT INTO `candidate` VALUES (1,'Đào ','Việt ','Phương','phuongdv@live.com','secondary@mail.com','phuongalas','0983949090','0123456789','11 giờ đêm','234 Phạm Văn Đồng','swilife.com','1','Tech','2018-01-21','Viettel','C++, State machine',0,'1000$','2000$','24/6/1988','interview notes...','1','notes...','Hanoi','Vietnam','\\\\192.168.1.200\\d\\swilifedata\\candidates\\resume\\2017-11-21_12-00-00eLzIHwhLCW\\SWILifeApp.docx','Nhân viên',11,'VQ; abc; xyz','Công nghệ thông tin','BKHN','English, Russian','2017-11-21 00:00:00',1,0,1,'2018-01-02 23:31:40','',0),(2,'Nguyễn','Hương','Trà','tra@email1.com','tra@email2.com','traSkype','0989838896','0122132132','12 giờ đêm','232 Phạm Văn Đồng','trawebsite.com.vn','2','Sale','2018-02-15','sale manager','xinh',1,'1200$','2500$','09/08/1990','note interview Trà','0','not Trà','HCM','Mỹ','','Vợ',2,'đẻ Sun Sun','Sếp','Báo chí','Tiếng Anh, Tiếng Em','2017-11-22 00:00:00',1,0,1,'2018-01-02 23:36:41','\\\\192.168.1.100\\SwilifeData\\candidates\\avatar\\NguyễnTrà2017-11-22XxfXINULxU\\26037285_10213197892453879_423453014_o.jpg',1),(3,'test','','','','','','','','','','','','','0001-01-01','','',0,'','','','','0','','','','','',0,'','','','','2017-12-16 23:10:36',0,0,0,'2018-01-02 23:40:23','',0);
/*!40000 ALTER TABLE `candidate` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `company`
--

DROP TABLE IF EXISTS `company`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `company` (
  `CompanyId` bigint(20) NOT NULL AUTO_INCREMENT,
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
  `IsHot` tinyint(4) DEFAULT NULL,
  `ContractSigingTime` date DEFAULT NULL,
  `ScanLink` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `UserId` int(11) DEFAULT NULL,
  `Created` datetime DEFAULT NULL,
  `Modified` datetime DEFAULT NULL,
  PRIMARY KEY (`CompanyId`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `company`
--

LOCK TABLES `company` WRITE;
/*!40000 ALTER TABLE `company` DISABLE KEYS */;
INSERT INTO `company` VALUES (1,'Swilife','01228800899','11111111','2222222','PVD','Vietnam','swilife.com','CNTT','FULL time','tuyển dụng ','A',1,'MiscNotes1','Hanoi','Hanoi_state','80000',1,'2017-11-26',' ',1,'2017-11-26 00:00:00','2017-11-26 00:00:00'),(2,'com Name','1111','2222','33333','Com address','Vietnam','company.com.vn','com tech','com service ','com industy','B',0,'com misc','HCM','HCM','90000',0,'2017-10-10',' ',1,'2017-11-26 00:00:00','2017-11-26 00:00:00'),(3,'testCom','011111111','022222222','03333333','Pham Van Dong','US','https://testcom.com','.NEt','-blah blah balh service contract terms\r\n','Computer Game','A',1,'- blah blah blah Misc NOtes','Ha Noi','Viet Nam','2000',1,'0001-01-01','',5,'2017-12-29 16:20:04','2017-12-29 17:15:13');
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
  `Title` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
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
  `Created` datetime DEFAULT NULL,
  `Modified` datetime DEFAULT NULL,
  `ImageLink` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`ContactId`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contact`
--

LOCK TABLES `contact` WRITE;
/*!40000 ALTER TABLE `contact` DISABLE KEYS */;
INSERT INTO `contact` VALUES (1,'Nguyễn ','Văn','Tèo','Talent Acquisition Manager','HR','(None)',1,'leo@email.com','leo@email2.com','6596855766','123456789','12345699','Phạm Văn Đông','Hà Nội','HN state','10000','https://link','Misc notes',1,1,'2017-06-12 00:00:00','2017-06-13 00:00:00','\"\"'),(2,'Bành ','Thị ','Nòi','Giám đốc nhân sự','Phòng nhân sư','Bèo Thị Nành',1,'banhnoi@gmail.com','banhnoi2#gmail.com','058585858','123456789','11111111','Động Văn Phàm','Hà Nội','Viet Nam','10000','https://linkbanhthinoi','blah blah',2,2,'2017-12-30 00:00:00','2017-12-30 00:00:00','1'),(3,'1','1','1','1','1','1',1,'1 ','1','1','1','1','1','1','1','1','1','1',3,5,'2017-12-30 16:45:02','2017-12-30 22:07:27','\\\\192.168.1.200\\d\\swilifedata\\contacts\\avatar\\112017-12-30Y65ZRrduym\\26037285_10213197892453879_423453014_o.jpg'),(4,'2','2','2','2','2','2',0,'2','2','2','2','2','2','2','2','2','2','2',1,5,'2017-12-30 16:45:53','2017-12-30 22:07:09','\\\\192.168.1.200\\d\\swilifedata\\contacts\\avatar\\112017-12-30Y65ZRrduym\\26037285_10213197892453879_423453014_o.jpg');
/*!40000 ALTER TABLE `contact` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `joborder`
--

DROP TABLE IF EXISTS `joborder`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `joborder` (
  `JobOrderId` int(11) NOT NULL AUTO_INCREMENT,
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
  `Type` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Openings` int(11) DEFAULT NULL,
  `IsHot` tinyint(4) DEFAULT NULL,
  `isPublic` tinyint(4) DEFAULT NULL,
  `Description` longtext CHARACTER SET utf8,
  `InternalNotes` longtext CHARACTER SET utf8,
  `AttachmentLink` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `Created` datetime DEFAULT NULL,
  `Modified` datetime DEFAULT NULL,
  `WebLink` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Status` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `ExperienceYear` int(11) DEFAULT NULL,
  PRIMARY KEY (`JobOrderId`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `joborder`
--

LOCK TABLES `joborder` WRITE;
/*!40000 ALTER TABLE `joborder` DISABLE KEYS */;
INSERT INTO `joborder` VALUES (1,'C++ senior','R&D','2000$',1,1,'HN','HN',1,1,'2017-06-12','2 years','H',5,1,1,'des','inter notes','','2017-06-12 00:00:00','2017-06-12 00:00:00','https://swilife.com/link1','Activate',5),(2,'Sale','PR','1500$',2,2,'HCM','HCM',2,2,'2017-12-25','3 years','H',2,1,1,'desc','inter','\\\\192.168.1.200\\d\\swilifedata\\joborder\\attachment\\2_2017-12-172RWGIrkTSw\\SWILifeApp.docx','2017-12-17 00:00:00','2017-12-17 00:00:00','https://swilife.com/link2','Lead',5),(3,'Tech Director','Head','2500$',2,2,'HN','HN',2,2,'2018-01-25','2 Years','H',1,1,1,'phat trien chuoi cua hang','can co kinh nghiem thuc te hoac cac du an tuong tu',NULL,'2017-12-27 00:00:00','2017-12-27 00:00:00','https://swilife.com/link3','Activate',5),(4,'Developer','','2000',-1,1,'HN','VN',5,5,'0001-01-01','1','Hire',1,0,0,'desp','tnter',NULL,'2018-01-01 22:20:53','2018-01-01 22:21:00','','Active',1);
/*!40000 ALTER TABLE `joborder` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `runningtask`
--

DROP TABLE IF EXISTS `runningtask`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `runningtask` (
  `RunningTaskId` int(65) NOT NULL AUTO_INCREMENT,
  `CandidateId` int(11) DEFAULT NULL,
  `JobOrderId` int(11) DEFAULT NULL,
  `Status` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Match` int(11) DEFAULT NULL,
  `Added` datetime DEFAULT NULL,
  `EnteredBy` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `IsSubmitted` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`RunningTaskId`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `runningtask`
--

LOCK TABLES `runningtask` WRITE;
/*!40000 ALTER TABLE `runningtask` DISABLE KEYS */;
INSERT INTO `runningtask` VALUES (14,2,1,'Not Contact',0,'2017-12-27 00:09:42','phuongdv',0),(16,2,2,'Not Contact',0,'2017-12-27 00:27:35','phuongdv',0),(17,1,1,'Not Contact',0,'2017-12-27 01:13:15','phuongdv',0),(18,2,3,'Not Contact',0,'2017-12-31 17:25:12','admin',0),(19,3,3,'Not Contact',0,'2017-12-31 17:25:16','admin',0);
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
  PRIMARY KEY (`ScheduleEventId`),
  UNIQUE KEY `ScheduleEventIndex_UNIQUE` (`ScheduleEventId`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `scheduleevent`
--

LOCK TABLES `scheduleevent` WRITE;
/*!40000 ALTER TABLE `scheduleevent` DISABLE KEYS */;
INSERT INTO `scheduleevent` VALUES (1,1,'Gap mat ung vien','2017-12-11 12:00:00',1,1,'Gap phong van so qua'),(2,2,'khong lam gi','2017-12-12 00:00:00',-1,0,'khong lam gi ca'),(7,0,'b','2017-12-15 01:00:00',2,1,'des'),(8,0,'','0001-01-01 12:00:00',2,0,'');
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
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci COMMENT='It''s for authentication. Password is md5 of raw_pass+ salt ';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'root','86EC4309A83C02FC2B514198FA93091C','123456a@',1,0),(2,'admin','86EC4309A83C02FC2B514198FA93091C','123456a@',1,0),(4,'dp','EEAFB716F93FA090D7716749A6EEFA72','123456',1,0),(5,'phuongdv','86EC4309A83C02FC2B514198FA93091C','123456a@',1,0),(6,'operator','86EC4309A83C02FC2B514198FA93091C','123456a@',1,0);
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'swilifecore'
--

--
-- Dumping routines for database 'swilifecore'
--
/*!50003 DROP PROCEDURE IF EXISTS `spGetCandidates` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spGetCandidates`()
BEGIN
select T1.CandidateId, T1.FirstName,T1.MiddleName, T1.LastName, concat(T1.FirstName, T1.MiddleName, T1.LastName) as Name, T1.Years, T1.InterviewNotes,
T1.KeySkills, T1.Modified, T1.CurrentEmployer, T1.DesiredPay, T1.CurrentPosition, T1.DOBMarried 
from candidate T1  order by T1.CandidateId desc;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spGetCandidatesInPipeline` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`admin`@`%` PROCEDURE `spGetCandidatesInPipeline`(in JobOrderId int)
BEGIN
select distinct T1.RunningTaskId, T1.CandidateId,T2.FirstName, T2.MiddleName, T2.LastName, T2.City, T1.Status, T1.Match, date_format(T1.Added, '%d-%m-%Y') as Added,
 T1.EnteredBy, concat(date_format(T3.Created, '%d-%m-%Y'),' (',ifnull(T4.UserName, 'Unknown'), '): ', T3.Type) as LastActivity
 from swilifecore.runningtask T1 inner join swilifecore.candidate T2 on T1.CandidateId = T2.CandidateId  
 left join swilifecore.activity T3 on T1.RunningTaskId = T3.RunningTaskId
 left join swilifecore.user T4 on T3.UserId = T4.UserId
 where T1.JobOrderId = JobOrderId order by T1.RunningTaskId desc;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spGetCompanies` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`admin`@`%` PROCEDURE `spGetCompanies`()
BEGIN
select T1.CompanyId, T1.Name, (select count(*) from swilifecore.joborder T3 where T1.CompanyId = T3.CompanyId) as Jobs, 
T1.City, T1.Industry, concat(T2.FirstName, T2.LastName) as ContactName, T2.WorkPhone, T4.UserName, date_format(T1.Modified, '%d/%m/%y %T') as Modified
from swilifecore.company T1 left join swilifecore.contact T2 on T1.CompanyId = T2.CompanyId
left join swilifecore.user T4 on T1.UserId = T4.UserId  order by T1.CompanyId desc;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spGetJobOrderById` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`admin`@`%` PROCEDURE `spGetJobOrderById`(in JobOrderId int)
BEGIN
select T1.*, T2.Name CompanyName, concat(T3.FirstName , T3.LastName) as ContactName, 
(select count(RunningTaskId) from runningtask where runningtask.JobOrderId = T1.JobOrderId) as CanInPipeLine ,
(select count(*) from runningtask where runningtask.JobOrderId = T1.JobOrderId and runningtask.IsSubmitted = '1') as Submitted
from swilifecore.joborder T1 left join swilifecore.company T2 on T1.CompanyId = T2.CompanyId 
left join swilifecore.contact T3 on T1.ContactId = T3.ContactId 
where T1.JobOrderId = JobOrderId;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SpGetJobOrders` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`admin`@`%` PROCEDURE `SpGetJobOrders`()
BEGIN
	select T1.JobOrderId, T1.Title, T2.Name CompanyName, T1.Type, T1.Status, T3.UserName as Owner, 
    T1.City, T1.Weblink, T1.Salary, T1.Modified ,
    (select count(RunningTaskId) from runningtask where runningtask.JobOrderId = T1.JobOrderId) as CanInPipeLine ,
(select count(*) from runningtask where runningtask.JobOrderId = T1.JobOrderId and runningtask.IsSubmitted = '1') as Submitted,
datediff(now(), T1.Created) as DaysOld
    from swilifecore.joborder T1 left join swilifecore.company T2 on T1.CompanyId = T2.CompanyId 
    left join swilifecore.user T3 on T1.OwnerId = T3.UserId
     order by T1.JobOrderId desc;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spGetLimitedCandidates` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spGetLimitedCandidates`(
in Offset int, in Length int)
BEGIN
set Offset = Offset - 1;
select T1.CandidateId, T1.FirstName, T1.LastName, T1.KeySkills, T1.Modified, T1.CurrentEmployer, T1.DesiredPay, T1.CurrentPosition, T1.DOBMarried from candidate T1 limit Offset,Length;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spGetUserByName` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spGetUserByName`(in UserName varchar(255))
BEGIN
 select * from user where user.UserName=UserName;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spLoginLogout` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spLoginLogout`(in UserName varchar(255), in IsOnline bool)
BEGIN
update user set user.IsOnline = IsOnline where user.UserName = UserName and user.IsOnline = !IsOnline;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-01-03  8:28:29
