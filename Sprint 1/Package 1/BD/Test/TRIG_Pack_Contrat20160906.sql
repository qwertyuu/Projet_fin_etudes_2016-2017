--But: Création des triggers et fonctions stockés du package Contrat.
--Date:06-09-2016
--Par: Kevin Kuété Moffo

USE PE2_Test
GO

CREATE FUNCTION 

CREATE TRIGGER Ins_vueSomContrat ON S_Contrat.tblAgence
AFTER INSERT
AS
BEGIN
  DECLARE @nomAgen VARCHAR(50)
  SELECT @nomAgen=nom from S_Contrat.tblAgence 
  INSERT INTO S_Contrat.vueSomContrat
  SELECT S_Contrat.tblAgence.nom
END
GO

CREATE TRIGGER Ins_vueSomEngagement ON S_Contrat.tblEngagement
AFTER INSERT
AS
BEGIN
  delete from S_Contrat.vueSomEngagement
  DBCC CHECKIDENT ('S_Contrat.vueSomEngagement', RESEED, 1)
  INSERT INTO S_Contrat.vueSomEngagement
  SELECT *FROM S_Contrat.tblEngagement
  END
GO


  DECLARE @nb INT, @dure VARCHAR(6),@nature VARCHAR(50),@heure TIME(7),@lieu varchar(max),@date DATE, @noCon VARCHAR(20)
  SELECT @nb=COUNT(*) FROM S_Contrat.tblAgence
  SELECT @dure=duree,@nature=nature,@heure=heure, @lieu=lieu, @date=date,@noCon=noContrat
  FROM S_Contrat.tblEngagement
  WHERE noEngagement=@nb
  INSERT INTO S_Contrat.vueSomEngagement(nature,date,heure,duree,lieu,noContrat) VALUES(@nature,@date,@heure,@dure,@lieu,@noCon) 
  
END
GO
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime) VALUES ('Voonyx27','Voonyx', 'valvarez0@umn.edu', null);
INSERT INTO S_Contrat.tblStatut (nomStatut, description, couleur, dateSupprime) VALUES ('Terminé', 'Le contrat a été réalisé et est archivé', 'df6c25', null);
INSERT INTO S_Contrat.tblContrat (noContrat, lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('CH-001', 'Chicoutimi', 'Musique d''ouverture des spectacles de la semaine 1', 'L''orchestre du conservatoire pour l''ouverture des show d''humour', null, null, 1, 'Voonyx27'); 
INSERT INTO S_Contrat.tblEngagement([duree],[lieu],[date],[heure],[nature],[commentaire],[description],[descriptionCourte],[dateSupprime],[noContrat]) VALUES('3h00','Jonquière','2017/02/07','01:07:49','Levée de fonds',null,null,null,null,'CH-001');
select * from S_Contrat.tblEngagement
select * from S_Contrat.vueSomEngagement
delete from S_Contrat.tblEngagement
DBCC CHECKIDENT ('S_Contrat.tblEngagement', RESEED, 1)