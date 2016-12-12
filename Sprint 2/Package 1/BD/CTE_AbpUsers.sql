USE PE2_Officiel
GO
ALTER TABLE S_personnel.tblMemo ADD
CONSTRAINT NO_UTILISATEUR_EXPEDITEUR FOREIGN KEY(expediteur) REFERENCES dbo.AbpUsers(Id),
CONSTRAINT NO_UTILISATEUR_DESTINATAIRE FOREIGN KEY(destinataire) REFERENCES dbo.AbpUsers(Id)
GO
ALTER TABLE S_evenement.tblActivite ADD
CONSTRAINT NO_UTILISATEUR_CREATEUR FOREIGN KEY(noUtilisateur) REFERENCES dbo.AbpUsers(Id)
GO
ALTER TABLE S_personnel.tblQuestionSecrete ADD
PRIMARY KEY (NoQuestion)
GO
ALTER TABLE dbo.AbpUsers
ADD NoQuestion INT NULL
GO
ALTER TABLE dbo.AbpUsers
ADD Reponse varchar(100) NULL
GO
ALTER TABLE dbo.AbpUsers
ADD ImageProfil Varbinary(MAX) NULL
GO
ALTER TABLE dbo.AbpUsers ADD
CONSTRAINT NO_Question FOREIGN KEY(NoQuestion) REFERENCES S_personnel.tblQuestionSecrete(NoQuestion)