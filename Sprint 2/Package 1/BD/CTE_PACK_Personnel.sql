--Ce script permet de créer l'ensemble des contraintes contenues dans le package personnel
--Fait par: Raphaël Côté
--En ce: 5 Octobre 2016
USE PE2_Officiel

ALTER TABLE S_personnel.tblUtilisateur ADD
CONSTRAINT IDUSER_PK PRIMARY Key(IdUser)
PRINT 'FIN des contraintes de la table tblUtilisateur'
GO

ALTER TABLE S_personnel.tblMemo ADD
CONSTRAINT NO_MEMO_PK PRIMARY Key(noMemo),
CONSTRAINT EXPEDITEUR_UTILISATEUR_MEMO_FK FOREIGN Key(expediteur) REFERENCES S_personnel.tblUtilisateur(IdUser),
CONSTRAINT DESTINATAIRE_UTILISATEUR_MEMO_FK FOREIGN Key(destinataire) REFERENCES S_personnel.tblUtilisateur(IdUser)
PRINT 'FIN des contraintes de la table tblMemo'
GO