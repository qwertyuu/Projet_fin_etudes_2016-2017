--But: Création des tables du package Forfait.
--Date:05-10-2016
--Par: Simon Girard
--Modification: Kevin Kuété

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
PRINT'Schéma créé'
END
GO

CREATE TABLE S_forfait.tblForfait (
	noForfait INT NOT NULL
	,nom VARCHAR(50) NOT NULL
	,description TEXT  NULL
	,dateSupprime DATETIME NULL
	);
PRINT 'Fin de création de la table tblForfait'
GO
CREATE TABLE S_forfait.tblService (
	noService INT NOT NULL
	,nomService VARCHAR(25) NOT NULL
	,dateSupprime DATETIME NULL
	);
PRINT 'Fin de création de la table tblService'
GO
CREATE TABLE S_forfait.tblSalle (
	noSalle INT NOT NULL
	,nomSalle VARCHAR(100) NOT NULL
	,prix DECIMAL(19, 2) NOT NULL
	,billet INT NOT NULL
	,billetVIP INT NOT NULL
	,photoSalle varBinary(max)
	,dateSupprime DATETIME NULL
	,urlGoogleMap TEXT NULL
	);
PRINT 'Fin de création de la table tblSalle'
GO
CREATE TABLE S_forfait.tblServiceRequis (
	noService INT NOT NULL
	,noSousEvenement INT NOT NULL
	);
PRINT 'Fin de création de la table tblServiceRequis'
GO
CREATE TABLE S_forfait.tblServiceOffert (
	noService INT NOT NULL
	,noSalle INT NOT NULL
	);
PRINT 'Fin de création de la table tblServiceOffert'
GO
CREATE TABLE S_forfait.tblForfaitSousEvenement (
	noForfait INT  NOT NULL
	,noSousEvenement INT NOT NULL
	);
PRINT 'Fin de création de la table tblForfaitSousEvenement'
GO

PRINT 'Fin de création des table du package Forfait'