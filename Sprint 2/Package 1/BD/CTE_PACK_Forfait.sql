--But: Création des contraintes des tables du package Évènement.
--Date:05-10-2016
--Par: Kevin Kuété

USE PE2_Officiel
GO

ALTER TABLE S_forfait.tblForfait ADD
CONSTRAINT NOFOR_FOR_PK PRIMARY Key(noForfait)
PRINT 'FIN des contraintes de la table tblForfait'
GO

ALTER TABLE S_forfait.tblSalle ADD
CONSTRAINT NOSAL_SAL_PK PRIMARY Key(noSalle)
PRINT 'FIN des contraintes de la table tblSalle'
GO

ALTER TABLE S_forfait.tblService ADD
CONSTRAINT NOSERV_SERV_PK PRIMARY Key(noService)
PRINT 'FIN des contraintes de la table tblService'
GO

ALTER TABLE S_forfait.tblForfaitSousEvenement ADD
CONSTRAINT NOFORSOUSEVEN_FORSEVEN_PK PRIMARY Key(noForfait,noSousEvenement),
CONSTRAINT FORF_SOUSEVENFORF_NOFOR_FK FOREIGN Key(noForfait) REFERENCES S_forfait.tblForfait(noForfait),
CONSTRAINT SOUSEVEN_SOUSEVENFORF_NOSOUSEVEN_FK FOREIGN Key(noSousEvenement) REFERENCES S_evenement.tblSousEvenement(noSousEvenement)
PRINT 'FIN des contraintes de la table tblForfaitSousEvenement'
GO

ALTER TABLE S_forfait.tblServiceOffert ADD
CONSTRAINT SEROFF_NOSERNOSAL_PK PRIMARY Key(noSalle,noService),
CONSTRAINT SAL_SEROFF_NOSAL_FK FOREIGN Key(noSalle) REFERENCES S_forfait.tblSalle(noSalle),
CONSTRAINT SERV_SEROFF_NOSERV_FK FOREIGN Key(noService) REFERENCES S_forfait.tblService(noService)
PRINT 'FIN des contraintes de la table tblServiceOffert'
GO

ALTER TABLE S_forfait.tblServiceRequis ADD
CONSTRAINT SERVREQUIS_NOSERNOSEVEN_PK PRIMARY Key(noSousEvenement,noService),
CONSTRAINT SOUSEVEN_SEROFF_NOSEVENL_FK FOREIGN Key(noSousEvenement) REFERENCES S_evenement.tblSousEvenement(noSousEvenement),
CONSTRAINT SERV_SERVREQ_NOSERV_FK FOREIGN Key(noService) REFERENCES S_forfait.tblService(noService)
PRINT 'FIN des contraintes de la table tblServiceRequis'
GO

PRINT 'FIN des contraintes des tables du package forfait '


ALTER TABLE S_Evenement.tblSousEvenement ADD
CONSTRAINT NOSALLE FOREIGN KEY(noSalle) REFERENCES S_forfait.tblSalle(noSalle)
GO
PRINT('Fin des contraintes FK des sous-évènements')
