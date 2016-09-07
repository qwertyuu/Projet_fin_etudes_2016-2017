--But: Création des vues du package Contrat.
--Date:06-09-2016
--Par: Kevin Kuété Moffo

USE PE2_Test

GO

CREATE VIEW  S_Contrat.vueSomContrat AS
SELECT con.noContrat, agen.nom,sta.nomStatut, con.lieu
FROM S_Contrat.tblAgence AS agen 
JOIN S_Contrat.tblContrat AS con 
ON con.noAgence=agen.noAgence
JOIN S_Contrat.tblStatut AS sta
ON con.noStatut=sta.noStatut
GO
PRINT 'Création de la vue reliée a l''affichage du sommaire contrat'

GO
CREATE VIEW  S_Contrat.vueSomCatArtiste AS
SELECT cat.noCategorie, cat.nom, cat.description
FROM S_Contrat.tblCategorieArtiste AS cat
GO
PRINT 'Création de la vue reliée a l''affichage du sommaire catégories d''artistes'
GO

CREATE VIEW  S_Contrat.vueSomArtiste AS
SELECT Art.noArtiste, Art.nom as 'nomAriste',Cat.nom as 'nomCat'
FROM S_Contrat.tblArtiste AS Art
JOIN S_Contrat.tblCatArtisteArt AS catArt
ON Art.noArtiste=catArt.noArtiste
JOIN S_Contrat.tblCategorieArtiste AS Cat
ON catArt.noCategorie=Cat.noCategorie
GO
PRINT 'Création de la vue pour sommaire artiste'
GO

CREATE VIEW  S_Contrat.vueSomAgence AS
SELECT agen.noAgence, agen.nom, agen.ville, agen.telBureau,agen.telCellulaire
FROM S_Contrat.tblAgence AS agen
JOIN S_Contrat.tblAdresse AS adre
ON agen.noAgence=adre.noAgence
GO
PRINT 'Création de la vue pour sommaire agence'
GO

CREATE VIEW  S_Contrat.vueSomEngagement AS
SELECT eng.noEngagement, eng.nature, eng.date, eng.heure, eng.duree, eng.lieu, con.noContrat
FROM S_Contrat.tblEngagement AS eng
JOIN S_Contrat.tblContrat AS con ON con.noContrat = eng.noContrat
GO
PRINT 'Création de la vue pour sommaire Engagement'
GO

CREATE VIEW  S_Contrat.vueSomExigence AS
SELECT exi.noExigence, exi.nom, exi.date, exi.montant, exi.descriptionCourte, exi.noStatut, con.noContrat
FROM S_Contrat.tblExigence AS exi
JOIN S_Contrat.tblContrat AS con ON con.noContrat = exi.noContrat
GO
PRINT 'Création de la vue pour sommaire Exigence'
GO