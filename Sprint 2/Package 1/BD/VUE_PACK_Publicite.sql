--But: Création des vues du package publicite.
--Date:09-10-2016
--Par: Raphaël Côté

USE PE2_Officiel

GO

CREATE VIEW  S_publicite.vueSomAppelOffre WITH SCHEMABINDING AS
SELECT  ao.[noAppelOffre], ao.[nom] as nomAppelOffre ,ao.[dateRequis],ao.[dateEnvoi],CAST(ao.[description] AS VARCHAR(MAX)) description,ao.[dateSupprime],even.nom as nomEvent,ao.[noStatut], sta.nom as nomStatut, sta.couleur, agen.nom AS nomAgence
FROM S_publicite.tblAppelOffre AS ao  
LEFT JOIN S_publicite.tblStatutAppelOffre AS sta
ON ao.noStatut=sta.noStatut
LEFT JOIN S_publicite.tblSoumission soumi
ON soumi.noAppelOffre=ao.noAppelOffre
LEFT JOIN S_publicite.tblAgencePublicite agen
ON agen.noAgencePub=soumi.noAgencePub
LEFT JOIN S_evenement.tblEvenement even
ON even.noEvenement=ao.noEvenement
WHERE ao.dateSupprime IS NULL
GO
PRINT 'Création de la vue reliée a l''affichage du sommaire appel offre'

GO
CREATE VIEW S_publicite.vueSomSoumission WITH SCHEMABINDING AS
SELECT soumi.prix,appelOfrre.nom as nomAppelOffre, soumi.commentaire, soumi.noSoumission
FROM S_publicite.tblSoumission soumi
LEFT JOIN S_publicite.tblAppelOffre appelOfrre
ON soumi.noAppelOffre=appelOfrre.noAppelOffre
WHERE soumi.dateSupprime IS NULL
GO
PRINT 'Création de la vue reliée a l''affichage du sommaire de soumission'

