--Ce script permet de supprimer et de recréer l'ensemble des tables contenues dans le package publicité
--Fait par: Raphaël Côté
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


PRINT 'CRÉATION DE LA TABLE APPEL D''OFFRE'
CREATE TABLE S_publicite.tblAppelOffre (
	noAppelOffre INT NOT NULL IDENTITY(1,1)
	,nom VARCHAR(50) NOT NULL
	,dateRequis DATETIME NOT NULL
	,dateEnvoi DATETIME NOT NULL
	,description TEXT
	,dateSupprime DATETIME NULL
	,noEvenement INT NOT NULL
	,noStatut INT NOT NULL
	,noMedia INT NOT NULL
	);
PRINT 'APPEL D''OFFRE RÉUSSI'

PRINT 'CRÉATION DE LA TABLE AGENCEPUBLICITE'
CREATE TABLE S_publicite.tblAgencePublicite (
	noAgencePub INT NOT NULL IDENTITY(1,1)
	,nom VARCHAR(50) NOT NULL
	,dateSupprime DATETIME NULL
	);
PRINT 'AgencePublicite RÉUSSI'

PRINT 'CRÉATION DE LA TABLE STATUT'
CREATE TABLE S_publicite.tblStatutAppelOffre (
	noStatut INT NOT NULL IDENTITY(1,1)
	,nom VARCHAR(20) NOT NULL
	,couleur CHAR(6) NOT NULL
	,description TEXT
	);
PRINT 'STATUT RÉUSSI'


CREATE TABLE S_publicite.tblSoumission (
    noSoumission INT NOT NULL IDENTITY(1,1)
	,noSoumissionAgence varchar(15)  NULL
	,prix DECIMAL(19, 2) DEFAULT(0.00)
	,statut tinyint  NULL
	,commentaire TEXT 
    ,noAgencePub INT NOT NULL
	,noAppelOffre INT NOT NULL 
    ,dateSupprime DATETIME 
	);
	
PRINT 'CRÉATION DE LA TABLE SOUMISSION'
GO
CREATE TABLE S_publicite.tblMedia (
	 noMedia INT NOT NULL IDENTITY(1,1)
	,nom  VARCHAR(20) NULL
	,description TEXT NULL
	);

GO
PRINT 'INTERSECTION ENTRE APPEL D''OFFRE ET AGENCEPUBLICITE REUSSI'