--But : Création du Package Contrat et ses TABLEs
--Date : 29-08-2016
--Par : Pierre-Alexandre Pageau

USE master

GO

DROP database PE2_Test
PRINT 'Suppression de la base de données de test'
GO

CREATE DATABASE PE2_Test
PRINT 'Création de la base de données de test'

GO

Use PE2_Test

GO

CREATE SCHEMA S_Contrat

GO

PRINT 'Création du schéma contrat'

GO

CREATE TABLE S_Contrat.tblContrat
(
	noContrat varchar(50),
	lieu text,
	nom varchar(50),
	description text,
	commentaire text,
	dateSupprime date,
	noStatut int,
	noAgence int
)
PRINT 'Création de la TABLE contrat'

GO

CREATE TABLE S_Contrat.tblExigences
(
	noExigence int,
	nom	varchar(20),
	statut varchar(50),
	date date,
	montant decimal,
	description text,
	commentaire text,
	descriptionCourte varchar(255),
	dateSupprime date,
	noContrat int
)
PRINT 'Création de la TABLE des exigences'

GO

CREATE TABLE S_Contrat.tblStatut
(
	noStatut int,
	nomStatut varchar(20),
	description text,
	dateSupprime date
)
PRINT 'Création de la TABLE statut'

GO

CREATE TABLE S_Contrat.tblEngagement
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
	dateSupprime date,
	noContrat int
)
PRINT 'Création de la TABLE des engagements'

GO

CREATE TABLE S_Contrat.tblFichierPersonnel
(
	idFichier int,
	type text,
	chemin text,
	commentaire text,
	dateSupprime date,
	noArtiste int
)
PRINT 'Création de la TABLE des fichiers personnel'

GO

CREATE TABLE S_Contrat.tblArtiste
(
	noArtiste int,
	nom varchar(50),
	commentaire text,
	dateSupprime date
)
PRINT 'Création de la TABLE des artiste'

GO

CREATE TABLE S_Contrat.tblCateGOrieArtiste
(
	noCateGOrie int,
	nom varchar(20),
	description text,
	dateSupprime date
)
PRINT 'Création de la TABLE des catéGOries d''artiste'

GO

CREATE TABLE S_Contrat.tblAgence
(
	noAgence varchar(15),
	nom varchar(50),
	courriel varchar(255),
	dateSupprime date,
	noAdresse int
)
PRINT 'Création de la TABLE agence'

GO

CREATE TABLE S_Contrat.tblAdresse
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
PRINT 'Création de la TABLE adresse'

GO

CREATE TABLE S_Contrat.tblDiffuseur
(
	noDiffuseur int,
	nom varchar(50),
	courriel varchar(255),
	dateSupprime date,
	noAdresse int
)
PRINT 'Création de la TABLE des diffuseurs'

GO

CREATE TABLE S_Contrat.tblResponsable
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
	dateSupprime date,
	noDiffuseur int,
	noAgence int
)
PRINT 'Création de la TABLE des responsables'

GO

CREATE TABLE S_Contrat.tblRespoContrat
(
	noResponsable int,
	noContrat int
)
PRINT'Création de la TABLE d''intersection responsable-contrat'

GO

CREATE TABLE S_Contrat.tblContratArtiste
(
	noArtiste int,
	noContrat int
)
PRINT 'Création de la TABLE d''intersection contrat-artiste'

GO

CREATE TABLE S_Contrat.tblFichierOfficiel
(
	noArtiste int,
	noContrat int,
	idFichier int
)
PRINT 'Création de la TABLE d''association artiste-contrat-ficherPersonnel'

GO

CREATE TABLE S_Contrat.CatArtisteArt
(
	noCateGOrie int,
	noArtiste int
)
PRINT 'Création de la TABLE d''intersection cateGOrieArtiste-artiste'