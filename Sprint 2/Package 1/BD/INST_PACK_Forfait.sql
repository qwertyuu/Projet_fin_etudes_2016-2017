--But: Cr�ation des insertions des tables du package Forfait.
--Date:05-10-2016
--Par: Simon Girard


use PE2_Officiel
GO
PRINT 'INSERTION DE LA tblSalle'
GO
INSERT INTO S_forfait.tblSalle (nomSalle,prix,billet,billetVIP,photoSalle,dateSupprime,urlGoogleMap)
VALUES('Salle Fran�ois Brassard',1000,700,60,null,null,null),
('Salle Polyvalente',300,200,30,null,null,null),
('Salle Pierrette Gaudreault',750,500,50,null,'2015/05/03',null);
GO
PRINT 'INSERTION R�USSI'
PRINT 'INSERTION DE LA tblForfait'
GO
INSERT INTO S_forfait.tblForfait (nom,description,dateSupprime)
VALUES('Age','Rabais selon les tranches d''�ges des billets',null),
('Pr�vente','Billet vendu d''avance a rabais',null),
('Souper Spectacle','Souper disponibles sur place',null),
('Promotions','Billet � rabais ou donn�s dans un concours',null),
('Alcool','Alcool � volont�, rajouter 40$ aux prix','2015/10/31');
GO
PRINT 'INSERTION R�USSI'
PRINT 'INSERTION DE LA tblService'
GO
INSERT INTO S_forfait.tblService(nomService,dateSupprime)
VALUES('Restaurant',null),
('Bar',null),
('Techniciens',null),
('Grande sc�ne',null),
('Filets pour acrobates',null);
GO
PRINT 'INSERTION R�USSI'
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
PRINT 'INSERTION R�USSI'
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
PRINT 'INSERTION R�USSI'
PRINT 'INSERTION DE LA tblForfaitSousEvenement'
GO

INSERT INTO S_forfait.tblForfaitSousEvenement (noForfait,noSousEvenement)
VALUES(4,1),
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
PRINT 'INSERTION R�USSI'
GO