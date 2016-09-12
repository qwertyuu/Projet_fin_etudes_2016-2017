--But: Création des contraintes du package Contrat.
--Date:29-08-2016
--Par: Kevin Kuété Moffo


Use PE2_Officiel
GO

PRINT 'Création des PK et les contraintes NULL des tables du pakages Contrat'

 ALTER TABLE S_Contrat.tblStatut ADD
 CONSTRAINT Sta_PK
 PRIMARY Key(noStatut) 
 PRINT 'FIN des contraintes PK de la table tblStatut'
 GO	

 ALTER TABLE S_Contrat.tblAgence ADD
 CONSTRAINT AGE_PK
 PRIMARY Key(noAgence)
 PRINT 'FIN des contraintes PK de la table tblAgence'
 GO

 ALTER TABLE S_Contrat.tblContrat ADD
 CONSTRAINT CON_PK
 PRIMARY Key(noContrat) 
 PRINT 'FIN des contraintes PK de la table tblContrat'
 GO

 ALTER TABLE S_Contrat.tblExigence ADD
 CONSTRAINT EXI_PK
 PRIMARY Key(noExigence) 
 PRINT 'FIN des contraintes PK de la table tblExigence'
 GO

 ALTER TABLE S_Contrat.tblEngagement ADD
 CONSTRAINT ENG_PK
 PRIMARY Key(noEngagement) 
 PRINT 'FIN des contraintes PK de la table tblEngagement'
 GO

 ALTER TABLE S_Contrat.tblArtiste ADD
 CONSTRAINT ART_PK
 PRIMARY Key(noArtiste) 
 PRINT 'FIN des contraintes PK de la table tblArtiste'
 GO

 ALTER TABLE S_Contrat.tblFichierPersonnel ADD
 CONSTRAINT FIC_PK
 PRIMARY Key(noFichier) 
 PRINT 'FIN des contraintes PK de la table tblFichierPersonnel'
 GO

 ALTER TABLE S_Contrat.tblCategorieArtiste ADD
 CONSTRAINT CAT_PK
 PRIMARY Key(noCategorie) 
 PRINT 'FIN des contraintes PK de la table tblCategorieArtiste'
 GO

 ALTER TABLE S_Contrat.tblAdresse ADD
 CONSTRAINT ADR_PK
 PRIMARY Key(noAdresse) 
 PRINT 'FIN des contraintes PK de la table tblAdresse'
 GO

 ALTER TABLE S_Contrat.tblDiffuseur ADD
 CONSTRAINT DIF_PK
 PRIMARY Key(noDiffuseur) 
 PRINT 'FIN des contraintes PK  de la table tblDiffuseur'
 GO

 ALTER TABLE S_Contrat.tblResponsable ADD
 CONSTRAINT RES_PK
 PRIMARY Key(noResponsable) 
 PRINT 'FIN des contraintes PK de la table tblResponsable'
 GO

 ALTER TABLE S_Contrat.tblRespoContrat ADD
 CONSTRAINT RESCON_PK
 PRIMARY Key(noResponsable,noContrat) 
 PRINT 'FIN des contraintes PK  de la table tblRespoContrat'
 GO

 ALTER TABLE S_Contrat.tblFichierOfficiel ADD
 CONSTRAINT FICOFFI_PK
 PRIMARY Key(noContrat,noFichier,noArtiste) 
 PRINT 'FIN des contraintes PK de la table tblFichierOfficiel'
 GO

 ALTER TABLE S_Contrat.tblContratArtiste ADD
 CONSTRAINT CONART_PK
 PRIMARY Key(noContrat,noArtiste) 
 PRINT 'FIN des contraintes PK de la table tblContratArtiste'
 GO

 ALTER TABLE S_Contrat.tblCatArtisteArt ADD
 CONSTRAINT CATART_PK
 PRIMARY Key(noCategorie,noArtiste) 
 PRINT 'FIN des contraintes PK  de la table tblCatArtisteArt'
 GO

 ALTER TABLE S_personnel.tblUtilisateur ADD
 CONSTRAINT IDUSER_PK
 PRIMARY Key(IdUser) 
 PRINT 'FIN des contraintes PK  de la table tblUtilisateur'
 GO
 PRINT 'FIN  de création des contraintes PK des tables du pakage Contrat'

 GO
 PRINT 'Création des contraintes FK des tables du pakage Contrat'
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
 FOREIGN Key(noFichier) 
 References S_Contrat.tblFichierPersonnel(noFichier)
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

 ALTER TABLE S_Contrat.tblAgence ADD
 CONSTRAINT AGE_ADR_FK
 FOREIGN KEY (noAdresse)
 REFERENCES S_Contrat.tblAdresse(noAdresse)
 PRINT 'Fin de création des contraintes FK de la table tblAgence'
 GO 

 ALTER TABLE S_Contrat.tblDiffuseur ADD
 CONSTRAINT DIF_ADR_FK
 FOREIGN KEY (noAdresse)
 REFERENCES S_Contrat.tblAdresse(noAdresse)
 PRINT 'Fin de création des contraintes FK de la table tblAgence'
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

    PRINT 'Création des contraintes CHECK des tables du package Contrat'

PRINT 'Création des contraintes CHECK de la table tblResponsable'
GO
ALTER TABLE S_Contrat.tblResponsable
ADD CONSTRAINT CHE_DIF_AGE_NUL_RES
CHECK (
(CASE WHEN noDiffuseur IS NOT NULL THEN 1 ELSE 0 END
    + CASE WHEN noAgence IS NOT NULL THEN 1 ELSE 0 END)
    = 1
)
GO
  ALTER TABLE S_Contrat.tblResponsable ADD
  CONSTRAINT CHE_TEL_LONG_NUM_RES CHECK(isnumeric(telBureau)=1 and len(telBureau)=10)
GO
  ALTER TABLE S_Contrat.tblResponsable ADD
  CONSTRAINT CHE_CEL_LONG_NUM_RES_RES  CHECK(isnumeric(telCellulaire)=1 and len(telCellulaire)=10)
GO
  ALTER TABLE S_Contrat.tblResponsable ADD
  CONSTRAINT CHE_COUR_FORM_RES CHECK(courriel like '%_@__%.__%')
PRINT 'Fin création des contraintes CHECK de table tblResponsable'
GO

PRINT 'Création des contraintes CHECK de table tblAdresse'
GO
  ALTER TABLE S_Contrat.tblAdresse ADD
  CONSTRAINT CHE_TEL_LONG_NUM_ADR CHECK(isnumeric(telBureau)=1 and len(telBureau)=10)
GO
  ALTER TABLE S_Contrat.tblAdresse ADD
  CONSTRAINT CHE_CEL_LONG_NUM_RES_ADR   CHECK(isnumeric(telCellulaire)=1 and len(telCellulaire)=10)
GO
  ALTER TABLE S_Contrat.tblAdresse ADD
  CONSTRAINT CHE_PRO_LON_MAJ_ADR CHECK(len(province)=2 and isnumeric(province)=0 ) 
GO
GO
  ALTER TABLE S_Contrat.tblAdresse ADD
  CONSTRAINT CHE_COD_LON_ADR CHECK(len(codepostal)=6) 
PRINT 'Fin de création des contraintes CHECK de table tblAdresse'
GO

PRINT 'Création des contraintes CHECK de table tblAgence'
  ALTER TABLE S_Contrat.tblAgence ADD
  CONSTRAINT CHE_COUR_FORM_AGE CHECK(courriel like '%_@__%.__%')
PRINT 'Fin de création des contraintes CHECK de table tblAgence'
GO

PRINT 'Création des contraintes CHECK de table tblDiffuseur'
  ALTER TABLE S_Contrat.tblDiffuseur ADD
  CONSTRAINT CHE_COUR_FORM_DIF CHECK(courriel like '%_@__%.__%')
PRINT 'Fin de création des contraintes CHECK de table tblDiffuseur'
GO

 



