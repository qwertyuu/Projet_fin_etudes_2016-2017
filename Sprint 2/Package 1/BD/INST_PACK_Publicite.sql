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
INSERT INTO S_publicite.tblMedia(nom,description)VALUES('Radio','la publicité sera communiqué au moyen de la radio');
INSERT INTO S_publicite.tblMedia([nom],[description]) VALUES('Blog','velit. Cras lorem lorem, luctus ut,');
INSERT INTO S_publicite.tblMedia(nom,description)VALUES('Télévision','la publicité sera communiqué au moyen de la télévision');
INSERT INTO S_publicite.tblMedia(nom,description)VALUES('Journal','la publicité sera communiquer au moyen des journaux');
INSERT INTO S_publicite.tblMedia(nom)VALUES('Réseaux sociaux');
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

INSERT INTO S_publicite.tblSoumission([nom],[prix],[statut],[description],[dateSupprime],[noAppelOffre]) VALUES('mattis. Integer eu lacus. Quisque','2.7473126874043',0,'quis turpis vitae purus',NULL,7);
INSERT INTO S_publicite.tblSoumission([nom],[prix],[statut],[description],[dateSupprime],[noAppelOffre]) VALUES('hendrerit neque. In ornare sagittis','3.0586347691344',0,'nascetur ridiculus mus. Aenean',NULL,10);
INSERT INTO S_publicite.tblSoumission([nom],[prix],[statut],[description],[dateSupprime],[noAppelOffre]) VALUES('lorem eu metus. In lorem.','2.7900857747429',1,'suscipit nonummy. Fusce fermentum fermentum arcu. Vestibulum',NULL,4);
INSERT INTO S_publicite.tblSoumission([nom],[prix],[statut],[description],[dateSupprime],[noAppelOffre]) VALUES('risus odio, auctor vitae, aliquet','3.3862742683918',1,'erat volutpat. Nulla facilisis. Suspendisse commodo tincidunt nibh. Phasellus',NULL,3);
INSERT INTO S_publicite.tblSoumission([nom],[prix],[statut],[description],[dateSupprime],[noAppelOffre]) VALUES('Aliquam rutrum lorem ac risus.','2.9022601300456',0,'dictum sapien. Aenean massa. Integer vitae',NULL,7);
INSERT INTO S_publicite.tblSoumission([nom],[prix],[statut],[description],[dateSupprime],[noAppelOffre]) VALUES('vulputate, posuere vulputate, lacus. Cras','3.0335540204716',0,'magna sed dui. Fusce aliquam, enim nec tempus','2016/06/24',2);
INSERT INTO S_publicite.tblSoumission([nom],[prix],[statut],[description],[dateSupprime],[noAppelOffre]) VALUES('ante. Vivamus non lorem vitae','2.7943151809682',1,'sed leo. Cras vehicula aliquet libero. Integer in magna.',NULL,1);
INSERT INTO S_publicite.tblSoumission([nom],[prix],[statut],[description],[dateSupprime],[noAppelOffre]) VALUES('eu erat semper rutrum. Fusce','3.0202206588346',0,'tincidunt dui augue eu tellus.',NULL,9);
INSERT INTO S_publicite.tblSoumission([nom],[prix],[statut],[description],[dateSupprime],[noAppelOffre]) VALUES('lorem. Donec elementum, lorem ut','2.9419528415708',0,'laoreet ipsum. Curabitur consequat, lectus sit',NULL,4);
INSERT INTO S_publicite.tblSoumission([nom],[prix],[statut],[description],[dateSupprime],[noAppelOffre]) VALUES('Nullam scelerisque neque sed sem','2.8802014906253',1,'Duis sit amet','2016/06/24',8);
PRINT 'Fin d''insertion de table tblSoumission'
GO

INSERT INTO S_publicite.tblAppelOffreAgence([noAgencePub],[offreNoPublicite],[noStatut],[noSoumission]) VALUES(4,10,2,8);
INSERT INTO S_publicite.tblAppelOffreAgence([noAgencePub],[offreNoPublicite],[noStatut],[noSoumission]) VALUES(4,1,2,6);
INSERT INTO S_publicite.tblAppelOffreAgence([noAgencePub],[offreNoPublicite],[noStatut],[noSoumission]) VALUES(9,3,2,3);
INSERT INTO S_publicite.tblAppelOffreAgence([noAgencePub],[offreNoPublicite],[noStatut],[noSoumission]) VALUES(4,1,3,8);
INSERT INTO S_publicite.tblAppelOffreAgence([noAgencePub],[offreNoPublicite],[noStatut],[noSoumission]) VALUES(8,8,4,1);
INSERT INTO S_publicite.tblAppelOffreAgence([noAgencePub],[offreNoPublicite],[noStatut],[noSoumission]) VALUES(1,7,4,8);
INSERT INTO S_publicite.tblAppelOffreAgence([noAgencePub],[offreNoPublicite],[noStatut],[noSoumission]) VALUES(7,2,1,7);
INSERT INTO S_publicite.tblAppelOffreAgence([noAgencePub],[offreNoPublicite],[noStatut],[noSoumission]) VALUES(3,4,3,5);
INSERT INTO S_publicite.tblAppelOffreAgence([noAgencePub],[offreNoPublicite],[noStatut],[noSoumission]) VALUES(2,2,4,1);
INSERT INTO S_publicite.tblAppelOffreAgence([noAgencePub],[offreNoPublicite],[noStatut],[noSoumission]) VALUES(3,2,1,7);
PRINT 'Fin d''insertion de table tblAppelOffreAgence'
GO

INSERT INTO S_publicite.tblMediaAppelOffre([noMedia],[noAppelOffre]) VALUES(1,1);
INSERT INTO S_publicite.tblMediaAppelOffre([noMedia],[noAppelOffre]) VALUES(1,8);
INSERT INTO S_publicite.tblMediaAppelOffre([noMedia],[noAppelOffre]) VALUES(10,1);
INSERT INTO S_publicite.tblMediaAppelOffre([noMedia],[noAppelOffre]) VALUES(1,9);
INSERT INTO S_publicite.tblMediaAppelOffre([noMedia],[noAppelOffre]) VALUES(4,4);
INSERT INTO S_publicite.tblMediaAppelOffre([noMedia],[noAppelOffre]) VALUES(4,10);
INSERT INTO S_publicite.tblMediaAppelOffre([noMedia],[noAppelOffre]) VALUES(6,3);
INSERT INTO S_publicite.tblMediaAppelOffre([noMedia],[noAppelOffre]) VALUES(2,10);
INSERT INTO S_publicite.tblMediaAppelOffre([noMedia],[noAppelOffre]) VALUES(8,4);
INSERT INTO S_publicite.tblMediaAppelOffre([noMedia],[noAppelOffre]) VALUES(9,6);
INSERT INTO S_publicite.tblMediaAppelOffre([noMedia],[noAppelOffre]) VALUES(4,5);
INSERT INTO S_publicite.tblMediaAppelOffre([noMedia],[noAppelOffre]) VALUES(9,9);
INSERT INTO S_publicite.tblMediaAppelOffre([noMedia],[noAppelOffre]) VALUES(4,4);
INSERT INTO S_publicite.tblMediaAppelOffre([noMedia],[noAppelOffre]) VALUES(9,7);
INSERT INTO S_publicite.tblMediaAppelOffre([noMedia],[noAppelOffre]) VALUES(8,7);
INSERT INTO S_publicite.tblMediaAppelOffre([noMedia],[noAppelOffre]) VALUES(2,3);
INSERT INTO S_publicite.tblMediaAppelOffre([noMedia],[noAppelOffre]) VALUES(7,5);
INSERT INTO S_publicite.tblMediaAppelOffre([noMedia],[noAppelOffre]) VALUES(2,2);
INSERT INTO S_publicite.tblMediaAppelOffre([noMedia],[noAppelOffre]) VALUES(5,1);
INSERT INTO S_publicite.tblMediaAppelOffre([noMedia],[noAppelOffre]) VALUES(6,6);
INSERT INTO S_publicite.tblMediaAppelOffre([noMedia],[noAppelOffre]) VALUES(10,3);
INSERT INTO S_publicite.tblMediaAppelOffre([noMedia],[noAppelOffre]) VALUES(5,1);
INSERT INTO S_publicite.tblMediaAppelOffre([noMedia],[noAppelOffre]) VALUES(9,4);
INSERT INTO S_publicite.tblMediaAppelOffre([noMedia],[noAppelOffre]) VALUES(2,1);
INSERT INTO S_publicite.tblMediaAppelOffre([noMedia],[noAppelOffre]) VALUES(3,8);
INSERT INTO S_publicite.tblMediaAppelOffre([noMedia],[noAppelOffre]) VALUES(3,7);
INSERT INTO S_publicite.tblMediaAppelOffre([noMedia],[noAppelOffre]) VALUES(9,4);
INSERT INTO S_publicite.tblMediaAppelOffre([noMedia],[noAppelOffre]) VALUES(7,5);
INSERT INTO S_publicite.tblMediaAppelOffre([noMedia],[noAppelOffre]) VALUES(2,8);
INSERT INTO S_publicite.tblMediaAppelOffre([noMedia],[noAppelOffre]) VALUES(1,10);
PRINT 'Fin d''insertion de table tblMediaAppelOffre'
