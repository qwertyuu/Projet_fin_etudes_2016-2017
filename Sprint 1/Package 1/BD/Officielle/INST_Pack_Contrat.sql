--But : Création des données de test du package contrats
--Date : 29-08-2016
--Par : Simon Girard


USE PE2_Officiel
GO

/*insertion des adresses*/

GO
PRINT 'insertion des adresses débutée'
GO
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Jonquière','G7X7W2','QC','Canada','4185472191','4185472191',5807, '2505 Rue Saint Hubert');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Murdochville','H5K1G9','QC','Canada','4185996631','4187076683',9439, '1768 Boulevard Laflèche');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Wekweti','D1C8D5','NT','Canada','4183707770','4184975797',8832, '110 Saskatchewan Dr');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Bay Roberts','D3Y1H7','NL','Canada','4188038712','4184374362',2171, '1987 rue Saint-Édouard');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Lakeshore','Z1P9C4','ON','Canada','4187828760','4182441530',3733, '2973 Rue King');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Charlottetown','M4U7W7','PE','Canada','4188094124','4182279533',6251, '4107 Ste. Catherine Ouest');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Caplan','Y6Z4K6','QC','Canada','4181251564','4182594355',5340, '3361 René-Lévesque Blvd');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Whitehorse','J2X2F7','YT','Canada','4185518302','4189937396',839, '1660 rue des Champs');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Kawartha Lakes','O7F0E6','ON','Canada','4185759408','4183226713',9922, '1414 Avenue Papineau');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Tuktoyaktuk','I2S5P3','NT','Canada','4188157372','4188886104',8234, '2736 boulevard des Laurentides');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Gravelbourg','C0W2I9','SK','Canada','4181957702','4184407891',1070, '4173 rue Saint-Édouard');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Bay Roberts','O2N5S8','NL','Canada','4181531514','4187161949',5900, '1635 rue Boulay');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Arviat','E5R1J3','NU','Canada','4188296563','4188296563',1254, '2917 avenue de Port-Royal');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Whitehorse','S8L1A3','YT','Canada','4184820847','4182594900',54, '2554 Aliquam Av');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Whitehorse','M0A7C0','YT','Canada','4189088995','4181435113',4, '2431 Proin Street');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Kearny','F5F2Q2','ON','Canada','4187675272','4188250409',8938, '4724 Nunc Avenue');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Tulita','X7H9X9','NT','Canada','4184517009','4187488001',null, '8318 Risus. Ave');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Fraser Lake','M6T7N2','BC','Canada','4188261336','4186370777',2700, '4724 Nunc Avenue');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Fredericton','M6M3S6','NB','Canada','4185122464','4181074914',null, '2397 Sir Wilfied de Lauier');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Fortune','L9D0R8','NL','Canada','4185262276','4184055003',7811, '2349 rue Lapointe');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('MansfieldetPontefract','G7B8O7','QC','Canada','4184473760','4188618109',null, '2397 Sir Wilfied de Lauier');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Argyle','B5Y2Z0','NS','Canada','4184478593','4184478593',4468, '2398 Sir Wilfied de Lauier');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Weyburn','W8R9N3','SK','Canada','4186474587','4188169626',null, '3643 Hendrerit St');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Fort McPherson','G5I3G5','NT','Canada','4183872302','4183219935',6440, '2397 Sir Wilfied de Lauier');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Minitonas','Z8H2Y3','MB','Canada','4182452811','4182452811',3598, '2380 rue Panet');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Fredericton','W3B9T7','NB','Canada','4187381094','4184316029',1505, '4047 Fermentum Rd.');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Harbour Grace','U9Q5L0','NL','Canada','4186441434','4188805329',7937, '2530 Quis Street');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Port Coquitlam','S8G0Y9','BC','Canada','4183969822','4184153973',4950, '2451 A, St');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Saint John','V3S5Q6','NB','Canada','4184187658','4182105046',7297, '5939 Morbi Road');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Saguenay','S0C5S1','QC','Canada','4188837600','4185887999',8426, '7980 Quisque St.');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Arviat','Z1Q3E8','NU','Canada','4184594117','4188096763',9253, '5112 Porttitor Avenue');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Edmundston','M9P2I2','NB','Canada','4185376718','4186438138',7077, '2431 Proin Street');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Minitonas','O4C2J7','MB','Canada','4187351849','4183013060',4633, '4822 Gravida Avenue');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Fort Providence','G8I4V8','NT','Canada','4184002201','4189134675',3379, '2397 Sir Wilfied de Lauier');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Moncton','P9F4Y0','NB','Canada','4184943873','4189474731',8245, '310 Nec Street');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Weyburn','N4L8Z4','SK','Canada','4187414424','4184564069',8107, '9808 rue les bluets');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Gjoa Haven','T8G2A3','NU','Canada','4187423404','4185457833',7597, '2357 Rue St Dominique');
GO
PRINT 'insertion des adresses réussi'
GO

/*insertion des diffuseurs*/

GO
PRINT 'insertion des diffuseurs débutée'
GO
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Cégep de Jonquière', 'cegepjonquiere@gamil.com', null, 1);

GO
PRINT 'insertion des diffuseurs réussi'
GO
/*insertion des Agences*/

GO
PRINT 'insertion des Agences débutée'
GO
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('3XIJAV90','Voonyx', 'valvarez0@umn.edu', null, 1);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('PP40CJ90','Rhyloo', 'bpierce1@drupal.org', '20160213', 2);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('ULJ9T790','Chatterbridge', 'rburns2@yelp.com', null, 3);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('D6NU2190','Oyonder', 'eallen3@comcast.net', null, 4);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('II54SL90','Einti', 'kwright4@themeforest.net', null, 5);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('5DKOEY90','Twimbo', 'rrichardson5@GOo.gl', null, 17);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('961SA690','Browsezoom', 'wking6@bloglovin.com', null, 6);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('LOMGLH90','Gigabox', 'pwheeler7@paginegialle.it', null, 7);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('G2MPAV90','Aivee', 'cstewart8@umich.edu', null, 8);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('2Z1NBU90','Brainverse', 'agray9@accuweather.com', '20160804', 10);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Q05ZDR90','Gabcube', 'rmatthewsa@upenn.edu', null, 11);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('U9PQDB90','Teklist', 'rbellb@live.com', null, 12);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('MK459B90','Twinte', 'rmedinac@netscape.com', null, 13);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('3X6XEJ90','Demizz', 'thansend@friendfeed.com', null, 14);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('4W624Q90','Linktype', 'mrobinsone@cdbaby.com', '20160414', 15);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('3ZB0MS90','Shufflebeat', 'vmartinezf@yellowbook.com', null, 16);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('UX63SW90','Twinder', 'mramirezg@networksolutions.com', null, 21);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('O4TTAC90','Yamia', 'kfranklinh@networkadvertising.org', null, 22);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('65PT4690','Fivebridge', 'bbradleyi@shinystat.com', null, 23);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('HSRN3290','Youopia', 'cmorrisonj@blinklist.com', null, 24);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('34XG0O90','Yakijo', 'cclarkk@mediafire.com', null, 25);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('O7FJIJ90','Browsezoom', 'ecollinsl@is.gd', '20160210', 26);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('TFWV8W90','Podcat', 'pphillipsm@hc360.com', null, 27);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('WJP0BH90','Eadel', 'jmasonn@dmoz.org', null, 28);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('CE7Q5Q90','Eimbee', 'mnicholso@newsvine.com', null, 29);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('81C36790','Skippad', 'dcruzp@nasa.GOv', null, 17);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('8N8IGA90','Photobug', 'lrileyq@howstuffworks.com', null, 18);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('4E3DH890','Topicstorm', 'pdeanr@bloglines.com', null, 19);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('08PR2490','Photobug', 'jburtons@posterous.com', null, 20);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('2WLBDW90','Topdrive', 'dwhitet@GOo.ne.jp', null, 30);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('9SR5G490','Yodoo', 'stayloru@epa.GOv', null, 31);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('9D0JF090','Oyoyo', 'jdeanv@mediafire.com', '20131113', 32);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('XVRBNB90','Linktype', 'bbradleyw@hud.GOv', null, 33);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('GYJQG090','Dabvine', 'jpetersonx@tamu.edu', null, 34);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('SL41FC90','Fivebridge', 'kclarky@lycos.com', null, 35);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('RZ5RSU90','Realcube', 'dwallacez@bloglines.com', null, 36);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('2D3MNI90','Blogtag', 'kbrown10@blogger.com', null, 37);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('EGMGKP90','Thoughtbridge', 'aburke11@psu.edu', '20160213', 9);
GO
PRINT 'insertion des agences réussi'
GO
/*insertion des responsables*/

GO
PRINT 'insertion des responsables débutée'
GO


INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Cruz', 'George', 'gcruz0@state.tx.us', 'George Cruz', '2016/01/15', '8631113471', '5734372137', null, 0, null, null, '3XIJAV90');
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Carter', 'Christina', 'ccarter1@GOogle.de', 'Christina Carter', '2016/07/22', '3856281598', '6327071769', 364, 0, null, 1, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Hart', 'Barbara', 'bhart2@sun.com', 'Barbara Hart', '2016/02/04', '6925115065', '1303156481', 913, 0, null, null, 'ULJ9T790');
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Henry', 'Ruth', 'rhenry3@livejournal.com', 'Ruth Henry', '2016/04/25', '5281157420', '6324147750', 265, 0, null, 1, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Mason', 'Nicholas', 'nmason4@hc360.com', null, '2015/12/08', '3511950020', '9671684340', 262, 1, null, null, 'Q05ZDR90');
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Young', 'Walter', 'wyoung5@sina.com.cn', null, '2016/02/11', '6359817195', '5182891148', 146, 1, null, 1, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Chavez', 'Julia', 'jchavez6@ibm.com', 'Julia Chavez', '2016/05/03', '3327172914', '3562601110', null, 0, null, null, '9D0JF090');
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Hill', 'Emily', 'ehill7@illinois.edu', 'Emily Hill', '2015/11/03', '5578512986', '6280071160', 138, 0, null, 1, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Walker', 'Kathy', 'kwalker8@purevolume.com', null, '2015/10/16', '1919815061', '6224815701', 161, 1, null, null, 'CE7Q5Q90');
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Hicks', 'Chris', 'chicks9@GOo.ne.jp', 'Chris Hicks', '2016/01/19', '6322134224', '5730717164', null, 0, null, 1, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Price', 'Carl', 'cpricea@jugem.jp', 'Carl Price', '2016/03/10', '9987127017', '8617165705', 651, 0, null, null, 'HSRN3290');
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Oliver', 'Frances', 'foliverb@army.mil', null, '2016/07/30', '4851942270', '5560317957', 702, 1, null, 1, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Warren', 'Brandon', 'bwarrenc@businessweek.com', 'Brandon Warren', '2015/09/05', '5571374038', '6275116346', 528, 0, null, null, '65PT4690');
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Lapointe', 'Luc', 'lapointeluc@ibm.com', null, '2015/12/16', '4189087544', '2345098765', null, 1, null, 1, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Clark', 'Barbara', 'bclarkd@ibm.com', null, '2015/10/16', '5245261440', '5537911456', null, 1, null, null,'81C36790');

GO
PRINT 'insertion des reponsables réussi'
GO

/*insertion des Catégories d'artistes

Modifier certaines dateSupprime pour ne pas qu'elles soient toutes*/

GO
PRINT 'insertion des Catégories d''artistes débutée'
GO
INSERT INTO S_Contrat.tblCategorieArtiste (nom, description, dateSupprime) VALUES ('Humoriste', 'Artiste qui se produit en spectacle en interprétant des personnages comiques, des monologues humoristiques, en exploitant des situations absurdes dans l''intention de faire rire un public.', null);
INSERT INTO S_Contrat.tblCategorieArtiste (nom, description, dateSupprime) VALUES ('Musicien', 'Artiste ou groupe d''artistes qui pratiquent des compositions musicales', null);
INSERT INTO S_Contrat.tblCategorieArtiste (nom, description, dateSupprime) VALUES ('Acrobate', 'Artiste qui maîtrise une ou plusieurs disciplines d''acrobatie, dont la pratique est fondée sur l''agilité, la force, la souplesse et l''équilibre.', null);
INSERT INTO S_Contrat.tblCategorieArtiste (nom, description, dateSupprime) VALUES ('Ventriloque', 'Personne qui peut articuler sans remuer les lèvres et fait "parler" une marionette pour un effet comique.', null);
INSERT INTO S_Contrat.tblCategorieArtiste (nom, description, dateSupprime) VALUES ('Danseur', 'Personne ou groupe qui performe des chorégraphie dans un but artistique', null);
INSERT INTO S_Contrat.tblCategorieArtiste (nom, description, dateSupprime) VALUES ('Théâtre', 'Art de représenter sur scène des événements mettant en cause des êtres humains.' , null);
INSERT INTO S_Contrat.tblCategorieArtiste (nom, description, dateSupprime) VALUES ('Chanteur', 'Des choristes qui chnatent en coeur et avec des rythmes' , null);
INSERT INTO S_Contrat.tblCategorieArtiste (nom, description, dateSupprime) VALUES ('Interpréteur', 'Ils reproduissent les chants et des chorégraphies des autres artistes' , null);
INSERT INTO S_Contrat.tblCategorieArtiste (nom, description, dateSupprime) VALUES ('Choéagraphe', 'Ces artistes reproduisent des scènes de tout genre' , null);
INSERT INTO S_Contrat.tblCategorieArtiste (nom, description, dateSupprime) VALUES ('Cracheur de feu ', 'Ces artistes, grâce au feu et leurs bouches reproduissent des scènes de feu' , null);
GO
PRINT 'insertion des Catégories d''artistes réussi'
GO


/*insertion des artistes

Modifier certaines dateSupprime pour ne pas qu'elles soient toutes

Rajouter des commentaires pour certains*/

GO
PRINT 'insertion des artistes débutée'
GO
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Howard Rodriguez', 'Artiste renomé, spécialiste dans l''humour', null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Matthew Fowler', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Dennis Garza', '{\rtf1\ansi\ansicpg1252\deff0\deflang3084{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}{\f1\fnil\fcharset2 Symbol;}}\viewkind4\uc1\pard{\pntext\f1\''B7\tab}{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\''B7}}\ul\b\f0\fs32 RichTextFormat\ulnone\b0\fs17\par}', null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Betty Mccoy', '{\rtf1\ansi\ansicpg1252\deff0\deflang3084{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}{\f1\fnil\fcharset2 Symbol;}}\viewkind4\uc1\pard{\pntext\f1\''B7\tab}{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\''B7}}\ul\b\f0\fs32 RichTextFormat\ulnone\b0\fs17\par}', null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Donald Collins', '{\rtf1\ansi\ansicpg1252\deff0\deflang3084{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}{\f1\fnil\fcharset2 Symbol;}}\viewkind4\uc1\pard{\pntext\f1\''B7\tab}{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\''B7}}\ul\b\f0\fs32 RichTextFormat\ulnone\b0\fs17\par}', null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Jerry Rodriguez', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Julie Alexander', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Gloria Mills', null, '20160213');
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Sandra Mason', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Lois Rivera', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Martin Mills', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Lois Riley', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Catherine Meyer', '{\rtf1\ansi\ansicpg1252\deff0\deflang3084{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}{\f1\fnil\fcharset2 Symbol;}}\viewkind4\uc1\pard{\pntext\f1\''B7\tab}{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\''B7}}\ul\b\f0\fs32 RichTextFormat\ulnone\b0\fs17\par}', null);
GO
PRINT 'insertion des artistes réussi'
GO

/*insertion des Fichier Personnel*/

GO
PRINT 'insertion des fichiers personnels débutée'
GO
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Photo','photos\\photo.jpg','{\rtf1\ansi\ansicpg1252\deff0\deflang3084{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}{\f1\fnil\fcharset2 Symbol;}}
\viewkind4\uc1\pard{\pntext\f1\''B7\tab}{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\''B7}}\ul\b\f0\fs32 RichTextFormat\ulnone\b0\fs17\par}',1,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Photo','photos\\photo.jpg','{\rtf1\ansi\ansicpg1252\deff0\deflang3084{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}{\f1\fnil\fcharset2 Symbol;}}
\viewkind4\uc1\pard{\pntext\f1\''B7\tab}{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\''B7}}\ul\b\f0\fs32 RichTextFormat\ulnone\b0\fs17\par}',2,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Photo','photos\\photo.jpg','{\rtf1\ansi\ansicpg1252\deff0\deflang3084{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}{\f1\fnil\fcharset2 Symbol;}}
\viewkind4\uc1\pard{\pntext\f1\''B7\tab}{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\''B7}}\ul\b\f0\fs32 RichTextFormat\ulnone\b0\fs17\par}',3,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Document','documents\\document.docx','{\rtf1\ansi\ansicpg1252\deff0\deflang3084{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}{\f1\fnil\fcharset2 Symbol;}}
\viewkind4\uc1\pard{\pntext\f1\''B7\tab}{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\''B7}}\ul\b\f0\fs32 RichTextFormat\ulnone\b0\fs17\par}',4,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Photo','photos\\photo.jpg','{\rtf1\ansi\ansicpg1252\deff0\deflang3084{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}{\f1\fnil\fcharset2 Symbol;}}
\viewkind4\uc1\pard{\pntext\f1\''B7\tab}{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\''B7}}\ul\b\f0\fs32 RichTextFormat\ulnone\b0\fs17\par}',5,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Photo','photos\\photo.jpg','{\rtf1\ansi\ansicpg1252\deff0\deflang3084{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}{\f1\fnil\fcharset2 Symbol;}}
\viewkind4\uc1\pard{\pntext\f1\''B7\tab}{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\''B7}}\ul\b\f0\fs32 RichTextFormat\ulnone\b0\fs17\par}',6,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Document','documents\\document.docx','{\rtf1\ansi\ansicpg1252\deff0\deflang3084{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}{\f1\fnil\fcharset2 Symbol;}}
\viewkind4\uc1\pard{\pntext\f1\''B7\tab}{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\''B7}}\ul\b\f0\fs32 RichTextFormat\ulnone\b0\fs17\par}',7,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Photo','photos\\photo.jpg','{\rtf1\ansi\ansicpg1252\deff0\deflang3084{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}{\f1\fnil\fcharset2 Symbol;}}
\viewkind4\uc1\pard{\pntext\f1\''B7\tab}{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\''B7}}\ul\b\f0\fs32 RichTextFormat\ulnone\b0\fs17\par}',8,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Document','photos\\photo.jpg','Une photo officielle de l''artiste',9,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Photo','photos\\photo.jpg',null,10,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Document','documents\\document.docx',null,11,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Document','photos\\photo.jpg',null,12,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Photo','photos\\photo.jpg',null,13,null);
GO
PRINT 'insertion des fichiers personnels réussie'
GO

/*insertion des statuts*/

GO
PRINT 'insertion des statuts débutée'
GO
INSERT INTO S_Contrat.tblStatut (nomStatut, description, couleur, dateSupprime) VALUES ('Terminé', 'Le contrat a été réalisé et est archivé', 'df6c25', null);
INSERT INTO S_Contrat.tblStatut (nomStatut, description, couleur, dateSupprime) VALUES ('En cours', 'Le contrat est à réaliser bientôt', '60aba8', null);
INSERT INTO S_Contrat.tblStatut (nomStatut, description, couleur, dateSupprime) VALUES ('En négociation', 'Les discussions a propos du contrat sont encore en cours', 'e97baa', null);
INSERT INTO S_Contrat.tblStatut (nomStatut, description, couleur, dateSupprime) VALUES ('En attente', 'Le contrat est attente d''une décision', '600c3d', null);
INSERT INTO S_Contrat.tblStatut (nomStatut, description, couleur, dateSupprime) VALUES ('Annulé', 'Le contrat a été annulé', '58c7f3', null);
INSERT INTO S_Contrat.tblStatut (nomStatut, description, couleur, dateSupprime) VALUES ('Expiré', 'La date du contrat a été dépassé sans qu''une decision soit prise.', '5a0243', null);
GO
PRINT 'insertion des statuts terminée'
GO

/*insertion des contrats*/


GO
PRINT 'insertion des contrats commencée'
GO
INSERT INTO S_Contrat.tblContrat (noContrat, lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('CH-001', 'Chicoutimi', 'Musique d''ouverture des spectacles de la semaine 1', '{\rtf1\ansi\ansicpg1252\deff0\deflang3084{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}{\f1\fnil\fcharset2 Symbol;}}\viewkind4\uc1\pard{\pntext\f1\''B7\tab}{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\''B7}}\ul\b\f0\fs32 RichTextFormat\ulnone\b0\fs17\par}', null, null, 3, '3XIJAV90'); 
INSERT INTO S_Contrat.tblContrat (noContrat, lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('JO-001', 'Jonquière', 'Musique d''ouverture des spectacles de la semaine 2', null, null, null, 1, 'ULJ9T790');
INSERT INTO S_Contrat.tblContrat (noContrat, lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('CH-002', 'Chicoutimi', 'Humoriste du matin', '{\rtf1\ansi\ansicpg1252\deff0\deflang3084{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}{\f1\fnil\fcharset2 Symbol;}}\viewkind4\uc1\pard{\pntext\f1\''B7\tab}{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\''B7}}\ul\b\f0\fs32 RichTextFormat\ulnone\b0\fs17\par}', null, null, 2,  'Q05ZDR90');
INSERT INTO S_Contrat.tblContrat (noContrat, lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('JO-002', 'Jonquière', 'Humoriste du soir','{\rtf1\ansi\ansicpg1252\deff0\deflang3084{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}{\f1\fnil\fcharset2 Symbol;}}\viewkind4\uc1\pard{\pntext\f1\''B7\tab}{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\''B7}}\ul\b\f0\fs32 RichTextFormat\ulnone\b0\fs17\par}','{\rtf1\ansi\ansicpg1252\deff0\deflang3084{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}{\f1\fnil\fcharset2 Symbol;}}\viewkind4\uc1\pard{\pntext\f1\''B7\tab}{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\''B7}}\ul\b\f0\fs32 RichTextFormat\ulnone\b0\fs17\par}', null, 3, '9D0JF090');
INSERT INTO S_Contrat.tblContrat (noContrat, lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('QU-001', 'Québec', 'Animation du midi semaine 1', '{\rtf1\ansi\ansicpg1252\deff0\deflang3084{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}{\f1\fnil\fcharset2 Symbol;}}\viewkind4\uc1\pard{\pntext\f1\''B7\tab}{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\''B7}}\ul\b\f0\fs32 RichTextFormat\ulnone\b0\fs17\par}', null, null, 3, 'CE7Q5Q90');
INSERT INTO S_Contrat.tblContrat (noContrat, lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('QU-002', 'Québec', 'Animation du midi semaine 2', '{\rtf1\ansi\ansicpg1252\deff0\deflang3084{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}{\f1\fnil\fcharset2 Symbol;}}\viewkind4\uc1\pard{\pntext\f1\''B7\tab}{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\''B7}}\ul\b\f0\fs32 RichTextFormat\ulnone\b0\fs17\par}', null, null, 2, 'HSRN3290');
INSERT INTO S_Contrat.tblContrat (noContrat, lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('MO-001', 'Montréal', 'Animation du midi semaine 1', null, null, null, 1, '65PT4690');
INSERT INTO S_Contrat.tblContrat (noContrat, lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('WY-001', 'Alma', 'Activité de cloture', '{\rtf1\ansi\ansicpg1252\deff0\deflang3084{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}{\f1\fnil\fcharset2 Symbol;}}\viewkind4\uc1\pard{\pntext\f1\''B7\tab}{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\''B7}}\ul\b\f0\fs32 RichTextFormat\ulnone\b0\fs17\par}', null, null, 2, 'Q05ZDR90');
INSERT INTO S_Contrat.tblContrat (noContrat, lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('XN-002', 'Sherbrooke', 'Animation du midi semaine 6', '{\rtf1\ansi\ansicpg1252\deff0\deflang3084{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}{\f1\fnil\fcharset2 Symbol;}}\viewkind4\uc1\pard{\pntext\f1\''B7\tab}{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\''B7}}\ul\b\f0\fs32 RichTextFormat\ulnone\b0\fs17\par}', null, null, 3, '81C36790');
GO
PRINT 'insertion des contrats terminée'
GO

/*insertion des exigences*/

GO
PRINT 'insertion des exigences commencée'
GO
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Bouteilles d''eau','2016/08/21','5697','{\rtf1\ansi\ansicpg1252\deff0\deflang3084{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}{\f1\fnil\fcharset2 Symbol;}}
\viewkind4\uc1\pard{\pntext\f1\''B7\tab}{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\''B7}}\ul\b\f0\fs32 RichTextFormat\ulnone\b0\fs17\par}',null,null,null,'QU-001',2);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Alcool','2016/09/06','8235','{\rtf1\ansi\ansicpg1252\deff0\deflang3084{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}{\f1\fnil\fcharset2 Symbol;}}
\viewkind4\uc1\pard{\pntext\f1\''B7\tab}{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\''B7}}\ul\b\f0\fs32 RichTextFormat\ulnone\b0\fs17\par}',null,null,'20161230','CH-002',4);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Repas fournis','2017/04/03','6754','{\rtf1\ansi\ansicpg1252\deff0\deflang3084{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}{\f1\fnil\fcharset2 Symbol;}}
\viewkind4\uc1\pard{\pntext\f1\''B7\tab}{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\''B7}}\ul\b\f0\fs32 RichTextFormat\ulnone\b0\fs17\par}',null,null,null,'JO-002',6);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Repas végétarien','2016/05/13','8600','{\rtf1\ansi\ansicpg1252\deff0\deflang3084{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}{\f1\fnil\fcharset2 Symbol;}}
\viewkind4\uc1\pard{\pntext\f1\''B7\tab}{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\''B7}}\ul\b\f0\fs32 RichTextFormat\ulnone\b0\fs17\par}',null,null,null,'CH-002',3);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Logis fournis','2015/12/31','5912','{\rtf1\ansi\ansicpg1252\deff0\deflang3084{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}{\f1\fnil\fcharset2 Symbol;}}
\viewkind4\uc1\pard{\pntext\f1\''B7\tab}{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\''B7}}\ul\b\f0\fs32 RichTextFormat\ulnone\b0\fs17\par}',null,'Logis arrangé par l''organisateur',null,'CH-001',5);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Nourriture','2016/10/07',null,null,null,null,null,'CH-001',2);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Logement','2015/09/06',null,null,null,null,'20160517','JO-001',4);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Transport','2017/01/22',null,'{\rtf1\ansi\ansicpg1252\deff0\deflang3084{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}{\f1\fnil\fcharset2 Symbol;}}
\viewkind4\uc1\pard{\pntext\f1\''B7\tab}{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\''B7}}\ul\b\f0\fs32 RichTextFormat\ulnone\b0\fs17\par}',null,null,'20150226','JO-002',3);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Logement','2017/01/26',null,null,null,null,null,'CH-002',2);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Nourriture','2016/03/07',null,null,null,null,'20140829','QU-001',2);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Prix des billets','2017/03/19','9020',null,null,null,null,'MO-001',2);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Sonorisation et éclairage','2016/04/28','5459',null,null,null,'20161221','MO-001',6);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Transport','2015/12/07','5824',null,null,null,'20160824','QU-002',1);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Nourriture','2016/01/29','5454',null,null,null,null,'JO-002',1);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Heure de la prise de son','2017/06/21',null,'{\rtf1\ansi\ansicpg1252\deff0\deflang3084{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}{\f1\fnil\fcharset2 Symbol;}}
\viewkind4\uc1\pard{\pntext\f1\''B7\tab}{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\''B7}}\ul\b\f0\fs32 RichTextFormat\ulnone\b0\fs17\par}',null,null,null,'JO-002',4);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Sonorisation et éclairage','2016/04/15','9617','{\rtf1\ansi\ansicpg1252\deff0\deflang3084{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}{\f1\fnil\fcharset2 Symbol;}}
\viewkind4\uc1\pard{\pntext\f1\''B7\tab}{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\''B7}}\ul\b\f0\fs32 RichTextFormat\ulnone\b0\fs17\par}',null,null,null,'QU-001',3);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Logement','2016/12/04','9369',null,null,null,null,'QU-001',1);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Heure de la prise de son','2016/11/10', null,null,null,null,null,'MO-001',3);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Prix des billets','2016/04/30','7766',null,null,null,'20160412','JO-002',6);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Capacité','2016/05/31','7043',null,null,null,null,'QU-001',3);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Transport','2015/09/15','7683',null,null,null,'20160516','JO-002',4);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Heure de la prise de son','2016/09/23','5899',null,null,null,null,'QU-002',6);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Capacité','2016/04/05','7980',null,null,null,null,'QU-001',6);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Transport','2016/01/23','5567',null,null,null,'20150602','JO-001',1);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Nourriture','2015/12/06','8515',null,null,null,null,'CH-001',2);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Prix des billets','2017/07/16','9327',null,null,null,null,'MO-001',2);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Heure de la prise de son','2015/09/28','5835',null,null,null,'20150319','CH-001',3);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Sonorisation et éclairage','2017/03/08','9721',null,null,null,null,'QU-001',5);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Transport','2017/05/18','5850',null,null,null,'20160414','QU-001',4);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Nourriture','2015/12/30','5348',null,null,null,'20151019','MO-001',2);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Sonorisation et éclairage','2016/08/05','9847',null,null,null,null,'CH-001',6);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Capacité','2016/04/08','5385',null,null,null,null,'JO-001',6);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Logement','2016/09/08','6221',null,null,null,null,'MO-001',1);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Prix des billets','2016/07/08','6928',null,null,null,'20160323','CH-001',4);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Heure de la prise de son','2017/05/15','6295',null,null,null,null,'QU-001',4);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Prix des billets','2016/05/31','5970',null,null,null,null,'JO-001',5);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Sonorisation et éclairage','2016/05/14','9890',null,null,null,null,'CH-002',1);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Heure de la prise de son','2016/06/29','6647',null,null,null,null,'CH-001',5);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Heure de la prise de son','2016/06/29','6647',null,null,null,null,'WY-001',4);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Logement','2016/06/29','2346',null,null,null,null,'XN-002',3);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Prix des billets','2016/10/29','5679',null,null,null,null,'WY-001',4);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Nourriture','2016/06/29','8903',null,null,null,null,'XN-002',3);


GO
PRINT 'insertion des exigences terminée'
GO

/*insertion des engagements*/
GO
PRINT 'insertion des engagements débutée'
GO
INSERT INTO S_Contrat.tblEngagement([duree],[lieu],[date],[heure],[nature],[commentaire],[description],[descriptionCourte],[dateSupprime],[noContrat]) VALUES('3h00','Jonquière','2017/02/07','01:07:49','Levée de fonds',null,null,null,null,'QU-002');
INSERT INTO S_Contrat.tblEngagement([duree],[lieu],[date],[heure],[nature],[commentaire],[description],[descriptionCourte],[dateSupprime],[noContrat]) VALUES('1h30','Jonquière','2017/05/09','08:25:55','Concert',null,null,null,null,'JO-001');
INSERT INTO S_Contrat.tblEngagement([duree],[lieu],[date],[heure],[nature],[commentaire],[description],[descriptionCourte],[dateSupprime],[noContrat]) VALUES('3h00','Quebec','2017/07/30','08:18:31','Concert',null,null,null,null,'MO-001');
INSERT INTO S_Contrat.tblEngagement([duree],[lieu],[date],[heure],[nature],[commentaire],[description],[descriptionCourte],[dateSupprime],[noContrat]) VALUES('4h00','Jonquière','2017/05/24','02:27:27','Spectacle',null,null,null,null,'JO-001');
INSERT INTO S_Contrat.tblEngagement([duree],[lieu],[date],[heure],[nature],[commentaire],[description],[descriptionCourte],[dateSupprime],[noContrat]) VALUES('3h30','Montréal','2017/03/18','12:33:30','Spectacle',null,null,null,null,'QU-001');
INSERT INTO S_Contrat.tblEngagement([duree],[lieu],[date],[heure],[nature],[commentaire],[description],[descriptionCourte],[dateSupprime],[noContrat]) VALUES('3h30','Quebec','2017/07/29','08:09:26','Concert',null,null,null,null,'CH-002');
INSERT INTO S_Contrat.tblEngagement([duree],[lieu],[date],[heure],[nature],[commentaire],[description],[descriptionCourte],[dateSupprime],[noContrat]) VALUES('1h00','Montréal','2017/06/16','01:56:11','Spectacle',null,null,null,null,'CH-001');
INSERT INTO S_Contrat.tblEngagement([duree],[lieu],[date],[heure],[nature],[commentaire],[description],[descriptionCourte],[dateSupprime],[noContrat]) VALUES('4h00','Quebec','2017/08/19','04:22:13','Concert',null,null,null,null,'MO-001');
INSERT INTO S_Contrat.tblEngagement([duree],[lieu],[date],[heure],[nature],[commentaire],[description],[descriptionCourte],[dateSupprime],[noContrat]) VALUES('2h30','Quebec','2016/09/09','07:12:59','Concert',null,null,null,null,'QU-002');
INSERT INTO S_Contrat.tblEngagement([duree],[lieu],[date],[heure],[nature],[commentaire],[description],[descriptionCourte],[dateSupprime],[noContrat]) VALUES('4h00','Montréal','2017/04/29','11:49:10','Concert',null,null,null,null,'QU-001');
INSERT INTO S_Contrat.tblEngagement([duree],[lieu],[date],[heure],[nature],[commentaire],[description],[descriptionCourte],[dateSupprime],[noContrat]) VALUES('2h30','Jonquière','2017/06/27','01:08:58','Concert',null,null,null,null,'JO-002');
INSERT INTO S_Contrat.tblEngagement([duree],[lieu],[date],[heure],[nature],[commentaire],[description],[descriptionCourte],[dateSupprime],[noContrat]) VALUES('2h30','Jonquière','2017/07/09','04:54:52','Spectacle',null,null,null,null,'CH-001');
INSERT INTO S_Contrat.tblEngagement([duree],[lieu],[date],[heure],[nature],[commentaire],[description],[descriptionCourte],[dateSupprime],[noContrat]) VALUES('3h30','Jonquière','2017/07/14','12:35:57','Spectacle',null,null,null,null,'QU-001');
INSERT INTO S_Contrat.tblEngagement([duree],[lieu],[date],[heure],[nature],[commentaire],[description],[descriptionCourte],[dateSupprime],[noContrat]) VALUES('2h00','Quebec','2017/02/12','08:07:41','Spectacle',null,null,null,null,'QU-002');
INSERT INTO S_Contrat.tblEngagement([duree],[lieu],[date],[heure],[nature],[commentaire],[description],[descriptionCourte],[dateSupprime],[noContrat]) VALUES('4h00','Jonquière','2017/01/15','04:52:04','Spectacle',null,null,null,null,'QU-002');
INSERT INTO S_Contrat.tblEngagement([duree],[lieu],[date],[heure],[nature],[commentaire],[description],[descriptionCourte],[dateSupprime],[noContrat]) VALUES('2h30','Quebec','2017/09/01','11:48:55','Spectacle',null,null,null,null,'JO-002');
INSERT INTO S_Contrat.tblEngagement([duree],[lieu],[date],[heure],[nature],[commentaire],[description],[descriptionCourte],[dateSupprime],[noContrat]) VALUES('1h30','Montréal','2017/01/13','05:57:32','Concert',null,null,null,null,'JO-001');
INSERT INTO S_Contrat.tblEngagement([duree],[lieu],[date],[heure],[nature],[commentaire],[description],[descriptionCourte],[dateSupprime],[noContrat]) VALUES('3h30','Chicoutimi','2017/01/13','05:57:32','Concert',null,null,null,null,'WY-001');
INSERT INTO S_Contrat.tblEngagement([duree],[lieu],[date],[heure],[nature],[commentaire],[description],[descriptionCourte],[dateSupprime],[noContrat]) VALUES('3h30','Chicoutimi','2017/01/13','05:57:32','Concert',null,null,null,null,'XN-002');
INSERT INTO S_Contrat.tblEngagement([duree],[lieu],[date],[heure],[nature],[commentaire],[description],[descriptionCourte],[dateSupprime],[noContrat]) VALUES('2h30','Alma','2017/10/03','05:57:32','Spectacle',null,null,null,null,'WY-001');
INSERT INTO S_Contrat.tblEngagement([duree],[lieu],[date],[heure],[nature],[commentaire],[description],[descriptionCourte],[dateSupprime],[noContrat]) VALUES('3h30','Chicoutimi','2017/06/18','05:57:32','Concert',null,null,null,null,'XN-002');
INSERT INTO S_Contrat.tblEngagement([duree],[lieu],[date],[heure],[nature],[commentaire],[description],[descriptionCourte],[dateSupprime],[noContrat]) VALUES('6h30','Québec','2017/03/20','05:57:32','Spectacle',null,null,null,null,'XN-002');



GO
PRINT 'insertion des engagements terminée'
GO

/*insertion des responsables par contrats*/
GO
PRINT 'insertion des responsables par contrats débutée'
GO
INSERT INTO S_Contrat.tblRespoContrat([noResponsable],[noContrat]) VALUES(1,	'CH-001');
INSERT INTO S_Contrat.tblRespoContrat([noResponsable],[noContrat]) VALUES(3,	'JO-001');
INSERT INTO S_Contrat.tblRespoContrat([noResponsable],[noContrat]) VALUES(5,	'CH-002');
INSERT INTO S_Contrat.tblRespoContrat([noResponsable],[noContrat]) VALUES(7,	'JO-002');
INSERT INTO S_Contrat.tblRespoContrat([noResponsable],[noContrat]) VALUES(9,	'QU-001');
INSERT INTO S_Contrat.tblRespoContrat([noResponsable],[noContrat]) VALUES(11,	'QU-002');
INSERT INTO S_Contrat.tblRespoContrat([noResponsable],[noContrat]) VALUES(13,	'MO-001');
INSERT INTO S_Contrat.tblRespoContrat([noResponsable],[noContrat]) VALUES(2,	'CH-001');
INSERT INTO S_Contrat.tblRespoContrat([noResponsable],[noContrat]) VALUES(4,	'JO-001');
INSERT INTO S_Contrat.tblRespoContrat([noResponsable],[noContrat]) VALUES(6,	'CH-002');
INSERT INTO S_Contrat.tblRespoContrat([noResponsable],[noContrat]) VALUES(8,	'JO-002');
INSERT INTO S_Contrat.tblRespoContrat([noResponsable],[noContrat]) VALUES(10,	'QU-001');
INSERT INTO S_Contrat.tblRespoContrat([noResponsable],[noContrat]) VALUES(12,	'QU-002');
INSERT INTO S_Contrat.tblRespoContrat([noResponsable],[noContrat]) VALUES(14,	'MO-001');
INSERT INTO S_Contrat.tblRespoContrat([noResponsable],[noContrat]) VALUES(5,	'WY-001');
INSERT INTO S_Contrat.tblRespoContrat([noResponsable],[noContrat]) VALUES(6,	'WY-001');
INSERT INTO S_Contrat.tblRespoContrat([noResponsable],[noContrat]) VALUES(2,	'XN-002');
INSERT INTO S_Contrat.tblRespoContrat([noResponsable],[noContrat]) VALUES(3,	'XN-002');
GO
PRINT 'insertion des responsables par contrats terminée'
GO

/*insertion des artistes par contrats*/
GO
PRINT 'insertion des artistes par contrats débutée'
GO
INSERT INTO S_Contrat.tblContratArtiste([noArtiste],[noContrat]) VALUES(12,'MO-001');
INSERT INTO S_Contrat.tblContratArtiste([noArtiste],[noContrat]) VALUES(13,'QU-002');
INSERT INTO S_Contrat.tblContratArtiste([noArtiste],[noContrat]) VALUES(11,'MO-001');
INSERT INTO S_Contrat.tblContratArtiste([noArtiste],[noContrat]) VALUES(9,'JO-001');
INSERT INTO S_Contrat.tblContratArtiste([noArtiste],[noContrat]) VALUES(11,'JO-001');
INSERT INTO S_Contrat.tblContratArtiste([noArtiste],[noContrat]) VALUES(12,'JO-002');
INSERT INTO S_Contrat.tblContratArtiste([noArtiste],[noContrat]) VALUES(10,'CH-001');
INSERT INTO S_Contrat.tblContratArtiste([noArtiste],[noContrat]) VALUES(11,'CH-001');
INSERT INTO S_Contrat.tblContratArtiste([noArtiste],[noContrat]) VALUES(2,'MO-001');
INSERT INTO S_Contrat.tblContratArtiste([noArtiste],[noContrat]) VALUES(3,'CH-002');
INSERT INTO S_Contrat.tblContratArtiste([noArtiste],[noContrat]) VALUES(5,'WY-001');
INSERT INTO S_Contrat.tblContratArtiste([noArtiste],[noContrat]) VALUES(7,'XN-002');
INSERT INTO S_Contrat.tblContratArtiste([noArtiste],[noContrat]) VALUES(1,'WY-001');
INSERT INTO S_Contrat.tblContratArtiste([noArtiste],[noContrat]) VALUES(8,'XN-002');
GO
PRINT 'insertion des artistes par contrats terminée'
GO

/*insertion des fichier par artistes par contrats*/
GO
PRINT 'insertion des fichier par artistes par contrats débutée'
GO
INSERT INTO S_Contrat.tblFichierOfficiel([noArtiste],[noContrat],[noFichier]) VALUES(11,'CH-001',1);
INSERT INTO S_Contrat.tblFichierOfficiel([noArtiste],[noContrat],[noFichier]) VALUES(4,'CH-001',2);
INSERT INTO S_Contrat.tblFichierOfficiel([noArtiste],[noContrat],[noFichier]) VALUES(4,'MO-001',3);
INSERT INTO S_Contrat.tblFichierOfficiel([noArtiste],[noContrat],[noFichier]) VALUES(2,'QU-002',13);
INSERT INTO S_Contrat.tblFichierOfficiel([noArtiste],[noContrat],[noFichier]) VALUES(4,'JO-002',5);
INSERT INTO S_Contrat.tblFichierOfficiel([noArtiste],[noContrat],[noFichier]) VALUES(13,'QU-002',2);
INSERT INTO S_Contrat.tblFichierOfficiel([noArtiste],[noContrat],[noFichier]) VALUES(7,'QU-001',4);
INSERT INTO S_Contrat.tblFichierOfficiel([noArtiste],[noContrat],[noFichier]) VALUES(1,'JO-001',8);
INSERT INTO S_Contrat.tblFichierOfficiel([noArtiste],[noContrat],[noFichier]) VALUES(3,'WY-001',3);
INSERT INTO S_Contrat.tblFichierOfficiel([noArtiste],[noContrat],[noFichier]) VALUES(5,'XN-002',1);
GO
PRINT 'insertion des fichier par artistes par contrats terminée'
GO

/*insertion des catégories des artistes*/

GO
PRINT 'insertion des catégories des artistes débutée'
GO
INSERT INTO S_Contrat.tblCatArtisteArt([noArtiste],[noCategorie]) VALUES(4,2);
INSERT INTO S_Contrat.tblCatArtisteArt([noArtiste],[noCategorie]) VALUES(9,5);
INSERT INTO S_Contrat.tblCatArtisteArt([noArtiste],[noCategorie]) VALUES(13,1);
INSERT INTO S_Contrat.tblCatArtisteArt([noArtiste],[noCategorie]) VALUES(12,1);
INSERT INTO S_Contrat.tblCatArtisteArt([noArtiste],[noCategorie]) VALUES(13,5);
INSERT INTO S_Contrat.tblCatArtisteArt([noArtiste],[noCategorie]) VALUES(11,3);
INSERT INTO S_Contrat.tblCatArtisteArt([noArtiste],[noCategorie]) VALUES(10,6);
INSERT INTO S_Contrat.tblCatArtisteArt([noArtiste],[noCategorie]) VALUES(5,2);
INSERT INTO S_Contrat.tblCatArtisteArt([noArtiste],[noCategorie]) VALUES(8,3);
INSERT INTO S_Contrat.tblCatArtisteArt([noArtiste],[noCategorie]) VALUES(13,4);
INSERT INTO S_Contrat.tblCatArtisteArt([noArtiste],[noCategorie]) VALUES(1,2);
INSERT INTO S_Contrat.tblCatArtisteArt([noArtiste],[noCategorie]) VALUES(2,5);
INSERT INTO S_Contrat.tblCatArtisteArt([noArtiste],[noCategorie]) VALUES(3,1);
INSERT INTO S_Contrat.tblCatArtisteArt([noArtiste],[noCategorie]) VALUES(4,1);
INSERT INTO S_Contrat.tblCatArtisteArt([noArtiste],[noCategorie]) VALUES(5,5);
INSERT INTO S_Contrat.tblCatArtisteArt([noArtiste],[noCategorie]) VALUES(6,3);
INSERT INTO S_Contrat.tblCatArtisteArt([noArtiste],[noCategorie]) VALUES(7,6);
INSERT INTO S_Contrat.tblCatArtisteArt([noArtiste],[noCategorie]) VALUES(8,2);
INSERT INTO S_Contrat.tblCatArtisteArt([noArtiste],[noCategorie]) VALUES(9,3);
INSERT INTO S_Contrat.tblCatArtisteArt([noArtiste],[noCategorie]) VALUES(10,4);
GO
PRINT 'insertion des catégories des artistes terminée'
GO
PRINT 'insertion terminée'
/*Insertion des Utilisateur débutée*/
/*Insertion des Utilisateur terminé*/