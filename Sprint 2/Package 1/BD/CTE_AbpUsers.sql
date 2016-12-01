USE PE2_Officiel
GO
ALTER TABLE S_personnel.tblMemo ADD
CONSTRAINT NO_UTILISATEUR_EXPEDITEUR FOREIGN KEY(expediteur) REFERENCES dbo.AbpUsers(Id),
CONSTRAINT NO_UTILISATEUR_DESTINATAIRE FOREIGN KEY(destinataire) REFERENCES dbo.AbpUsers(Id)
GO
ALTER TABLE S_evenement.tblActivite ADD
CONSTRAINT NO_UTILISATEUR_CREATEUR FOREIGN KEY(noUtilisateur) REFERENCES dbo.AbpUsers(Id)
GO
CREATE TABLE tblQuestionSecrete
(
	IdQuestion INT NOT NULL IDENTITY(1,1),
	Question varchar(100)
)
GO
ALTER TABLE tblQuestionSecrete ADD
PRIMARY KEY (IdQuestion)
GO
ALTER TABLE dbo.AbpUsers
ADD IdQuestion INT
GO
ALTER TABLE dbo.AbpUsers
ADD Reponse varchar(100)
GO
ALTER TABLE dbo.AbpUsers
ADD ImageProfil Varbinary
GO
ALTER TABLE dbo.AbpUsers ADD
CONSTRAINT Id_Question FOREIGN KEY(IdQuestion) REFERENCES tblQuestionSecrete(IdQuestion)