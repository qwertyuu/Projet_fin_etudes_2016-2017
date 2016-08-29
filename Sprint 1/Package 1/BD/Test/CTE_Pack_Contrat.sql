--But: Création des contraintes du package Contrat.
--Date:29-08-2016
--Par: Kevin Kuété Moffo


Use PE2_Test
GO
 PRINT 'Création des Contraintes de la TABLE tblContrat'

 ALTER TABLE S_Contrat.tblContrat
 ALTER Column noContrat  varchar(20) NOT NULL

 ALTER TABLE S_Contrat.tblContrat
 ALTER Column nom  varchar(20) NOT NULL
 GO

 PRINT 'Création de la PK et des Fk de la TABLE tblContrat'
 ALTER TABLE S_Contrat.tblContrat ADD
 CONSTRAINT CON_PK
 PRIMARY Key(noContrat) 

 ALTER TABLE S_Contrat.tblContrat ADD
 CONSTRAINT CON_AGE_FK
 FOREIGN Key(noAgence) 
 References S_Contrat.tblAgence(noAgence)

 ALTER TABLE S_Contrat.tblContrat ADD
 CONSTRAINT CON_STA_FK
 FOREIGN Key(noStatut) 
 References S_Contrat.tblStatut(noStatut)

 GO
 PRINT 'Création des Contraintes de la TABLE tblStatut'
 ALTER TABLE S_Contrat.tblStatut
 ALTER Column noStatut  Int NOT NULL
 ALTER TABLE S_Contrat.tblStatut
 ALTER Column nomStatut  varchar(20) NOT NULL

 GO
 PRINT 'Création des Contraintes de la TABLE tblAgence'
 ALTER TABLE S_Contrat.tblAgence
 ALTER Column noAgence  varchar(15) NOT NULL
 ALTER TABLE S_Contrat.tblStatut
 ALTER Column nomAgence  varchar(20) NOT NULL






