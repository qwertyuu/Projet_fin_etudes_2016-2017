--Ce script permet de supprimer et de recr�er l'ensemble des tables contenues dans le package publicit�
--Fait par: Rapha�l C�t�
--En ce: 5 Octobre 2016
USE PE2_Officiel

DECLARE @Sql VARCHAR(MAX), @Schema varchar(20)
SET @Schema = 'S_publicite'

SELECT @Sql = COALESCE(@Sql,'') + 'DROP TABLE ' + @Schema + '.' + QUOTENAME(TABLE_NAME) + ';' + CHAR(13)
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_SCHEMA = @Schema
AND TABLE_TYPE = 'BASE TABLE'
Exec(@Sql)

IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = @Schema)
BEGIN
EXEC('CREATE SCHEMA ' + @Schema)
END
GO


PRINT 'CR�ATION DE LA TABLE APPEL D''OFFRE'
CREATE TABLE S_publicite.tblAppelOffre (
	noAppelOffre INT NOT NULL IDENTITY(1,1)
	,nom VARCHAR(50) NOT NULL
	,media VARCHAR(25) NOT NULL
	,dateRequis DATETIME NOT NULL
	,dateEnvoi DATETIME NOT NULL
	,description TEXT NOT NULL
	,dateSupprime DATETIME NULL
	,noEvenement INT NOT NULL
	,noStatut INT NOT NULL
	);
PRINT 'APPEL D''OFFRE R�USSI'

PRINT 'CR�ATION DE LA TABLE AGENCEPUBLICITE'
CREATE TABLE S_publicite.tblAgencePublicite (
	noAgencePub INT NOT NULL IDENTITY(1,1)
	,nom VARCHAR(50) NOT NULL
	,dateSupprime DATETIME NULL
	);
PRINT 'AgencePublicite R�USSI'

PRINT 'CR�ATION DE LA TABLE STATUT'
CREATE TABLE S_publicite.tblStatut (
	noStatut INT NOT NULL IDENTITY(1,1)
	,nom VARCHAR(20) NOT NULL
	,couleur CHAR(6) NOT NULL
	,description TEXT
	);
PRINT 'STATUT R�USSI'

PRINT 'CR�ATION DE LA TABLE SOUMISSION'
CREATE TABLE S_publicite.tblSoumission (
	noSoumission INT NOT NULL IDENTITY(1,1)
	,nom VARCHAR(20) NOT NULL
	,prix DECIMAL(19, 2) NOT NULL
	,statut BIT NOT NULL
	,description TEXT NOT NULL
	,dateSupprime DATETIME NULL
	,noAppelOffre INT NOT NULL
	);
PRINT 'TABLE STATUT R�USSI'

PRINT 'CR�ATION DE LA TABLE INTERSECTION ENTRE APPEL D''OFFRE ET AGENCEPUBLICITE'
CREATE TABLE S_publicite.tblAppelOffreAgence (
	noAppelOffre INT NOT NULL IDENTITY(1,1)
	,noAgencePub INT NOT NULL
	,offreNoPublicite INT NOT NULL
	,noStatut INT NOT NULL
	,noSoumission INT NOT NULL
	);
GO
CREATE TABLE S_publicite.tblMedia (
	 noMedia INT NOT NULL IDENTITY(1,1)
	,nom  VARCHAR(20) NULL
	,descriptio TEXT NULL
	);

GO
CREATE TABLE S_publicite.tblMediaAppelOffre (
	 noMedia INT NOT NULL,
	 noAppelOffre INT NOT NULL	
	);
PRINT 'Fin de cr�ation de la table tblMediaAppelOffre'	
GO
PRINT 'INTERSECTION ENTRE APPEL D''OFFRE ET AGENCEPUBLICITE REUSSI'