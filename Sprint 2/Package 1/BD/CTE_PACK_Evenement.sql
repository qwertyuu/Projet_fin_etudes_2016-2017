--But: Création des contraintes des tables du package Évènement.
--Date:05-10-2016
--Par: Kevin Kuété

USE PE2_Officiel
GO
ALTER TABLE S_evenement.tblEvenement ADD
CONSTRAINT NOEVEN_EVEN_PK PRIMARY Key(noEvenement)
PRINT 'FIN des contraintes de la table tblEvenement'
GO

ALTER TABLE S_evenement.tblSousEvenement ADD
CONSTRAINT NOSOUSEVEN_SOUSEVEN_PK PRIMARY Key(noSousEvenement),
CONSTRAINT SOUSEVEN_EVEN_NOSOUSEVEN_FK FOREIGN Key(noEvenement) REFERENCES S_evenement.tblEvenement(noEvenement)
PRINT 'FIN des contraintes de la table tblSousEvenement'
GO
ALTER TABLE S_evenement.tblActivite ADD
CONSTRAINT NO_ACT_PK PRIMARY Key(noActivite),
CONSTRAINT EVEN_ACT_NOEVEN_FK FOREIGN Key(noEvenement) REFERENCES S_evenement.tblEvenement(noEvenement),
CONSTRAINT SOUSEVEN_ACT_NOSOUSEVEN_FK FOREIGN Key(noSousEvenement) REFERENCES S_evenement.tblSousEvenement(noSousEvenement)
PRINT 'FIN des contraintes de la table tblActivite'
GO

ALTER TABLE S_evenement.tblCommanditaire ADD
CONSTRAINT NOCOM_COM_PK PRIMARY Key(noCommanditaire)
PRINT 'FIN des contraintes de la table tblCommanditaire'
GO

ALTER TABLE S_evenement.tblDon ADD
CONSTRAINT DOn_NODON_PK PRIMARY Key(noDon),
CONSTRAINT EVEN_DON_NOEVEN_FK FOREIGN Key(noCommanditaire) REFERENCES S_evenement.tblCommanditaire(noCommanditaire),
CONSTRAINT SOUSEVEN_DON_NOSOUSEVEN_FK FOREIGN Key(noSousEvenement) REFERENCES S_evenement.tblSousEvenement(noSousEvenement)
PRINT 'FIN des contraintes de la table tblDon'
GO

PRINT 'FIN des contraintes des tables pour le package Évèmenent'

