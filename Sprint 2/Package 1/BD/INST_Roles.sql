USE [PE2_Officiel]
GO
INSERT [dbo].[AbpRoles] ([TenantId], [Name], [DisplayName], [IsStatic], [IsDefault], [IsDeleted], [CreationTime]) 
VALUES 
-- admin 2 
(1, 'Agent', 'Agent', 1, 0, 0, '2016-11-03'),--3
(1, 'AgentSenior', 'AgentSenior', 1, 0, 0, '2016-11-03'),--4
(1, 'Representant', 'Representant', 1, 0, 0, '2016-11-03')--5
GO
INSERT [dbo].[AbpPermissions] ([TenantId], [RoleId], [Name], [IsGranted], [CreationTime], [Discriminator]) 
VALUES
(1, 2, 'GererEvenement', 1, '2016-11-03', 'RolePermissionSetting'),
(1, 3, 'CreerAppelOffre', 1, '2016-11-03', 'RolePermissionSetting'),
(1, 3, 'ConsulterAppelOffre', 1, '2016-11-03', 'RolePermissionSetting'),
(1, 3, 'ConsulterSoumission', 1, '2016-11-03', 'RolePermissionSetting'),
(1, 4, 'CreerAppelOffre', 1, '2016-11-03', 'RolePermissionSetting'),
(1, 4, 'ApprouverSoumission', 1, '2016-11-03', 'RolePermissionSetting'),
(1, 4, 'ConsulterAppelOffre', 1, '2016-11-03', 'RolePermissionSetting'),
(1, 4, 'ConsulterSoumission', 1, '2016-11-03', 'RolePermissionSetting'),
(1, 4, 'CreerMemo', 1, '2016-11-03', 'RolePermissionSetting'),
(1, 5, 'GererCommanditaire', 1, '2016-11-03', 'RolePermissionSetting'),
(1, 5, 'GererDon', 1, '2016-11-03', 'RolePermissionSetting'),
(1, 5, 'GererSousEvenement', 1, '2016-11-03', 'RolePermissionSetting'),
(1, 5, 'CreerMemo', 1, '2016-11-03', 'RolePermissionSetting'),
(1, 5, 'CreerSoumission', 1, '2016-11-03', 'RolePermissionSetting'),
(1, 5, 'GererSalle', 1, '2016-11-03', 'RolePermissionSetting')
GO