--Ce script permet d'insetion des tables dans le package publicite
--Fait par: Kevin Ku�t� Moffo
--En ce: 5 Octobre 2016
USE PE2_Officiel

INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Cervo Communications Inc');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Agence Polka');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Le Journal de Qu�bec');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('M�dia Touch Inc');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Diane Aub� Promotions');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Eureka Communication-Marketing');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Publicit� JL');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Zed Productions');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Imperdiet Ullamcorper Consulting');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Jim & Jane Productions');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Platine Communication');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Auctor Corp.');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Mediative');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Le Groupe Madie Solution Publicite');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Unik M�dia');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('N�o');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Doner Canada Inc');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Productions Ever Elle Inc');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Jim & Jane Productions');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Agence MAsse');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Le Groupe Madie Solution Publicite');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Tortor Corporation');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Multi-Services Prestige');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('C�t� Fleuve Inc');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Cam�lion Designer');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Publicar');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Indiana Sportswear');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Carnet Communication Marketing');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Communication Bon Retour');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('X-Prime Group');
PRINT 'Fin d''insertion de table tblAgencePublicite'

GO
INSERT INTO S_publicite.tblStatutAppelOffre(nom,couleur,description)VALUES('En Cr�ation','F90202','L''appel d''offre est en cr�ation et n''est pas encore envoy�e � l''agence')
INSERT INTO S_publicite.tblStatutAppelOffre(nom,couleur,description)VALUES('Envoy�','022BF9','L''appel d''offre est envoy�e � l''agence de publicit�')
INSERT INTO S_publicite.tblStatutAppelOffre(nom,couleur,description)VALUES('Compl�t�','DBF902','L''appel d''offre est compl�t�e et une soumission est envoy�e par l''agence')
INSERT INTO S_publicite.tblStatutAppelOffre(nom,couleur,description)VALUES('Annul�','4B0082','L''appel d''offre est annul�')
PRINT 'Fin d''insertion de table tblStatutAppelOffre'

GO
INSERT INTO S_publicite.tblMedia(nom,description)VALUES('Radio','la publicit� sera communiqu� au moyen de la radio');
INSERT INTO S_publicite.tblMedia([nom],[description]) VALUES('Blog','velit. Cras lorem lorem, luctus ut,');
INSERT INTO S_publicite.tblMedia(nom,description)VALUES('T�l�vision','la publicit� sera communiqu� au moyen de la t�l�vision');
INSERT INTO S_publicite.tblMedia(nom,description)VALUES('Journal','la publicit� sera communiquer au moyen des journaux');
INSERT INTO S_publicite.tblMedia(nom,description)VALUES('R�seaux sociaux','La publicit� sera diffus�e sur les r�seaux sociaux comme Facebook, Twitter,...');
INSERT INTO S_publicite.tblMedia(nom,description)VALUES('Courrier','Des courriers seront envoy�s aux commenditaires pour les remercier de leur don.');
INSERT INTO S_publicite.tblMedia(nom,description)VALUES('Affiche','Des affiches seront coll�s soit pour faire la promotion des artites ou des concours � venir.');
PRINT 'Fin d''insertion de table tblMedia'

GO
INSERT INTO S_publicite.tblAppelOffre([nom],[dateEnvoi],[dateRequis],[description],[noEvenement],[noStatut],noMedia) VALUES('Promotion sur les billets de spectacle','2016-04-05 17:07:42','2016-05-19 20:23:45','Cette publicit� est faitre pour promouvoir les promotions et les rabais sur les billlets des spectacles.',1,3,1);
INSERT INTO S_publicite.tblAppelOffre([nom],[dateEnvoi],[dateRequis],[description],[noEvenement],[noStatut],noMedia) VALUES('Concours pour gagner des billets graduits','2016-03-29 14:31:19','2017-04-13 10:05:17','concours en vedette et courer la chance de gagner des billets graduits',2,2,3);
INSERT INTO S_publicite.tblAppelOffre([nom],[dateEnvoi],[dateRequis],[description],[noEvenement],[noStatut],noMedia) VALUES('Spectacle en feu','2016-08-29 11:45:41','2017-04-25 16:34:29','Rep�sente de spectacle de cl�ture',3,3,4);
INSERT INTO S_publicite.tblAppelOffre([nom],[dateEnvoi],[dateRequis],description,[noEvenement],[noStatut],noMedia) VALUES('Humoriste de l''ann�e','2016-07-03 09:21:11','2017-07-19 16:08:04','Duis risus odio auctor vitae aliquet nec imperdiet nec, leo Morbi neque tellus imperdiet non vestibulum nec, euismod  dolor. Fusce feugiat',4,3,5);
INSERT INTO S_publicite.tblAppelOffre([nom],[dateEnvoi],[dateRequis],[description],[noEvenement],[noStatut],noMedia) VALUES('Meilleur artiste du spectacle','2016-06-27 03:25:34','2016-09-05 23:23:27','Permt de savoir le meilleur artiste du spectacle',5,1,2);
INSERT INTO S_publicite.tblAppelOffre([nom],[dateEnvoi],[dateRequis],description,[noEvenement],[noStatut],noMedia) VALUES('Spectacle en joie','2016-01-17 07:22:52','2016-02-08 09:51:21','tristique aliquet. Phasellus fermentum convallis ligula. Donec luctus aliquet odio. Etiam ligula tortor, dictum eu, placerat eget, venenatis a, magna. Lorem ipsum dolor sit amet',6,1,3);
INSERT INTO S_publicite.tblAppelOffre([nom],[dateEnvoi],[dateRequis],[description],[noEvenement],[noStatut],noMedia) VALUES('Promotion des places','2016-07-09 14:09:06','2016-11-14 08:19:39','Faire la publicit� sur differentes places',7,4,5);
INSERT INTO S_publicite.tblAppelOffre([nom],[dateEnvoi],[dateRequis],[description],[noEvenement],[noStatut],noMedia) VALUES('Promotion de fin de spectacle','2016-10-23 09:55:54','2017-07-06 02:22:27','Savoir les differentes promotions de la fin du spectacle',7,2,1);
INSERT INTO S_publicite.tblAppelOffre([nom],[dateEnvoi],[dateRequis],[description],[noEvenement],[noStatut],noMedia) VALUES('Publicit� du souper de fin de spectacle','2016-03-20 21:22:45','2016-12-01 18:52:02','Faire la publicit� de l''�v�nement',8,2,2);
INSERT INTO S_publicite.tblAppelOffre([nom],[dateEnvoi],[dateRequis],description, [noEvenement],[noStatut],noMedia) VALUES('Promotions des auberges','2016-12-12 23:45:29','2017-01-11 21:47:20','Cette publicit� rend compte des prix et rabais des auberges',8,1,1);
INSERT INTO S_publicite.tblAppelOffre([nom],[dateEnvoi],[dateRequis],description, [noEvenement],[noStatut],noMedia) VALUES('Promtion des places de spectacles','2016-12-24 15:45:29','2017-06-11 21:47:20','Cette publicit� fait la promotion des bonnes places du spectacle',3,2,3);
INSERT INTO S_publicite.tblAppelOffre([nom],[dateEnvoi],[dateRequis],description, [noEvenement],[noStatut],noMedia) VALUES('Publicit� de d�but de spectacle','2016-12-24 12:45:29','2017-03-11 16:47:00','Cette publicit� fait la promotion des bonnes places du spectacle',4,1,3);
PRINT 'Fin d''insertion de table tblAppelOffre'

GO
INSERT INTO S_publicite.tblSoumission(noSoumissionAgence,prix,statut,commentaire,dateEnvoi,dateReponse,dateSupprime,[noAgencePub],[noAppelOffre]) VALUES(NULL,87.74,1,'Cette soumission permet de faire la promotion billets  de spectacle aupr�s des agences de publicit� et elle doit �tre r�pondu le plut�t posiblle','2016-04-05 17:07:42','2016-08-05 19:07:42',NULL,4,1);
INSERT INTO S_publicite.tblSoumission(noSoumissionAgence,prix,statut,commentaire,dateEnvoi,dateReponse,dateSupprime,[noAgencePub],[noAppelOffre]) VALUES(NULL, 90.05,0,'leo. Vivamus nibh dolor, nonummy ac, feugiat non, lobortis quis, pede. Suspendisse dui. Fusce diam nunc, ullamcorper eu, euismod ac, fermentum vel, mauris. Integer sem','2016-08-29 11:45:41',NULL,NULL,5,3);
INSERT INTO S_publicite.tblSoumission(noSoumissionAgence,prix,statut,commentaire,dateEnvoi,dateReponse,dateSupprime,[noAgencePub],[noAppelOffre])  VALUES(NULL,150.38,1,'erat volutpat. Nulla facilisis. Suspendisse commodo tincidunt nibh. Phasellus','2016-08-29 11:45:41','2016-12-29 11:45:41',NULL,1,3);
INSERT INTO S_publicite.tblSoumission(noSoumissionAgence,prix,statut,commentaire,dateEnvoi,dateReponse,dateSupprime,[noAgencePub],[noAppelOffre])  VALUES(NULL,199.90,0,'dictum sapien. Aenean massa. Integer vitae','2016-04-05 17:07:42',NULL,NULL,10,1);
INSERT INTO S_publicite.tblSoumission(noSoumissionAgence,prix,statut,commentaire,dateEnvoi,dateReponse,dateSupprime,[noAgencePub],[noAppelOffre]) VALUES(NULL,300.03,0,'Cette soumission permet de faire la promotion des artites  du festival aupr�s des agences de publicit� et elle doit �tre r�pondu le plut�t dans les heures qui suivent','2016-07-09 14:09:06',NULL,null,10,7);
INSERT INTO S_publicite.tblSoumission(noSoumissionAgence,prix,statut,commentaire,dateEnvoi,dateReponse,dateSupprime,[noAgencePub],[noAppelOffre])  VALUES(NULL,600.79,0,'sed leo. Cras vehicula aliquet libero. Integer in magna.','2016-04-05 17:07:42',NULL,NULL,1,1);
INSERT INTO S_publicite.tblSoumission(noSoumissionAgence,prix,statut,commentaire,dateEnvoi,dateReponse,dateSupprime,[noAgencePub],[noAppelOffre])  VALUES(NULL,987.02,null,'non lorem vitae odio sagittis semper. Nam tempor diam dictum sapien. Aenean massa. Integer vitae nibh. Donec est mauris, rhoncus id, mollis nec, cursus a','2016-07-09 14:09:06',NULL,NULL,7,2);
INSERT INTO S_publicite.tblSoumission(noSoumissionAgence,prix,statut,commentaire,dateEnvoi,dateReponse,dateSupprime,[noAgencePub],[noAppelOffre]) VALUES(NULL,540.94,1,'Cette soumission permet de faire la publicit� de l''humoriste de l''ann�e aupr�s des agences de publicit� et elle doit �tre r�pondu le plut�t posiblle','2016-07-03 09:21:11',NULL,NULL,3,4);
INSERT INTO S_publicite.tblSoumission(noSoumissionAgence,prix,statut,commentaire,dateEnvoi,dateReponse,dateSupprime,[noAgencePub],[noAppelOffre])  VALUES(NULL,984.88,null,'Integer sem elit, pharetra ut, pharetra sed, hendrerit a, arcu. Sed et libero. Proin mi. Aliquam gravida mauris ut mi. Duis risus odio, auctor vitae','2016-03-29 14:31:19',null,null,1,2);
INSERT INTO S_publicite.tblSoumission(noSoumissionAgence,prix,statut,commentaire,dateEnvoi,dateReponse,dateSupprime,[noAgencePub],[noAppelOffre]) VALUES(NULL,1000.79,0,'suscipit nonummy. Fusce fermentum fermentum arcu. Vestibulum','2016-12-12 23:45:29','2017-02-12 10:45:29',NULL,2,11);
INSERT INTO S_publicite.tblSoumission(noSoumissionAgence,prix,statut,commentaire,dateEnvoi,dateReponse,dateSupprime,[noAgencePub],[noAppelOffre]) VALUES('PPL',100.99,0,'morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aliquam fringilla cursus purus. Nullam scelerisque neque sed sem egestas blandit. Nam nulla magna','2016-04-05 17:07:42',NULL,NULL,7,1);
INSERT INTO S_publicite.tblSoumission(noSoumissionAgence,prix,statut,commentaire,dateEnvoi,dateReponse, dateSupprime,[noAgencePub],[noAppelOffre])  VALUES('JOURQC',454.88,0,'Integer sem elit, pharetra ut, pharetra sed, hendrerit a, arcu. Sed et libero. Proin mi. Aliquam gravida mauris ut mi. Duis risus odio, auctor vitae','2016-03-20 21:22:45','2016-07-20 15:22:45',null,3,9);
INSERT INTO S_publicite.tblSoumission(noSoumissionAgence,prix,statut,commentaire,dateEnvoi,dateReponse,dateSupprime,[noAgencePub],[noAppelOffre]) VALUES('JIMES&JAN',390.79,null,'scelerisque scelerisque dui. Suspendisse ac metus vitae velit egestas lacinia. Sed congue, elit sed consequat auctor, nunc nulla vulputate dui, nec tempus mauris erat eget','2016-10-23 09:55:54','2016-12-23 13:55:54',NULL,10,8);
PRINT 'Fin d''insertion de table tblSoumission'
GO



