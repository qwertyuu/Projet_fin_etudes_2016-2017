USE [PE2_Officiel]
GO
INSERT [S_personnel].[tblQuestionSecrete]([Question]) VALUES ('Quel est le nom de votre père ?')
GO
INSERT [S_personnel].[tblQuestionSecrete]([Question]) VALUES ('Quel est le nom de votre mère ?')
GO
INSERT [S_personnel].[tblQuestionSecrete]([Question]) VALUES ('Quel la rue où vous avez grandi ?')
GO
INSERT INTO [dbo].[AbpUsers](TenantId, AuthenticationSource, Name, Surname, UserName, Password, EmailAddress, IsEmailConfirmed, EmailConfirmationCode, PasswordResetCode, LastLoginTime, IsActive, IsDeleted, DeleterUserId, DeletionTime, LastModificationTime, LastModifierUserId, CreationTime, CreatorUserId, NoQuestion,Reponse, ImageProfil) 
VALUES 
(1, NULL, N'Lina', N'Bérubé', N'linaB', N'ABZafDHsjPN2G34uAz2+Oqsh5JCV3acxv1E2pVEaTVIiCBR0B8wmPVwh07GPDLNEGw==', N'linaberube@cegepjonquiere.ca', 0, NULL, NULL, CAST(N'2016-10-26 16:29:46.010' AS DateTime), 1, 0, NULL, NULL, CAST(N'2016-10-26 16:29:46.010' AS DateTime), NULL, CAST(N'2016-10-26 16:28:45.163' AS DateTime), NULL,1,'Ginette',NULL),
(1, NULL, N'Patrice', N'Boudreault', N'patriceB', N'AIdyGgCVrbaYujsm+7+JVOtRIuc6RglkEgQX1Yn1qMyiANayHRtn8NLtTo63tYaz4A==', N'patriceboudreault@cegepjonquiere.ca', 0, NULL, NULL, CAST(N'2016-10-26 16:30:07.823' AS DateTime), 1, 0, NULL, NULL, CAST(N'2016-10-26 16:30:07.823' AS DateTime), NULL, CAST(N'2016-10-26 16:30:07.777' AS DateTime), NULL,2,'St-Albert',NULL),
(1, NULL, N'Éric', N'Dallaire', N'ericD', N'AIdyGgCVrbaYujsm+7+JVOtRIuc6RglkEgQX1Yn1qMyiANayHRtn8NLtTo63tYaz4A==', N'ericdallaire@cegepjonquiere.ca', 0, NULL, NULL, CAST(N'2016-10-26 16:30:07.823' AS DateTime), 1, 0, NULL, NULL, CAST(N'2016-10-26 16:30:07.823' AS DateTime), NULL, CAST(N'2016-10-26 16:30:07.777' AS DateTime), NULL,NULL,NULL,NULL),
(1, NULL, N'Lucie', N'Fortin', N'lucieF', N'AIdyGgCVrbaYujsm+7+JVOtRIuc6RglkEgQX1Yn1qMyiANayHRtn8NLtTo63tYaz4A==', N'luciefortin@cegepjonquiere.ca', 0, NULL, NULL, CAST(N'2016-10-26 16:30:07.823' AS DateTime), 1, 0, NULL, NULL, CAST(N'2016-10-26 16:30:07.823' AS DateTime), NULL, CAST(N'2016-10-26 16:30:07.777' AS DateTime), NULL,NULL,NULL,NULL),
(1, NULL, N'Kim', N'Lavoie', N'kimL', N'AIdyGgCVrbaYujsm+7+JVOtRIuc6RglkEgQX1Yn1qMyiANayHRtn8NLtTo63tYaz4A==', N'kimlavoie@cegepjonquiere.ca', 0, NULL, NULL, CAST(N'2016-10-26 16:30:07.823' AS DateTime), 1, 0, NULL, NULL, CAST(N'2016-10-26 16:30:07.823' AS DateTime), NULL, CAST(N'2016-10-26 16:30:07.777' AS DateTime), NULL,NULL,NULL,NULL),
(1, NULL, N'Jimmy', N'Maltais', N'jimmyM', N'AIdyGgCVrbaYujsm+7+JVOtRIuc6RglkEgQX1Yn1qMyiANayHRtn8NLtTo63tYaz4A==', N'jimmymaltais@cegepjonquiere.ca', 0, NULL, NULL, CAST(N'2016-10-26 16:30:07.823' AS DateTime), 1, 0, NULL, NULL, CAST(N'2016-10-26 16:30:07.823' AS DateTime), NULL, CAST(N'2016-10-26 16:30:07.777' AS DateTime), NULL,NULL,NULL,NULL),
(1, NULL, N'Vincent', N'Morin', N'vincentM', N'AIdyGgCVrbaYujsm+7+JVOtRIuc6RglkEgQX1Yn1qMyiANayHRtn8NLtTo63tYaz4A==', N'vincentmorin@cegepjonquiere.ca', 0, NULL, NULL, CAST(N'2016-10-26 16:30:07.823' AS DateTime), 1, 0, NULL, NULL, CAST(N'2016-10-26 16:30:07.823' AS DateTime), NULL, CAST(N'2016-10-26 16:30:07.777' AS DateTime), NULL,NULL,NULL,NULL),
(1, NULL, N'Michel', N'Payette', N'michelP', N'AIdyGgCVrbaYujsm+7+JVOtRIuc6RglkEgQX1Yn1qMyiANayHRtn8NLtTo63tYaz4A==', N'michelpayette@cegepjonquiere.ca', 0, NULL, NULL, CAST(N'2016-10-26 16:30:07.823' AS DateTime), 1, 0, NULL, NULL, CAST(N'2016-10-26 16:30:07.823' AS DateTime), NULL, CAST(N'2016-10-26 16:30:07.777' AS DateTime), NULL,NULL,NULL,NULL),
(1, NULL, N'Aymen', N'Sioud', N'aymenS', N'AIdyGgCVrbaYujsm+7+JVOtRIuc6RglkEgQX1Yn1qMyiANayHRtn8NLtTo63tYaz4A==', N'aymensioud@cegepjonquiere.ca', 0, NULL, NULL, CAST(N'2016-10-26 16:30:07.823' AS DateTime), 1, 0, NULL, NULL, CAST(N'2016-10-26 16:30:07.823' AS DateTime), NULL, CAST(N'2016-10-26 16:30:07.777' AS DateTime), NULL,NULL,NULL,NULL);
GO

UPDATE S_evenement.tblActivite SET noUtilisateur = ABS(2 + ((CAST(ABS(CHECKSUM(NEWID())) % 101 AS FLOAT) / 100) * 9)) WHERE noActivite IN
(
    SELECT TOP 100 PERCENT noActivite FROM S_evenement.tblActivite ORDER BY NEWID()
)

GO

PRINT('Fin de l''ajout de FK dans la table activite')
