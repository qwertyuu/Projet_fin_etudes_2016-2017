--But: Création des contraintes du package Contrat.
--Date:29-08-2016
--Par: Kevin Kuété Moffo


Use PE2_Test
GO

PRINT 'Création des PK et les contraintes NULL des tables du pakages Contrat'

 ALTER TABLE S_Contrat.tblStatut
 ALTER Column noStatut  Int NOT NULL
 ALTER TABLE S_Contrat.tblStatut
 ALTER Column nomStatut  varchar(20) NOT NULL
 GO
 ALTER TABLE S_Contrat.tblStatut ADD
 CONSTRAINT Sta_PK
 PRIMARY Key(noStatut) 
 PRINT 'FIN des contraintes PK et NULL de la table tblStatut'
 GO	

 ALTER TABLE S_Contrat.tblAgence
 ALTER Column noAgence  varchar(15) NOT NULL
 ALTER TABLE S_Contrat.tblAgence
 ALTER Column nom  varchar(50) NOT NULL
 GO
 ALTER TABLE S_Contrat.tblAgence ADD
 CONSTRAINT AGE_PK
 PRIMARY Key(noAgence)
 PRINT 'FIN des contraintes PK et NULL de la table tblAgence'
 GO

 ALTER TABLE S_Contrat.tblContrat
 ALTER Column noContrat  varchar(20) NOT NULL
 ALTER TABLE S_Contrat.tblContrat
 ALTER Column nom  varchar(20) NOT NULL
 GO
 ALTER TABLE S_Contrat.tblContrat ADD
 CONSTRAINT CON_PK
 PRIMARY Key(noContrat) 
 PRINT 'FIN des contraintes PK et NULL de la table tblContrat'
 GO

 ALTER TABLE S_Contrat.tblExigence
 ALTER Column noExigence INT NOT NULL
 ALTER TABLE S_Contrat.tblExigence
 ALTER Column nom  varchar(20) NOT NULL
GO
 ALTER TABLE S_Contrat.tblExigence ADD
 CONSTRAINT EXI_PK
 PRIMARY Key(noExigence) 
 PRINT 'FIN des contraintes PK et NULL de la table tblExigence'
 GO

 ALTER TABLE S_Contrat.tblEngagement
 ALTER Column noEngagement INT NOT NULL
 ALTER TABLE S_Contrat.tblEngagement
 ALTER Column nature  varchar(50) NOT NULL
 ALTER TABLE S_Contrat.tblEngagement
 ALTER Column duree  varchar(6) NOT NULL
 ALTER TABLE S_Contrat.tblEngagement
 ALTER Column lieu  Text NOT NULL
GO
 ALTER TABLE S_Contrat.tblEngagement ADD
 CONSTRAINT ENG_PK
 PRIMARY Key(noEngagement) 
 PRINT 'FIN des contraintes PK et NULL de la table tblEngagement'
 GO

 ALTER TABLE S_Contrat.tblArtiste
 ALTER Column noArtiste INT NOT NULL
 ALTER TABLE S_Contrat.tblArtiste
 ALTER Column nom  varchar(50) NOT NULL
GO
 ALTER TABLE S_Contrat.tblArtiste ADD
 CONSTRAINT ART_PK
 PRIMARY Key(noArtiste) 
 PRINT 'FIN des contraintes PK et NULL de la table tblArtiste'
 GO

 ALTER TABLE S_Contrat.tblFichierPersonnel
 ALTER Column idFichier INT NOT NULL
 ALTER TABLE S_Contrat.tblFichierPersonnel
 ALTER Column chemin  TEXT NOT NULL
 ALTER TABLE S_Contrat.tblFichierPersonnel
 ALTER Column type  TEXT NOT NULL
GO
 ALTER TABLE S_Contrat.tblFichierPersonnel ADD
 CONSTRAINT FIC_PK
 PRIMARY Key(idFichier) 
 PRINT 'FIN des contraintes PK et NULL de la table tblFichierPersonnel'
 GO

 ALTER TABLE S_Contrat.tblCategorieArtiste
 ALTER Column noCategorie INT NOT NULL
 ALTER TABLE S_Contrat.tblCategorieArtiste
 ALTER Column nom  VARCHAR(20) NOT NULL

GO
 ALTER TABLE S_Contrat.tblCategorieArtiste ADD
 CONSTRAINT CAT_PK
 PRIMARY Key(noCategorie) 
 PRINT 'FIN des contraintes PK et NULL de la table tblCategorieArtiste'
 GO

 ALTER TABLE S_Contrat.tblAdresse
 ALTER Column noAdresse INT NOT NULL
 ALTER TABLE S_Contrat.tblAdresse
 ALTER Column ville  VARCHAR(20) NOT NULL
 ALTER TABLE S_Contrat.tblAdresse
 ALTER Column province  VARCHAR(2) NOT NULL
 ALTER TABLE S_Contrat.tblAdresse
 ALTER Column pays  VARCHAR(20) NOT NULL
 ALTER TABLE S_Contrat.tblAdresse
 ALTER Column codePostal  VARCHAR(6) NOT NULL
GO
 ALTER TABLE S_Contrat.tblAdresse ADD
 CONSTRAINT ADR_PK
 PRIMARY Key(noAdresse) 
 PRINT 'FIN des contraintes PK et NULL de la table tblAdresse'
 GO

 ALTER TABLE S_Contrat.tblDiffuseur
 ALTER Column noDiffuseur INT NOT NULL
 ALTER TABLE S_Contrat.tblDiffuseur
 ALTER Column nom  VARCHAR(50) NOT NULL
 ALTER TABLE S_Contrat.tblDiffuseur
 ALTER Column courriel  VARCHAR(255) NOT NULL
 GO
 ALTER TABLE S_Contrat.tblDiffuseur ADD
 CONSTRAINT DIF_PK
 PRIMARY Key(noDiffuseur) 
 PRINT 'FIN des contraintes PK et NULL de la table tblDiffuseur'
 GO

 ALTER TABLE S_Contrat.tblResponsable
 ALTER Column noResponsable INT NOT NULL
 ALTER TABLE S_Contrat.tblResponsable
 ALTER Column nom  VARCHAR(20) NOT NULL
 ALTER TABLE S_Contrat.tblResponsable
 ALTER Column prenom  VARCHAR(20) NOT NULL
 ALTER TABLE S_Contrat.tblResponsable
 ALTER Column courriel  VARCHAR(255) NOT NULL
 GO
 ALTER TABLE S_Contrat.tblResponsable ADD
 CONSTRAINT RES_PK
 PRIMARY Key(noResponsable) 
 PRINT 'FIN des contraintes PK et NULL de la table tblResponsable'
 GO

 ALTER TABLE S_Contrat.tblRespoContrat
 ALTER Column noResponsable INT NOT NULL
 ALTER TABLE S_Contrat.tblRespoContrat
 ALTER Column noContrat  varchar(20) NOT NULL
 GO
 ALTER TABLE S_Contrat.tblRespoContrat ADD
 CONSTRAINT RESCON_PK
 PRIMARY Key(noResponsable,noContrat) 
 PRINT 'FIN des contraintes PK et NULL de la table tblRespoContrat'
 GO

 ALTER TABLE S_Contrat.tblFichierOfficiel
 ALTER Column noContrat varchar(20) NOT NULL
 ALTER TABLE S_Contrat.tblFichierOfficiel
 ALTER Column idFichier INT NOT NULL
 ALTER TABLE S_Contrat.tblFichierOfficiel
 ALTER Column noArtiste INT NOT NULL
 GO
 ALTER TABLE S_Contrat.tblFichierOfficiel ADD
 CONSTRAINT FICOFFI_PK
 PRIMARY Key(noContrat,idFichier,noArtiste) 
 PRINT 'FIN des contraintes PK et NULL de la table tblFichierOfficiel'
 GO

 ALTER TABLE S_Contrat.tblContratArtiste
 ALTER Column noContrat varchar(20) NOT NULL
 ALTER TABLE S_Contrat.tblContratArtiste
 ALTER Column noArtiste INT NOT NULL
 GO
 ALTER TABLE S_Contrat.tblContratArtiste ADD
 CONSTRAINT CONART_PK
 PRIMARY Key(noContrat,noArtiste) 
 PRINT 'FIN des contraintes PK et NULL de la table tblContratArtiste'
 GO

 ALTER TABLE S_Contrat.tblCatArtisteArt
 ALTER Column noCategorie INT NOT NULL
 ALTER TABLE S_Contrat.tblCatArtisteArt
 ALTER Column noArtiste INT NOT NULL
 GO
 ALTER TABLE S_Contrat.tblCatArtisteArt ADD
 CONSTRAINT CATART_PK
 PRIMARY Key(noCategorie,noArtiste) 
 PRINT 'FIN des contraintes PK et NULL de la table tblCatArtisteArt'
 GO
 PRINT 'FIN  de création des contraintes PK et NULL des tables du pakage Contrat'

 GO
 PRINT 'Création des contraintes FK des tables du pakage Contrat'
 GO

 ALTER TABLE S_Contrat.tblDiffuseur ADD
 CONSTRAINT DIF_RES_FK
 FOREIGN Key(noAdresse) 
 References S_Contrat.tblAdresse(noAdresse)
 PRINT 'Fin de création des contraintes FK de la table tblDiffuseur'
 GO

 ALTER TABLE S_Contrat.tblResponsable ADD
 CONSTRAINT RES_DIF_FK
 FOREIGN Key(noDiffuseur) 
 References S_Contrat.tblDiffuseur(noDiffuseur)
 GO
 ALTER TABLE S_Contrat.tblResponsable ADD
 CONSTRAINT RES_AGE_FK
 FOREIGN Key(noAgence) 
 References S_Contrat.tblAgence(noAgence)
 PRINT 'Fin de création des contraintes FK de la table tblResponsable'
 GO

 ALTER TABLE S_Contrat.tblAgence ADD
 CONSTRAINT AGE_ADR_FK
 FOREIGN Key(noAdresse) 
 References S_Contrat.tblAdresse(noAdresse)
 PRINT 'Fin de création des contraintes FK de la table tblAgence'
 GO

 ALTER TABLE S_Contrat.tblCatArtisteArt ADD
 CONSTRAINT CATART_CATART_FK
 FOREIGN Key(noCategorie) 
 References S_Contrat.tblCategorieArtiste(noCategorie)
 GO
 ALTER TABLE S_Contrat.tblCatArtisteArt ADD
 CONSTRAINT CATART_ART_FK
 FOREIGN Key(noArtiste) 
 References S_Contrat.tblArtiste(noArtiste)
 PRINT 'Fin de création des contraintes FK de la table tblCatArtisteArt'
 GO

 ALTER TABLE S_Contrat.tblContratArtiste ADD
 CONSTRAINT CONART_ART_FK
 FOREIGN Key(noArtiste) 
 References S_Contrat.tblArtiste(noArtiste)
 GO
 ALTER TABLE S_Contrat.tblContratArtiste ADD
 CONSTRAINT CONART_CON_FK
 FOREIGN Key(noContrat) 
 References S_Contrat.tblContrat(noContrat)
 PRINT 'Fin de création des contraintes FK de la table tblContratArtiste'
 GO

 ALTER TABLE S_Contrat.tblRespoContrat ADD
 CONSTRAINT RESCONT_RES_FK
 FOREIGN Key(noResponsable) 
 References S_Contrat.tblResponsable(noResponsable)
 GO
 ALTER TABLE S_Contrat.tblRespoContrat ADD
 CONSTRAINT RESCON_CON_FK
 FOREIGN Key(noContrat) 
 References S_Contrat.tblContrat(noContrat)
 PRINT 'Fin de création des contraintes FK de la table tblRespoContrat'
 GO

 ALTER TABLE S_Contrat.tblContrat ADD
 CONSTRAINT CON_STA_FK
 FOREIGN Key(noStatut) 
 References S_Contrat.tblStatut(noStatut)
 GO
 ALTER TABLE S_Contrat.tblContrat ADD
 CONSTRAINT CON_AGE_FK
 FOREIGN Key(noAgence) 
 References S_Contrat.tblAgence(noAgence)
 PRINT 'Fin de création des contraintes FK de la table tblContrat'
 GO

 ALTER TABLE S_Contrat.tblFichierPersonnel ADD
 CONSTRAINT FIC_ART_FK
 FOREIGN Key(noArtiste) 
 References S_Contrat.tblArtiste(noArtiste)
 PRINT 'Fin de création des contraintes FK de la table tblFichierPersonnel'
 GO

 ALTER TABLE S_Contrat.tblFichierOfficiel ADD
 CONSTRAINT FICOFF_FICPER_FK
 FOREIGN Key(idFichier) 
 References S_Contrat.tblFichierPersonnel(idFichier)
 GO
 ALTER TABLE S_Contrat.tblFichierOfficiel ADD
 CONSTRAINT FICOFF_ART_FK
 FOREIGN Key(noArtiste) 
 References S_Contrat.tblArtiste(noArtiste)
 GO
 ALTER TABLE S_Contrat.tblFichierOfficiel ADD
 CONSTRAINT FICOFF_CON_FK
 FOREIGN Key(noContrat) 
 References S_Contrat.tblContrat(noContrat)
 PRINT 'Fin de création des contraintes FK de la table tblFichierOfficiel'
 GO

 ALTER TABLE S_Contrat.tblEngagement ADD
 CONSTRAINT ENG_CON_FK
 FOREIGN Key(noContrat) 
 References S_Contrat.tblContrat(noContrat)
 PRINT 'Fin de création des contraintes FK de la table tblEngagement'
 GO

 ALTER TABLE S_Contrat.tblExigence ADD
 CONSTRAINT EXI_CON_FK
 FOREIGN Key(noContrat) 
 References S_Contrat.tblContrat(noContrat)
 GO
 ALTER TABLE S_Contrat.tblExigence ADD
 CONSTRAINT EXI_STA_FK
 FOREIGN Key(noStatut) 
 References S_Contrat.tblStatut(noStatut)
 PRINT 'Fin de création des contraintes FK de la table tblExigence'
 GO
  PRINT 'Fin de création des contraintes FK des tables du package Contrat'





 



