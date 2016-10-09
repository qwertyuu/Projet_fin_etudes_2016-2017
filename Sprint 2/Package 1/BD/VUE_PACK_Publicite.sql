--But: Création des vues du package Contrat.
--Date:06-09-2016
--Par: Kevin Kuété Moffo

USE PE2_Officiel

GO

CREATE VIEW  S_publicite.vueSomAppelOffre WITH SCHEMABINDING AS
SELECT ao.*, sta.nom, sta.couleur
FROM S_publicite.tblAppelOffre AS ao  
LEFT JOIN S_publicite.tblStatut AS sta 
ON ao.noStatut=sta.noStatut
WHERE ao.dateSupprime IS NULL
GO
PRINT 'Création de la vue reliée a l''affichage du sommaire appel offre'
--J'AFFICHE QUOI DE LA SOUMISSION

