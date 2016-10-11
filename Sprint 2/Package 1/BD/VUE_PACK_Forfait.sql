--But: Création des vues du package Contrat.
--Date:08-10-2016
--Par: Simon Girard

USE PE2_Officiel

GO
CREATE VIEW S_forfait.vueSomForfait WITH SCHEMABINDING AS
SELECT forf.noForfait, forf.nom, forf.description
FROM S_forfait.tblForfait AS forf
WHERE  forf.dateSupprime IS NULL
GO
PRINT 'Création de la vue pour sommaire Forfaits'
GO

GO
CREATE VIEW S_forfait.vueSomService WITH SCHEMABINDING AS
SELECT forf.noService, forf.nomService
FROM S_forfait.tblService AS forf
WHERE  forf.dateSupprime IS NULL
GO
PRINT 'Création de la vue pour sommaire services'
GO

GO
CREATE VIEW S_forfait.vueSomSalle WITH SCHEMABINDING AS
SELECT forf.noSalle, forf.nomSalle, forf.prix, forf.billet, forf.billetVIP, forf.photoSalle, forf.urlGoogleMap
FROM S_forfait.tblSalle AS forf
WHERE  forf.dateSupprime IS NULL
GO
PRINT 'Création de la vue pour sommaire des salles'
GO