--But: Cr�ation des vues du package Contrat.
--Date:06-09-2016
--Par: Kevin Ku�t� Moffo

USE PE2_Test

GO

CREATE VIEW  S_Contrat.vueContrat AS
SELECT con.noContrat, agen.nom,sta.nomStatut, con.lieu
FROM S_Contrat.tblAgence AS agen 
JOIN S_Contrat.tblContrat AS con 
ON con.noAgence=agen.noAgence
JOIN S_Contrat.tblStatut AS sta
ON con.noStatut=sta.noStatut
PRINT 'Cr�ation de la vue reli�e a l''affichage du sommaire contrat'
GO

PRINT 'Cr�ation de la vue reli�e a l''affichage du sommaire contrat'