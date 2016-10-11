--Ce script permet de supprimer et de (re)créer l'ensemble des tables contenues dans le package personnel
--Fait par: Raphaël Côté
--En ce: 5 Octobre 2016
USE PE2_Officiel

DECLARE @Sql VARCHAR(MAX), @Schema varchar(20)
SET @Schema = 'S_personnel'

SELECT @Sql = COALESCE(@Sql,'') + 'DROP TABLE ' + @Schema + '.' + QUOTENAME(TABLE_NAME) + ';' + CHAR(13)
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_SCHEMA = @Schema
AND TABLE_TYPE = 'BASE TABLE'
Exec(@Sql)

IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = @Schema)
BEGIN
EXEC('CREATE SCHEMA ' + @Schema)
END

PRINT 'Création de la table d''utilisateur'

CREATE TABLE S_personnel.tblUtilisateur
(
	IdUser  varchar(30)NOT NULL,
	motPasse char(24) NOT NULL
)
PRINT 'Fin de la création de la table d''utilisateur'

GO
PRINT 'Création de la table memo'
CREATE TABLE S_personnel.tblMemo (
	noMemo INT NOT NULL IDENTITY(1,1) 
	,info TEXT NOT NULL
	,statut BIT NOT NULL DEFAULT(0)
	,dateEnvoi DATETIME NOT NULL DEFAULT(GETDATE())
	,dateSupprime DATETIME  NULL
	,expediteur VARCHAR(30) NOT NULL
	,destinataire VARCHAR(30) NOT NULL
	);
PRINT 'Fin de la création de la table memo'
 