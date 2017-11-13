/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50714
Source Host           : localhost:3306
Source Database       : hackton

Target Server Type    : MYSQL
Target Server Version : 50714
File Encoding         : 65001

Date: 2017-11-12 23:24:56
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for cadastro
-- ----------------------------
DROP TABLE IF EXISTS `cadastro`;
CREATE TABLE `cadastro` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome1` varchar(255) NOT NULL,
  `ra1` varchar(255) NOT NULL,
  `nome2` varchar(255) NOT NULL,
  `ra2` varchar(255) NOT NULL,
  `nome3` varchar(255) NOT NULL,
  `ra3` varchar(255) NOT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of cadastro
-- ----------------------------
INSERT INTO `cadastro` VALUES ('1', 'Pedro', '1111111', 'Joao', '1111111', 'Maria', '1111111');
INSERT INTO `cadastro` VALUES ('2', 'Mario', '1111111', 'Luis', '111111', 'Antonio', '111111');
INSERT INTO `cadastro` VALUES ('3', 'Joao', '1111111', 'Maria', '1111111', 'Carla', '1111111');
INSERT INTO `cadastro` VALUES ('4', 'Carla', '1111111', 'Maria', '1111111', 'Carol', '1111111');
INSERT INTO `cadastro` VALUES ('5', 'Pedro', '1111111', 'Joao', '1111111', 'Maria', '1111111');

-- ----------------------------
-- Table structure for hash
-- ----------------------------
DROP TABLE IF EXISTS `hash`;
CREATE TABLE `hash` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `hashid` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of hash
-- ----------------------------
INSERT INTO `hash` VALUES ('1', '00100110');
INSERT INTO `hash` VALUES ('2', '00200120');
INSERT INTO `hash` VALUES ('3', '00300131');
INSERT INTO `hash` VALUES ('4', '00400240');
INSERT INTO `hash` VALUES ('5', '00500250');

-- ----------------------------
-- Table structure for pontosf1
-- ----------------------------
DROP TABLE IF EXISTS `pontosf1`;
CREATE TABLE `pontosf1` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `hash` varchar(255) DEFAULT NULL,
  `p1` varchar(255) DEFAULT NULL,
  `p2` varchar(255) DEFAULT NULL,
  `p3` varchar(255) DEFAULT NULL,
  `p4` varchar(255) DEFAULT NULL,
  `p5` varchar(255) DEFAULT NULL,
  `p6` varchar(255) DEFAULT NULL,
  `p7` varchar(255) DEFAULT NULL,
  `p8` varchar(255) DEFAULT NULL,
  `p9` varchar(255) DEFAULT NULL,
  `p10` varchar(255) DEFAULT NULL,
  `p11` varchar(255) DEFAULT NULL,
  `p12` varchar(255) DEFAULT NULL,
  `p13` varchar(255) DEFAULT NULL,
  `p14` varchar(255) DEFAULT NULL,
  `p15` varchar(255) DEFAULT NULL,
  `p16` varchar(255) DEFAULT NULL,
  `p17` varchar(255) DEFAULT NULL,
  `p18` varchar(255) DEFAULT NULL,
  `p19` varchar(255) DEFAULT NULL,
  `p20` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of pontosf1
-- ----------------------------
INSERT INTO `pontosf1` VALUES ('1', '00300131', '0', '1', '0', '0', '0', '0', '0', '1', '0', '0', '0', '1', '0', '0', '0', '0', '0', '1', '0', '0');
INSERT INTO `pontosf1` VALUES ('2', '00300131', '0', '1', '0', '0', '0', '0', '0', '1', '0', '0', '0', '1', '0', '0', '0', '0', '0', '1', '0', '0');
INSERT INTO `pontosf1` VALUES ('3', '00300131', '0', '1', '0', '0', '0', '0', '0', '1', '0', '0', '0', '1', '0', '0', '0', '0', '0', '1', '0', '0');

-- ----------------------------
-- Table structure for pontosf2
-- ----------------------------
DROP TABLE IF EXISTS `pontosf2`;
CREATE TABLE `pontosf2` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `hash` varchar(255) DEFAULT NULL,
  `p1` varchar(255) DEFAULT NULL,
  `p2` varchar(255) DEFAULT NULL,
  `p3` varchar(255) DEFAULT NULL,
  `p4` varchar(255) DEFAULT NULL,
  `p5` varchar(255) DEFAULT NULL,
  `p6` varchar(255) DEFAULT NULL,
  `p7` varchar(255) DEFAULT NULL,
  `p8` varchar(255) DEFAULT NULL,
  `p9` varchar(255) DEFAULT NULL,
  `p10` varchar(255) DEFAULT NULL,
  `p11` varchar(255) DEFAULT NULL,
  `p12` varchar(255) DEFAULT NULL,
  `p13` varchar(255) DEFAULT NULL,
  `p14` varchar(255) DEFAULT NULL,
  `p15` varchar(255) DEFAULT NULL,
  `p16` varchar(255) DEFAULT NULL,
  `p17` varchar(255) DEFAULT NULL,
  `p18` varchar(255) DEFAULT NULL,
  `p19` varchar(255) DEFAULT NULL,
  `p20` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of pontosf2
-- ----------------------------
INSERT INTO `pontosf2` VALUES ('1', '00300131', '0', '5', '0', '0', '0', '0', '0', '5', '0', '0', '0', '5', '0', '0', '0', '0', '0', '5', '0', '5');
INSERT INTO `pontosf2` VALUES ('2', '00300131', '0', '5', '0', '0', '0', '0', '0', '5', '0', '3', '0', '3', '3', '0', '1', '1', '1', '0', '0', '1');
INSERT INTO `pontosf2` VALUES ('3', '00300131', '0', '0', '0', '0', '0', '5', '0', '5', '0', '0', '0', '5', '0', '0', '0', '0', '0', '5', '0', '0');

-- ----------------------------
-- Table structure for respostasf1
-- ----------------------------
DROP TABLE IF EXISTS `respostasf1`;
CREATE TABLE `respostasf1` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `hash` varchar(255) DEFAULT NULL,
  `p1` varchar(255) DEFAULT NULL,
  `p2` varchar(255) DEFAULT NULL,
  `p3` varchar(255) DEFAULT NULL,
  `p4` varchar(255) DEFAULT NULL,
  `p5` varchar(255) DEFAULT NULL,
  `p6` varchar(255) DEFAULT NULL,
  `p7` varchar(255) DEFAULT NULL,
  `p8` varchar(255) DEFAULT NULL,
  `p9` varchar(255) DEFAULT NULL,
  `p10` varchar(255) DEFAULT NULL,
  `p11` varchar(255) DEFAULT NULL,
  `p12` varchar(255) DEFAULT NULL,
  `p13` varchar(255) DEFAULT NULL,
  `p14` varchar(255) DEFAULT NULL,
  `p15` varchar(255) DEFAULT NULL,
  `p16` varchar(255) DEFAULT NULL,
  `p17` varchar(255) DEFAULT NULL,
  `p18` varchar(255) DEFAULT NULL,
  `p19` varchar(255) DEFAULT NULL,
  `p20` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of respostasf1
-- ----------------------------

-- ----------------------------
-- Table structure for respostasf2
-- ----------------------------
DROP TABLE IF EXISTS `respostasf2`;
CREATE TABLE `respostasf2` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `hash` varchar(255) DEFAULT NULL,
  `p1` varchar(255) DEFAULT NULL,
  `p2` varchar(255) DEFAULT NULL,
  `p3` varchar(255) DEFAULT NULL,
  `p4` varchar(255) DEFAULT NULL,
  `p5` varchar(255) DEFAULT NULL,
  `p6` varchar(255) DEFAULT NULL,
  `p7` varchar(255) DEFAULT NULL,
  `p8` varchar(255) DEFAULT NULL,
  `p9` varchar(255) DEFAULT NULL,
  `p10` varchar(255) DEFAULT NULL,
  `p11` varchar(255) DEFAULT NULL,
  `p12` varchar(255) DEFAULT NULL,
  `p13` varchar(255) DEFAULT NULL,
  `p14` varchar(255) DEFAULT NULL,
  `p15` varchar(255) DEFAULT NULL,
  `p16` varchar(255) DEFAULT NULL,
  `p17` varchar(255) DEFAULT NULL,
  `p18` varchar(255) DEFAULT NULL,
  `p19` varchar(255) DEFAULT NULL,
  `p20` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of respostasf2
-- ----------------------------
