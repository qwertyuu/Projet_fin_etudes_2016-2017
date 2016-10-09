--But: Cr�ation des vues du package Contrat.
--Date:06-09-2016
--Par: Kevin Ku�t� Moffo

USE PE2_Officiel

GO

CREATE VIEW  S_publicite.vueSomAppelOffre WITH SCHEMABINDING AS
SELECT ao.*, sta.nom, sta.couleur
FROM S_publicite.tblAppelOffre AS ao  
LEFT JOIN S_publicite.tblStatut AS sta 
ON ao.noStatut=sta.noStatut
WHERE ao.dateSupprime IS NULL
GO
PRINT 'Cr�ation de la vue reli�e a l''affichage du sommaire appel offre'
--J'AFFICHE QUOI DE LA SOUMISSION

