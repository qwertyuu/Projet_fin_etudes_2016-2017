--Ce script permet de cr�er l'ensemble des contraintes contenues dans le package personnel
--Fait par: Rapha�l C�t�
--En ce: 5 Octobre 2016
USE PE2_Officiel

ALTER TABLE S_personnel.tblUtilisateur ADD
CONSTRAINT IDUSER_PK PRIMARY Key(IdUser)
PRINT 'FIN des contraintes de la table tblUtilisateur'
GO

ALTER TABLE S_personnel.tblMemo ADD
CONSTRAINT NO_MEMO_PK PRIMARY Key(noMemo);
PRINT 'FIN des contraintes de la table tblMemo'
GO