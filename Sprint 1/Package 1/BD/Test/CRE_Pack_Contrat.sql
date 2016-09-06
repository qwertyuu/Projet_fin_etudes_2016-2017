--But : Création du Package Contrat et ses tables
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
	noContrat varchar(20) NOT NULL,
	lieu text,
	nom varchar(50) NOT NULL,
	description text,
	commentaire text,
	dateSupprime date,
	noStatut int NOT NULL,
	noAgence varchar(15) NOT NULL
)
PRINT 'Création de la table contrat'

GO

CREATE TABLE S_Contrat.tblExigence
(
	noExigence int NOT NULL identity(1,1),
	nom	varchar(20) NOT NULL,
	date date,
	montant decimal,
	description text,
	commentaire text,
	descriptionCourte varchar(255),
	dateSupprime date,
	noContrat varchar(20) NOT NULL,
	noStatut int NOT NULL
)
PRINT 'Création de la table des exigences'

GO

CREATE TABLE S_Contrat.tblStatut
(
	noStatut int NOT NULL identity(1,1),
	nomStatut varchar(20) NOT NULL,
	description text,
	couleur char(6) NOT NULL,
	dateSupprime date
)
PRINT 'Création de la table statut'

GO

CREATE TABLE S_Contrat.tblEngagement
(
	noEngagement int NOT NULL identity(1,1),
	duree varchar(6) NOT NULL,
	lieu text NOT NULL,
	date date,
	heure time,
	nature varchar(50) NOT NULL,
	commentaire text,
	description text,
	descriptionCourte varchar(255),
	dateSupprime date,
	noContrat varchar(20) NOT NULL
)
PRINT 'Création de la table des engagements'

GO

CREATE TABLE S_Contrat.tblFichierPersonnel
(
	noFichier int NOT NULL identity(1,1),
	type text NOT NULL,
	chemin text NOT NULL,
	commentaire text,
	dateSupprime date,
	noArtiste int NOT NULL
)
PRINT 'Création de la table des fichiers personnel'

GO

CREATE TABLE S_Contrat.tblArtiste
(
	noArtiste int NOT NULL identity(1,1),
	nom varchar(50) NOT NULL,
	commentaire text,
	dateSupprime date
)
PRINT 'Création de la table des artiste'

GO

CREATE TABLE S_Contrat.tblCategorieArtiste
(
	noCategorie int NOT NULL identity(1,1),
	nom varchar(20)NOT NULL,
	description text,
	dateSupprime date
)
PRINT 'Création de la table des catégories d''artiste'

GO

CREATE TABLE S_Contrat.tblAgence
(
	noAgence varchar(15) NOT NULL,
	nom varchar(50) NOT NULL,
	courriel varchar(255) NOT NULL,
	dateSupprime date,
	noAdresse int NOT NULL
)
PRINT 'Création de la table agence'

GO

CREATE TABLE S_Contrat.tblAdresse
(
	noAdresse int NOT NULL identity(1,1),
	adresse text NULL,
	ville varchar(30) NOT NULL,
	codepostal char(6) NOT NULL,
	province char(2) NOT NULL,
	pays varchar(20) NOT NULL,
	telBureau char(10),
	telCellulaire char(10),
	extension varchar(5),
	dateSupprime date
)
PRINT 'Création de la table adresse'

GO

CREATE TABLE S_Contrat.tblDiffuseur
(
	noDiffuseur int NOT NULL identity(1,1),
	nom varchar(50) NOT NULL,
	courriel varchar(255) NOT NULL,
	dateSupprime date,
	noAdresse int NOT NULL
)
PRINT 'Création de la table des diffuseurs'

GO

CREATE TABLE S_Contrat.tblResponsable
(
	noResponsable int NOT NULL identity(1,1),
	nom varchar(20) NOT NULL,
	prenom varchar(20) NOT NULL,
	courriel varchar(255) NOT NULL,
	signataire varchar(70),
	dateSignature date,
	telBureau char(10),
	telCellulaire char(10),
	extension varchar(5),
	idem bit NOT NULL,
	dateSupprime date,
	noDiffuseur int  NULL,
	noAgence varchar(15) NULL
)
PRINT 'Création de la table des responsables'

GO

CREATE TABLE S_Contrat.tblRespoContrat
(
	noResponsable int NOT NULL,
	noContrat varchar(20) NOT NULL
)
PRINT'Création de la table d''intersection responsable-contrat'

GO

CREATE TABLE S_Contrat.tblContratArtiste
(
	noArtiste int NOT NULL,
	noContrat varchar(20) NOT NULL
)
PRINT 'Création de la table d''intersection contrat-artiste'

GO

CREATE TABLE S_Contrat.tblFichierOfficiel
(
	noArtiste int NOT NULL,
	noContrat varchar(20) NOT NULL,
	noFichier int NOT NULL
)
PRINT 'Création de la table d''association artiste-contrat-ficherPersonnel'

GO

CREATE TABLE S_Contrat.tblCatArtisteArt
(
	noCategorie int NOT NULL,
	noArtiste int NOT NULL
)
PRINT 'Création de la table d''intersection categorieArtiste-artiste'