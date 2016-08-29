--But : Création du Package Contrat et ses tables
--Date : 29-08-2016
--Par : Pierre-Alexandre Pageau

Use master

Go

Drop database PE2_Test
Print 'Suppression de la base de données de test'
Go

Create database PE2_Test
Print 'Création de la base de données de test'

Go

Use PE2_Test

Go

Create Schema S_Contrat

Go

Print 'Création du schéma contrat'

Go

Create Table S_Contrat.tblContrat
(
	noContrat varchar(50),
	lieu text,
	nom varchar(50),
	description text,
	commentaire text,
	dateSupprime date
)
Print 'Création de la table contrat'

Go

Create Table S_Contrat.tblExigences
(
	noExigence int,
	nom	varchar(20),
	statut varchar(50),
	date date,
	montant decimal,
	description text,
	commentaire text,
	descriptionCourte varchar(255),
	dateSupprime date
)
Print 'Création de la table des exigences'

Go

Create Table S_Contrat.tblStatut
(
	noStatut int,
	nomStatut varchar(20),
	description text,
	dateSupprime date
)
Print 'Création de la table statut'

Go

Create Table S_Contrat.tblEngagement
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
	dateSupprime date
)
Print 'Création de la table des engagements'

Go

Create Table S_Contrat.tblFichierPersonnel
(
	idFichier int,
	type text,
	chemin text,
	commentaire text,
	dateSupprime date
)
Print 'Création de la table des fichiers personnel'

Go

Create Table S_Contrat.tblArtiste
(
	noArtiste int,
	nom varchar(50),
	commentaire text,
	dateSupprime date
)
Print 'Création de la table des artiste'

Go

Create table S_Contrat.tblCategorieArtiste
(
	noCategorie int,
	nom varchar(20),
	description text,
	dateSupprime date
)
Print 'Création de la table des catégories d''artiste'

Go

Create Table S_Contrat.tblAgence
(
	noAgence varchar(15),
	nom varchar(50),
	courriel varchar(255),
	dateSupprime date
)
Print 'Création de la table agence'

Go

Create Table S_Contrat.tblAdresse
(
	noAdresse int,
	ville varchar(20),
	codepostal varchar(6),
	province varchar(2),
	pays varchar(20),
	telBureau varchar(15),
	telCellulaire varchar(15),
	extension varchar(5),
	dateSupprime date
)
Print 'Création de la table adresse'

Go

Create Table S_Contrat.tblDiffuseur
(
	noDiffuseur int,
	nom varchar(50),
	courriel varchar(255),
	dateSupprime date
)
Print 'Création de la table des diffuseurs'

Go

Create Table S_Contrat.tblResponsable
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
	dateSupprime date
)
Print 'Création de la table des responsables'

Go

Create Table S_Contrat.tblRespoContrat
(
	noResponsable int,
	noContrat int
)
Print'Création de la table d''intersection responsable-contrat'

Go

Create Table S_Contrat.tblContratArtiste
(
	noArtiste int,
	noContrat int
)
Print 'Création de la table d''intersection contrat-artiste'

Go

Create Table S_Contrat.tblFichierOfficiel
(
	noArtiste int,
	noContrat int,
	idFichier int
)
Print 'Création de la table d''association artiste-contrat-ficherPersonnel'

Go

Create Table S_Contrat.CatArtisteArt
(
	noCategorie int,
	noArtiste int
)
Print 'Création de la table d''intersection categorieArtiste-artiste'