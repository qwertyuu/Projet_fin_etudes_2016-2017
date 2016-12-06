USE [PE2_Officiel]
GO
INSERT [tblQuestionSecrete]([Question]) VALUES ('Quel est le nom de votre père ?')
GO
INSERT [tblQuestionSecrete]([Question]) VALUES ('Quel est le nom de votre mère ?')
GO
INSERT [tblQuestionSecrete]([Question]) VALUES ('Quel la rue où vous avez grandi ?')
GO
INSERT [dbo].[AbpUsers] ([TenantId], [AuthenticationSource], [Name], [Surname], [UserName], [Password], [EmailAddress], [IsEmailConfirmed], [EmailConfirmationCode], [PasswordResetCode], [LastLoginTime], [IsActive], [IsDeleted], [DeleterUserId], [DeletionTime], [LastModificationTime], [LastModifierUserId], [CreationTime], [CreatorUserId], [IdQuestion],[Reponse], [ImageProfil]) VALUES (1, NULL, N'test', N'test', N'Utilisateur', N'ACnp1+gYjuQYx7dw4EWh4UTlLpB1q+fwsC+hPBa6Rff5h72P5Uy3wSwlgxCu7NXN+A==', N'test@example.com', 0, NULL, NULL, CAST(N'2016-10-26 16:24:30.307' AS DateTime), 1, 0, NULL, NULL, CAST(N'2016-10-26 16:24:30.313' AS DateTime), NULL, CAST(N'2016-10-26 16:24:30.117' AS DateTime ), NULL,1,'George',NULL)
GO
INSERT [dbo].[AbpUsers] ([TenantId], [AuthenticationSource], [Name], [Surname], [UserName], [Password], [EmailAddress], [IsEmailConfirmed], [EmailConfirmationCode], [PasswordResetCode], [LastLoginTime], [IsActive], [IsDeleted], [DeleterUserId], [DeletionTime], [LastModificationTime], [LastModifierUserId], [CreationTime], [CreatorUserId],[IdQuestion], [Reponse], [ImageProfil]) VALUES (1, NULL, N'test', N'tust', N'a', N'ABZafDHsjPN2G34uAz2+Oqsh5JCV3acxv1E2pVEaTVIiCBR0B8wmPVwh07GPDLNEGw==', N'a@a.a', 0, NULL, NULL, CAST(N'2016-10-26 16:29:46.010' AS DateTime), 1, 0, NULL, NULL, CAST(N'2016-10-26 16:29:46.010' AS DateTime), NULL, CAST(N'2016-10-26 16:28:45.163' AS DateTime), NULL,2,'Ginette',NULL)
GO
INSERT [dbo].[AbpUsers] ([TenantId], [AuthenticationSource], [Name], [Surname], [UserName], [Password], [EmailAddress], [IsEmailConfirmed], [EmailConfirmationCode], [PasswordResetCode], [LastLoginTime], [IsActive], [IsDeleted], [DeleterUserId], [DeletionTime], [LastModificationTime], [LastModifierUserId], [CreationTime], [CreatorUserId],[IdQuestion], [Reponse], [ImageProfil]) VALUES (1, NULL, N'd', N'd', N'b', N'AIdyGgCVrbaYujsm+7+JVOtRIuc6RglkEgQX1Yn1qMyiANayHRtn8NLtTo63tYaz4A==', N'cotlarrc@gmail.com', 0, NULL, NULL, CAST(N'2016-10-26 16:30:07.823' AS DateTime), 1, 0, NULL, NULL, CAST(N'2016-10-26 16:30:07.823' AS DateTime), NULL, CAST(N'2016-10-26 16:30:07.777' AS DateTime), NULL,3,'St-Albert',NULL)
GO

UPDATE S_evenement.tblActivite SET noUtilisateur = ABS(2 + ((CAST(ABS(CHECKSUM(NEWID())) % 101 AS FLOAT) / 100) * 4)) WHERE noActivite IN
(
    SELECT TOP 100 PERCENT noActivite FROM S_evenement.tblActivite ORDER BY NEWID()
)

GO

PRINT('Fin de l''ajout de FK dans la table activite')
