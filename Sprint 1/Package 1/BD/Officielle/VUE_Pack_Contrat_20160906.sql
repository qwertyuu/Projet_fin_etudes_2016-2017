--But: Création des vues du package Contrat.
--Date:06-09-2016
--Par: Kevin Kuété Moffo

USE PE2_Officiel

GO

CREATE VIEW  S_Contrat.vueSomContrat WITH SCHEMABINDING AS
SELECT con.noContrat, agen.nom,sta.nomStatut, con.lieu
FROM S_Contrat.tblContrat AS con  
LEFT JOIN S_Contrat.tblAgence AS agen 
ON con.noAgence=agen.noAgence
LEFT JOIN S_Contrat.tblStatut AS sta
ON con.noStatut=sta.noStatut
WHERE con.dateSupprime IS NULL
GO
PRINT 'Création de la vue reliée a l''affichage du sommaire contrat'

GO
CREATE VIEW  S_Contrat.vueSomCatArtiste WITH SCHEMABINDING AS
SELECT cat.noCategorie, cat.nom, cat.description
FROM S_Contrat.tblCategorieArtiste AS cat
WHERE cat.dateSupprime IS NULL
GO
PRINT 'Création de la vue reliée a l''affichage du sommaire catégories d''artistes'
GO

CREATE VIEW  S_Contrat.vueSomArtiste WITH SCHEMABINDING AS
SELECT Art.noArtiste, Art.nom as 'nomAriste',Cat.nom as 'nomCat'
FROM S_Contrat.tblArtiste AS Art
LEFT JOIN S_Contrat.tblCatArtisteArt AS catArt
ON Art.noArtiste=catArt.noArtiste
LEFT JOIN S_Contrat.tblCategorieArtiste AS Cat
ON catArt.noCategorie=Cat.noCategorie
WHERE Art.dateSupprime IS NULL
GO
PRINT 'Création de la vue pour sommaire artiste'
GO

CREATE VIEW  S_Contrat.vueSomAgence WITH SCHEMABINDING AS
SELECT agen.noAgence, agen.nom, adre.ville, adre.telBureau, adre.telCellulaire
FROM S_Contrat.tblAgence AS agen
LEFT JOIN S_Contrat.tblAdresse AS adre
ON agen.noAdresse=adre.noAdresse
WHERE adre.dateSupprime IS NULL
AND agen.dateSupprime IS NULL
GO
PRINT 'Création de la vue pour sommaire agence'
GO

CREATE VIEW  S_Contrat.vueSomEngagement WITH SCHEMABINDING AS
SELECT eng.noEngagement, eng.nature, eng.date, eng.heure, eng.duree, eng.lieu, con.noContrat
FROM S_Contrat.tblEngagement AS eng
LEFT JOIN S_Contrat.tblContrat AS con ON con.noContrat = eng.noContrat
WHERE eng.dateSupprime IS NULL
GO
PRINT 'Création de la vue pour sommaire Engagement'
GO

CREATE VIEW  S_Contrat.vueSomExigence WITH SCHEMABINDING AS
SELECT exi.noExigence, exi.nom, exi.date, exi.montant, exi.descriptionCourte, exi.noStatut, con.noContrat
FROM S_Contrat.tblExigence AS exi
LEFT JOIN S_Contrat.tblContrat AS con ON con.noContrat = exi.noContrat
WHERE exi.dateSupprime IS NULL
GO
PRINT 'Création de la vue pour sommaire Exigence'
GO

CREATE VIEW S_Contrat.vueSomStatut WITH SCHEMABINDING AS
SELECT sta.noStatut, sta.NomStatut, sta.description, sta.couleur, sta.dateSupprime
FROM S_Contrat.tblStatut AS sta
WHERE  sta.dateSupprime IS NULL AND noStatut > 6
GO
PRINT 'Création de la vue pour sommaire Statut'
GO