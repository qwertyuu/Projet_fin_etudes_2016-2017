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
('Salle Pierrette Gaudreault',750,500,50,'http://diffusion.saguenay.ca/wp-content/uploads/2016/10/pierrette-gaudreault-plan-de-salle.jpg',null,'https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d7490.843849969319!2d-71.26963707816424!3d48.41021028620453!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x8a28e75e909e7336!2sCentre+Culturel+Mont+Jacob!5e0!3m2!1sen!2sca!4v1478536664327'),
('Place Nikitoutagan',3000,1000,100,'http://magasin.skivr.com/133-1792-thickbox/option-marque-blanche-pour-krpano.jpg',null,'https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2648.6453269213494!2d-71.24667188474935!3d48.405753937193936!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x2dd30e450fd3bd83!2zQ8OpZ2VwIGRlIEpvbnF1acOocmU!5e0!3m2!1sfr!2sca!4v1476204181668'),
('Place du vieux port',5000,1500,200,'http://magasin.skivr.com/133-1792-thickbox/option-marque-blanche-pour-krpano.jpg',null,'<iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2647.416769891239!2d-71.06205588434075!3d48.42934037924776!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x4cc0274e76118ab3%3A0x83d03ed86cb18f0!2sZone+portuaire+de+Chicoutimi!5e0!3m2!1sen!2sca!4v1481746487800'),
('Salle la petite grenouille',1500,300,30,null,2015/10/31,null);
GO
PRINT 'INSERTION RÉUSSI'

PRINT('Ajout de FK vers les salles dans la table sous-evenement')

GO

UPDATE S_evenement.tblSousEvenement SET noSalle = ABS(1 + ((CAST(ABS(CHECKSUM(NEWID())) % 101 AS FLOAT) / 100) * 5)) WHERE noSousEvenement IN
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
('Loges',null);
GO
PRINT 'INSERTION RÉUSSI'
PRINT 'INSERTION DE LA tblServiceOffert'
GO
INSERT INTO S_forfait.tblServiceOffert(noService,noSalle)
VALUES
(3,1),
(4,1),
(5,1),
(1,2),
(2,2),
(3,2),
(5,2),
(1,3),
(2,3),
(3,3),
(4,3),
(5,3),
(3,4),
(4,4),
(3,5),
(4,5);
GO
PRINT 'INSERTION RÉUSSI'
PRINT 'INSERTION DE LA tblServiceRequis'
GO
INSERT INTO S_forfait.tblServiceRequis(noService,noSousEvenement)
VALUES
(1,1),
(1,2),
(1,3),
(2,3),
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
(5,13),
(1,14),
(2,14),
(3,15),
(5,16),
(1,17),
(2,18),
(3,19),
(1,20),
(2,20),
(3,20),
(4,20),
(5,20),
(5,21),
(4,22),
(2,23);
GO
PRINT 'INSERTION RÉUSSI'
PRINT 'INSERTION DE LA tblForfaitSousEvenement'
GO

INSERT INTO S_forfait.tblForfaitSousEvenement (noForfait,noSousEvenement)
VALUES
(1,1),
(4,1),
(4,4),
(4,3),
(2,3),
(1,3),
(2,4),
(4,5),
(2,5),
(4,6),
(2,6),
(1,8),
(3,11),
(1,12),
(2,12),
(3,12),
(4,12),
(1,13),
(2,13),
(3,13),
(4,13),
(1,14),
(2,14),
(3,16),
(4,16),
(1,17),
(2,18),
(3,18),
(4,18),
(1,19),
(2,19),
(3,19),
(4,19),
(1,20),
(2,20),
(3,20),
(4,20),
(1,22),
(1,23),
(2,23);
GO
PRINT 'INSERTION RÉUSSI'

PRINT 'INSERTION DE LA tblCalculateur'
GO
INSERT INTO S_forfait.tblCalculateur (noSousEvenement,billet,billetVIP,prixBillet,prixBilletVIP,souperSpectacle,prixSouper,jeunePourcent,adultePourcent,ainePourcent,jeuneRatio,adulteRatio,aineRatio,promo,prevente,customBillet1,customBillet2,customPrix1,customPrix2,customNom1,customNom2)
VALUES
(1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'',''),
(2,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'',''),
(3,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'',''),
(4,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'',''),
(5,5,0,5,0,0,0,0,0,0,50,30,20,0,0,0,0,0,0,'Rabais rue','Rabais internet'),
(6,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'',''),
(7,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'',''),
(8,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'',''),
(9,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'',''),
(10,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'',''),
(11,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'',''),
(12,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'',''),
(13,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'',''),
(14,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'',''),
(15,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'',''),
(16,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'',''),
(17,600,60,10,20,0,0,10,0,20,20,60,20,50,50,50,0,50,0,'Billet entrée',''),
(18,100,20,30,40,0,0,0,0,0,0,0,0,50,50,0,0,0,0,'',''),
(19,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'',''),
(20,100,20,30,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'',''),
(21,100,20,30,50,0,0,10,0,20,20,60,20,0,0,0,0,0,0,'',''),
(22,200,30,15,20,0,0,0,0,0,0,0,0,10,10,20,20,20,50,'Billet étudiants','Billet 50 à l''entrée'),
(23,500,60,20,30,0,0,15,0,30,20,70,10,0,0,0,0,0,0,'','');


GO
PRINT 'INSERTION RÉUSSI'

