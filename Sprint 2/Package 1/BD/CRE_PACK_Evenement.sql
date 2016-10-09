--But: Création des tables du package Évènement.
--Date:05-10-2016
--Par: Simon Girard
--Modification: Kevin Kuété


USE PE2_Officiel

DECLARE @Sql VARCHAR(MAX), @Schema varchar(20)
SET @Schema = 'S_evenement'
SELECT @Sql = COALESCE(@Sql,'') + 'DROP TABLE ' + @Schema + '.' + QUOTENAME(TABLE_NAME) + '; WITH NOCHECK ' + CHAR(13)
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

CREATE TABLE S_evenement.tblActivite (
	noActivite INT NOT NULL IDENTITY(1,1)
	,nomResponsable VARCHAR(50) NOT NULL
	,etat tinyint NOT NULL
	,dateCreation DATE NOT NULL
	,tache VARCHAR(50) NOT NULL
	,detail TEXT NULL
	,dateSupprime DATETIME NULL
	,noEvenement INT NOT  NULL
	,noSousEvenement INT NOT NULL
	);
PRINT 'Fin de création de la table tblActivite'
GO
CREATE TABLE S_evenement.tblEvenement (
	noEvenement INT NOT NULL IDENTITY(1,1)
	,nom VARCHAR(100) NOT NULL
	,dateDebut DATE NOT NULL
	,datefin DATE NOT NULL
	,affiche varBinary(max) NULL
	,url TEXT NULL
	,description TEXT NULL
	,dateSupprime DATETIME NULL
	);
PRINT 'Fin de création de la table tblEvenement'
GO
CREATE TABLE S_evenement.tblCommanditaire (
	noCommanditaire INT NOT NULL IDENTITY(1,1)
	,nomCommanditaire VARCHAR(50) NOT NULL
	,nomContact VARCHAR(50) NOT NULL
	,logo varBinary(max)
	,url TEXT NULL
	,textePresentation TEXT NOT NULL
	,courrielContact VARCHAR(255) NULL
	,numTel CHAR(10) NOT NULL
	,extension VARCHAR(5) NULL
	,dateSupprime DATETIME NULL
	);
PRINT 'Fin de création de la table tblActivite'
GO
CREATE TABLE S_evenement.tblSousEvenement (
	noSousEvenement INT NOT NULL IDENTITY(1,1)
	,nom VARCHAR(50) NOT NULL
	,description TEXT  NULL
	,noEvenement INT NOT NULL
	,dateSupprime DATETIME NULL
	);
PRINT 'Fin de création de la table tblSousEvenement'
GO
CREATE TABLE S_evenement.tblDon (
	noDon INT NOT NULL IDENTITY(1,1)
	,noCommanditaire INT  NULL
	,noSousEvenement INT  NULL
	,Montant DECIMAL(19,2) NOT NULL
	,dateDon DATE NULL
	,dateSupprime DATETIME NULL
	);
PRINT 'Fin de création de la table tblDon'
GO
PRINT 'Fin de création des tables package évènement'