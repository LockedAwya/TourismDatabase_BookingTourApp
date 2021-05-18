-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 18, 2021 at 09:49 PM
-- Server version: 10.4.17-MariaDB
-- PHP Version: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tourismdatabase`
--
CREATE DATABASE IF NOT EXISTS `tourismdatabase` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `tourismdatabase`;

DELIMITER $$
--
-- Procedures
--
DROP PROCEDURE IF EXISTS `DeleteABookingActivity`$$
CREATE DEFINER=`` PROCEDURE `DeleteABookingActivity` (IN `Acc_ID` INT(20), IN `Tour_ID` VARCHAR(200))  NO SQL
DELETE from travellers_info where aid = Acc_ID and travellers_info.Tour_ID = Tour_ID$$

DROP PROCEDURE IF EXISTS `getTour`$$
CREATE DEFINER=`` PROCEDURE `getTour` ()  select tat.*, t.name, c.country_name, t.description, t.policy, t.startdate, t.enddate, t.startdestination, t.enddestination, t.childrenprice, t.adultprice, fm.flight_name, ta.name, ta.phonenumber from travel_agent_tourid tat 
left join tour t using(id) 
left join countries c on t.country = c.id 
left join flight_manager fm on t.flight_id = fm.flight_id 
left join travel_agent ta on tat.ta_id = ta.ta_id$$

DROP PROCEDURE IF EXISTS `getTourRecords`$$
CREATE DEFINER=`` PROCEDURE `getTourRecords` ()  select * from travellers_view_tours$$

DROP PROCEDURE IF EXISTS `get_records`$$
CREATE DEFINER=`` PROCEDURE `get_records` (IN `prefix` VARCHAR(50))  select * from travellers_view_tours where left(tour_id, length(prefix)) = prefix or left(name,length(prefix)) = prefix$$

DROP PROCEDURE IF EXISTS `ViewBookingActivity`$$
CREATE DEFINER=`` PROCEDURE `ViewBookingActivity` (IN `Acc_ID` VARCHAR(200), IN `Tour_ID` VARCHAR(200))  SELECT * from travellers_info where aid = Acc_ID and travellers_info.Tour_ID = Tour_ID$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `account`
--

DROP TABLE IF EXISTS `account`;
CREATE TABLE `account` (
  `ID` int(10) NOT NULL,
  `Name` varchar(40) NOT NULL,
  `Username` varchar(40) NOT NULL,
  `password` varchar(70) NOT NULL,
  `phone_number` int(20) NOT NULL,
  `email` varchar(30) NOT NULL,
  `address` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `account`
--

INSERT INTO `account` (`ID`, `Name`, `Username`, `password`, `phone_number`, `email`, `address`) VALUES
(5, 'hoang', 'duc', '270723e7f50a26d4ae90da0e13079f293dd37e9953f7f9801ce7de19a35fc58e', 123, 'ads@gmail.com', 'hanoi'),
(6, 'Dang Hai Ngoooo', 'dangbb', '6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b', 1261, 'bbbbbbbbbb@gmail.com', 'thai nguyen'),
(8, 'Duc Hoang', 'tester1', '6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b', 19020000, '19020000@vnu.edu.vn', 'Hanoi'),
(13, '1', 'rw', '6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b', 423823, 'ri@gmail.com', 'ewq'),
(14, 'duchoang', 'hoang102', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 2378231, 'gh@gmail.com', 'Hanoi'),
(15, 'duc hoang', 'hoang1', '5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5', 1902000128, '1912@gmail.com', 'Hanoi, Vietnam'),
(17, 'Hoang', 'duchoang0000', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 93248171, 'hoang@gmail.com', 'Hanoi'),
(18, 'Duc Hoang', 'hoang1234', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 92381321, 'hoang1@gmail.com', 'Hanoi'),
(19, 'Duc Hoang Hoang', 'hoang0123', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 91324237, 'random@gmail.com', 'Hanoi'),
(20, 'Duc Hoang test', 'tester123', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 83267, 'i@gmail.com', 'hanoi, Vietnam'),
(21, 'Duc Hoang', 'tester4', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 923767236, 'tester4@gmail.com', 'Hanoi, Vietnam, Vietnam'),
(22, 'Duc Hoang ', 'tester6', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 93217621, 'tester6@gmail.com', 'Hanoi, Vietnam');

-- --------------------------------------------------------

--
-- Stand-in structure for view `booking_section`
-- (See below for the actual view)
--
DROP VIEW IF EXISTS `booking_section`;
CREATE TABLE `booking_section` (
`aid` int(10)
,`tour_id` varchar(20)
,`No_of_adults` decimal(23,0)
,`No_of_children` decimal(23,0)
);

-- --------------------------------------------------------

--
-- Table structure for table `countries`
--

DROP TABLE IF EXISTS `countries`;
CREATE TABLE `countries` (
  `id` int(11) NOT NULL,
  `phone_code` int(5) NOT NULL,
  `country_code` char(2) NOT NULL,
  `country_name` varchar(80) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `countries`
--

INSERT INTO `countries` (`id`, `phone_code`, `country_code`, `country_name`) VALUES
(1, 93, 'AF', 'Afghanistan'),
(2, 358, 'AX', 'Aland Islands'),
(3, 355, 'AL', 'Albania'),
(4, 213, 'DZ', 'Algeria'),
(5, 1684, 'AS', 'American Samoa'),
(6, 376, 'AD', 'Andorra'),
(7, 244, 'AO', 'Angola'),
(8, 1264, 'AI', 'Anguilla'),
(9, 672, 'AQ', 'Antarctica'),
(10, 1268, 'AG', 'Antigua and Barbuda'),
(11, 54, 'AR', 'Argentina'),
(12, 374, 'AM', 'Armenia'),
(13, 297, 'AW', 'Aruba'),
(14, 61, 'AU', 'Australia'),
(15, 43, 'AT', 'Austria'),
(16, 994, 'AZ', 'Azerbaijan'),
(17, 1242, 'BS', 'Bahamas'),
(18, 973, 'BH', 'Bahrain'),
(19, 880, 'BD', 'Bangladesh'),
(20, 1246, 'BB', 'Barbados'),
(21, 375, 'BY', 'Belarus'),
(22, 32, 'BE', 'Belgium'),
(23, 501, 'BZ', 'Belize'),
(24, 229, 'BJ', 'Benin'),
(25, 1441, 'BM', 'Bermuda'),
(26, 975, 'BT', 'Bhutan'),
(27, 591, 'BO', 'Bolivia'),
(28, 599, 'BQ', 'Bonaire, Sint Eustatius and Saba'),
(29, 387, 'BA', 'Bosnia and Herzegovina'),
(30, 267, 'BW', 'Botswana'),
(31, 55, 'BV', 'Bouvet Island'),
(32, 55, 'BR', 'Brazil'),
(33, 246, 'IO', 'British Indian Ocean Territory'),
(34, 673, 'BN', 'Brunei Darussalam'),
(35, 359, 'BG', 'Bulgaria'),
(36, 226, 'BF', 'Burkina Faso'),
(37, 257, 'BI', 'Burundi'),
(38, 855, 'KH', 'Cambodia'),
(39, 237, 'CM', 'Cameroon'),
(40, 1, 'CA', 'Canada'),
(41, 238, 'CV', 'Cape Verde'),
(42, 1345, 'KY', 'Cayman Islands'),
(43, 236, 'CF', 'Central African Republic'),
(44, 235, 'TD', 'Chad'),
(45, 56, 'CL', 'Chile'),
(46, 86, 'CN', 'China'),
(47, 61, 'CX', 'Christmas Island'),
(48, 672, 'CC', 'Cocos (Keeling) Islands'),
(49, 57, 'CO', 'Colombia'),
(50, 269, 'KM', 'Comoros'),
(51, 242, 'CG', 'Congo'),
(52, 242, 'CD', 'Congo, Democratic Republic of the Congo'),
(53, 682, 'CK', 'Cook Islands'),
(54, 506, 'CR', 'Costa Rica'),
(55, 225, 'CI', 'Cote D\'Ivoire'),
(56, 385, 'HR', 'Croatia'),
(57, 53, 'CU', 'Cuba'),
(58, 599, 'CW', 'Curacao'),
(59, 357, 'CY', 'Cyprus'),
(60, 420, 'CZ', 'Czech Republic'),
(61, 45, 'DK', 'Denmark'),
(62, 253, 'DJ', 'Djibouti'),
(63, 1767, 'DM', 'Dominica'),
(64, 1809, 'DO', 'Dominican Republic'),
(65, 593, 'EC', 'Ecuador'),
(66, 20, 'EG', 'Egypt'),
(67, 503, 'SV', 'El Salvador'),
(68, 240, 'GQ', 'Equatorial Guinea'),
(69, 291, 'ER', 'Eritrea'),
(70, 372, 'EE', 'Estonia'),
(71, 251, 'ET', 'Ethiopia'),
(72, 500, 'FK', 'Falkland Islands (Malvinas)'),
(73, 298, 'FO', 'Faroe Islands'),
(74, 679, 'FJ', 'Fiji'),
(75, 358, 'FI', 'Finland'),
(76, 33, 'FR', 'France'),
(77, 594, 'GF', 'French Guiana'),
(78, 689, 'PF', 'French Polynesia'),
(79, 262, 'TF', 'French Southern Territories'),
(80, 241, 'GA', 'Gabon'),
(81, 220, 'GM', 'Gambia'),
(82, 995, 'GE', 'Georgia'),
(83, 49, 'DE', 'Germany'),
(84, 233, 'GH', 'Ghana'),
(85, 350, 'GI', 'Gibraltar'),
(86, 30, 'GR', 'Greece'),
(87, 299, 'GL', 'Greenland'),
(88, 1473, 'GD', 'Grenada'),
(89, 590, 'GP', 'Guadeloupe'),
(90, 1671, 'GU', 'Guam'),
(91, 502, 'GT', 'Guatemala'),
(92, 44, 'GG', 'Guernsey'),
(93, 224, 'GN', 'Guinea'),
(94, 245, 'GW', 'Guinea-Bissau'),
(95, 592, 'GY', 'Guyana'),
(96, 509, 'HT', 'Haiti'),
(97, 0, 'HM', 'Heard Island and Mcdonald Islands'),
(98, 39, 'VA', 'Holy See (Vatican City State)'),
(99, 504, 'HN', 'Honduras'),
(100, 852, 'HK', 'Hong Kong'),
(101, 36, 'HU', 'Hungary'),
(102, 354, 'IS', 'Iceland'),
(103, 91, 'IN', 'India'),
(104, 62, 'ID', 'Indonesia'),
(105, 98, 'IR', 'Iran, Islamic Republic of'),
(106, 964, 'IQ', 'Iraq'),
(107, 353, 'IE', 'Ireland'),
(108, 44, 'IM', 'Isle of Man'),
(109, 972, 'IL', 'Israel'),
(110, 39, 'IT', 'Italy'),
(111, 1876, 'JM', 'Jamaica'),
(112, 81, 'JP', 'Japan'),
(113, 44, 'JE', 'Jersey'),
(114, 962, 'JO', 'Jordan'),
(115, 7, 'KZ', 'Kazakhstan'),
(116, 254, 'KE', 'Kenya'),
(117, 686, 'KI', 'Kiribati'),
(118, 850, 'KP', 'Korea, Democratic People\'s Republic of'),
(119, 82, 'KR', 'Korea, Republic of'),
(120, 381, 'XK', 'Kosovo'),
(121, 965, 'KW', 'Kuwait'),
(122, 996, 'KG', 'Kyrgyzstan'),
(123, 856, 'LA', 'Lao People\'s Democratic Republic'),
(124, 371, 'LV', 'Latvia'),
(125, 961, 'LB', 'Lebanon'),
(126, 266, 'LS', 'Lesotho'),
(127, 231, 'LR', 'Liberia'),
(128, 218, 'LY', 'Libyan Arab Jamahiriya'),
(129, 423, 'LI', 'Liechtenstein'),
(130, 370, 'LT', 'Lithuania'),
(131, 352, 'LU', 'Luxembourg'),
(132, 853, 'MO', 'Macao'),
(133, 389, 'MK', 'Macedonia, the Former Yugoslav Republic of'),
(134, 261, 'MG', 'Madagascar'),
(135, 265, 'MW', 'Malawi'),
(136, 60, 'MY', 'Malaysia'),
(137, 960, 'MV', 'Maldives'),
(138, 223, 'ML', 'Mali'),
(139, 356, 'MT', 'Malta'),
(140, 692, 'MH', 'Marshall Islands'),
(141, 596, 'MQ', 'Martinique'),
(142, 222, 'MR', 'Mauritania'),
(143, 230, 'MU', 'Mauritius'),
(144, 269, 'YT', 'Mayotte'),
(145, 52, 'MX', 'Mexico'),
(146, 691, 'FM', 'Micronesia, Federated States of'),
(147, 373, 'MD', 'Moldova, Republic of'),
(148, 377, 'MC', 'Monaco'),
(149, 976, 'MN', 'Mongolia'),
(150, 382, 'ME', 'Montenegro'),
(151, 1664, 'MS', 'Montserrat'),
(152, 212, 'MA', 'Morocco'),
(153, 258, 'MZ', 'Mozambique'),
(154, 95, 'MM', 'Myanmar'),
(155, 264, 'NA', 'Namibia'),
(156, 674, 'NR', 'Nauru'),
(157, 977, 'NP', 'Nepal'),
(158, 31, 'NL', 'Netherlands'),
(159, 599, 'AN', 'Netherlands Antilles'),
(160, 687, 'NC', 'New Caledonia'),
(161, 64, 'NZ', 'New Zealand'),
(162, 505, 'NI', 'Nicaragua'),
(163, 227, 'NE', 'Niger'),
(164, 234, 'NG', 'Nigeria'),
(165, 683, 'NU', 'Niue'),
(166, 672, 'NF', 'Norfolk Island'),
(167, 1670, 'MP', 'Northern Mariana Islands'),
(168, 47, 'NO', 'Norway'),
(169, 968, 'OM', 'Oman'),
(170, 92, 'PK', 'Pakistan'),
(171, 680, 'PW', 'Palau'),
(172, 970, 'PS', 'Palestinian Territory, Occupied'),
(173, 507, 'PA', 'Panama'),
(174, 675, 'PG', 'Papua New Guinea'),
(175, 595, 'PY', 'Paraguay'),
(176, 51, 'PE', 'Peru'),
(177, 63, 'PH', 'Philippines'),
(178, 64, 'PN', 'Pitcairn'),
(179, 48, 'PL', 'Poland'),
(180, 351, 'PT', 'Portugal'),
(181, 1787, 'PR', 'Puerto Rico'),
(182, 974, 'QA', 'Qatar'),
(183, 262, 'RE', 'Reunion'),
(184, 40, 'RO', 'Romania'),
(185, 70, 'RU', 'Russian Federation'),
(186, 250, 'RW', 'Rwanda'),
(187, 590, 'BL', 'Saint Barthelemy'),
(188, 290, 'SH', 'Saint Helena'),
(189, 1869, 'KN', 'Saint Kitts and Nevis'),
(190, 1758, 'LC', 'Saint Lucia'),
(191, 590, 'MF', 'Saint Martin'),
(192, 508, 'PM', 'Saint Pierre and Miquelon'),
(193, 1784, 'VC', 'Saint Vincent and the Grenadines'),
(194, 684, 'WS', 'Samoa'),
(195, 378, 'SM', 'San Marino'),
(196, 239, 'ST', 'Sao Tome and Principe'),
(197, 966, 'SA', 'Saudi Arabia'),
(198, 221, 'SN', 'Senegal'),
(199, 381, 'RS', 'Serbia'),
(200, 381, 'CS', 'Serbia and Montenegro'),
(201, 248, 'SC', 'Seychelles'),
(202, 232, 'SL', 'Sierra Leone'),
(203, 65, 'SG', 'Singapore'),
(204, 1, 'SX', 'Sint Maarten'),
(205, 421, 'SK', 'Slovakia'),
(206, 386, 'SI', 'Slovenia'),
(207, 677, 'SB', 'Solomon Islands'),
(208, 252, 'SO', 'Somalia'),
(209, 27, 'ZA', 'South Africa'),
(210, 500, 'GS', 'South Georgia and the South Sandwich Islands'),
(211, 211, 'SS', 'South Sudan'),
(212, 34, 'ES', 'Spain'),
(213, 94, 'LK', 'Sri Lanka'),
(214, 249, 'SD', 'Sudan'),
(215, 597, 'SR', 'Suriname'),
(216, 47, 'SJ', 'Svalbard and Jan Mayen'),
(217, 268, 'SZ', 'Swaziland'),
(218, 46, 'SE', 'Sweden'),
(219, 41, 'CH', 'Switzerland'),
(220, 963, 'SY', 'Syrian Arab Republic'),
(221, 886, 'TW', 'Taiwan, Province of China'),
(222, 992, 'TJ', 'Tajikistan'),
(223, 255, 'TZ', 'Tanzania, United Republic of'),
(224, 66, 'TH', 'Thailand'),
(225, 670, 'TL', 'Timor-Leste'),
(226, 228, 'TG', 'Togo'),
(227, 690, 'TK', 'Tokelau'),
(228, 676, 'TO', 'Tonga'),
(229, 1868, 'TT', 'Trinidad and Tobago'),
(230, 216, 'TN', 'Tunisia'),
(231, 90, 'TR', 'Turkey'),
(232, 7370, 'TM', 'Turkmenistan'),
(233, 1649, 'TC', 'Turks and Caicos Islands'),
(234, 688, 'TV', 'Tuvalu'),
(235, 256, 'UG', 'Uganda'),
(236, 380, 'UA', 'Ukraine'),
(237, 971, 'AE', 'United Arab Emirates'),
(238, 44, 'GB', 'United Kingdom'),
(239, 1, 'US', 'United States'),
(240, 1, 'UM', 'United States Minor Outlying Islands'),
(241, 598, 'UY', 'Uruguay'),
(242, 998, 'UZ', 'Uzbekistan'),
(243, 678, 'VU', 'Vanuatu'),
(244, 58, 'VE', 'Venezuela'),
(245, 84, 'VN', 'Viet Nam'),
(246, 1284, 'VG', 'Virgin Islands, British'),
(247, 1340, 'VI', 'Virgin Islands, U.s.'),
(248, 681, 'WF', 'Wallis and Futuna'),
(249, 212, 'EH', 'Western Sahara'),
(250, 967, 'YE', 'Yemen'),
(251, 260, 'ZM', 'Zambia'),
(252, 263, 'ZW', 'Zimbabwe');

-- --------------------------------------------------------

--
-- Table structure for table `flight_manager`
--

DROP TABLE IF EXISTS `flight_manager`;
CREATE TABLE `flight_manager` (
  `Flight_ID` varchar(20) NOT NULL,
  `Flight_Name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `flight_manager`
--

INSERT INTO `flight_manager` (`Flight_ID`, `Flight_Name`) VALUES
('BA', 'Bamboo Airways'),
('EK', 'Emirates Airways'),
('EY', 'Etihad Airways'),
('QA', 'Qatar Airways'),
('VA', 'Vietnam Airlines');

-- --------------------------------------------------------

--
-- Table structure for table `paymenttype`
--

DROP TABLE IF EXISTS `paymenttype`;
CREATE TABLE `paymenttype` (
  `PaymentID` int(50) NOT NULL,
  `AID` int(20) NOT NULL,
  `TID` varchar(50) NOT NULL,
  `PaymentMethod` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `paymenttype`
--

INSERT INTO `paymenttype` (`PaymentID`, `AID`, `TID`, `PaymentMethod`) VALUES
(1, 6, 'EGYPT_2', 'Cash'),
(2, 6, 'LEBANON_1', 'Paypal'),
(3, 6, 'Qatar_2', 'Paypal'),
(6, 6, 'UAE_1', 'Paypal'),
(7, 6, 'UAE_2', 'Cash'),
(31, 21, 'UAE_2', 'Bitcoin'),
(33, 22, 'UAE_1', 'Bitcoin'),
(34, 6, 'EGYPT_1', 'Paypal'),
(35, 6, 'EGYPT_2', 'Paypal');

-- --------------------------------------------------------

--
-- Table structure for table `tour`
--

DROP TABLE IF EXISTS `tour`;
CREATE TABLE `tour` (
  `Tour_ID` varchar(20) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Country` int(11) NOT NULL,
  `Description` longtext NOT NULL,
  `Policy` text NOT NULL,
  `StartDate` date NOT NULL,
  `EndDate` date NOT NULL,
  `StartDestination` varchar(20) NOT NULL,
  `EndDestination` varchar(20) NOT NULL,
  `ChildrenPrice` int(10) NOT NULL,
  `AdultPrice` int(10) NOT NULL,
  `Flight_ID` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tour`
--

INSERT INTO `tour` (`Tour_ID`, `Name`, `Country`, `Description`, `Policy`, `StartDate`, `EndDate`, `StartDestination`, `EndDestination`, `ChildrenPrice`, `AdultPrice`, `Flight_ID`) VALUES
('EGYPT_1', 'Cairo - Alexandria', 66, 'Day 1: Go to...\r\nDay 2: Go to...\r\nDay 3:\r\nDay 4:\r\nDay 5:', 'Get a free spa voucher\r\nDiscount 20% hotel rooms', '2021-05-12', '2021-05-20', 'Hanoi', 'Cairo', 1500000, 3000000, 'BA'),
('EGYPT_2', 'Cairo', 66, 'Day 1:\r\nDay 2:\r\nDay 3:\r\nDay 4:\r\n', 'discount 1\r\ndiscount 2\r\ndiscount 3', '2021-04-22', '2021-04-26', 'TPHCM', 'Cairo', 1000000, 2000000, 'VA'),
('EGYPT_3', 'Cairo - Khartoum - Aswan - Luxor', 66, 'Day 1:\r\nDay 2:\r\nDay 3:\r\n....', 'discount 1\r\ndiscount 2\r\ndiscount 3', '2021-04-07', '2021-04-17', 'Hanoi', 'Cairo', 5000000, 6000000, 'BA'),
('EGYPT_5', 'Giza tour', 66, 'Day 1\r\nDay 2\r\nDay 3', 'Discount 1\r\nDiscount 2', '2021-06-09', '2021-05-11', 'TPHCM', 'Cairo', 1500000, 3000000, 'VA'),
('LEBANON_1', 'Trip to the Beirut', 125, 'Day 1\r\nDay 2\r\nDay 3', 'Policy 1\r\nPolicy 2', '2021-05-18', '2021-05-25', 'Hanoi', 'Beirut', 1000000, 2000000, 'VA'),
('Qatar_2', 'Doha', 182, 'Day 1:\r\nDay 2:\r\nDay 3:\r\n....', 'Day 1:\r\nDay 2:\r\nDay 3:\r\n....', '2021-04-16', '2021-04-20', 'Hanoi', 'Doha', 5000000, 9000000, 'QA'),
('QATAR_3', 'Stadiums trip of 2022 World Cup home owner', 182, 'Day 1\r\nDay 2\r\nDay 3\r\n...', 'Policy 1\r\nPolicy 2\r\nPolicy 3', '2022-07-14', '2021-05-28', 'Hanoi', 'Doha', 10000000, 20000000, 'QA'),
('SAUDI_1', 'Riyadh tour', 197, 'Day 1:\r\nDay 2:\r\nDay 3:\r\nDay 4:', 'Discount\r\ndiscount', '2021-05-15', '2021-05-19', 'Hanoi', 'Riyadh', 1000000, 2000000, 'BA'),
('TURKEY_1', 'Viewing cats in Istanbul, Turkey.', 231, 'Day 1:\r\nDay 2:\r\nDay 3:\r\n...', 'Discount 1\r\nDiscount 2\r\nDiscount 3', '2021-05-21', '2021-05-20', 'Hanoi', 'Istanbul', 1000000, 2000000, 'BA'),
('UAE_1', 'Dubai Exploration', 237, 'Day 1\r\nDay 2\r\nDay 3', 'Discount 1\r\nDiscount 2\r\nDiscount 3', '2021-05-19', '2021-05-25', 'Hanoi', 'Dubai', 10000000, 20000000, 'VA'),
('UAE_2', 'Dessert tour in Abu Dhabi', 237, 'Day 1\r\nDay 2\r\nDay 3\r\n...', 'Policy 1\r\nPolicy 2\r\nPolicy 3', '2021-05-20', '2021-05-25', 'Danang', 'Abu Dhabi', 5000000, 10000000, 'BA'),
('UAE_3', 'Trip to Sharjah', 237, 'Day 1\r\nDay 2\r\nDay 3\r\n', 'Policy 1\r\nPolicy 2', '2021-05-19', '2021-05-26', 'Hanoi', 'Abu Dhabi', 5000000, 6000000, 'EK'),
('UAE_4', 'Trip to the dessert', 237, 'day 1\r\nday 2\r\nday 3', 'policy 1\r\npolicy 2\r\npolicy 3', '2021-05-26', '2021-05-31', 'Hanoi', 'Dubai', 1000000, 2000000, 'BA');

-- --------------------------------------------------------

--
-- Table structure for table `tour_guide`
--

DROP TABLE IF EXISTS `tour_guide`;
CREATE TABLE `tour_guide` (
  `TG_ID` int(11) NOT NULL,
  `Name` varchar(40) NOT NULL,
  `BirthDate` date NOT NULL,
  `Gender` varchar(10) NOT NULL,
  `Country` int(11) NOT NULL,
  `Age` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tour_guide`
--

INSERT INTO `tour_guide` (`TG_ID`, `Name`, `BirthDate`, `Gender`, `Country`, `Age`) VALUES
(1045, 'Hoang Duc', '1995-04-07', 'Male', 245, 26),
(1046, 'Tran Xuan Hai', '1989-12-06', 'Male', 245, 31),
(1047, 'Tran Xuan Hai 1', '1990-03-02', 'Male', 245, 31),
(1221, 'Duc Hoang', '1994-06-03', 'Male', 245, 26),
(1222, 'Hoang Duc', '1994-06-11', 'Male', 245, 26),
(8123, 'Ngo Hai Dnag', '1995-04-07', 'Male', 245, 26),
(14872391, 'Hoang', '1995-04-07', 'Male', 245, 26),
(414128791, 'Duc', '1990-03-02', 'Male', 239, 31);

-- --------------------------------------------------------

--
-- Table structure for table `tour_guide_classification`
--

DROP TABLE IF EXISTS `tour_guide_classification`;
CREATE TABLE `tour_guide_classification` (
  `Type_ID` int(11) NOT NULL,
  `Type_Name` varchar(60) NOT NULL,
  `Description` mediumtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tour_guide_classification`
--

INSERT INTO `tour_guide_classification` (`Type_ID`, `Type_Name`, `Description`) VALUES
(1, 'Adventure Guide', 'Mountaineering Guide\r\nTrekking Guide\r\nSkiing Guide\r\nSurfing Guide\r\nScuba Diving / Snorkeling Guide '),
(2, 'Business Guide', 'Real Estate Consultant '),
(3, 'Coach Guide', 'City Tour Guide '),
(4, 'Culture Guide', 'One who gives information on the lifestyle patter on the native society of that particular Tourist Destination\r\na.Cuisine Guide: One who gives information on the Agriculture, cultivation, and staple diet of a place, delicacies of that region and where to eat what and when. He /she takes the guest around the city making them taste specialties prepared at different food shops and restaurants. Places visited are Farms, Restaurants, Sweet Shops, Chocolate Factory, Cheese Factory, Vineyards, Orchards etc\r\nb.Religious Guide / Temple Guide / Pilgrim Guide : One who gives information on the religion, gods & goddesses, mythology, traditions, rituals etc, such guides are hired especially during festival times, they are found at temples, and other shrines '),
(5, 'Forest/Wilderness', 'Hunting Guide\r\nSafari Guide\r\n'),
(6, 'Heritage', 'a.History:One who gives information of the past, moreover found at Palaces, Forts, Museums, Battlefields, Tombs / Mausoleums, Temples , Churches etc\r\nb.Archeological:One who gives information on the ancient civilizations and the bygone era , found at museums and archeological sites like the Giza Pyramid s, Harappa & Mohenjo-Daro, Nalanda University, Machu Picchu etc\r\nc.Architecture Guide :One who gives information of the art and construction strategy of the monuments and masterpieces from the past, found especially outside Temples, Palaces, Tombs / Mausoleums, Towers etc '),
(7, 'Natural Guide', 'Desert Guide\r\nHill Station Guide\r\nBotanical Garden Guide\r\n'),
(8, 'Special Interest Gui', 'Cruise Guide, Golf Guide, Shopping Guide, Hotel Guide, Wedding Guide etc ');

-- --------------------------------------------------------

--
-- Table structure for table `tour_guide_tourid`
--

DROP TABLE IF EXISTS `tour_guide_tourid`;
CREATE TABLE `tour_guide_tourid` (
  `NumberID` int(30) NOT NULL,
  `TG_ID` int(11) NOT NULL,
  `Tour_ID` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tour_guide_tourid`
--

INSERT INTO `tour_guide_tourid` (`NumberID`, `TG_ID`, `Tour_ID`) VALUES
(1, 1221, 1),
(2, 1221, 5),
(3, 1222, 5),
(4, 414128791, 3),
(5, 414128791, 9),
(6, 8123, 1),
(7, 1045, 5),
(8, 1046, 1),
(12, 1047, 1),
(13, 1046, 8);

-- --------------------------------------------------------

--
-- Table structure for table `tour_guide_types`
--

DROP TABLE IF EXISTS `tour_guide_types`;
CREATE TABLE `tour_guide_types` (
  `NumberID` int(11) NOT NULL,
  `TG_ID` int(11) NOT NULL,
  `Type_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tour_guide_types`
--

INSERT INTO `tour_guide_types` (`NumberID`, `TG_ID`, `Type_ID`) VALUES
(1, 414128791, 3),
(2, 414128791, 5),
(3, 1221, 3),
(4, 1222, 3),
(5, 8123, 3),
(6, 8123, 6),
(7, 14872391, 2),
(8, 14872391, 1);

-- --------------------------------------------------------

--
-- Table structure for table `travellers_info`
--

DROP TABLE IF EXISTS `travellers_info`;
CREATE TABLE `travellers_info` (
  `AID` int(10) NOT NULL,
  `Tour_ID` varchar(20) NOT NULL,
  `SSN` int(20) DEFAULT NULL,
  `Name` varchar(20) NOT NULL,
  `PassportNumber` varchar(20) NOT NULL,
  `PhoneNumber` int(15) DEFAULT NULL,
  `Country` varchar(20) NOT NULL,
  `BirthDate` date NOT NULL,
  `Gender` char(10) NOT NULL,
  `age` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `travellers_info`
--

INSERT INTO `travellers_info` (`AID`, `Tour_ID`, `SSN`, `Name`, `PassportNumber`, `PhoneNumber`, `Country`, `BirthDate`, `Gender`, `age`) VALUES
(19, 'QATAR_3', 931247, 'Duc', '0234323', 427912, 'Vietnam', '1998-05-03', 'Male', 23),
(18, 'QATAR_3', 93244317, 'Duc', '0412378', 9123712, 'Vietnam', '1998-05-03', 'Male', 23),
(6, 'EGYPT_1', 981239478, 'dnag', '073481297', 9861253, 'Vietnam', '1999-05-03', 'Male', 22),
(6, 'EGYPT_1', 897421, 'hi', '0908178', 9887142, 'Vietnam', '1994-05-03', 'Male', 27),
(6, 'EGYPT_2', 932813, 'hoang', '0942312', 932712, 'Vietnam', '1998-05-03', 'Male', 23),
(6, 'EGYPT_1', 12445533, 'phong', '094828137', 9748917, 'Brunei', '1994-05-03', 'Male', 27),
(6, 'EGYPT_2', 974432, 'ji', '098329', 981248, 'Vietnam', '1998-05-03', 'Male', 23),
(5, 'EGYPT_1', 123432, 'huy', '1234154353', 9841023, 'Vietnam', '1999-07-15', 'Male', 21),
(5, 'EGYPT_1', 46742, 'hoan', '134', 7836233, 'Brunei', '1998-05-03', 'Male', 23),
(5, 'EGYPT_2', 97123, 'Duc', '1387322', 191318112, 'Vietnam', '1994-05-03', 'Male', 27),
(5, 'EGYPT_2', 134, 'hu', '4123412', 980941, 'Vietnam', '1991-05-03', 'Male', 30),
(21, 'UAE_2', 42367864, 'Hoang 5', '412376521', 4238234, 'Vietnam', '1998-05-03', 'Male', 23),
(19, 'QATAR_3', NULL, 'Hien', '42378237', 94276118, 'Vietnam', '2010-11-01', 'Male', 10),
(22, 'UAE_1', 4237645, 'Hoang 18', '423874376', 432761, 'Vietnam', '1998-05-03', 'Male', 23),
(6, 'EGYPT_1', 989021, 'phuong', '489732213', 982312332, 'Vietnam', '1995-05-03', 'Female', 26),
(6, 'EGYPT_2', 874327, 'po', '641832764', 98123, 'Brazil', '1998-05-03', 'Male', 23),
(6, 'EGYPT_3', 74821, 'hai', '64724681', 8487372, 'Vietnam', '1995-05-03', 'Male', 26),
(6, 'EGYPT_1', 998792, 'dan', '6821', 9328, 'Vietnam', '1999-05-03', 'Male', 22),
(6, 'EGYPT_2', 213, 'Ngo Hai Dang', '6969', 969696, 'Vietnam', '2001-05-03', 'Male', 20),
(6, 'EGYPT_1', 90812, 'ducc', '754132765', 12481, 'Vietnam', '1995-05-03', 'Male', 26),
(6, 'EGYPT_1', 467834163, 'hien', '774217361', 947762762, 'Vietnam', '1998-05-03', 'Female', 23),
(5, 'EGYPT_1', 135, 'ronaldo', '786832', 864837, 'Portugal', '1989-05-03', 'Male', 32),
(6, 'QATAR_3', 8732, 'duc', '8735', 2317232, 'Vietnam', '1998-05-03', 'Male', 23),
(5, 'EGYPT_2', 1982712, 'ly', '87891232', 887197941, 'Vietnam', '1994-05-03', 'Female', 27),
(18, 'QATAR_3', 94377, 'tester1', '932713265', 93217321, 'Vietnam', '1998-05-03', 'Male', 23),
(6, 'Qatar_2', 49823, 'duc', '93437441', 412387, 'Vietnam', '1998-05-03', 'Male', 23),
(18, 'QATAR_3', NULL, 'Hieu', '942371291', 234326786, 'Vietnam', '2015-05-03', 'Male', 6),
(19, 'QATAR_3', 412673412, 'Hieu', '942676741', 421714712, 'Vietnam', '1994-06-03', 'Male', 26),
(6, 'EGYPT_2', 890, 'yenes', '98412', 912321, 'Vietnam', '2001-05-03', 'Female', 20),
(6, 'EGYPT_1', 74194123, 'hoang', 'VN81379', 9841847, 'Vietnam', '2000-05-05', 'Male', 21);

-- --------------------------------------------------------

--
-- Stand-in structure for view `travellers_view_tours`
-- (See below for the actual view)
--
DROP VIEW IF EXISTS `travellers_view_tours`;
CREATE TABLE `travellers_view_tours` (
`TA_ID` int(20)
,`Tour_id` varchar(20)
,`name` varchar(100)
,`country_name` varchar(80)
,`description` longtext
,`policy` text
,`startdate` date
,`enddate` date
,`startdestination` varchar(20)
,`enddestination` varchar(20)
,`childrenprice` int(10)
,`adultprice` int(10)
,`flight_name` varchar(100)
,`TA_Name` varchar(40)
,`phonenumber` varchar(30)
);

-- --------------------------------------------------------

--
-- Table structure for table `travel_agent`
--

DROP TABLE IF EXISTS `travel_agent`;
CREATE TABLE `travel_agent` (
  `TA_ID` int(20) NOT NULL,
  `Name` varchar(40) NOT NULL,
  `BirthDate` date NOT NULL,
  `Gender` varchar(10) NOT NULL,
  `Country_ID` int(20) NOT NULL,
  `Age` int(10) DEFAULT NULL,
  `PhoneNumber` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `travel_agent`
--

INSERT INTO `travel_agent` (`TA_ID`, `Name`, `BirthDate`, `Gender`, `Country_ID`, `Age`, `PhoneNumber`) VALUES
(2, 'Duc', '1990-03-02', 'Male', 245, 31, '0862351'),
(3, 'Dang', '1990-03-02', 'Male', 245, 31, '08326132'),
(4, 'Manh', '1995-04-07', 'Male', 245, 26, '0863251'),
(5, 'Hoang', '1995-04-07', 'Male', 239, 26, '0982361');

-- --------------------------------------------------------

--
-- Table structure for table `travel_agent_tourid`
--

DROP TABLE IF EXISTS `travel_agent_tourid`;
CREATE TABLE `travel_agent_tourid` (
  `NumberID` int(11) NOT NULL,
  `Tour_ID` varchar(20) NOT NULL,
  `TA_ID` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `travel_agent_tourid`
--

INSERT INTO `travel_agent_tourid` (`NumberID`, `Tour_ID`, `TA_ID`) VALUES
(1, 'EGYPT_1', 3),
(2, 'EGYPT_2', 3),
(3, 'EGYPT_3', 5),
(4, 'EGYPT_5', 5),
(5, 'LEBANON_1', 3),
(6, 'Qatar_2', 2),
(7, 'QATAR_3', 3),
(8, 'SAUDI_1', 3),
(9, 'TURKEY_1', 5),
(10, 'UAE_1', 2),
(11, 'UAE_2', 2),
(12, 'UAE_3', 5),
(13, 'UAE_4', 3);

-- --------------------------------------------------------

--
-- Structure for view `booking_section`
--
DROP TABLE IF EXISTS `booking_section`;

DROP VIEW IF EXISTS `booking_section`;
CREATE OR REPLACE ALGORITHM=UNDEFINED DEFINER=`` SQL SECURITY DEFINER VIEW `booking_section`  AS SELECT `travellers_info`.`AID` AS `aid`, `travellers_info`.`Tour_ID` AS `tour_id`, sum(`travellers_info`.`age` >= 14) AS `No_of_adults`, sum(`travellers_info`.`age` < 14) AS `No_of_children` FROM `travellers_info` GROUP BY `travellers_info`.`AID`, `travellers_info`.`Tour_ID` ;

-- --------------------------------------------------------

--
-- Structure for view `travellers_view_tours`
--
DROP TABLE IF EXISTS `travellers_view_tours`;

DROP VIEW IF EXISTS `travellers_view_tours`;
CREATE OR REPLACE ALGORITHM=UNDEFINED DEFINER=`` SQL SECURITY DEFINER VIEW `travellers_view_tours`  AS SELECT `tat`.`TA_ID` AS `TA_ID`, `tat`.`Tour_ID` AS `Tour_id`, `t`.`Name` AS `name`, `c`.`country_name` AS `country_name`, `t`.`Description` AS `description`, `t`.`Policy` AS `policy`, `t`.`StartDate` AS `startdate`, `t`.`EndDate` AS `enddate`, `t`.`StartDestination` AS `startdestination`, `t`.`EndDestination` AS `enddestination`, `t`.`ChildrenPrice` AS `childrenprice`, `t`.`AdultPrice` AS `adultprice`, `fm`.`Flight_Name` AS `flight_name`, `ta`.`Name` AS `TA_Name`, `ta`.`PhoneNumber` AS `phonenumber` FROM ((((`travel_agent_tourid` `tat` left join `tour` `t` on(`tat`.`Tour_ID` = `t`.`Tour_ID`)) left join `countries` `c` on(`t`.`Country` = `c`.`id`)) left join `flight_manager` `fm` on(`t`.`Flight_ID` = `fm`.`Flight_ID`)) left join `travel_agent` `ta` on(`tat`.`TA_ID` = `ta`.`TA_ID`)) ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `account`
--
ALTER TABLE `account`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Username` (`Username`),
  ADD UNIQUE KEY `phone_number` (`phone_number`),
  ADD UNIQUE KEY `email` (`email`);

--
-- Indexes for table `countries`
--
ALTER TABLE `countries`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `flight_manager`
--
ALTER TABLE `flight_manager`
  ADD PRIMARY KEY (`Flight_ID`),
  ADD UNIQUE KEY `Flight_Name` (`Flight_Name`);

--
-- Indexes for table `paymenttype`
--
ALTER TABLE `paymenttype`
  ADD PRIMARY KEY (`PaymentID`),
  ADD KEY `AID_2` (`AID`),
  ADD KEY `TID` (`TID`);

--
-- Indexes for table `tour`
--
ALTER TABLE `tour`
  ADD PRIMARY KEY (`Tour_ID`),
  ADD KEY `Flight_ID` (`Flight_ID`),
  ADD KEY `tour_ibfk_2` (`Country`);

--
-- Indexes for table `tour_guide`
--
ALTER TABLE `tour_guide`
  ADD PRIMARY KEY (`TG_ID`),
  ADD KEY `Country` (`Country`);

--
-- Indexes for table `tour_guide_classification`
--
ALTER TABLE `tour_guide_classification`
  ADD PRIMARY KEY (`Type_ID`);

--
-- Indexes for table `tour_guide_tourid`
--
ALTER TABLE `tour_guide_tourid`
  ADD PRIMARY KEY (`NumberID`),
  ADD KEY `TG_ID` (`TG_ID`),
  ADD KEY `Tour_ID` (`Tour_ID`);

--
-- Indexes for table `tour_guide_types`
--
ALTER TABLE `tour_guide_types`
  ADD PRIMARY KEY (`NumberID`),
  ADD KEY `tour_guide_types_ibfk_2` (`Type_ID`),
  ADD KEY `TG_ID` (`TG_ID`);

--
-- Indexes for table `travellers_info`
--
ALTER TABLE `travellers_info`
  ADD UNIQUE KEY `PassportNumber` (`PassportNumber`),
  ADD UNIQUE KEY `SSN` (`SSN`),
  ADD UNIQUE KEY `PhoneNumber` (`PhoneNumber`),
  ADD KEY `AID` (`AID`),
  ADD KEY `TID` (`Tour_ID`);

--
-- Indexes for table `travel_agent`
--
ALTER TABLE `travel_agent`
  ADD PRIMARY KEY (`TA_ID`),
  ADD UNIQUE KEY `PhoneNumber` (`PhoneNumber`),
  ADD KEY `Country_ID` (`Country_ID`);

--
-- Indexes for table `travel_agent_tourid`
--
ALTER TABLE `travel_agent_tourid`
  ADD PRIMARY KEY (`NumberID`),
  ADD KEY `TA_ID` (`TA_ID`),
  ADD KEY `ID` (`Tour_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `account`
--
ALTER TABLE `account`
  MODIFY `ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `countries`
--
ALTER TABLE `countries`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=253;

--
-- AUTO_INCREMENT for table `paymenttype`
--
ALTER TABLE `paymenttype`
  MODIFY `PaymentID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=36;

--
-- AUTO_INCREMENT for table `tour_guide_classification`
--
ALTER TABLE `tour_guide_classification`
  MODIFY `Type_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `tour_guide_types`
--
ALTER TABLE `tour_guide_types`
  MODIFY `NumberID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `travel_agent`
--
ALTER TABLE `travel_agent`
  MODIFY `TA_ID` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `paymenttype`
--
ALTER TABLE `paymenttype`
  ADD CONSTRAINT `paymenttype_ibfk_1` FOREIGN KEY (`AID`) REFERENCES `account` (`ID`) ON UPDATE CASCADE,
  ADD CONSTRAINT `paymenttype_ibfk_2` FOREIGN KEY (`TID`) REFERENCES `tour` (`Tour_ID`) ON UPDATE CASCADE;

--
-- Constraints for table `tour`
--
ALTER TABLE `tour`
  ADD CONSTRAINT `tour_ibfk_1` FOREIGN KEY (`Flight_ID`) REFERENCES `flight_manager` (`Flight_ID`) ON UPDATE CASCADE,
  ADD CONSTRAINT `tour_ibfk_2` FOREIGN KEY (`Country`) REFERENCES `countries` (`id`) ON UPDATE CASCADE;

--
-- Constraints for table `tour_guide`
--
ALTER TABLE `tour_guide`
  ADD CONSTRAINT `tour_guide_ibfk_2` FOREIGN KEY (`Country`) REFERENCES `countries` (`id`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Constraints for table `tour_guide_tourid`
--
ALTER TABLE `tour_guide_tourid`
  ADD CONSTRAINT `tour_guide_tourid_ibfk_1` FOREIGN KEY (`TG_ID`) REFERENCES `tour_guide` (`TG_ID`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `tour_guide_tourid_ibfk_2` FOREIGN KEY (`Tour_ID`) REFERENCES `travel_agent_tourid` (`NumberID`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Constraints for table `tour_guide_types`
--
ALTER TABLE `tour_guide_types`
  ADD CONSTRAINT `tour_guide_types_ibfk_2` FOREIGN KEY (`Type_ID`) REFERENCES `tour_guide_classification` (`Type_ID`) ON UPDATE CASCADE,
  ADD CONSTRAINT `tour_guide_types_ibfk_3` FOREIGN KEY (`TG_ID`) REFERENCES `tour_guide` (`TG_ID`) ON UPDATE CASCADE;

--
-- Constraints for table `travellers_info`
--
ALTER TABLE `travellers_info`
  ADD CONSTRAINT `travellers_info_ibfk_1` FOREIGN KEY (`AID`) REFERENCES `account` (`ID`) ON UPDATE CASCADE,
  ADD CONSTRAINT `travellers_info_ibfk_2` FOREIGN KEY (`Tour_ID`) REFERENCES `tour` (`Tour_ID`) ON UPDATE CASCADE;

--
-- Constraints for table `travel_agent`
--
ALTER TABLE `travel_agent`
  ADD CONSTRAINT `travel_agent_ibfk_1` FOREIGN KEY (`Country_ID`) REFERENCES `countries` (`id`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Constraints for table `travel_agent_tourid`
--
ALTER TABLE `travel_agent_tourid`
  ADD CONSTRAINT `travel_agent_tourid_ibfk_1` FOREIGN KEY (`TA_ID`) REFERENCES `travel_agent` (`TA_ID`) ON UPDATE CASCADE,
  ADD CONSTRAINT `travel_agent_tourid_ibfk_2` FOREIGN KEY (`Tour_ID`) REFERENCES `tour` (`Tour_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
