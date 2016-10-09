--Ce script permet de créer l'ensemble des contraintes contenues dans le package publicite
--Fait par: Raphaël Côté
--En ce: 5 Octobre 2016
USE PE2_Officiel

GO
ALTER TABLE S_publicite.tblStatut ADD
CONSTRAINT NO_STATUT_PK PRIMARY Key(noStatut),
CONSTRAINT CHK_COULEUR CHECK(couleur LIKE '%[0-9A-F]%')
PRINT 'FIN des contraintes de la table tblStatut'
GO

ALTER TABLE S_publicite.tblMedia ADD
CONSTRAINT NO_MEDIA_PK PRIMARY Key(noMedia)
PRINT 'FIN des contraintes de la table tblMedia'

GO
ALTER TABLE S_publicite.tblMediaAppelOffre ADD
CONSTRAINT OFFREMED_NOOFF_NOMEDIA_PK PRIMARY Key(noAppelOffre,noMedia),
CONSTRAINT OFFMED_MED_NOMED_FK FOREIGN Key(noMedia) REFERENCES S_publicite.tblMedia(noMedia),
CONSTRAINT OFFMED_APPELOFFRE_FK FOREIGN Key(noAppelOffre) REFERENCES S_publicite.tblAppelOffre(noAppelOffre)
PRINT 'FIN des contraintes de la table tblMediaAppelOffre'

GO
ALTER TABLE S_publicite.tblAppelOffre ADD
CONSTRAINT NO_APPEL_OFFRE_PK PRIMARY Key(noAppelOffre),
CONSTRAINT EVENEMENT_APPEL_FK FOREIGN Key(noEvenement) REFERENCES S_evenement.tblEvenement(noEvenement),
CONSTRAINT STATUT_APPEL_FK FOREIGN Key(noStatut) REFERENCES S_publicite.tblStatut(noStatut)
PRINT 'FIN des contraintes de la table tblAppelOffre'
GO
ALTER TABLE S_publicite.tblAppelOffre ADD
CONSTRAINT NO_APPEL_OFFRE_PK PRIMARY Key(noAppelOffre),
CONSTRAINT EVENEMENT_APPEL_FK FOREIGN Key(noEvenement) REFERENCES S_evenement.tblEvenement(noEvenement),
CONSTRAINT STATUT_APPEL_FK FOREIGN Key(noStatut) REFERENCES S_publicite.tblStatut(noStatut)
PRINT 'FIN des contraintes de la table tblAppelOffre'

GO
ALTER TABLE S_publicite.tblAgencePublicite ADD
CONSTRAINT NO_AGENCE_PUB_PK PRIMARY Key(noAgencePub)
PRINT 'FIN des contraintes de la table tblAgencePublicite'
GO


ALTER TABLE S_publicite.tblSoumission ADD
CONSTRAINT NO_SOUMISSION_PK PRIMARY Key(noSoumission),
CONSTRAINT SOUMISSION_APPEL_OFFRE_FK FOREIGN Key(offreNoPublicite) REFERENCES S_publicite.tblAppelOffreAgence(offreNoPublicite)
PRINT 'FIN des contraintes de la table tblSoumission'
GO

ALTER TABLE S_publicite.tblAppelOffreAgence ADD
CONSTRAINT NO_APPEL_OFFRE_NO_AGENCE_PUB_PK PRIMARY KEY(offreNoPublicite),
CONSTRAINT APPEL_OFFRE_FK FOREIGN Key(noAppelOffre) REFERENCES S_publicite.tblAppelOffre(noAppelOffre),
CONSTRAINT AGENCE_PUB_FK FOREIGN Key(noAgencePub) REFERENCES S_publicite.tblAgencePublicite(noAgencePub),
CONSTRAINT STATUT_APPEL_OFFRE_AGENCE_FK FOREIGN Key(noStatut) REFERENCES S_publicite.tblStatut(noStatut)
PRINT 'FIN des contraintes de la table tblAppelOffreAgence'
GO