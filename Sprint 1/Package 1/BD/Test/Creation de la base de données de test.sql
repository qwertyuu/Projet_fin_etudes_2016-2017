Use master

Go

Drop database PE2_Test

Go

Create database PE2_Test

Go

Use PE2_Test

Go

Create Table tblContrat
(
	noContrat varchar(50) NOT NULL,
	lieu text,
	nom varchar(50) NOT NULL,
	description text,
	commentaire text
)

Go

Create Table tblExigences
(
	noExigence int NOT NULL,
	nom	varchar(20) NOT NULL,
	statut varchar(50) NOT NULL,
	date date,
	montant decimal,
	description text,
	commentaire text,
	descriptionCourte varchar(255)
)

Go

Create Table tblStatut
(
	noStatut int NOT NULL,
	nomStatut varchar(20) NOT NULL,
	description text
)

Go

Create Table tblEngagement
(
	noEngagement int NOT NULL,
	duree varchar(6),
	lieu text,
	date date,
	heure time,
	nature varchar(50),
	commentaire text,
	description text,
	descriptionCourte varchar(255)
)

Go

Create Table tblFichierPersonnel
(
	idFichier int NOT NULL,
	type text,
	chemin text NOT NULL,
	commentaire text
)

Go

Create Table tblArtiste
(
	noArtiste int NOT NULL,
	nom varchar(50) NOT NULL,
	commentaire text
)

Go

Create table tblCategorieArtiste
(
	noCategorie int NOT NULL,
	nom varchar(20) NOT NULL,
	description text
)

Go

Create Table tblAgence
(
	noAgence varchar(15) NOT NULL,
	nom varchar(50) NOT NULL,
	courriel varchar(255)
)

Go

Create Table tblAdresse
(
	noAdresse int NOT NULL,
	ville varchar(20) NOT NULL,
	codepostal varchar(6) NOT NULL,
	province varchar(2) NOT NULL,
	pays varchar(20) NOT NULL,
	telBureau varchar(15) NOT NULL,
	telCellulaire varchar(15) NOT NULL,
	extension varchar(5) NOT NULL
)

Go

Create Table tblDiffuseur
(
	noDiffuseur int NOT NULL,
	nom varchar(50) NOT NULL,
	courriel varchar(255) NOT NULL
)

Go

Create Table tblResponsable
(
	noResponsable int NOT NULL,
	nom varchar(20) NOT NULL,
	prenom varchar(20) NOT NULL,
	courriel varchar(255) NOT NULL,
	signataire varchar(70) NOT NULL,
	date date,
	telBureau varchar(15) NOT NULL,
	telCellulaire varchar(15) NOT NULL,
	extension varchar(5) NOT NULL,
	idem bit NOT NULL
)