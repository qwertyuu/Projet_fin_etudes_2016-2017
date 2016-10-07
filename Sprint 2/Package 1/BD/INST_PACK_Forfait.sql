--But: Création des insertions des tables du package Forfait.
--Date:05-10-2016
--Par: Simon Girard


use PE2_Officiel

INSERT INTO S_forfait.tblSalle (nomSalle,prix,billet,billetVIP,photoSalle,dateSupprime,urlGoogleMap)
VALUES('Salle François Brassard',1000,700,60,null,null,null);
VALUES('Salle Polyvalente',300,200,30,null,null,null);
VALUES('Salle Pierrette Gaudreault',750,500,50,null,'2015/05/03',null);

INSERT INTO S_forfait.tblForfait (nom,description,dateSupprime)
VALUES('Age','Rabais selon les tranches d''âges des billets',null);
VALUES('Prévente','Billet vendu d''avance a rabais',null);
VALUES('Souper Spectacle','Souper disponibles sur place',null);
VALUES('Promotions','Billet à rabais ou donnés dans un concours',null);
VALUES('Alcool','Alcool à volonté, rajouter 40$ aux prix','2015/10/31');

INSERT INTO S_forfait.tblService(nomService,dateSupprime)
VALUES('Restaurant',null);
VALUES('Bar',null);
VALUES('Techniciens',null);
VALUES('Grande scène',null);
VALUES('Filets pour acrobates',null);

INSERT INTO S_forfait.tblServiceOffert(noService,noSalle)
VALUES(3,1);
VALUES(4,1);
VALUES(5,1);
VALUES(1,2);
VALUES(2,2);
VALUES(3,2);
VALUES(5,2);


INSERT INTO S_forfait.tblServiceRequis(noService,noSousEvenement)
VALUES(1,1);
VALUES(1,2);
VALUES(1,3);
VALUES(2,4);
VALUES(2,5);
VALUES(2,6);
VALUES(3,7);
VALUES(3,8);
VALUES(3,9);
VALUES(3,1);
VALUES(3,2);
VALUES(3,3);
VALUES(4,1);
VALUES(4,2);
VALUES(4,3);
VALUES(5,10);
VALUES(5,11);
VALUES(1,12);
VALUES(2,12);
VALUES(3,12);
VALUES(5,12);
VALUES(1,13);
VALUES(2,13);
VALUES(3,13);
VALUES(5,13);


INSERT INTO S_forfait.tblForfaitSousEvenement (noForfait,noSousEvenement)
VALUES(4,1);
VALUES(4,2);
VALUES(4,3);
VALUES(5,10);
VALUES(5,11);
VALUES(1,12);
VALUES(2,12);
VALUES(3,12);
VALUES(5,12);
VALUES(1,13);
VALUES(2,13);
VALUES(3,13);
VALUES(5,13);