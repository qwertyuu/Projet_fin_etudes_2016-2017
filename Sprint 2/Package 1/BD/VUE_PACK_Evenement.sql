--But: Création des vues du package évènements.
--Date:09-10-2016
--Par: Raphaël Côté

USE PE2_Officiel

GO
PRINT 'Création de la vue reliée a l''affichage du sommaire commanditaire'

GO

CREATE VIEW S_evenement.vueSomCommanditaire WITH SCHEMABINDING AS
SELECT c.nomCommanditaire, c.nomContact, CAST(c.textePresentation AS varchar(max)) as textPres, c.courrielContact, c.numTel, c.extension, SUM(d.montant) as montantTotalDon, c.noCommanditaire
FROM S_evenement.tblCommanditaire AS c 
LEFT JOIN S_evenement.tblDon AS d 
ON c.noCommanditaire = d.noCommanditaire
WHERE c.dateSupprime IS NULL
AND d.dateSupprime IS NULL
GROUP BY c.noCommanditaire, c.nomCommanditaire, c.nomContact, CAST(c.textePresentation AS varchar(max)), c.courrielContact, c.numTel, c.extension
GO
PRINT 'Création de la vue reliée a l''affichage du sommaire commanditaire terminé'
PRINT 'Création de la vue reliée a l''affichage du sommaire des évènements'

GO

CREATE VIEW S_evenement.vueSomEvenement WITH SCHEMABINDING AS
SELECT e.nom, e.dateDebut, e.dateFin, e.description, e.noEvenement
FROM S_evenement.tblEvenement AS e
WHERE e.dateSupprime IS NULL
GO
PRINT 'Création de la vue reliée a l''affichage du sommaire des évènements terminé'

GO

