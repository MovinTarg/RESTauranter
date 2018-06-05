-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema Restauranter
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema Restauranter
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Restauranter` DEFAULT CHARACTER SET utf8 ;
USE `Restauranter` ;

-- -----------------------------------------------------
-- Table `Restauranter`.`reviews`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Restauranter`.`reviews` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `ReviewerName` VARCHAR(255) NULL,
  `RestaurantName` VARCHAR(255) NULL,
  `Comment` VARCHAR(255) NULL,
  `Rating` INT NULL,
  `Visited` DATETIME NULL,
  `CreatedAt` DATETIME NULL,
  `UpdatedAt` DATETIME NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
