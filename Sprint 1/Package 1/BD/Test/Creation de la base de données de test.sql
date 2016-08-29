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
	noContrat varchar(50),
	lieu text,
	nom varchar(50),
	description text,
	commentaire text,
	dateSupprime DateTime
)

Go

Create Table tblExigences
(
	noExigence int,
	nom	varchar(20),
	statut varchar(50),
	date date,
	montant decimal,
	description text,
	commentaire text,
	descriptionCourte varchar(255),
	dateSupprime DateTime
)

Go

Create Table tblStatut
(
	noStatut int,
	nomStatut varchar(20),
	description text,
	dateSupprime DateTime
)

Go

Create Table tblEngagement
(
	noEngagement int,
	duree varchar(6),
	lieu text,
	date date,
	heure time,
	nature varchar(50),
	commentaire text,
	description text,
	descriptionCourte varchar(255),
	dateSupprime DateTime
)

Go

Create Table tblFichierPersonnel
(
	idFichier int,
	type text,
	chemin text,
	commentaire text,
	dateSupprime DateTime
)

Go

Create Table tblArtiste
(
	noArtiste int,
	nom varchar(50),
	commentaire text,
	dateSupprime DateTime
)

Go

Create table tblCategorieArtiste
(
	noCategorie int,
	nom varchar(20),
	description text,
	dateSupprime DateTime
)

Go

Create Table tblAgence
(
	noAgence varchar(15),
	nom varchar(50),
	courriel varchar(255),
	dateSupprime DateTime
)

Go

Create Table tblAdresse
(
	noAdresse int,
	ville varchar(20),
	codepostal varchar(6),
	province varchar(2),
	pays varchar(20),
	telBureau varchar(15),
	telCellulaire varchar(15),
	extension varchar(5),
	dateSupprime DateTime
)

Go

Create Table tblDiffuseur
(
	noDiffuseur int,
	nom varchar(50),
	courriel varchar(255),
	dateSupprime DateTime
)

Go

Create Table tblResponsable
(
	noResponsable int,
	nom varchar(20),
	prenom varchar(20),
	courriel varchar(255),
	signataire varchar(70),
	date date,
	telBureau varchar(15),
	telCellulaire varchar(15),
	extension varchar(5),
	idem bit,
	dateSupprime DateTime
)