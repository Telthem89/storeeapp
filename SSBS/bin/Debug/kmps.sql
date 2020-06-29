-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Sep 14, 2019 at 11:17 AM
-- Server version: 5.7.24
-- PHP Version: 7.2.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `kmps`
--

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE `category` (
  `category_id` int(11) NOT NULL,
  `category_name` varchar(255) DEFAULT NULL,
  `category_detail` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`category_id`, `category_name`, `category_detail`) VALUES
(1, 'Dossage Drugs', 'For dosages use only.'),
(2, 'Leprostatics', 'Dosage Drungs'),
(3, 'Allergenics', 'Dosage Drungs'),
(4, 'Amebicides', 'Dosage Drungs'),
(5, 'Methylxanthines', 'Dosage Drungs'),
(6, 'Antacids', 'Dosage Drungs'),
(7, 'Nasal steroids', 'Dosage Drungs'),
(8, 'Antitussives', 'Dosage Drungs');

-- --------------------------------------------------------

--
-- Table structure for table `customer_details`
--

CREATE TABLE `customer_details` (
  `customer_id` int(11) NOT NULL,
  `customer_name` varchar(255) DEFAULT NULL,
  `customer_address` varchar(255) DEFAULT NULL,
  `customer_mobile` varchar(100) DEFAULT NULL,
  `customer_email` varchar(100) DEFAULT NULL,
  `registered` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `customer_details`
--

INSERT INTO `customer_details` (`customer_id`, `customer_name`, `customer_address`, `customer_mobile`, `customer_email`, `registered`) VALUES
(1, 'Tanaka Gelly', 'Harare 8788', '0774914150', 'datatelthem@gmail.com', '2019-02-21'),
(2, 'Taka Gelly', '98/A, East Lackx view West Nkhali', '077492345', 'maki@blaaa.com', '2019-03-14'),
(3, 'Mike Bolt', '231,East Patalipur,Sonamuri', '0779257827', 'boltu@gmail.com', '2019-02-14'),
(4, 'George Wainaina', 'Nakuru CBS', '0778423947', 'georgewainaina18@gmail.com', '2019-03-20');

-- --------------------------------------------------------

--
-- Table structure for table `invoice_receipt`
--

CREATE TABLE `invoice_receipt` (
  `id` int(11) NOT NULL,
  `receipt_no` varchar(250) NOT NULL,
  `invoice_type` varchar(50) NOT NULL DEFAULT 'POS',
  `total_price` double NOT NULL,
  `discount` double DEFAULT '0',
  `tax` double DEFAULT '0',
  `paid_amount` double NOT NULL DEFAULT '0',
  `change_amount` double DEFAULT '0',
  `customer_name` varchar(140) DEFAULT 'Customer 1',
  `cashier_name` varchar(140) DEFAULT NULL,
  `invoice_due` datetime DEFAULT CURRENT_TIMESTAMP,
  `invoice_date` datetime DEFAULT CURRENT_TIMESTAMP,
  `dateAdded` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `invoice_receipt`
--

INSERT INTO `invoice_receipt` (`id`, `receipt_no`, `invoice_type`, `total_price`, `discount`, `tax`, `paid_amount`, `change_amount`, `customer_name`, `cashier_name`, `invoice_due`, `invoice_date`, `dateAdded`) VALUES
(1, '140112001.705548', 'INVOICE', 275, 66, 0.15, 275, 0, 'Tanaka Gelly', '      Add Cart', '2019-04-14 01:19:45', '2019-04-14 00:00:00', '2019-04-14'),
(2, '140112526.705548', 'INVOICE', 678, 0.89, 0.07, 678, 0, 'Mike Bolt', '      Add Cart', '2019-04-14 01:24:48', '2019-04-14 01:25:26', '2019-03-23'),
(3, '140112820.705548', 'INVOICE', 999, 0.9, 0.07, 999, 0, 'Tanaka Gelly', '      Add Cart', '2019-04-14 01:27:27', '2019-04-14 01:28:20', '2019-03-23'),
(4, '140113049.705548', 'INVOICE', 999, 2, 0.07, 999, 0, 'Tanaka Gelly', 'Patience Shorai', '2019-04-14 01:30:10', '2019-04-14 01:30:49', '2019-03-23'),
(5, '140113542.705548', 'INVOICE', 789, 0.78, 0.07, 789, 0, 'Taka Gelly', 'Patience Shorai', '2019-04-14 01:35:11', '2019-04-14 01:35:42', '2019-03-23'),
(6, '140113615.533424', 'INVOICE', 4940, 0.78, 0.15, 4940, 0, 'Taka Gelly', 'Patience Shorai', '2019-04-14 01:35:11', '2019-04-14 01:36:15', '2019-03-23'),
(7, '140113852.579519', 'INVOICE', 225, 0.78, 0.15, 225, 0, 'Taka Gelly', 'Patience Shorai', '2019-04-14 01:35:11', '2019-04-14 01:38:52', '2019-03-23'),
(8, '140114059.289562', 'INVOICE', 2256, 0.78, 0.22, 2256, 0, 'George Wainaina', 'Patience Shorai', '2019-04-14 01:35:11', '2019-04-14 01:40:59', '2019-03-23'),
(9, '161202425.705548', 'INVOICE', 13, 0, 0.07, 13, 0, 'Mike Bolt', 'Patience Shorai', '2019-04-16 12:22:17', '2019-04-16 12:24:25', '2019-03-23'),
(10, '161202508.533424', 'INVOICE', 100, 0, 0.07, 100, 0, 'George Wainaina', 'Patience Shorai', '2019-04-16 12:22:17', '2019-04-16 12:25:08', '2019-03-23'),
(11, '161205118.705548', 'INVOICE', 1903.8, 30, 7.72, 1903.8, 0, 'Tanaka Gelly', 'Patience Shorai', '2019-04-16 12:49:42', '2019-04-16 12:51:18', '2019-03-23');

-- --------------------------------------------------------

--
-- Table structure for table `invoice_receipt_details`
--

CREATE TABLE `invoice_receipt_details` (
  `cart_id` int(11) NOT NULL,
  `receipt_no` varchar(250) DEFAULT 'XRJKD39203634',
  `product_id` int(11) NOT NULL,
  `product_name` varchar(240) NOT NULL,
  `quantity` int(8) DEFAULT NULL,
  `rate` double DEFAULT '0',
  `tax` double DEFAULT '0',
  `total_price` double DEFAULT NULL,
  `checkout_date` datetime DEFAULT CURRENT_TIMESTAMP,
  `dateAdded` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `invoice_receipt_details`
--

INSERT INTO `invoice_receipt_details` (`cart_id`, `receipt_no`, `product_id`, `product_name`, `quantity`, `rate`, `tax`, `total_price`, `checkout_date`, `dateAdded`) VALUES
(1, '140112526.705548', 3, 'Manet', 678, 1, 0.07, 678, '2019-04-14 01:25:26', '2019-04-14'),
(2, '140112820.705548', 3, 'Manet', 999, 1, 0.07, 999, '2019-04-14 01:28:20', '2019-04-14'),
(3, '140113049.705548', 3, 'Manet', 999, 1, 0.07, 999, '2019-04-14 01:30:49', '2019-04-14'),
(4, '140113542.705548', 3, 'Manet', 789, 1, 0.07, 789, '2019-04-14 01:35:42', '2019-04-14'),
(5, '140113615.533424', 2, 'Caefenol', 988, 5, 0.15, 4940, '2019-04-14 01:36:15', '2019-04-14'),
(6, '140113852.579519', 2, 'Caefenol', 45, 5, 0.15, 225, '2019-04-14 01:38:52', '2019-04-14'),
(7, '140114059.289562', 2, 'Caefenol', 45, 5, 0.15, 225, '2019-04-14 01:40:59', '2019-04-14'),
(8, '140114059.289562', 3, 'Manet', 2031, 1, 0.07, 2031, '2019-04-14 01:40:59', '2019-04-14'),
(9, '161202425.705548', 3, 'Manet', 13, 1, 0.07, 13, '2019-04-16 12:24:25', '2019-04-14'),
(10, '161202508.533424', 3, 'Manet', 100, 1, 0.07, 100, '2019-04-16 12:25:08', '2019-04-14'),
(11, '161205118.705548', 4, 'Acetaminophen', 34, 2.85, 1.93, 96.9, '2019-04-16 12:51:18', '2019-04-14'),
(12, '161205118.705548', 7, 'Doxepin Hydrochloride', 234, 2.85, 1.93, 666.9, '2019-04-16 12:51:18', '2019-04-14'),
(13, '161205118.705548', 5, 'Bioelements', 56, 2.85, 1.93, 159.6, '2019-04-16 12:51:18', '2019-04-14'),
(14, '161205118.705548', 6, 'Pediacare Childrens Allergy', 344, 2.85, 1.93, 980.4, '2019-04-16 12:51:18', '2019-04-14');

-- --------------------------------------------------------

--
-- Table structure for table `product_details`
--

CREATE TABLE `product_details` (
  `product_id` int(11) NOT NULL,
  `product_name` varchar(255) NOT NULL,
  `product_supplier` int(11) DEFAULT NULL,
  `product_category` int(11) DEFAULT NULL,
  `expiry_date` date DEFAULT NULL,
  `quantity` int(11) DEFAULT '0',
  `price` double DEFAULT NULL,
  `supplier_price` double DEFAULT NULL,
  `tax` double DEFAULT NULL,
  `registered` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `product_details`
--

INSERT INTO `product_details` (`product_id`, `product_name`, `product_supplier`, `product_category`, `expiry_date`, `quantity`, `price`, `supplier_price`, `tax`, `registered`) VALUES
(2, 'Caefenol', 1, 1, '2024-05-25', 2, 5, 5677, 0.15, '2019-03-25'),
(3, 'Manet', 1, 3, '2029-08-30', 8909, 1, 656, 0.07, '2019-03-25'),
(4, 'Acetaminophen', 3, 2, '2034-03-20', 25643, 2.85, 1.61, 1.93, '2019-04-14'),
(5, 'Bioelements', 3, 2, '2034-03-20', 55621, 2.85, 1.61, 1.93, '2019-04-14'),
(6, 'Pediacare Childrens Allergy', 3, 5, '2034-03-20', 55333, 2.85, 1.61, 1.93, '2019-04-14'),
(7, 'Doxepin Hydrochloride', 2, 1, '2034-03-20', 55443, 2.85, 1.61, 1.93, '2019-04-14');

-- --------------------------------------------------------

--
-- Table structure for table `product_purchase_details`
--

CREATE TABLE `product_purchase_details` (
  `purchase_id` int(11) NOT NULL,
  `product_name` varchar(100) NOT NULL,
  `supplier_name` varchar(100) NOT NULL,
  `quantity` int(11) NOT NULL,
  `rate` int(11) NOT NULL,
  `total_amount` int(11) NOT NULL,
  `purchase_date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `suppliers`
--

CREATE TABLE `suppliers` (
  `supplier_id` int(11) NOT NULL,
  `supplier_name` varchar(255) NOT NULL,
  `supplier_address` varchar(255) DEFAULT NULL,
  `supplier_email` varchar(255) DEFAULT NULL,
  `supplier_mobile` varchar(100) DEFAULT NULL,
  `registered` varchar(100) DEFAULT NULL,
  `status` int(2) DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `suppliers`
--

INSERT INTO `suppliers` (`supplier_id`, `supplier_name`, `supplier_address`, `supplier_email`, `supplier_mobile`, `registered`, `status`) VALUES
(1, 'Jencoh Medical and Mobility, Inc', '23 Main Harare Road', 'jec@main.co.zw', '077856789', '2019-03-24', 1),
(2, 'Daliany Rongbang Medical Healthy Devices Co', '5690 Malcom Vetinary', 'dalian@gmail.com', '0765845566', '2019-03-24', 1),
(3, 'Cosmeticy Enterprises Ltd Park.', '6509 Dandamvura Mutoko', 'well@heath.co.zw', '0776890321', '2019-03-24', 1),
(4, 'Geiss, Destin and Dunn, Inc', '2 Everett Park', NULL, NULL, '2019-03-24', 1),
(5, 'ECI Pharmaceuticals LLC', '98 Clemons Place', NULL, NULL, '2019-03-24', 1),
(6, 'Ahold U.S.A., Inc.', '4 Haas Road', NULL, NULL, '2019-03-24', 1),
(7, 'Creekwood Pharmaceuticals Inc.', '2 1st Lane', NULL, NULL, '2019-03-24', 1),
(8, 'Kingsway Trading', '2 Darwin Place', NULL, NULL, '2019-03-24', 1),
(9, 'Best Accessory Group', '4 Eggendart Junction', NULL, NULL, '2019-03-24', 1),
(10, 'Cosmetic Enterprises Ltd.', '4000 Esch Plaza', NULL, NULL, '2019-03-24', 1),
(11, 'Health-Tech, Inc.', '34 7th Place', NULL, NULL, '2019-03-24', 1),
(12, 'Alexso Inc', '908 Mosinee Court', NULL, NULL, '2019-03-24', 1),
(13, 'Basic Research', '83266 Hauk Park', NULL, NULL, '2019-03-24', 1),
(14, 'ATOMY CO LTD', '238 Beilfuss Drive', NULL, NULL, '2019-03-24', 1),
(15, 'Lampton Welding Supply Company, Inc', '9143 Fremont Court', NULL, NULL, '2019-03-24', 1),
(16, 'Landy International', '57 Raven Alley', NULL, NULL, '2019-03-24', 1),
(17, 'CSL Behring AG', '75557 Magdeline Parkway', NULL, NULL, '2019-03-24', 1),
(18, 'Jenco Medical and Mobility, Inc', '46777 Eastwood Trail', NULL, NULL, '2019-03-24', 1),
(19, 'GeneraMedix', '3617 Magdeline Terrace', NULL, NULL, '2019-03-24', 1),
(20, 'ECI Pharmaceuticals, LLC', '792 Waubesa Crossing', NULL, NULL, '2019-03-24', 1),
(21, 'Certus Medical, Inc.', '44899 Karstens Avenue', NULL, NULL, '2019-03-24', 1),
(22, 'AnuMed International LLC', '63397 Gerald Hill', NULL, NULL, '2019-03-24', 1);

-- --------------------------------------------------------

--
-- Table structure for table `systemlogs`
--

CREATE TABLE `systemlogs` (
  `userid` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `user_role` varchar(50) NOT NULL,
  `token` varchar(50) NOT NULL,
  `timeIn` varchar(50) NOT NULL,
  `timeout` varchar(50) NOT NULL DEFAULT 'Pending',
  `dateadded` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `systemlogs`
--

INSERT INTO `systemlogs` (`userid`, `username`, `user_role`, `token`, `timeIn`, `timeout`, `dateadded`) VALUES
(1, 'Admin', 'Administrator', '1000000', '10:00 AM', '2:45 PM', '2019-03-23'),
(3, 'Admin', 'Administrator', '1000001', '3:16:56 PM', '3:16:56 PM', '2019-03-23'),
(4, 'Admin', 'Administrator', '1000002', '3:19:33 PM', '3:19:33 PM', '2019-03-23'),
(5, 'Admin', 'Administrator', '1000003', '3:28:40 PM', '3:28:40 PM', '2019-03-23'),
(6, 'Admin', 'Administrator', '1000004', '3:54:36 PM', '3:54:36 PM', '2019-03-23'),
(7, 'admin', 'Administrator', '1000005', '3:56:25 PM', '3:56:25 PM', '2019-03-23'),
(8, 'admin', 'Administrator', '1000006', '7:21:36 PM', '7:21:36 PM', '2019-03-23'),
(9, 'admin', 'Administrator', '1000007', '8:13:33 PM', 'Pending', '2019-03-23'),
(10, 'admin', 'Administrator', '1000008', '8:15:39 PM', '8:15:39 PM', '2019-03-23'),
(11, 'admin', 'Administrator', '1000009', '8:18:18 PM', '8:18:18 PM', '2019-03-23'),
(12, 'admin', 'Administrator', '1000010', '8:23:26 PM', '8:23:26 PM', '2019-03-23'),
(13, 'admin', 'Administrator', '1000011', '8:45:46 PM', '8:45:46 PM', '2019-03-23'),
(14, 'admin', 'Administrator', '1000012', '8:49:09 PM', '8:49:09 PM', '2019-03-23'),
(15, 'admin', 'Administrator', '1000013', '8:50:10 PM', '8:50:10 PM', '2019-03-23'),
(16, 'admin', 'Administrator', '1000014', '8:51:01 PM', '8:51:01 PM', '2019-03-23'),
(17, 'admin', 'Administrator', '1000015', '8:51:47 PM', '8:51:47 PM', '2019-03-23'),
(18, 'admin', 'Administrator', '1000016', '8:56:02 PM', '8:56:02 PM', '2019-03-23'),
(19, 'admin', 'Administrator', '1000017', '8:57:10 PM', '8:57:10 PM', '2019-03-23'),
(20, 'admin', 'Administrator', '1000018', '8:58:08 PM', '8:58:08 PM', '2019-03-23'),
(21, 'admin', 'Administrator', '1000019', '8:58:59 PM', '8:58:59 PM', '2019-03-23'),
(22, 'admin', 'Administrator', '1000020', '9:05:32 PM', '9:05:32 PM', '2019-03-23'),
(23, 'admin', 'Administrator', '1000021', '9:06:55 PM', '9:06:55 PM', '2019-03-23'),
(24, 'admin', 'Administrator', '1000022', '9:08:33 PM', '9:08:33 PM', '2019-03-23'),
(25, 'Admin', 'Administrator', '1000023', '9:31:04 PM', '9:31:04 PM', '2019-03-23'),
(26, 'admin', 'Administrator', '1000024', '9:32:54 PM', '9:32:54 PM', '2019-03-23'),
(27, 'admin', 'Administrator', '1000025', '9:34:11 PM', '9:34:11 PM', '2019-03-23'),
(28, 'admin', 'Administrator', '1000026', '9:35:39 PM', '9:35:39 PM', '2019-03-23'),
(29, 'admin', 'Administrator', '1000027', '9:37:05 PM', '9:37:05 PM', '2019-03-23'),
(30, 'admin', 'Administrator', '1000028', '9:39:13 PM', '9:39:13 PM', '2019-03-23'),
(31, 'admin', 'Administrator', '1000029', '9:56:10 PM', '9:56:10 PM', '2019-03-23'),
(32, 'admin', 'Administrator', '1000030', '9:58:19 PM', '9:58:19 PM', '2019-03-23'),
(33, 'admin', 'Administrator', '1000031', '10:01:48 PM', '10:01:48 PM', '2019-03-23'),
(34, 'admin', 'Administrator', '1000032', '10:07:53 PM', '10:07:53 PM', '2019-03-23'),
(35, 'admin', 'Administrator', '1000033', '10:10:47 PM', '10:10:47 PM', '2019-03-23'),
(36, 'admin', 'Administrator', '1000034', '10:11:54 PM', '10:11:54 PM', '2019-03-23'),
(37, 'admin', 'Administrator', '1000035', '10:12:38 PM', '10:12:38 PM', '2019-03-23'),
(38, 'admin', 'Administrator', '1000036', '10:13:20 PM', '10:13:20 PM', '2019-03-23'),
(39, 'admin', 'Administrator', '1000037', '10:14:45 PM', '10:14:45 PM', '2019-03-23'),
(40, 'Admin', 'Administrator', '1000038', '9:30:08 AM', '9:30:08 AM', '2019-03-24'),
(41, 'Admin', 'Administrator', '1000039', '10:22:52 AM', '10:22:52 AM', '2019-03-24'),
(42, 'admin', 'Administrator', '1000040', '10:49:22 AM', '10:49:22 AM', '2019-03-24'),
(43, 'admin', 'Administrator', '1000041', '10:52:52 AM', '10:52:52 AM', '2019-03-24'),
(44, 'admin', 'Administrator', '1000042', '10:54:14 AM', '10:54:14 AM', '2019-03-24'),
(45, 'admin', 'Administrator', '1000043', '10:55:05 AM', '10:55:05 AM', '2019-03-24'),
(46, 'admin', 'Administrator', '1000044', '10:58:54 AM', '10:58:54 AM', '2019-03-24'),
(47, 'Admin', 'Administrator', '1000045', '11:02:37 AM', '11:02:37 AM', '2019-03-24'),
(48, 'admin', 'Administrator', '1000046', '12:39:43 PM', '12:39:43 PM', '2019-03-24'),
(49, 'Admin', 'Administrator', '1000047', '10:02:10 PM', '10:02:10 PM', '2019-03-24'),
(50, 'admin', 'Administrator', '1000048', '10:07:54 PM', '10:07:54 PM', '2019-03-24'),
(51, 'admin', 'Administrator', '1000049', '9:06:29 AM', '9:06:29 AM', '2019-03-25'),
(52, 'admin', 'Administrator', '1000050', '9:08:44 AM', '9:08:44 AM', '2019-03-25'),
(53, 'admin', 'Administrator', '1000051', '9:10:19 AM', '9:10:19 AM', '2019-03-25'),
(54, 'Admin', 'Administrator', '1000052', '10:18:25 AM', '10:18:25 AM', '2019-03-25'),
(55, 'admin', 'Administrator', '1000053', '10:24:43 AM', '10:24:43 AM', '2019-03-25'),
(56, 'Admin', 'Administrator', '1000054', '10:28:11 AM', '10:28:11 AM', '2019-03-25'),
(57, 'admin', 'Administrator', '1000055', '10:45:40 AM', '10:45:40 AM', '2019-03-25'),
(58, 'admin', 'Administrator', '1000056', '10:46:51 AM', 'Pending', '2019-03-25'),
(59, 'admin', 'Administrator', '1000057', '10:48:06 AM', 'Pending', '2019-03-25'),
(60, 'admin', 'Administrator', '1000058', '10:49:20 AM', '10:49:20 AM', '2019-03-25'),
(61, 'admin', 'Administrator', '1000059', '10:53:18 AM', '10:53:18 AM', '2019-03-25'),
(62, 'admin', 'Administrator', '1000060', '11:05:25 AM', '11:05:25 AM', '2019-03-25'),
(63, 'admin', 'Administrator', '1000061', '11:25:35 AM', '11:25:35 AM', '2019-03-25'),
(64, 'admin', 'Administrator', '1000062', '11:45:52 AM', '11:45:52 AM', '2019-03-25'),
(65, 'admin', 'Administrator', '1000063', '11:47:12 AM', '11:47:12 AM', '2019-03-25'),
(66, 'admin', 'Administrator', '1000064', '11:50:10 AM', '11:50:10 AM', '2019-03-25'),
(67, 'Admin', 'Administrator', '1000065', '11:53:04 AM', 'Pending', '2019-03-25'),
(68, 'Admin', 'Administrator', '1000066', '12:07:53 PM', '12:07:53 PM', '2019-03-25'),
(69, 'admin', 'Administrator', '1000067', '12:19:58 PM', '12:19:58 PM', '2019-03-25'),
(70, 'Admin', 'Administrator', '1000068', '12:42:19 PM', '12:42:19 PM', '2019-03-25'),
(71, 'admin', 'Administrator', '1000069', '6:26:05 PM', '6:26:05 PM', '2019-03-25'),
(72, 'sales', 'Sales', '1000069', '6:26:05 PM', 'Pending', '2019-03-25'),
(73, 'sales', 'Sales', '1000070', '6:39:30 PM', 'Pending', '2019-03-25'),
(74, 'sales', 'Sales', '1000071', '6:49:23 PM', 'Pending', '2019-03-25'),
(75, 'sales', 'Sales', '1000072', '7:51:50 PM', 'Pending', '2019-03-25'),
(76, 'sales', 'Sales', '1000073', '7:53:57 PM', 'Pending', '2019-03-25'),
(77, 'sales', 'Sales', '1000074', '7:59:34 PM', 'Pending', '2019-03-25'),
(78, 'sales', 'Sales', '1000075', '8:02:38 PM', 'Pending', '2019-03-25'),
(79, 'sales', 'Sales', '1000076', '8:25:38 PM', 'Pending', '2019-03-25'),
(80, 'sales', 'Sales', '1000077', '8:28:02 PM', 'Pending', '2019-03-25'),
(81, 'sales', 'Sales', '1000078', '8:30:13 PM', 'Pending', '2019-03-25'),
(82, 'sales', 'Sales', '1000079', '8:38:25 PM', 'Pending', '2019-03-25'),
(83, 'sales', 'Sales', '1000080', '8:57:44 PM', 'Pending', '2019-03-25'),
(84, 'sales', 'Sales', '1000081', '8:59:59 PM', 'Pending', '2019-03-25'),
(85, 'sales', 'Sales', '1000082', '9:01:18 PM', 'Pending', '2019-03-25'),
(86, 'sales', 'Sales', '1000083', '9:22:46 PM', 'Pending', '2019-03-25'),
(87, 'sales', 'Sales', '1000084', '9:29:17 PM', 'Pending', '2019-03-25'),
(88, 'sales', 'Sales', '1000085', '9:35:12 PM', 'Pending', '2019-03-25'),
(89, 'sales', 'Sales', '1000086', '9:52:44 PM', 'Pending', '2019-03-25'),
(90, 'sales', 'Sales', '1000087', '9:59:29 PM', 'Pending', '2019-03-25'),
(91, 'sales', 'Sales', '1000088', '10:03:13 PM', 'Pending', '2019-03-25'),
(92, 'sales', 'Sales', '1000089', '10:10:34 PM', 'Pending', '2019-03-25'),
(93, 'sales', 'Sales', '1000090', '10:14:43 PM', 'Pending', '2019-03-25'),
(94, 'sales', 'Sales', '1000091', '10:17:49 PM', 'Pending', '2019-03-25'),
(95, 'sales', 'Sales', '1000092', '10:30:30 PM', 'Pending', '2019-03-25'),
(96, 'sales', 'Sales', '1000093', '10:32:45 PM', '10:32:45 PM', '2019-03-25'),
(97, 'admin', 'Administrator', '1000093', '10:32:45 PM', '10:32:45 PM', '2019-03-25'),
(98, 'sales', 'Sales', '1000093', '10:32:45 PM', 'Pending', '2019-03-25'),
(99, 'sales', 'Sales', '1000094', '10:37:29 PM', 'Pending', '2019-03-25'),
(100, 'sales', 'Sales', '1000095', '10:44:24 PM', 'Pending', '2019-03-25'),
(101, 'sales', 'Sales', '1000096', '10:47:03 PM', 'Pending', '2019-03-25'),
(102, 'sales', 'Sales', '1000097', '10:55:49 PM', 'Pending', '2019-03-25'),
(103, 'sales', 'Sales', '1000097', '10:55:49 PM', 'Pending', '2019-03-25'),
(104, 'sales', 'Sales', '1000098', '10:59:38 PM', 'Pending', '2019-03-25'),
(105, 'sales', 'Sales', '1000099', '11:05:55 PM', 'Pending', '2019-03-25'),
(106, 'sales', 'Sales', '1000100', '11:11:19 PM', 'Pending', '2019-03-25'),
(107, 'Sales', 'Sales', '1000101', '8:45:32 AM', '8:45:32 AM', '2019-03-27'),
(108, 'admin', 'Administrator', '1000101', '8:45:32 AM', '8:45:32 AM', '2019-03-27'),
(109, 'admin', 'Administrator', '1000102', '1:15:05 PM', '1:15:05 PM', '2019-03-29'),
(110, 'Pharmacist', 'Pharmacist', '1000102', '1:15:05 PM', 'Pending', '2019-03-29'),
(111, 'Admin', 'Administrator', '1000103', '7:13:17 AM', '7:13:17 AM', '2019-04-06'),
(112, 'Pharmacist', 'Pharmacist', '1000104', '7:41:13 AM', '7:41:13 AM', '2019-04-06'),
(113, 'Pharmacist', 'Pharmacy', '1000104', '7:41:13 AM', '7:41:13 AM', '2019-04-06'),
(114, 'sales', 'Sales', '1000104', '7:41:13 AM', 'Pending', '2019-04-06'),
(115, 'Pharmacist', 'Pharmacy', '1000105', '1:32:48 AM', 'Pending', '2019-04-12'),
(116, 'Pharmacist', 'Pharmacy', '1000106', '1:37:13 AM', 'Pending', '2019-04-12'),
(117, 'Admin', 'Administrator', '1000107', '3:31:38 PM', '3:31:38 PM', '2019-04-13'),
(118, 'sales', 'Sales', '1000108', '1:13:28 AM', 'Pending', '2019-04-14'),
(119, 'sales', 'Sales', '1000109', '1:29:51 AM', 'Pending', '2019-04-14'),
(120, 'sales', 'Sales', '1000110', '1:34:57 AM', 'Pending', '2019-04-14'),
(121, 'sales', 'Sales', '1000110', '1:34:57 AM', 'Pending', '2019-04-14'),
(122, 'SALES', 'Sales', '1000111', '12:21:55 AM', 'Pending', '2019-04-16'),
(123, 'manager', 'Manager', '1000112', '12:48:29 AM', 'Pending', '2019-04-16'),
(124, 'sales', 'Sales', '1000113', '12:49:29 AM', 'Pending', '2019-04-16'),
(125, 'manager', 'c', '1000114', '7:11:38 AM', 'Pending', '2019-04-16'),
(126, 'manager', 'Manager', '1000115', '7:15:23 AM', 'Pending', '2019-04-16'),
(127, 'Manager', 'Manager', '1000116', '7:18:02 AM', 'Pending', '2019-04-16'),
(128, 'manager', 'Manager', '1000117', '7:19:20 AM', 'Pending', '2019-04-16'),
(129, 'manager', 'Manager', '1000118', '7:22:15 AM', 'Pending', '2019-04-16'),
(130, 'manager', 'Manager', '1000119', '7:23:13 AM', 'Pending', '2019-04-16'),
(131, 'Manager', 'Manager', '1000120', '7:24:02 AM', 'Pending', '2019-04-16'),
(132, 'manager', 'Manager', '1000121', '7:31:58 AM', 'Pending', '2019-04-16'),
(133, 'Manager', 'Manager', '1000122', '7:34:01 AM', 'Pending', '2019-04-16'),
(134, 'manager', 'Manager', '1000123', '7:50:12 AM', 'Pending', '2019-04-16'),
(135, 'Manager', 'Manager', '1000124', '7:52:43 AM', 'Pending', '2019-04-16'),
(136, 'manager', 'Manager', '1000125', '7:59:30 AM', 'Pending', '2019-04-16'),
(137, 'manager', 'Manager', '1000126', '8:00:49 AM', 'Pending', '2019-04-16'),
(138, 'manager', 'Manager', '1000127', '8:01:33 AM', 'Pending', '2019-04-16'),
(139, 'manager', 'Manager', '1000128', '8:12:04 AM', 'Pending', '2019-04-16'),
(140, 'manager', 'Manager', '1000129', '8:37:17 AM', 'Pending', '2019-04-16'),
(141, 'manager', 'Manager', '1000130', '8:42:08 AM', 'Pending', '2019-04-16'),
(142, 'Manager', 'Manager', '1000131', '8:53:26 AM', 'Pending', '2019-04-16'),
(143, 'manager', 'Manager', '1000132', '11:56:48 PM', 'Pending', '2019-04-16'),
(144, 'Manager', 'Manager', '1000133', '12:00:14 AM', 'Pending', '2019-04-17'),
(145, 'pharmacist', 'Pharmacist', '1000134', '10:19:42 PM', 'Pending', '2019-04-18'),
(146, 'manager', 'Manager', '1000135', '10:21:31 PM', 'Pending', '2019-04-18'),
(147, 'manager', 'Manager', '1000136', '8:58:52 AM', 'Pending', '2019-04-23'),
(148, 'manager', 'Manager', '1000137', '9:00:47 AM', 'Pending', '2019-04-23'),
(149, 'manager', 'Manager', '1000138', '9:23:01 AM', 'Pending', '2019-04-23'),
(150, 'manager', 'Manager', '1000139', '9:29:53 AM', 'Pending', '2019-04-23'),
(151, 'manager', 'Manager', '1000140', '9:31:15 AM', 'Pending', '2019-04-23'),
(152, 'manager', 'Manager', '1000141', '9:33:16 AM', 'Pending', '2019-04-23'),
(153, 'MANAGER', 'Manager', '1000142', '9:41:46 AM', 'Pending', '2019-04-23'),
(154, 'manager', 'Manager', '1000143', '9:43:11 AM', 'Pending', '2019-04-23'),
(155, 'manager', 'Manager', '1000144', '9:45:30 AM', 'Pending', '2019-04-23'),
(156, 'manager', 'Manager', '1000145', '9:49:53 AM', 'Pending', '2019-04-23'),
(157, 'manager', 'Manager', '1000146', '9:52:33 AM', 'Pending', '2019-04-23'),
(158, 'manager', 'Manager', '1000147', '9:54:05 AM', 'Pending', '2019-04-23'),
(159, 'Manager', 'Manager', '1000148', '9:56:28 AM', 'Pending', '2019-04-23'),
(160, 'manager', 'Manager', '1000149', '10:15:02 AM', 'Pending', '2019-04-23'),
(161, 'manager', 'Manager', '1000150', '10:16:17 AM', 'Pending', '2019-04-23'),
(162, 'Pharmacist', 'Pharmacist', '1000151', '3:24:30 PM', 'Pending', '2019-04-23'),
(163, 'sales', 'Pharmacist', '1000152', '8:38:08 AM', 'Pending', '2019-04-29'),
(164, 'sales', 'Sales', '1000153', '8:43:02 AM', 'Pending', '2019-04-29'),
(165, 'sales', 'Sales', '1000154', '8:49:38 AM', 'Pending', '2019-04-29'),
(166, 'sales', 'Sales', '1000155', '8:52:20 AM', 'Pending', '2019-04-29'),
(167, 'sales', 'Sales', '1000156', '8:53:15 AM', 'Pending', '2019-04-29'),
(168, 'sales', 'Sales', '1000157', '8:56:22 AM', 'Pending', '2019-04-29'),
(169, 'sales', 'Sales', '1000158', '8:57:50 AM', 'Pending', '2019-04-29'),
(170, 'manager', 'Manager', '1000158', '8:57:50 AM', 'Pending', '2019-04-29'),
(171, 'manager', 'Manager', '1000159', '9:14:16 AM', 'Pending', '2019-04-29'),
(172, 'admin', 'Administrator', '1000160', '9:15:22 AM', '9:15:22 AM', '2019-04-29'),
(173, 'admin', 'Administrator', '1000161', '7:23:49 AM', '7:23:49 AM', '2019-04-30'),
(174, 'manager', 'Manager', '1000161', '7:23:49 AM', 'Pending', '2019-04-30'),
(175, 'Admin', 'Administrator', '1000162', '9:42:43 AM', '9:42:43 AM', '2019-04-30'),
(176, 'Admin', 'Administrator', '1000162', '9:42:43 AM', '9:42:43 AM', '2019-04-30'),
(177, 'Admin', 'Administrator', '1000163', '9:43:43 AM', '9:43:43 AM', '2019-04-30'),
(178, 'Manager', 'Manager', '1000164', '9:45:54 AM', 'Pending', '2019-04-30'),
(179, 'admin', 'Administrator', '1000165', '9:48:35 AM', '9:48:35 AM', '2019-04-30'),
(180, 'manager', 'Manager', '1000165', '9:48:35 AM', 'Pending', '2019-04-30'),
(181, 'pharmacist', 'Pharmacist', '1000166', '9:51:30 AM', 'Pending', '2019-04-30'),
(182, 'manager', 'Manager', '1000167', '9:31:04 PM', 'Pending', '2019-04-30'),
(183, 'manager', 'Manager', '1000168', '9:33:18 PM', 'Pending', '2019-04-30'),
(184, 'manager', 'Manager', '1000169', '9:34:47 PM', 'Pending', '2019-04-30'),
(185, 'manager', 'Manager', '1000170', '9:37:34 PM', 'Pending', '2019-04-30'),
(186, 'manager', 'Manager', '1000171', '9:38:22 PM', 'Pending', '2019-04-30'),
(187, 'manager', 'Manager', '1000172', '9:39:12 PM', 'Pending', '2019-04-30'),
(188, 'manager', 'Manager', '1000173', '9:51:45 PM', 'Pending', '2019-04-30'),
(189, 'manager', 'Manager', '1000174', '9:57:30 PM', 'Pending', '2019-04-30'),
(190, 'manager', 'Manager', '1000175', '9:59:57 PM', 'Pending', '2019-04-30'),
(191, 'manager', 'Manager', '1000176', '10:22:32 PM', 'Pending', '2019-04-30'),
(192, 'manager', 'Manager', '1000177', '10:50:19 PM', 'Pending', '2019-04-30'),
(193, 'manager', 'Manager', '1000178', '10:53:35 PM', 'Pending', '2019-04-30'),
(194, 'admin', 'Administrator', '1000179', '11:01:29 PM', '11:01:29 PM', '2019-04-30'),
(195, 'admin', 'Administrator', '1000180', '11:05:28 PM', '11:05:28 PM', '2019-04-30'),
(196, 'pharmacist', 'Pharmacist', '1000181', '11:07:22 PM', 'Pending', '2019-04-30'),
(197, 'pharmacist', 'Pharmacist', '1000182', '11:10:28 PM', 'Pending', '2019-04-30'),
(198, 'pharmacist', 'Pharmacist', '1000183', '11:11:40 PM', 'Pending', '2019-04-30'),
(199, 'pharmacist', 'Pharmacist', '1000184', '11:12:28 PM', 'Pending', '2019-04-30'),
(200, 'pharmacist', 'Pharmacist', '1000185', '11:13:18 PM', 'Pending', '2019-04-30'),
(201, 'pharmacist', 'Pharmacist', '1000186', '11:14:16 PM', 'Pending', '2019-04-30'),
(202, 'pharmacist', 'Pharmacist', '1000187', '11:15:04 PM', 'Pending', '2019-04-30'),
(203, 'manager', 'Manager', '1000188', '11:22:20 PM', 'Pending', '2019-04-30'),
(204, 'pharmacist', 'Pharmacist', '1000189', '11:23:08 PM', 'Pending', '2019-04-30'),
(205, 'pharmacist', 'Pharmacist', '1000190', '11:24:14 PM', 'Pending', '2019-04-30'),
(206, 'pharmacist', 'Pharmacist', '1000190', '11:24:14 PM', 'Pending', '2019-04-30');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `userid` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `name` varchar(50) NOT NULL,
  `surname` varchar(50) NOT NULL,
  `gender` varchar(50) NOT NULL,
  `user_role` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL DEFAULT '123456'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`userid`, `username`, `name`, `surname`, `gender`, `user_role`, `password`) VALUES
(1, 'Admin', 'Patie', 'Shorai', 'Female', 'Administrator', '123456'),
(2, 'Sales', 'Manue', 'Manika', 'Female', 'Sales', '123456'),
(3, 'Manager', 'Mabhande', 'Very', 'Female', 'Manager', '123456'),
(4, 'Pharmacist', 'Manu', 'Mainduna', 'Female', 'Pharmacist', '123456');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`category_id`),
  ADD UNIQUE KEY `category_name` (`category_name`);

--
-- Indexes for table `customer_details`
--
ALTER TABLE `customer_details`
  ADD PRIMARY KEY (`customer_id`);

--
-- Indexes for table `invoice_receipt`
--
ALTER TABLE `invoice_receipt`
  ADD PRIMARY KEY (`receipt_no`),
  ADD KEY `id` (`id`);

--
-- Indexes for table `invoice_receipt_details`
--
ALTER TABLE `invoice_receipt_details`
  ADD PRIMARY KEY (`cart_id`),
  ADD KEY `receipt_no` (`receipt_no`),
  ADD KEY `product_name` (`product_name`);

--
-- Indexes for table `product_details`
--
ALTER TABLE `product_details`
  ADD PRIMARY KEY (`product_id`);

--
-- Indexes for table `product_purchase_details`
--
ALTER TABLE `product_purchase_details`
  ADD PRIMARY KEY (`purchase_id`);

--
-- Indexes for table `suppliers`
--
ALTER TABLE `suppliers`
  ADD PRIMARY KEY (`supplier_id`),
  ADD UNIQUE KEY `supplier_name` (`supplier_name`);

--
-- Indexes for table `systemlogs`
--
ALTER TABLE `systemlogs`
  ADD PRIMARY KEY (`userid`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`userid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `category`
--
ALTER TABLE `category`
  MODIFY `category_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `customer_details`
--
ALTER TABLE `customer_details`
  MODIFY `customer_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `invoice_receipt`
--
ALTER TABLE `invoice_receipt`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `invoice_receipt_details`
--
ALTER TABLE `invoice_receipt_details`
  MODIFY `cart_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `product_details`
--
ALTER TABLE `product_details`
  MODIFY `product_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `product_purchase_details`
--
ALTER TABLE `product_purchase_details`
  MODIFY `purchase_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `suppliers`
--
ALTER TABLE `suppliers`
  MODIFY `supplier_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `systemlogs`
--
ALTER TABLE `systemlogs`
  MODIFY `userid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=207;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `userid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
