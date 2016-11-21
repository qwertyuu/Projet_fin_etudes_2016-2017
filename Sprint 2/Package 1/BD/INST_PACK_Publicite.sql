--Ce script permet d'insetion des tables dans le package publicite
--Fait par: Kevin Kuété Moffo
--En ce: 5 Octobre 2016
USE PE2_Officiel

INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Cervo Communications Inc');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Agence Polka');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Le Journal de Québec');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Média Touch Inc');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Diane Aubé Promotions');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Eureka Communication-Marketing');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Publicité JL');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Zed Productions');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Imperdiet Ullamcorper Consulting');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Jim & Jane Productions');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Platine Communication');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Auctor Corp.');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Mediative');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Le Groupe Madie Solution Publicite');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Unik Média');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Néo');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Doner Canada Inc');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Productions Ever Elle Inc');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Jim & Jane Productions');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Agence MAsse');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Le Groupe Madie Solution Publicite');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Tortor Corporation');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Multi-Services Prestige');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Côté Fleuve Inc');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Camélion Designer');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Publicar');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Indiana Sportswear');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Carnet Communication Marketing');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Communication Bon Retour');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('X-Prime Group');
PRINT 'Fin d''insertion de table tblAgencePublicite'

GO
INSERT INTO S_publicite.tblStatutAppelOffre(nom,couleur,description)VALUES('En Création','F90202','L''appel d''offre est en création et n''est pas encore envoyée à l''agence')
INSERT INTO S_publicite.tblStatutAppelOffre(nom,couleur,description)VALUES('Envoyé','022BF9','L''appel d''offre est envoyée à l''agence de publicité')
INSERT INTO S_publicite.tblStatutAppelOffre(nom,couleur,description)VALUES('Complété','DBF902','L''appel d''offre est complétée et une soumission est envoyée par l''agence')
INSERT INTO S_publicite.tblStatutAppelOffre(nom,couleur,description)VALUES('Annulé','0281F9','L''appel d''offre est annulé')
PRINT 'Fin d''insertion de table tblStatutAppelOffre'

GO
INSERT INTO S_publicite.tblMedia(nom,description)VALUES('Radio','la publicité sera communiqué au moyen de la radio');
INSERT INTO S_publicite.tblMedia([nom],[description]) VALUES('Blog','velit. Cras lorem lorem, luctus ut,');
INSERT INTO S_publicite.tblMedia(nom,description)VALUES('Télévision','la publicité sera communiqué au moyen de la télévision');
INSERT INTO S_publicite.tblMedia(nom,description)VALUES('Journal','la publicité sera communiquer au moyen des journaux');
INSERT INTO S_publicite.tblMedia(nom,description)VALUES('Réseaux sociaux','La publicité sera diffusée sur les réseaux sociaux comme Facebook, Twitter,...');
INSERT INTO S_publicite.tblMedia(nom,description)VALUES('Courrier','Des courriers seront envoyés aux commenditaires pour les remercier de leur don.');
INSERT INTO S_publicite.tblMedia(nom,description)VALUES('Affiche','Des affiches seront collés soit pour faire la promotion des artites ou des concours à venir.');
PRINT 'Fin d''insertion de table tblMedia'

GO
INSERT INTO S_publicite.tblAppelOffre([nom],[dateEnvoi],[dateRequis],[description],[noEvenement],[noStatut],noMedia) VALUES('Promotion sur les billets de spectacle','2016-04-05 17:07:42','2016-05-19 20:23:45','Cette publicité est faitre pour promouvoir les promotions et les rabais sur les billlets des spectacles.',10,3,1);
INSERT INTO S_publicite.tblAppelOffre([nom],[dateEnvoi],[dateRequis],[description],[noEvenement],[noStatut],noMedia) VALUES('Concours pour gagner des billets graduits','2016-03-29 14:31:19','2015-04-13 10:05:17','concours en vedette et courer la chance de gagner des billets graduits',6,2,3);
INSERT INTO S_publicite.tblAppelOffre([nom],[dateEnvoi],[dateRequis],[description],[noEvenement],[noStatut],noMedia) VALUES('Spectacle en feu','2016-08-29 11:45:41','2017-04-25 16:34:29','Repésente de spectacle de clôture',6,3,4);
INSERT INTO S_publicite.tblAppelOffre([nom],[dateEnvoi],[dateRequis],description,[noEvenement],[noStatut],noMedia) VALUES('Humoriste de l''année','2016-07-03 09:21:11','2017-07-19 16:08:04','Duis risus odio auctor vitae aliquet nec imperdiet nec, leo Morbi neque tellus imperdiet non vestibulum nec, euismod  dolor. Fusce feugiat',2,3,5);
INSERT INTO S_publicite.tblAppelOffre([nom],[dateEnvoi],[dateRequis],[description],[noEvenement],[noStatut],noMedia) VALUES('Meilleur artiste du spectacle','2016-06-27 03:25:34','2016-02-05 23:23:27','Permt de savoir le meilleur artiste du spectacle',10,1,2);
INSERT INTO S_publicite.tblAppelOffre([nom],[dateEnvoi],[dateRequis],description,[noEvenement],[noStatut],noMedia) VALUES('Spectacle en joie','2016-01-17 07:22:52','2016-02-08 09:51:21','tristique aliquet. Phasellus fermentum convallis ligula. Donec luctus aliquet odio. Etiam ligula tortor, dictum eu, placerat eget, venenatis a, magna. Lorem ipsum dolor sit amet',2,1,3);
INSERT INTO S_publicite.tblAppelOffre([nom],[dateEnvoi],[dateRequis],[description],[noEvenement],[noStatut],noMedia) VALUES('Promotion des places','2016-07-09 14:09:06','2016-11-14 08:19:39','Faire la publicité sur differentes places',1,4,5);
INSERT INTO S_publicite.tblAppelOffre([nom],[dateEnvoi],[dateRequis],[description],[noEvenement],[noStatut],noMedia) VALUES('Promotion de fin de spectacle','2015-10-23 09:55:54','2017-07-06 02:22:27','Savoir les differentes promotions de la fin du spectacle',7,2,1);
INSERT INTO S_publicite.tblAppelOffre([nom],[dateEnvoi],[dateRequis],[description],[noEvenement],[noStatut],noMedia) VALUES('Publicité du souper de fin de spectacle','2016-03-20 21:22:45','2015-12-01 18:52:02','Faire la publicité de l''évènement',4,2,2);
INSERT INTO S_publicite.tblAppelOffre([nom],[dateEnvoi],[dateRequis],description,[noEvenement],[noStatut],noMedia) VALUES('Promotion des artistes','2016-04-05 10:01:15','2017-02-25 04:34:45','Cette publicité permet de faire savoir les artistes du spectacle',1,1,4);
INSERT INTO S_publicite.tblAppelOffre([nom],[dateEnvoi],[dateRequis],description, [noEvenement],[noStatut],noMedia) VALUES('Promotions des auberges','2016-12-12 23:45:29','2017-06-11 21:47:20','Cette publicité rend compte des prix et rabais des auberges',8,2,1);
INSERT INTO S_publicite.tblAppelOffre([nom],[dateEnvoi],[dateRequis],description, [noEvenement],[noStatut],noMedia) VALUES('Promtion des places de spectacles','2016-12-24 15:45:29','2017-06-11 21:47:20','Cette publicité fait la promotion des bonnes places du spectacle',4,1,3);
INSERT INTO S_publicite.tblAppelOffre([nom],[dateEnvoi],[dateRequis],description, [noEvenement],[noStatut],noMedia) VALUES('Publicité de début de spectacle','2016-12-24 12:45:29','2016-12-11 16:47:00','Cette publicité fait la promotion des bonnes places du spectacle',4,1,3);
PRINT 'Fin d''insertion de table tblAppelOffre'

GO
INSERT INTO S_publicite.tblSoumission(noSoumissionAgence,prix,statut,commentaire,dateSupprime,[noAgencePub],[noAppelOffre]) VALUES(NULL,87.74,1,'Cette soumission permet de faire la promotion billets  de spectacle auprès des agences de publicité et elle doit être répondu le plutôt posiblle',NULL,4,1);
INSERT INTO S_publicite.tblSoumission(noSoumissionAgence,prix,statut,commentaire,dateSupprime,[noAgencePub],[noAppelOffre]) VALUES(NULL, 90.05,0,'leo. Vivamus nibh dolor, nonummy ac, feugiat non, lobortis quis, pede. Suspendisse dui. Fusce diam nunc, ullamcorper eu, euismod ac, fermentum vel, mauris. Integer sem',NULL,5,3);
INSERT INTO S_publicite.tblSoumission(noSoumissionAgence,prix,statut,commentaire,dateSupprime,[noAgencePub],[noAppelOffre])  VALUES(NULL,150.38,1,'erat volutpat. Nulla facilisis. Suspendisse commodo tincidunt nibh. Phasellus',NULL,1,3);
INSERT INTO S_publicite.tblSoumission(noSoumissionAgence,prix,statut,commentaire,dateSupprime,[noAgencePub],[noAppelOffre])  VALUES(NULL,199.90,0,'dictum sapien. Aenean massa. Integer vitae',NULL,10,1);
INSERT INTO S_publicite.tblSoumission(noSoumissionAgence,prix,statut,commentaire,dateSupprime,[noAgencePub],[noAppelOffre]) VALUES(NULL,300.03,0,'Cette soumission permet de faire la promotion des artites  du festival auprès des agences de publicité et elle doit être répondu le plutôt dans les heures qui suivent',null,10,7);
INSERT INTO S_publicite.tblSoumission(noSoumissionAgence,prix,statut,commentaire,dateSupprime,[noAgencePub],[noAppelOffre])  VALUES(NULL,600.79,0,'sed leo. Cras vehicula aliquet libero. Integer in magna.',NULL,1,1);
INSERT INTO S_publicite.tblSoumission(noSoumissionAgence,prix,statut,commentaire,dateSupprime,[noAgencePub],[noAppelOffre])  VALUES(NULL,987.02,null,'non lorem vitae odio sagittis semper. Nam tempor diam dictum sapien. Aenean massa. Integer vitae nibh. Donec est mauris, rhoncus id, mollis nec, cursus a',NULL,7,2);
INSERT INTO S_publicite.tblSoumission(noSoumissionAgence,prix,statut,commentaire,dateSupprime,[noAgencePub],[noAppelOffre]) VALUES(NULL,540.94,1,'Cette soumission permet de faire la publicité de l''humoriste de l''année auprès des agences de publicité et elle doit être répondu le plutôt posiblle',NULL,3,4);
INSERT INTO S_publicite.tblSoumission(noSoumissionAgence,prix,statut,commentaire, dateSupprime,[noAgencePub],[noAppelOffre])  VALUES(NULL,984.88,null,'Integer sem elit, pharetra ut, pharetra sed, hendrerit a, arcu. Sed et libero. Proin mi. Aliquam gravida mauris ut mi. Duis risus odio, auctor vitae',null,1,2);
INSERT INTO S_publicite.tblSoumission(noSoumissionAgence,prix,statut,commentaire,dateSupprime,[noAgencePub],[noAppelOffre]) VALUES(NULL,1000.79,0,'suscipit nonummy. Fusce fermentum fermentum arcu. Vestibulum',NULL,2,11);
INSERT INTO S_publicite.tblSoumission(noSoumissionAgence,prix,statut,commentaire,dateSupprime,[noAgencePub],[noAppelOffre]) VALUES('PPL',100.99,0,'morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aliquam fringilla cursus purus. Nullam scelerisque neque sed sem egestas blandit. Nam nulla magna',NULL,7,1);
INSERT INTO S_publicite.tblSoumission(noSoumissionAgence,prix,statut,commentaire, dateSupprime,[noAgencePub],[noAppelOffre])  VALUES('JOURQC',454.88,0,'Integer sem elit, pharetra ut, pharetra sed, hendrerit a, arcu. Sed et libero. Proin mi. Aliquam gravida mauris ut mi. Duis risus odio, auctor vitae',null,3,9);
INSERT INTO S_publicite.tblSoumission(noSoumissionAgence,prix,statut,commentaire,dateSupprime,[noAgencePub],[noAppelOffre]) VALUES('JIMES&JAN',390.79,null,'scelerisque scelerisque dui. Suspendisse ac metus vitae velit egestas lacinia. Sed congue, elit sed consequat auctor, nunc nulla vulputate dui, nec tempus mauris erat eget',NULL,10,8);
PRINT 'Fin d''insertion de table tblSoumission'
GO



