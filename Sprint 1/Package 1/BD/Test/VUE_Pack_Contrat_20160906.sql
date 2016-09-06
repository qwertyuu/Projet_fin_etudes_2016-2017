--But: Création des vues du package Contrat.
--Date:06-09-2016
--Par: Kevin Kuété Moffo

USE PE2_Test

GO

CREATE VIEW  S_Contrat.vueContrat AS
SELECT con.noContrat, agen.nom,sta.nomStatut, con.lieu
FROM S_Contrat.tblAgence AS agen 
JOIN S_Contrat.tblContrat AS con 
ON con.noAgence=agen.noAgence
JOIN S_Contrat.tblStatut AS sta
ON con.noStatut=sta.noStatut
PRINT 'Création de la vue reliée a l''affichage du sommaire contrat'
GO

PRINT 'Création de la vue reliée a l''affichage du sommaire contrat'