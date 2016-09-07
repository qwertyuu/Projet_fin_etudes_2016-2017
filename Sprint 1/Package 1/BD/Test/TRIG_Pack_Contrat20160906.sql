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
  DECLARE @nb INT, @dure VARCHAR(6),@nature VARCHAR(50),@heure TIME(7),@lieu TEXT
  SELECT @nb=COUNT(*) FROM S_Contrat.tblAgence
  SELECT @dure=duree,@nature=nature,@heure=heure, @lieu=lieu
  FROM S_Contrat.tblEngagement
  WHERE noEngagement=@nb
  INSERT INTO S_Contrat.vueSomEngagement()
  
END
GO