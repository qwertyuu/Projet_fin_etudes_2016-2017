--But: Création des contraintes du package Contrat.
--Date:29-08-2016
--Par: Kevin Kuété Moffo


Use PE2_Test
GO


 ALTER TABLE S_Contrat.tblStatut
 ALTER Column noStatut  Int NOT NULL
 ALTER TABLE S_Contrat.tblStatut
 ALTER Column nomStatut  varchar(20) NOT NULL
   --Les Contraintes Clé----
 GO
 ALTER TABLE S_Contrat.tblStatut ADD
 CONSTRAINT Sta_PK
 PRIMARY Key(noStatut) 
 PRINT 'Fin création des Contraintes de la table tblStatut'
 GO	
 ALTER TABLE S_Contrat.tblAgence
 ALTER Column noAgence  varchar(15) NOT NULL
 ALTER TABLE S_Contrat.tblAgence
 ALTER Column nom  varchar(20) NOT NULL
 --Les contraintes Clés----
 GO
 ALTER TABLE S_Contrat.tblAgence ADD
 CONSTRAINT AGE_PK
 PRIMARY Key(noAgence)
 ALTER TABLE S_Contrat.tblContrat ADD
 CONSTRAINT ADR_AGE_FK
 FOREIGN Key(noAdresse) 
 References S_Contrat.tblStatut(noAdresse)
 PRINT 'Fin création des Contraintes de la table tblAgence'
 GO

 ALTER TABLE S_Contrat.tblContrat
 ALTER Column noContrat  varchar(20) NOT NULL
 ALTER TABLE S_Contrat.tblContrat
 ALTER Column nom  varchar(20) NOT NULL
 PRINT 'Fin création des Contraintes de la table tblContrat'
 GO


 ALTER TABLE S_Contrat.tblContrat ADD
 CONSTRAINT CON_PK
 PRIMARY Key(noContrat) 

 ALTER TABLE S_Contrat.tblContrat ADD
 CONSTRAINT CON_AGE_FK
 FOREIGN Key(noAgence) 
 References S_Contrat.tblAgence(noAgence)
 GO
 ALTER TABLE S_Contrat.tblContrat ADD
 CONSTRAINT CON_STA_FK
 FOREIGN Key(noStatut) 
 References S_Contrat.tblStatut(noStatut)
 PRINT 'Fin création de la PK et des Fk de la table tblContrat'
 GO


 





