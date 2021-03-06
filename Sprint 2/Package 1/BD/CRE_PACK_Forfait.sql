--But: Cr�ation des tables du package Forfait.
--Date:05-10-2016
--Par: Simon Girard
--Modification: Kevin Ku�t�

DECLARE @Sql VARCHAR(MAX), @Schema varchar(20)
SET @Schema = 'S_forfait'

SELECT @Sql = COALESCE(@Sql,'') + 'DROP TABLE ' + @Schema + '.' + QUOTENAME(TABLE_NAME) + ';' + CHAR(13)
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_SCHEMA = @Schema
AND TABLE_TYPE = 'BASE TABLE'
Exec(@Sql)

IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = @Schema)
BEGIN
EXEC('CREATE SCHEMA ' + @Schema)
PRINT'Sch�ma cr��'
END
GO

CREATE TABLE S_forfait.tblForfait (
	noForfait INT NOT NULL IDENTITY(1,1)
	,nom VARCHAR(50) NOT NULL
	,description TEXT  NULL
	,dateSupprime DATETIME NULL
	);
PRINT 'Fin de cr�ation de la table tblForfait'
GO
CREATE TABLE S_forfait.tblService (
	noService INT NOT NULL IDENTITY(1,1)
	,nomService VARCHAR(25) NOT NULL
	,dateSupprime DATETIME NULL
	);
PRINT 'Fin de cr�ation de la table tblService'
GO
CREATE TABLE S_forfait.tblSalle (
	noSalle INT NOT NULL IDENTITY(1,1)
	,nomSalle VARCHAR(100) NOT NULL
	,prix DECIMAL(19, 2) NOT NULL
	,billet INT NOT NULL
	,billetVIP INT NOT NULL
	,photoSalle VARCHAR(500) NULL
	,dateSupprime DATETIME NULL
	,urlGoogleMap TEXT NULL
	);
PRINT 'Fin de cr�ation de la table tblSalle'
GO
CREATE TABLE S_forfait.tblServiceRequis (
	noService INT NOT NULL
	,noSousEvenement INT NOT NULL
	);
PRINT 'Fin de cr�ation de la table tblServiceRequis'
GO
CREATE TABLE S_forfait.tblServiceOffert (
	noService INT NOT NULL
	,noSalle INT NOT NULL
	);
PRINT 'Fin de cr�ation de la table tblServiceOffert'
GO
CREATE TABLE S_forfait.tblForfaitSousEvenement (
	noForfait INT  NOT NULL
	,noSousEvenement INT NOT NULL
	);
PRINT 'Fin de cr�ation de la table tblForfaitSousEvenement'
GO
CREATE TABLE S_forfait.tblCalculateur(
noSousEvenement INT NOT NULL
,billet INT NULL
,billetVIP INT NULL
,prixBillet INT NULL
,prixBilletVIP INT NULL
,souperSpectacle INT NULL
,prixSouper INT NULL
,jeunePourcent INT NULL
,adultePourcent INT NULL
,ainePourcent INT NULL
,jeuneRatio INT NULL
,adulteRatio INT NULL
,aineRatio INT NULL
,promo INT NULL
,prevente INT NULL
,customBillet1 INT NULL
,customBillet2 INT NULL
,customPrix1 INT NULL
,customPrix2 INT NULL
,customNom1 varchar(50) NULL
,customNom2 varchar(50) NULL
);

PRINT 'Fin de cr�ation des table du package Forfait'