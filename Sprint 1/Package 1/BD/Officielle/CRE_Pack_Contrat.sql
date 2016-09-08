--But : Création du Package Contrat et ses table (Base de données officielle)
--Date : 30-08-2016
--Par : Pierre-Alexandre Pageau

USE master

GO

CREATE DATABASE PE2_Officielle
PRINT 'Création de la base de données officielle'

GO

Use PE2_Officielle

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
PRINT 'Création de la table contrat'

GO

CREATE TABLE S_Contrat.tblExigence
(
	noExigence int,
	nom	varchar(20),
	date date,
	montant decimal,
	description text,
	commentaire text,
	descriptionCourte varchar(255),
	dateSupprime date,
	noContrat varchar(50),
	noStatut int
)
PRINT 'Création de la table des exigences'

GO

CREATE TABLE S_Contrat.tblStatut
(
	noStatut int,
	nomStatut varchar(20),
	description text,
	couleur varchar(6),
	dateSupprime date
)
PRINT 'Création de la table statut'

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
	noContrat varchar(50)
)
PRINT 'Création de la table des engagements'

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
PRINT 'Création de la table des fichiers personnel'

GO

CREATE TABLE S_Contrat.tblArtiste
(
	noArtiste int,
	nom varchar(50),
	commentaire text,
	dateSupprime date
)
PRINT 'Création de la table des artiste'

GO

CREATE TABLE S_Contrat.tblCategorieArtiste
(
	noCategorie int,
	nom varchar(20),
	description text,
	dateSupprime date
)
PRINT 'Création de la table des catégories d''artiste'

GO

CREATE TABLE S_Contrat.tblAgence
(
	noAgence varchar(15),
	nom varchar(50),
	courriel varchar(255),
	dateSupprime date,
	noAdresse int
)
PRINT 'Création de la table agence'

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
PRINT 'Création de la table adresse'

GO

CREATE TABLE S_Contrat.tblDiffuseur
(
	noDiffuseur int,
	nom varchar(50),
	courriel varchar(255),
	dateSupprime date,
	noAdresse int
)
PRINT 'Création de la table des diffuseurs'

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
PRINT 'Création de la table des responsables'

GO

CREATE TABLE S_Contrat.tblRespoContrat
(
	noResponsable int,
	noContrat varchar(50)
)
PRINT'Création de la table d''intersection responsable-contrat'

GO

CREATE TABLE S_Contrat.tblContratArtiste
(
	noArtiste int,
	noContrat varchar(50)
)
PRINT 'Création de la table d''intersection contrat-artiste'

GO

CREATE TABLE S_Contrat.tblFichierOfficiel
(
	noArtiste int,
	noContrat varchar(50),
	idFichier int
)
PRINT 'Création de la table d''association artiste-contrat-ficherPersonnel'

GO

CREATE TABLE S_Contrat.tblCatArtisteArt
(
	noCategorie varchar(50),
	noArtiste int
)
PRINT 'Création de la table d''intersection categorieArtiste-artiste'