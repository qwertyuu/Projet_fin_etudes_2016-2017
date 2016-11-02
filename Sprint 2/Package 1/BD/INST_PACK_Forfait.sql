--But: Création des insertions des tables du package Forfait.
--Date:05-10-2016
--Par: Simon Girard


use PE2_Officiel
GO
PRINT 'INSERTION DE LA tblSalle'
GO
INSERT INTO S_forfait.tblSalle (nomSalle,prix,billet,billetVIP,photoSalle,dateSupprime,urlGoogleMap)
VALUES('Salle François Brassard',1000,700,60,'http://i.imgur.com/qcfbNLq.png',null,'https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2648.6453269213494!2d-71.24667188474935!3d48.405753937193936!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x2dd30e450fd3bd83!2zQ8OpZ2VwIGRlIEpvbnF1acOocmU!5e0!3m2!1sfr!2sca!4v1476204181668'),
('Salle Polyvalente',300,200,30,'http://i.imgur.com/2VxTEYs.png',null,'https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2648.6453269213494!2d-71.24667188474935!3d48.405753937193936!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x2dd30e450fd3bd83!2zQ8OpZ2VwIGRlIEpvbnF1acOocmU!5e0!3m2!1sfr!2sca!4v1476204181668'),
('Salle Pierrette Gaudreault',750,500,50,null,'2015/05/03',null);
GO
PRINT 'INSERTION RÉUSSI'

PRINT('Ajout de FK vers les salles dans la table sous-evenement')

GO

UPDATE S_evenement.tblSousEvenement SET noSalle = ABS(1 + ((CAST(ABS(CHECKSUM(NEWID())) % 101 AS FLOAT) / 100) * 2)) WHERE noSousEvenement IN
(
    SELECT TOP 75 PERCENT noSousEvenement FROM S_evenement.tblSousEvenement ORDER BY NEWID()
)

GO
PRINT('Fin de l''ajout de FK vers les salles dans la table sous-evenement')


PRINT 'INSERTION DE LA tblForfait'
GO
INSERT INTO S_forfait.tblForfait (nom,description,dateSupprime)
VALUES('Tranche d''age','Rabais selon les tranches d''âges des billets',null),
('Souper Spectacle','Souper disponibles sur place',null),
('Réductions','Billet à rabais ou donnés dans un concours',null),
('Alcool','Alcool à volonté, rajouter 40$ aux prix','2015/10/31');
GO
PRINT 'INSERTION RÉUSSI'
PRINT 'INSERTION DE LA tblService'
GO
INSERT INTO S_forfait.tblService(nomService,dateSupprime)
VALUES('Restaurant',null),
('Bar',null),
('Techniciens',null),
('Grande scène',null),
('Filets pour acrobates',null);
GO
PRINT 'INSERTION RÉUSSI'
PRINT 'INSERTION DE LA tblServiceOffert'
GO
INSERT INTO S_forfait.tblServiceOffert(noService,noSalle)
VALUES(3,1),
(4,1),
(5,1),
(1,2),
(2,2),
(3,2),
(5,2);

GO
PRINT 'INSERTION RÉUSSI'
PRINT 'INSERTION DE LA tblServiceRequis'
GO
INSERT INTO S_forfait.tblServiceRequis(noService,noSousEvenement)
VALUES(1,1),
(1,2),
(1,3),
(2,4),
(2,5),
(2,6),
(3,7),
(3,8),
(3,9),
(3,1),
(3,2),
(3,3),
(4,1),
(4,2),
(4,3),
(5,10),
(5,11),
(1,12),
(2,12),
(3,12),
(5,12),
(1,13),
(2,13),
(3,13),
(5,13);
GO
PRINT 'INSERTION RÉUSSI'
PRINT 'INSERTION DE LA tblForfaitSousEvenement'
GO

INSERT INTO S_forfait.tblForfaitSousEvenement (noForfait,noSousEvenement)
VALUES(4,1),
(4,2),
(4,3),
(2,10),
(3,11),
(1,12),
(2,12),
(3,12),
(4,12),
(1,13),
(2,13),
(3,13),
(4,13);

GO
PRINT 'INSERTION RÉUSSI'

