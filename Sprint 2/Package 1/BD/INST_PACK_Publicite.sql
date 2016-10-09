--Ce script permet d'insetion des tables dans le package publicite
--Fait par: Kevin Kuété Moffo
--En ce: 5 Octobre 2016
USE PE2_Officiel

INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Placerat LLP');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Adipiscing Elit Corporation');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Ipsum Donec Sollicitudin Industries');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Nostra Per Inc.');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Metus Aliquam Erat Associates');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Ac Corporation');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Nisl Company');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Scelerisque PC');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Imperdiet Ullamcorper Consulting');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Nec Foundation');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Et Risus Quisque LLP');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Auctor Corp.');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Rutrum Eu Ultrices Limited');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Lorem Sit Amet Foundation');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Id Incorporated');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Tellus Imperdiet PC');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('At Foundation');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Eu Tellus Industries');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('A Inc.');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Venenatis A PC');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Nibh Foundation');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Tortor Corporation');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Ut Sem Nulla Company');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Tincidunt Tempus Risus Industries');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Sed Malesuada Consulting');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Tellus Id Foundation');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Risus LLC');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Nunc Interdum Limited');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Vitae Sodales Associates');
INSERT INTO S_publicite.tblAgencePublicite([nom]) VALUES('Donec PC');
PRINT 'Fin d''insertion de table tblAgencePublicite'

GO
INSERT INTO S_publicite.tblStatut(nom,couleur,description)VALUES('En Création','F90202','L''appel d''offre est en création et n''est pas encore envoyée à l''agence')
INSERT INTO S_publicite.tblStatut(nom,couleur,description)VALUES('Envoyé','022BF9','L''appel d''offre est envoyée')
INSERT INTO S_publicite.tblStatut(nom,couleur,description)VALUES('Complété','DBF902','L''appel d''offre est complétée et une soumission est envoyée par l''agence')
INSERT INTO S_publicite.tblStatut(nom,couleur,description)VALUES('Annulé','0281F9','L''appel d''offre est annulée')
PRINT 'Fin d''insertion de table tblStatut'

GO
INSERT INTO S_publicite.tblMedia(nom,description)VALUES('Radio','la publicité sera communiqué au moyen de la radio')
INSERT INTO S_publicite.tblMedia(nom,description)VALUES('Télévision','la publicité sera communiqué au moyen de la télévision')
INSERT INTO S_publicite.tblMedia(nom,description)VALUES('Journal','la publicité sera communiquer au moyen des journaux')
INSERT INTO S_publicite.tblMedia(nom)VALUES('Réseaux sociaux')
PRINT 'Fin d''insertion de table tblMedia'

GO
INSERT INTO S_publicite.tblAppelOffre([nom],[dateEnvoi],[dateRequis],[description],[noEvenement],[noStatut]) VALUES('Promotion sur les billets de spectacle','2016-04-05 17:07:42','2016-01-19 20:23:45','promotion en vedette',10,4);
INSERT INTO S_publicite.tblAppelOffre([nom],[dateEnvoi],[dateRequis],[description],[noEvenement],[noStatut]) VALUES('Concours pour gagner des billets graduits','2016-03-29 21:31:19','2015-12-13 00:05:17','concours en vedette et courer la chnace de gagner des billets graduits',6,2);
INSERT INTO S_publicite.tblAppelOffre([nom],[dateEnvoi],[dateRequis],[description],[noEvenement],[noStatut]) VALUES('Spectacle en feu','2016-08-29 11:45:41','2017-04-25 16:34:29','Repésente de spectacle de clôture',6,1);
INSERT INTO S_publicite.tblAppelOffre([nom],[dateEnvoi],[dateRequis],[noEvenement],[noStatut]) VALUES('Humoriste de l''année','2016-07-03 22:21:11','2017-04-19 06:08:04',2,3);
INSERT INTO S_publicite.tblAppelOffre([nom],[dateEnvoi],[dateRequis],[description],[noEvenement],[noStatut]) VALUES('Meilleur artiste du spectacle','2016-06-27 03:25:34','2016-02-05 23:23:27','Permt de savoir le meilleur artiste du spectacle',10,3);
INSERT INTO S_publicite.tblAppelOffre([nom],[dateEnvoi],[dateRequis],[noEvenement],[noStatut]) VALUES('Spectacle en joie','2016-01-17 07:22:52','2016-02-08 09:51:21',2,4);
INSERT INTO S_publicite.tblAppelOffre([nom],[dateEnvoi],[dateRequis],[description],[noEvenement],[noStatut]) VALUES('Promotion des places','2016-07-09 14:09:06','2016-11-14 08:19:39','Faire la publicité sur differentes places',1,4);
INSERT INTO S_publicite.tblAppelOffre([nom],[dateEnvoi],[dateRequis],[description],[noEvenement],[noStatut]) VALUES('Promotion de fin de spectacle','2015-10-23 09:55:54','2017-07-06 02:22:27','Savoir les differentes promotions de la fin du spectacle',7,1);
INSERT INTO S_publicite.tblAppelOffre([nom],[dateEnvoi],[dateRequis],[description],[noEvenement],[noStatut]) VALUES('Publicité de l''évènement','2016-03-20 21:22:45','2015-12-01 18:52:02','Faire la publicité de l''évènement',4,4);
INSERT INTO S_publicite.tblAppelOffre([nom],[dateEnvoi],[dateRequis],[noEvenement],[noStatut]) VALUES('Kai Small','2016-04-05 10:01:15','2017-02-25 04:34:45',1,2);
INSERT INTO S_publicite.tblAppelOffre([nom],[dateEnvoi],[dateRequis],[noEvenement],[noStatut]) VALUES('Kaitlin Cummings','2015-12-12 23:45:29','2017-06-11 21:47:20',8,3);
PRINT 'Fin d''insertion de table tblAppelOffre'

GO
INSERT INTO S_publicite.S_publicite.tblAppelOffreAgence([noMedia],[noAppelOffre]) VALUES(2,8);
INSERT INTO S_publicite.S_publicite.tblAppelOffreAgence([noMedia],[noAppelOffre]) VALUES(3,5);
INSERT INTO S_publicite.S_publicite.tblAppelOffreAgence([noMedia],[noAppelOffre]) VALUES(1,4);
INSERT INTO S_publicite.S_publicite.tblAppelOffreAgence([noMedia],[noAppelOffre]) VALUES(1,6);
INSERT INTO S_publicite.S_publicite.tblAppelOffreAgence([noMedia],[noAppelOffre]) VALUES(3,9);
INSERT INTO S_publicite.S_publicite.tblAppelOffreAgence([noMedia],[noAppelOffre]) VALUES(4,7);
INSERT INTO S_publicite.S_publicite.tblAppelOffreAgence([noMedia],[noAppelOffre]) VALUES(3,5);
INSERT INTO S_publicite.S_publicite.tblAppelOffreAgence([noMedia],[noAppelOffre]) VALUES(1,9);
INSERT INTO S_publicite.S_publicite.tblAppelOffreAgence([noMedia],[noAppelOffre]) VALUES(1,2);
INSERT INTO S_publicite.S_publicite.tblAppelOffreAgence([noMedia],[noAppelOffre]) VALUES(3,4);
PRINT 'Fin d''insertion de table S_publicite.tblAppelOffreAgence'

INSERT INTO S_publicite.tblAppelOffreAgence([noAgencePub],[noAppelOffre],[noStatut]) VALUES(23,5,4);
INSERT INTO S_publicite.tblAppelOffreAgence([noAgencePub],[noAppelOffre],[noStatut]) VALUES(25,4,2);
INSERT INTO S_publicite.tblAppelOffreAgence([noAgencePub],[noAppelOffre],[noStatut]) VALUES(2,8,4);
INSERT INTO S_publicite.tblAppelOffreAgence([noAgencePub],[noAppelOffre],[noStatut]) VALUES(15,1,2);
INSERT INTO S_publicite.tblAppelOffreAgence([noAgencePub],[noAppelOffre],[noStatut]) VALUES(12,4,4);
INSERT INTO S_publicite.tblAppelOffreAgence([noAgencePub],[noAppelOffre],[noStatut]) VALUES(16,3,3);
INSERT INTO S_publicite.tblAppelOffreAgence([noAgencePub],[noAppelOffre],[noStatut]) VALUES(17,6,2);
INSERT INTO S_publicite.tblAppelOffreAgence([noAgencePub],[noAppelOffre],[noStatut]) VALUES(14,2,3);
INSERT INTO S_publicite.tblAppelOffreAgence([noAgencePub],[noAppelOffre],[noStatut]) VALUES(21,9,3);
INSERT INTO S_publicite.tblAppelOffreAgence([noAgencePub],[noAppelOffre],[noStatut]) VALUES(11,1,3);
INSERT INTO S_publicite.tblAppelOffreAgence([noAgencePub],[noAppelOffre],[noStatut]) VALUES(13,4,4);
INSERT INTO S_publicite.tblAppelOffreAgence([noAgencePub],[noAppelOffre],[noStatut]) VALUES(3,4,2);
INSERT INTO S_publicite.tblAppelOffreAgence([noAgencePub],[noAppelOffre],[noStatut]) VALUES(23,8,3);
INSERT INTO S_publicite.tblAppelOffreAgence([noAgencePub],[noAppelOffre],[noStatut]) VALUES(4,4,3);
INSERT INTO S_publicite.tblAppelOffreAgence([noAgencePub],[noAppelOffre],[noStatut]) VALUES(17,7,4);
INSERT INTO S_publicite.tblAppelOffreAgence([noAgencePub],[noAppelOffre],[noStatut]) VALUES(9,7,2);
INSERT INTO S_publicite.tblAppelOffreAgence([noAgencePub],[noAppelOffre],[noStatut]) VALUES(25,9,2);
INSERT INTO S_publicite.tblAppelOffreAgence([noAgencePub],[noAppelOffre],[noStatut]) VALUES(23,3,2);
INSERT INTO S_publicite.tblAppelOffreAgence([noAgencePub],[noAppelOffre],[noStatut]) VALUES(11,5,3);
INSERT INTO S_publicite.tblAppelOffreAgence([noAgencePub],[noAppelOffre],[noStatut]) VALUES(26,4,2);
PRINT 'Fin d''insertion de table S_publicite.tblAppelOffreAgence'

GO
INSERT INTO S_publicite.tblSoumission([nom],[prix],[Statut],[offreNoPublicite]) VALUES('Soumission1','$58.05',0,8);
INSERT INTO S_publicite.tblSoumission([nom],[prix],[Statut],[offreNoPublicite]) VALUES('Soumission2','$40.86',1,6);
INSERT INTO S_publicite.tblSoumission([nom],[prix],[Statut],[offreNoPublicite]) VALUES('Soumission3','$31.75',1,2);
INSERT INTO S_publicite.tblSoumission([nom],[prix],[Statut],[offreNoPublicite]) VALUES('Soumission4','$96.00',0,3);
INSERT INTO S_publicite.tblSoumission([nom],[prix],[Statut],[offreNoPublicite]) VALUES('Soumission5','$43.34',0,11);
INSERT INTO S_publicite.tblSoumission([nom],[prix],[Statut],[offreNoPublicite]) VALUES('Soumission6','$35.95',1,12);
INSERT INTO S_publicite.tblSoumission([nom],[prix],[Statut],[offreNoPublicite]) VALUES('Soumission7','$43.03',1,5);
INSERT INTO S_publicite.tblSoumission([nom],[prix],[Statut],[offreNoPublicite]) VALUES('Soumission8','$95.89',1,15);
INSERT INTO S_publicite.tblSoumission([nom],[prix],[Statut],[offreNoPublicite]) VALUES('Soumission9','$74.28',0,5);
INSERT INTO S_publicite.tblSoumission([nom],[prix],[Statut],[offreNoPublicite]) VALUES('Soumission10','$79.06',1,6);
INSERT INTO S_publicite.tblSoumission([nom],[prix],[Statut],[offreNoPublicite]) VALUES('Soumission11','$89.61',0,4);
INSERT INTO S_publicite.tblSoumission([nom],[prix],[Statut],[offreNoPublicite]) VALUES('Soumission12','$98.42',1,15);
INSERT INTO S_publicite.tblSoumission([nom],[prix],[Statut],[offreNoPublicite]) VALUES('Soumission13','$89.00',0,11);
INSERT INTO S_publicite.tblSoumission([nom],[prix],[Statut],[offreNoPublicite]) VALUES('Soumission14','$36.41',0,12);
INSERT INTO S_publicite.tblSoumission([nom],[prix],[Statut],[offreNoPublicite]) VALUES('Soumission15','$46.66',0,6);
PRINT 'Fin d''insertion de table S_publicite.tblSoumission'

GO
PRINT 'Fin d''insertion des tables du package Publicité'


