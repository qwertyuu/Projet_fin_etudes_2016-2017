

GO
CREATE SCHEMA S_evenement
GO

CREATE TABLE S_evenement.tblActivite (
	noActivite INT (11) NOT NULL
	,nomResponsable VARCHAR(50) NOT NULL
	,etat tinyint(1) NOT NULL
	,dateCreation DATE NOT NULL
	,tache VARCHAR(50) NOT NULL
	,detail TEXT
	,dateSupprime DATETIME NULL
	,noEvenement INT (11) NOT NULL
	,noSousEvenement INT (11) NOT NULL
	);

CREATE TABLE S_evenement.tblEvenement (
	noEvenement INT (11)
	,nom VARCHAR(100) NOT NULL
	,dateDebut DATE NOT NULL
	,datefin DATE NOT NULL
	,affiche blob
	,url TEXT
	,description TEXT
	,dateSupprime DATETIME NULL
	);

CREATE TABLE S_evenement.tblCommanditaire (
	noCommanditaire INT (11)
	,nomCommanditaire VARCHAR(50) NOT NULL
	,nomContact VARCHAR(50) NOT NULL
	,logo blob
	,url TEXT
	,textePresentation TEXT NOT NULL
	,courrielContact VARCHAR(255)
	,numTel CHAR(10) NOT NULL
	,extension VARCHAR(5)
	,dateSupprimee DATETIME NULL
	);

CREATE TABLE S_evenement.tblSousEvenement (
	noSousEvenement INT (11)
	,nom VARCHAR(50) NOT NULL
	,description TEXT NOT NULL
	,noEvenement INT (11) NOT NULL
	,dateSupprime DATETIME NULL
	);

CREATE TABLE S_evenement.tblDon (
	noDon INT (11) NOT NULL
	,noCommanditaire INT (11) NOT NULL
	,noSousEvenement INT (11) NOT NULL
	,Montant DECIMAL(19, 0) NOT NULL
	,dateDon DATE NOT NULL
	,dateSupprime DATETIME NULL
	);
