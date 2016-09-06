--But: Cr�ation des vues du package Contrat.
--Date:06-09-2016
--Par: Kevin Ku�t� Moffo

USE PE2_Test

GO

CREATE VIEW  S_Contrat.vueSomContrat AS
SELECT con.noContrat, agen.nom,sta.nomStatut, con.lieu
FROM S_Contrat.tblAgence AS agen 
JOIN S_Contrat.tblContrat AS con 
ON con.noAgence=agen.noAgence
JOIN S_Contrat.tblStatut AS sta
ON con.noStatut=sta.noStatut
PRINT 'Cr�ation de la vue reli�e a l''affichage du sommaire contrat'
GO

CREATE VIEW  S_Contrat.vueSomCatArtiste AS
SELECT cat.nom, cat.description
FROM S_Contrat.tblCategorieArtiste AS cat
PRINT 'Cr�ation de la vue reli�e a l''affichage du sommaire cat�gories d''artistes'
GO

CREATE VIEW  S_Contrat.vueSomArtiste AS
SELECT Art.nom as 'nomAriste',Cat.nom as 'nomCat'
FROM S_Contrat.tblArtiste AS Art
JOIN S_Contrat.tblCatArtisteArt AS catArt
ON Art.noArtiste=catArt.noArtiste
JOIN S_Contrat.tblCategorieArtiste AS Cat
ON catArt.noCategorie=Cat.noCategorie
PRINT 'Cr�ation de la vue pour sommaire artiste'
GO

CREATE VIEW  S_Contrat.vueSomAgence AS
SELECT agen.nom, agen.ville, agen.telBureau,agen.telCellulaire
FROM S_Contrat.tblAgence AS agen
PRINT 'Cr�ation de la vue pour sommaire agence'



