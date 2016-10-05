CREATE SCHEMA S_personnel
GO

CREATE TABLE S_personnel.tblUtilisateur
(
	IdUser  varchar(30)NOT NULL,
	motPasse char(24) NOT NULL
)


CREATE TABLE S_Personnel.tblMemo (
	noMemo INT (11)
	,info TEXT
	,statut TINYINT (1)
	,dateSupprime DATE NOT NULL
	,expediteur VARCHAR(30) NOT NULL
	,destinataire VARCHAR(30) NOT NULL
	);

PRINT 'Création de la table d''utilisateur'

 ALTER TABLE S_personnel.tblUtilisateur ADD
 CONSTRAINT IDUSER_PK
 PRIMARY Key(IdUser) 
 PRINT 'FIN des contraintes PK  de la table tblUtilisateur'
 GO
 
 INSERT INTO S_Personnel.tblUtilisateur(IdUser,motPasse)VALUES('Equipe2','PvCmx48Mqm5pqGzWe6nKEg==');