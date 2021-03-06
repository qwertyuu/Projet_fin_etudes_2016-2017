--But: Cr�ation des tables du package �v�nement.
--Date:05-10-2016
--Par: Simon Girard
--Modification: Kevin Ku�t�


USE PE2_Officiel

DECLARE @Sql VARCHAR(MAX), @Schema varchar(20)
SET @Schema = 'S_evenement'
EXEC('CREATE SCHEMA ' + @Schema)
PRINT'Sch�ma cr��'
GO

CREATE TABLE S_evenement.tblActivite (
	noActivite INT NOT NULL IDENTITY(1,1)
	,nomResponsable VARCHAR(50) NOT NULL
	,etat tinyint NOT NULL
	,dateCreation DATE NOT NULL
	,tache VARCHAR(50) NOT NULL
	,detail TEXT NULL
	,dateSupprime DATETIME NULL
	,noEvenement INT
	,noSousEvenement INT
	,noUtilisateur BIGINT
	);
PRINT 'Fin de cr�ation de la table tblActivite'
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
PRINT 'Fin de cr�ation de la table tblEvenement'
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
PRINT 'Fin de cr�ation de la table tblActivite'
GO
CREATE TABLE S_evenement.tblSousEvenement (
	noSousEvenement INT NOT NULL IDENTITY(1,1)
	,nom VARCHAR(50) NOT NULL
	,description TEXT  NULL
	,noEvenement INT NOT NULL
	,noSalle INT NULL
	,dateSupprime DATETIME NULL
	);
PRINT 'Fin de cr�ation de la table tblSousEvenement'
GO
CREATE TABLE S_evenement.tblDon (
	noDon INT NOT NULL IDENTITY(1,1)
	,noCommanditaire INT  NULL
	,noSousEvenement INT  NULL
	,montant DECIMAL(19,2) NOT NULL
	,dateDon DATE NULL
	,dateSupprime DATETIME NULL
	);
PRINT 'Fin de cr�ation de la table tblDon'
GO
PRINT 'Fin de cr�ation des tables package �v�nement'