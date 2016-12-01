USE PE2_Officiel

ALTER TABLE S_personnel.tblMemo ADD
CONSTRAINT NO_UTILISATEUR_EXPEDITEUR FOREIGN KEY(expediteur) REFERENCES dbo.AbpUsers(Id),
CONSTRAINT NO_UTILISATEUR_DESTINATAIRE FOREIGN KEY(destinataire) REFERENCES dbo.AbpUsers(Id)

ALTER TABLE S_evenement.tblActivite ADD
CONSTRAINT NO_UTILISATEUR_CREATEUR FOREIGN KEY(noUtilisateur) REFERENCES dbo.AbpUsers(Id)

GO

CREATE TABLE tblQuestionSecrete
(
	idQuestion INT NOT NULL IDENTITY(1,1),
	Question varchar(100)
)

GO

ALTER TABLE dbo.AbpUsers
ADD idQuestion INT