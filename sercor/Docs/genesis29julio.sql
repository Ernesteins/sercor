-- MySQL Script genesis serordb
-- Creado por Ernesto Yaselga & Cristian Bastidas
-- versi�n 1.3
drop database sercordb;
SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema sercordb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema sercordb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `sercordb` DEFAULT CHARACTER SET latin1 ;
USE `sercordb` ;

-- -----------------------------------------------------
-- Table `sercordb`.`caja`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sercordb`.`caja` (
  `ID_CAJA` INT(11) NOT NULL,
  `TIPO` SMALLINT(6) NOT NULL,
  `FECHA` DATETIME NOT NULL,
  `DESCRIPCION` CHAR(128) NOT NULL,
  `MONTO` FLOAT(12,2) NOT NULL,
  PRIMARY KEY (`ID_CAJA`),
  UNIQUE INDEX `CAJA_PK` (`ID_CAJA` ASC))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `sercordb`.`cliente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sercordb`.`cliente` (
  `ID_CLIENTE` CHAR(32) NOT NULL,
  `NOMBRE` CHAR(100) NOT NULL,
  `DIRECCION` CHAR(128) NOT NULL,
  `TELEFONO` CHAR(32) NOT NULL,
  PRIMARY KEY (`ID_CLIENTE`),
  UNIQUE INDEX `CLIENTE_PK` (`ID_CLIENTE` ASC))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `sercordb`.`cuenta`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sercordb`.`cuenta` (
  `ID_CUENTA` INT(11) NOT NULL,
  `ID_CLIENTE` CHAR(32) NULL,
  `TOTAL` FLOAT(12,2) NOT NULL,
  `SALDO` FLOAT(12,2) NOT NULL,
  `ESTADO_P` TINYINT(1) NOT NULL,
  PRIMARY KEY (`ID_CUENTA`),
  UNIQUE INDEX `CUENTA_PK` (`ID_CUENTA` ASC),
  INDEX `fk_cuenta_cliente1_idx` (`ID_CLIENTE` ASC),
  CONSTRAINT `fk_cuenta_cliente1`
    FOREIGN KEY (`ID_CLIENTE`)
    REFERENCES `sercordb`.`cliente` (`ID_CLIENTE`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `sercordb`.`detalle`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sercordb`.`detalle` (
  `ID_DETALLE` INT(11) NOT NULL,
  `SUBTOTAL` FLOAT(12,2) NOT NULL,
  PRIMARY KEY (`ID_DETALLE`),
  UNIQUE INDEX `DETALLE_PK` (`ID_DETALLE` ASC))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `sercordb`.`egresos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sercordb`.`egresos` (
  `ID_EGRESO` INT(11) NOT NULL,
  `ID_CAJA` INT(11) NULL DEFAULT NULL,
  `FECHA` DATETIME NOT NULL,
  `DESCUENTO` FLOAT(12,2) NOT NULL,
  `MONTO` FLOAT(12,2) NOT NULL,
  PRIMARY KEY (`ID_EGRESO`),
  UNIQUE INDEX `EGRESOS_PK` (`ID_EGRESO` ASC),
  INDEX `CAJA_EGRESOS_FK` (`ID_CAJA` ASC),
  CONSTRAINT `FK_EGRESOS_CAJA_EGRE_CAJA`
    FOREIGN KEY (`ID_CAJA`)
    REFERENCES `sercordb`.`caja` (`ID_CAJA`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `sercordb`.`usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sercordb`.`usuario` (
  `ID_USUARIO` INT(11) NOT NULL,
  `TIPO` SMALLINT(6) NOT NULL,
  `USUARIO` CHAR(32) NOT NULL,
  `CONTRASENA` CHAR(64) NOT NULL,
  `NOMBRE` CHAR(50) NOT NULL,
  `APELLIDO` CHAR(50) NOT NULL,
  `CEDULA` CHAR(10) NOT NULL,
  `DIRECCION` CHAR(128) NOT NULL,
  `TELEFONO` CHAR(32) NOT NULL,
  `privilegio1` SMALLINT(6) NOT NULL,
  `privilegio2` SMALLINT(6) NOT NULL,
  PRIMARY KEY (`ID_USUARIO`),
  UNIQUE INDEX `USUARIO_PK` (`ID_USUARIO` ASC))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `sercordb`.`factura`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sercordb`.`factura` (
  `ID_FACTURA` INT(11) NOT NULL,
  `ID_CLIENTE` CHAR(32) NULL DEFAULT NULL,
  `ID_USUARIO` INT(11) NULL DEFAULT NULL,
  `ID_DETALLE` INT(11) NULL,
  `ID_CUENTA` INT(11) NULL,
  `IVA` FLOAT(12,2) NOT NULL,
  `TOTAL` FLOAT(12,2) NOT NULL,
  `FECHA` DATETIME NOT NULL,
  `FACTOR_DESCUENTO` FLOAT(12,2) NOT NULL,
  `VALOR_DESCONTADO` FLOAT(12,2) NOT NULL,
  `TIPO` TINYINT(1) NOT NULL,
  `INDICE` INT(11) NULL DEFAULT '0',
  PRIMARY KEY (`ID_FACTURA`),
  UNIQUE INDEX `FACTURA_PK` (`ID_FACTURA` ASC),
  INDEX `FACT_CLIENTE_FK` (`ID_CLIENTE` ASC),
  INDEX `FACT_USUARIO_FK` (`ID_USUARIO` ASC),
  INDEX `fk_factura_detalle1_idx` (`ID_DETALLE` ASC),
  INDEX `fk_factura_cuenta1_idx` (`ID_CUENTA` ASC),
  CONSTRAINT `FK_FACTURA_FACT_CLIE_CLIENTE`
    FOREIGN KEY (`ID_CLIENTE`)
    REFERENCES `sercordb`.`cliente` (`ID_CLIENTE`),
  CONSTRAINT `FK_FACTURA_FACT_USUA_USUARIO`
    FOREIGN KEY (`ID_USUARIO`)
    REFERENCES `sercordb`.`usuario` (`ID_USUARIO`),
  CONSTRAINT `fk_factura_detalle1`
    FOREIGN KEY (`ID_DETALLE`)
    REFERENCES `sercordb`.`detalle` (`ID_DETALLE`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_factura_cuenta1`
    FOREIGN KEY (`ID_CUENTA`)
    REFERENCES `sercordb`.`cuenta` (`ID_CUENTA`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `sercordb`.`producto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sercordb`.`producto` (
  `ID_PRODUCTO` CHAR(16) NOT NULL,
  `NOMBRE` CHAR(50) NOT NULL,
  `DESCRIPCION` CHAR(128) NOT NULL,
  `CATEGORIA` CHAR(32) NOT NULL,
  `SUBCATEGORIA` CHAR(32) NOT NULL,
  `EXISTENCIA` INT(11) NOT NULL,
  `PRECIO` FLOAT(12,2) NOT NULL,
  `ESTADO` SMALLINT(6) NOT NULL,
  PRIMARY KEY (`ID_PRODUCTO`),
  UNIQUE INDEX `PRODUCTO_PK` (`ID_PRODUCTO` ASC))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `sercordb`.`producto_vendido`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sercordb`.`producto_vendido` (
  `ID_PRODUCTO` CHAR(16) NOT NULL,
  `ID_DETALLE` INT(11) NULL,
  `NOMBRE` CHAR(50) NOT NULL,
  `DESCRIPCION` CHAR(128) NOT NULL,
  `CATEGORIA` CHAR(32) NOT NULL,
  `SUBCATEGORIA` CHAR(32) NOT NULL,
  `PRECIO` FLOAT(12,2) NOT NULL,
  `CANTIDAD` INT(11) NOT NULL,
  PRIMARY KEY (`ID_PRODUCTO`),
  UNIQUE INDEX `PRODUCTO_PK` (`ID_PRODUCTO` ASC),
  INDEX `fk_producto_vendido_detalle1_idx` (`ID_DETALLE` ASC),
  CONSTRAINT `fk_producto_vendido_detalle1`
    FOREIGN KEY (`ID_DETALLE`)
    REFERENCES `sercordb`.`detalle` (`ID_DETALLE`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `sercordb`.`trabajos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sercordb`.`trabajos` (
  `ID_TRABAJO` INT(11) NOT NULL,
  `ID_FACTURA` INT(11) NULL DEFAULT NULL,
  `ID_CUENTA` INT(11) NULL DEFAULT NULL,
  `FECHA_INICIO` DATETIME NOT NULL,
  `NOMBRE_CL` CHAR(32) NOT NULL,
  `ARMAZON` CHAR(32) NOT NULL,
  `LUNA` CHAR(32) NOT NULL,
  `ESTADO` SMALLINT(6) NOT NULL,
  `FECHA_ENTREGA` DATETIME NOT NULL,
  PRIMARY KEY (`ID_TRABAJO`),
  UNIQUE INDEX `TRABAJOS_PK` (`ID_TRABAJO` ASC),
  INDEX `FACTURA_TRABAJOS_FK` (`ID_FACTURA` ASC),
  INDEX `fk_trabajos_cuenta1_idx` (`ID_CUENTA` ASC),
  CONSTRAINT `FK_TRABAJOS_FACTURA_T_FACTURA`
    FOREIGN KEY (`ID_FACTURA`)
    REFERENCES `sercordb`.`factura` (`ID_FACTURA`),
  CONSTRAINT `fk_trabajos_cuenta1`
    FOREIGN KEY (`ID_CUENTA`)
    REFERENCES `sercordb`.`cuenta` (`ID_CUENTA`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `sercordb`.`pago`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sercordb`.`pago` (
  `ID_PAGO` INT NOT NULL,
  `ID_CUENTA` INT(11) NULL,
  `FECHA_ABONO` DATETIME NOT NULL,
  `TIPO_PAGO` TINYINT(1) NOT NULL,
  `MONTO` FLOAT(12,2) NOT NULL,
  `DESCRIPCION` VARCHAR(256) NULL,
  PRIMARY KEY (`ID_PAGO`),
  INDEX `fk_pago_cuenta1_idx` (`ID_CUENTA` ASC),
  CONSTRAINT `fk_pago_cuenta1`
    FOREIGN KEY (`ID_CUENTA`)
    REFERENCES `sercordb`.`cuenta` (`ID_CUENTA`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;