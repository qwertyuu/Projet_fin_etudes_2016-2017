--But: Création des contraintes du package Contrat.
--Date:29-08-2016
--Par: Kevin Kuété Moffo


Use PE2_Test
GO
 Print 'Création des Contraintes de la table tblContrat'

 Alter table S_Contrat.tblContrat
 Alter Column noContrat  varchar(20) NOT NULL

 Alter table S_Contrat.tblContrat
 Alter Column nom  varchar(20) NOT NULL

 Print 'Création de la PK et des Fk de la table tblContrat'
 Alter table S_Contrat.tblContrat ADD
 Constraint CON_PK
 Primary Key(noContrat) 

 Alter table S_Contrat.tblContrat ADD
 Constraint CON_AGE_FK
 Foreign Key(noAgence) 
 References S_Contrat.tblAgence(noAgence)

 Alter table S_Contrat.tblContrat ADD
 Constraint CON_STA_FK
 Foreign Key(noStatut) 
 References S_Contrat.tblStatut(noStatut)

 GO
 Print 'Création des Contraintes de la table tblStatut'
 Alter table S_Contrat.tblStatut
 Alter Column noStatut  Int NOT NULL
 Alter table S_Contrat.tblStatut
 Alter Column nomStatut  varchar(20) NOT NULL

 GO
 Print 'Création des Contraintes de la table tblAgence'
 Alter table S_Contrat.tblAgence
 Alter Column noAgence  varchar(15) NOT NULL
 Alter table S_Contrat.tblStatut
 Alter Column nomAgence  varchar(20) NOT NULL






