--But: Création des vues du package publicite.
--Date:09-10-2016
--Par: Raphaël Côté

USE PE2_Officiel

GO

CREATE VIEW  S_publicite.vueSomAppelOffre WITH SCHEMABINDING AS
SELECT ao.[noAppelOffre],ao.[nom] as nomAppelOffre ,ao.[dateRequis],ao.[dateEnvoi],ao.[description],ao.[dateSupprime],ao.[noEvenement],ao.[noStatut], sta.nom as nomStatut, sta.couleur
FROM S_publicite.tblAppelOffre AS ao  
LEFT JOIN S_publicite.tblStatut AS sta 
ON ao.noStatut=sta.noStatut
WHERE ao.dateSupprime IS NULL
GO
PRINT 'Création de la vue reliée a l''affichage du sommaire appel offre'

GO
CREATE VIEW S_publicite.vueSomSoumission WITH SCHEMABINDING AS
SELECT soumi.nom as nomSoumission,soumi.prix,appelOfrre.nom as nomAppelOffre, soumi.description, soumi.noSoumission
FROM S_publicite.tblSoumission soumi
LEFT JOIN S_publicite.tblAppelOffreAgence offreAgence
ON offreAgence.offreNoPublicite=soumi.offreNoPublicite
LEFT JOIN S_publicite.tblAppelOffre appelOfrre
ON appelOfrre.noAppelOffre=offreAgence.noAppelOffre
WHERE soumi.dateSupprime IS NULL
GO
PRINT 'Création de la vue reliée a l''affichage du sommaire de soumission'

