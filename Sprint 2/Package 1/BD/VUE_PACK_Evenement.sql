--But: Cr�ation des vues du package �v�nements.
--Date:09-10-2016
--Par: Rapha�l C�t�

USE PE2_Officiel

GO
PRINT 'Cr�ation de la vue reli�e a l''affichage du sommaire commanditaire'

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
PRINT 'Cr�ation de la vue reli�e a l''affichage du sommaire commanditaire termin�'
PRINT 'Cr�ation de la vue reli�e a l''affichage du sommaire des �v�nements'

GO

CREATE VIEW S_evenement.vueSomEvenement WITH SCHEMABINDING AS
SELECT e.nom, e.dateDebut, e.dateFin, e.description, e.noEvenement
FROM S_evenement.tblEvenement AS e
WHERE e.dateSupprime IS NULL
GO
PRINT 'Cr�ation de la vue reli�e a l''affichage du sommaire des �v�nements termin�'

GO

