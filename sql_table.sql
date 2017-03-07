-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`game_table`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`game_table` (
  `ID` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `Name` VARCHAR(45) NOT NULL COMMENT '',
  `Wins` INT NOT NULL COMMENT '',
  `Losses` INT NOT NULL COMMENT '',
  PRIMARY KEY (`ID`)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`game`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`game` (
  `ID` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `Name` VARCHAR(45) NULL DEFAULT NULL COMMENT '',
  `Wins` INT NULL DEFAULT NULL COMMENT '',
  `Losses` INT NULL DEFAULT NULL COMMENT '',
  `HighScore` INT NULL DEFAULT NULL COMMENT '',
  PRIMARY KEY (`ID`)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`table`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`table` (
  `ID` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `Name` VARCHAR(45) NULL DEFAULT NULL COMMENT '',
  `Wins` INT NULL DEFAULT NULL COMMENT '',
  `Losses` INT NULL DEFAULT NULL COMMENT '',
  `HighScore` INT NULL DEFAULT NULL COMMENT '',
  PRIMARY KEY (`ID`)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`statictics`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`statictics` (
  `ID` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `Name` VARCHAR(45) NULL DEFAULT NULL COMMENT '',
  `Wins` INT NULL DEFAULT NULL COMMENT '',
  `Losses` INT NULL DEFAULT NULL COMMENT '',
  `HighScore` INT NULL DEFAULT NULL COMMENT '',
  PRIMARY KEY (`ID`)  COMMENT '')
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;