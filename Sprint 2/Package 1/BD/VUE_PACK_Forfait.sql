--But: Cr�ation des vues du package Contrat.
--Date:08-10-2016
--Par: Simon Girard

USE PE2_Officiel

GO
CREATE VIEW S_forfait.vueSomSalle WITH SCHEMABINDING AS
SELECT forf.noSalle, forf.nomSalle, forf.prix, forf.billet, forf.billetVIP, forf.photoSalle, forf.urlGoogleMap
FROM S_forfait.tblSalle AS forf
WHERE  forf.dateSupprime IS NULL
GO
PRINT 'Cr�ation de la vue pour sommaire des salles'
GO