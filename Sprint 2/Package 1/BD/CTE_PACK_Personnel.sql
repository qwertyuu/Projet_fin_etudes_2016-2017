--Ce script permet de créer l'ensemble des contraintes contenues dans le package personnel
--Fait par: Raphaël Côté
--En ce: 5 Octobre 2016
USE PE2_Officiel

ALTER TABLE S_personnel.tblMemo ADD
CONSTRAINT NO_MEMO_PK PRIMARY Key(noMemo);
PRINT 'FIN des contraintes de la table tblMemo'
GO