--But : Création des données de test du package contrats
--Date : 29-08-2016
--Par : Simon Girard


USE PE2_Test
GO

/*insertion des adresses*/

GO
PRINT 'insertion des adresses débutée'
GO
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('SainteFlavie','E4O6I0','QC','Canada','4181755665','4184221810',5807, '2505 Rue Saint Hubert');
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Murdochville','H5K1G9','QC','Canada','4185996631','4187076683',9439, null);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Wekweti','D1C8D5','NT','Canada','4183707770','4184975797',8832, null);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Bay Roberts','D3Y1H7','NL','Canada','4188038712','4184374362',2171, null);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Lakeshore','Z1P9C4','ON','Canada','4187828760','4182441530',3733, null);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Charlottetown','M4U7W7','PE','Canada','4188094124','4182279533',6251, null);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Caplan','Y6Z4K6','QC','Canada','4181251564','4182594355',5340, null);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Whitehorse','J2X2F7','YT','Canada','4185518302','4189937396',839, null);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Kawartha Lakes','O7F0E6','ON','Canada','4185759408','4183226713',9922, null);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Tuktoyaktuk','I2S5P3','NT','Canada','4188157372','4188886104',8234, null);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Gravelbourg','C0W2I9','SK','Canada','4181957702','4184407891',1070, null);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Bay Roberts','O2N5S8','NL','Canada','4181531514','4187161949',5900, null);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Arviat','E5R1J3','NU','Canada','4188296563','4188296563',1254, null);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Whitehorse','S8L1A3','YT','Canada','4184820847','4182594900',54, null);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Whitehorse','M0A7C0','YT','Canada','4189088995','4181435113',4, null);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Kearny','F5F2Q2','ON','Canada','4187675272','4188250409',8938, null);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Tulita','X7H9X9','NT','Canada','4184517009','4187488001',null, null);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Fraser Lake','M6T7N2','BC','Canada','4188261336','4186370777',2700, null);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Fredericton','M6M3S6','NB','Canada','4185122464','4181074914',null, null);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Fortune','L9D0R8','NL','Canada','4185262276','4184055003',7811, null);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('MansfieldetPontefract','G7B8O7','QC','Canada','4184473760','4188618109',null, null);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Argyle','B5Y2Z0','NS','Canada','4184478593','4184478593',4468, null);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Weyburn','W8R9N3','SK','Canada','4186474587','4188169626',null, null);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Fort McPherson','G5I3G5','NT','Canada','4183872302','4183219935',6440, null);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Minitonas','Z8H2Y3','MB','Canada','4182452811','4182452811',3598, null);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Fredericton','W3B9T7','NB','Canada','4187381094','4184316029',1505, null);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Harbour Grace','U9Q5L0','NL','Canada','4186441434','4188805329',7937, null);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Port Coquitlam','S8G0Y9','BC','Canada','4183969822','4184153973',4950, null);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Saint John','V3S5Q6','NB','Canada','4184187658','4182105046',7297, null);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Saguenay','S0C5S1','QC','Canada','4188837600','4185887999',8426, null);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Arviat','Z1Q3E8','NU','Canada','4184594117','4188096763',9253, null);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Edmundston','M9P2I2','NB','Canada','4185376718','4186438138',7077, null);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Minitonas','O4C2J7','MB','Canada','4187351849','4183013060',4633, null);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Fort Providence','G8I4V8','NT','Canada','4184002201','4189134675',3379, null);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Moncton','P9F4Y0','NB','Canada','4184943873','4189474731',8245, null);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Weyburn','N4L8Z4','SK','Canada','4187414424','4184564069',8107, null);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension],[adresse]) VALUES('Gjoa Haven','T8G2A3','NU','Canada','4187423404','4185457833',7597, null);
GO
PRINT 'insertion des adresses réussi'
GO

/*insertion des diffuseurs*/

GO
PRINT 'insertion des diffuseurs débutée'
GO
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Tazzy', 'bclark0@apache.org', '20160613', 1);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Photofeed', 'wwoods1@opera.com', '20160213', 2);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Wikido', 'rdixon2@php.net', null, 3);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Brainlounge', 'cmitchell3@latimes.com', null, 4);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Jaxbean', 'ereyes4@scientificamerican.com', null, 5);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Browsebug', 'jperez5@GOogle.fr', null, 6);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Yodel', 'jhayes6@is.gd', null, 7);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Brainsphere', 'frobinson7@GOogle.de', null, 8);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Zooveo', 'dmontGOmery8@yellowpages.com', null, 9);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Photolist', 'rcrawford9@360.cn', null, 10);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Leexo', 'rdaya@mysql.com', null, 11);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Skippad', 'athompsonb@weather.com', null, 12);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Oodoo', 'gharrisc@purevolume.com', null, 13);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Meevee', 'fgriffind@samsung.com', null, 14);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Feedspan', 'wcastilloe@ustream.tv', null, 15);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Tagcat', 'aowensf@GOogle.com.hk', null, 16);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Quatz', 'jmeyerg@sciencedaily.com', null, 17);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Flashdog', 'jalexanderh@livejournal.com', null, 18);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Yacero', 'sjohnsoni@cdc.GOv', null, 19);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Jayo', 'lmeyerj@people.com.cn', null, 20);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Avaveo', 'wkelleyk@cornell.edu', null, 21);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Demivee', 'nlopezl@opensource.org', '20160227', 22);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Yotz', 'lwheelerm@si.edu', null, 23);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Topiczoom', 'tkingn@usa.GOv', null, 24);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Demimbu', 'pmedinao@purevolume.com', null, 25);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Flipopia', 'cwebbp@businessinsider.com', null, 26);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Zoombox', 'jmartinq@latimes.com', null, 27);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Einti', 'jgreenr@miitbeian.GOv.cn', null, 28);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Layo', 'scoopers@xrea.com', null, 29);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Oozz', 'flyncht@bigcartel.com', null, 30);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Edgeify', 'kfloresu@biglobe.ne.jp', null, 31);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Midel', 'sbishopv@wordpress.org', null, 32);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Browsezoom', 'vchavezw@businessweek.com', null, 33);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Zooxo', 'hstephensx@mac.com', null, 34);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Vidoo', 'bromeroy@unicef.org', '20160105', 35);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Photobug', 'dbishopz@ca.GOv', null, 36);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Flipstorm', 'wolson10@purevolume.com', null, 37);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Yakidoo', 'bhall11@fda.GOv', null, 38);
GO
PRINT 'insertion des diffuseurs réussi'
GO

/*insertion des Agences*/

GO
PRINT 'insertion des Agences débutée'
GO
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Voonyx27','Voonyx', 'valvarez0@umn.edu', null, 1);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Rhyloo01','Rhyloo', 'bpierce1@drupal.org', '20160213', 2);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('chatter91','Chatterbridge', 'rburns2@yelp.com', null, 3);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Oyonde43','Oyonder', 'eallen3@comcast.net', null, 4);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Einti12','Einti', 'kwright4@themeforest.net', null, 5);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Twimbo98','Twimbo', 'rrichardson5@GOo.gl', null, 17);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Browsez41','Browsezoom', 'wking6@bloglovin.com', null, 6);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Gigabo54','Gigabox', 'pwheeler7@paginegialle.it', null, 7);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Aiveez13','Aivee', 'cstewart8@umich.edu', null, 8);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Brainv53','Brainverse', 'agray9@accuweather.com', null, 10);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Gabcub90','Gabcube', 'rmatthewsa@upenn.edu', null, 11);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Teklis84','Teklist', 'rbellb@live.com', null, 12);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Twinte00','Twinte', 'rmedinac@netscape.com', null, 13);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Demizz23','Demizz', 'thansend@friendfeed.com', null, 14);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Linkty46','Linktype', 'mrobinsone@cdbaby.com', '20160414', 15);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Shuffle85','Shufflebeat', 'vmartinezf@yellowbook.com', null, 16);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Twinder06','Twinder', 'mramirezg@networksolutions.com', null, 21);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Yamiaz61','Yamia', 'kfranklinh@networkadvertising.org', null, 22);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Fiveb86','Fivebridge', 'bbradleyi@shinystat.com', null, 23);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Youopi50','Youopia', 'cmorrisonj@blinklist.com', null, 24);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Yakijo34','Yakijo', 'cclarkk@mediafire.com', null, 25);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Browsez00','Browsezoom', 'ecollinsl@is.gd', null, 26);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Podcat78','Podcat', 'pphillipsm@hc360.com', null, 27);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Eadelp75','Eadel', 'jmasonn@dmoz.org', null, 28);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Eimbee13','Eimbee', 'mnicholso@newsvine.com', null, 29);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Skippa01','Skippad', 'dcruzp@nasa.GOv', null, 17);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Photob34','Photobug', 'lrileyq@howstuffworks.com', null, 18);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Topics81','Topicstorm', 'pdeanr@bloglines.com', null, 19);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Photob11','Photobug', 'jburtons@posterous.com', null, 20);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Topdri28','Topdrive', 'dwhitet@GOo.ne.jp', null, 30);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Yodooz94','Yodoo', 'stayloru@epa.GOv', null, 31);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Oyoyoz39','Oyoyo', 'jdeanv@mediafire.com', '20131113', 32);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Linkty09','Linktype', 'bbradleyw@hud.GOv', null, 33);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Dabvin64','Dabvine', 'jpetersonx@tamu.edu', null, 34);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Fivebr56','Fivebridge', 'kclarky@lycos.com', null, 35);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Realcu06','Realcube', 'dwallacez@bloglines.com', null, 36);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Blogta01','Blogtag', 'kbrown10@blogger.com', null, 37);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Though77','Thoughtbridge', 'aburke11@psu.edu', '20160213', 9);
INSERT INTO S_Contrat.tblAgence (noAgence, nom, courriel, dateSupprime, noAdresse) VALUES ('Camido97','Camido', 'jwoods12@hud.GOv', null, 38);
GO
PRINT 'insertion des agences réussi'
GO
/*insertion des responsables*/

GO
PRINT 'insertion des responsables débutée'
GO


INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Cruz', 'George', 'gcruz0@state.tx.us', 'George Cruz', '2016/01/15', '8631113471', '5734372137', null, 0, null, 1, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Carter', 'Christina', 'ccarter1@GOogle.de', 'Christina Carter', '2016/07/22', '3856281598', '6327071769', 364, 0, null, 2, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Hart', 'Barbara', 'bhart2@sun.com', 'Barbara Hart', '2016/02/04', '6925115065', '1303156481', 913, 0, null, 3, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Henry', 'Ruth', 'rhenry3@livejournal.com', 'Ruth Henry', '2016/04/25', '5281157420', '6324147750', 265, 0, '20160613', 4, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Mason', 'Nicholas', 'nmason4@hc360.com', 'Nicholas Mason', '2015/12/08', '3511950020', '9671684340', 262, 1, null, 5, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Young', 'Walter', 'wyoung5@sina.com.cn', 'Walter Young', '2016/02/11', '6359817195', '5182891148', 146, 1, null, 6, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Chavez', 'Julia', 'jchavez6@ibm.com', 'Julia Chavez', '2016/05/03', '3327172914', '3562601110', null, 0, null, 7, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Hill', 'Emily', 'ehill7@illinois.edu', 'Emily Hill', '2015/11/03', '5578512986', '6280071160', 138, 0, null, 8, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Walker', 'Kathy', 'kwalker8@purevolume.com', 'Kathy Walker', '2015/10/16', '1919815061', '6224815701', 161, 1, '20160113', 9, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Hicks', 'Chris', 'chicks9@GOo.ne.jp', 'Chris Hicks', '2016/01/19', '6322134224', '5730717164', null, 0, null, 10, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Price', 'Carl', 'cpricea@jugem.jp', 'Carl Price', '2016/03/10', '9987127017', '8617165705', 651, 0, null, 11, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Oliver', 'Frances', 'foliverb@army.mil', 'Frances Oliver', '2016/07/30', '4851942270', '5560317957', 702, 1, null, 11, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Warren', 'Brandon', 'bwarrenc@businessweek.com', 'Brandon Warren', '2015/09/05', '5571374038', '6275116346', 528, 0, null, 11, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Clark', 'Barbara', 'bclarkd@ibm.com', 'Barbara Clark', '2015/10/16', '5245261440', '5537911456', null, 1, null, 11, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Kim', 'Albert', 'akime@tonline.de', 'Albert Kim', '2015/11/12', '3811101326', '1151318981', 660, 0, null, null, 'Camido97');
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Hunt', 'Laura', 'lhuntf@sina.com.cn', 'Laura Hunt', '2016/01/21', '8689912348', '2353017490', 117, 1, '20160613', null,'Oyoyoz39');
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Rice', 'Judith', 'jriceg@army.mil', 'Judith Rice', '2016/02/02', '5048111875', '6263170508', 509, 0, null, 12, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Ellis', 'Lillian', 'lellish@indiatimes.com', 'Lillian Ellis', '2016/08/09', '3171709947', '4823139054', 277, 0, null, null, 'Dabvin64');
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Mills', 'Kenneth', 'kmillsi@comcast.net', 'Kenneth Mills', '2016/01/10', '2515132240', '6239167736', 308, 0, null, null, 'Skippa01');
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Sims', 'Howard', 'hsimsj@zimbio.com', 'Howard Sims', '2016/04/02', '5482271992', '1261591831', 488, 0, null, null, 'Browsez00');
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Griffin', 'James', 'jgriffink@booking.com', 'James Griffin', '2016/07/07', '4201311689', '5571630869', 637, 0, null, null, 'Youopi50');
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Murphy', 'Eugene', 'emurphyl@stanford.edu', 'Eugene Murphy', '2015/10/11', '9365318046', '2341289629', 516, 0, null, null, 'Yamiaz61');
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Rose', 'Robin', 'rrosem@nsw.GOv.au', 'Robin Rose', '2016/08/19', '9703913190', '8611204331', 736, 0, null, null, 'Realcu06');
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Arnold', 'Joe', 'jarnoldn@mac.com', 'Joe Arnold', '2016/06/07', '6241471121', '1671440772', 273, 1, null, null, 'Though77');
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Davis', 'Helen', 'hdaviso@bloomberg.com', 'Helen Davis', '2016/08/27', '8641311420', '1610313270', 746, 0, null, null, 'Aiveez13');
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Ryan', 'Stephanie', 'sryanp@shoppro.jp', 'Stephanie Ryan', '2016/05/05', '7761833176', '2488146532', 512, 0, null, 35, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Hudson', 'Frank', 'fhudsonq@macromedia.com', 'Frank Hudson', '2015/11/14', '5792651523', '3862101486', 149, 0, '20130613', 26, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Morgan', 'Paula', 'pmorganr@GOogle.de', 'Paula Morgan', '2015/11/26', '8620734135', '5848122908', 826, 0, null, 17, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Sullivan', 'Chris', 'csullivans@abc.net.au', 'Chris Sullivan', '2016/01/26', '5585411605', '8126163730', 856, 0, null, 8, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Howard', 'Jimmy', 'jhowardt@addtoany.com', 'Jimmy Howard', '2016/07/20', '8647684121', '3165419184', 594, 0, '20140613', 17, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Hunter', 'Barbara', 'bhunteru@narod.ru', 'Barbara Hunter', '2015/12/17', '8691148701', '7716177581', 235, 1, null, 9, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, dateSignature, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Fields', 'Charles', 'cfieldsv@tonline.de', 'Charles Fields', '2016/05/19', '3863106232', '8114110334', 992, 0, null, 29, null);
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
GO
PRINT 'insertion des Catégories d''artistes réussi'
GO


/*insertion des artistes

Modifier certaines dateSupprime pour ne pas qu'elles soient toutes

Rajouter des commentaires pour certains*/

GO
PRINT 'insertion des artistes débutée'
GO

INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Howard Rodriguez', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Matthew Fowler', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Dennis Garza', 'N''a pas répondu à son dernier appel', null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Betty Mccoy', 'Photo à ajouter', null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Donald Collins', 'Donald ne veut pas qu''on le contacte le matin.', null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Jerry Rodriguez', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Julie Alexander', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Gloria Mills', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Sandra Mason', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Lois Rivera', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Martin Mills', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Lois Riley', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Catherine Meyer', 'Catherine veut qu''on passe par son agent.', null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Karen Ferguson', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Carol Thompson', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Denise Cunningham', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Melissa Patterson', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Kathryn Oliver', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Larry Lane', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Dorothy Bryant', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Todd Clark', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Kenneth Henry', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Bobby Hanson', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Tammy Hall', 'Mettre à jour l''image de l''artiste', null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Cheryl Rogers', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Anthony Hall', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Scott Graham', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Wayne Morgan',null, null);
GO
PRINT 'insertion des artistes réussi'
GO

/*insertion des Fichier Personnel*/

GO
PRINT 'insertion des artistes débutée'
GO
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Photo','C:\\Users\\utilisateur.DESKTOP-7L405VB\\Desktop\\Photos\\photo.jpg','On devrait s''en mettre une avec plus de lumière',1,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Photo','C:\\photos\\photo.jpg','La photo devrait être rotaté',2,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Photo','C:\\Users\\utilisateur.DESKTOP-7L405VB\\Desktop\\Photos\\photo.jpg','Je trouve que cette photo n''a pas été prise dans le bon angle',3,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Document','D:\\documents artistes\\document.docx','Manque la page 3?????\nEst ou',4,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Photo','C:\\photos\\photo.jpg','On devrait recadrer la photo',5,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Photo','C:\\Users\\utilisateur.DESKTOP-7L405VB\\Desktop\\Photos\\photo.jpg','Ne représente pas l''artiste',6,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Document','D:\\documents artistes\\document.docx','Pas oublier de faire la page titre',7,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Photo','C:\\Users\\utilisateur.DESKTOP-7L405VB\\Desktop\\Photos\\photo.jpg','Ca serait pas mieux sans lunettes????',8,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Document','C:\\photos\\photo.jpg',null,9,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Photo','C:\\Users\\utilisateur.DESKTOP-7L405VB\\Desktop\\Photos\\photo.jpg',null,10,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Document','D:\\documents artistes\\document.docx',null,11,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Document','C:\\photos\\photo.jpg',null,12,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Photo','C:\\photos\\photo.jpg',null,13,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Document','D:\\documents artistes\\document.docx',null,14,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Photo','C:\\Users\\utilisateur.DESKTOP-7L405VB\\Desktop\\Photos\\photo.jpg',null,15,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Document','D:\\documents artistes\\document.docx',null,16,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Photo','C:\\Users\\utilisateur.DESKTOP-7L405VB\\Desktop\\Photos\\photo.jpg',null,17,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Document','C:\\photos\\photo.jpg',null,18,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Photo','C:\\Users\\utilisateur.DESKTOP-7L405VB\\Desktop\\Photos\\photo.jpg',null,19,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Photo','C:\\Users\\utilisateur.DESKTOP-7L405VB\\Desktop\\Photos\\photo.jpg',null,20,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Photo','C:\\Users\\utilisateur.DESKTOP-7L405VB\\Desktop\\Photos\\photo.jpg',null,21,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Photo','C:\\Users\\utilisateur.DESKTOP-7L405VB\\Desktop\\Photos\\photo.jpg',null,22,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Photo','C:\\Users\\utilisateur.DESKTOP-7L405VB\\Desktop\\Photos\\photo.jpg',null,23,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Document','D:\\documents artistes\\document.docx',null,24,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Document','D:\\documents artistes\\document.docx',null,25,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Document','D:\\documents artistes\\document.docx',null,26,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Photo','C:\\Users\\utilisateur.DESKTOP-7L405VB\\Desktop\\Photos\\photo.jpg',null,27,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Document','D:\\documents artistes\\document.docx',null,28,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Photo','C:\\Users\\utilisateur.DESKTOP-7L405VB\\Desktop\\Photos\\photo.jpg',null,1,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Photo','C:\\Users\\utilisateur.DESKTOP-7L405VB\\Desktop\\Photos\\photo.jpg',null,2,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Photo','C:\\Users\\utilisateur.DESKTOP-7L405VB\\Desktop\\Photos\\photo.jpg',null,3,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Document','D:\\documents artistes\\document.docx',null,4,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Document','D:\\documents artistes\\document.docx',null,5,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Photo','C:\\Users\\utilisateur.DESKTOP-7L405VB\\Desktop\\Photos\\photo.jpg',null,6,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Photo','C:\\photos\\photo.jpg',null,7,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Document','C:\\photos\\photo.jpg',null,8,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Photo','C:\\Users\\utilisateur.DESKTOP-7L405VB\\Desktop\\Photos\\photo.jpg',null,9,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Photo','C:\\Users\\utilisateur.DESKTOP-7L405VB\\Desktop\\Photos\\photo.jpg',null,10,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Photo','C:\\photos\\photo.jpg',null,11,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Document','D:\\documents artistes\\document.docx',null,12,null);
GO
PRINT 'insertion des artistes réussie'
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
INSERT INTO S_Contrat.tblContrat (noContrat, lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('CH-001', 'Chicoutimi', 'Musique d''ouverture des spectacles de la semaine 1', 'L''orchestre du conservatoire pour l''ouverture des show d''humour', null, null, 3, 'Yakijo34'); 
INSERT INTO S_Contrat.tblContrat (noContrat, lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('JO-001', 'Jonquière', 'Musique d''ouverture des spectacles de la semaine 2', 'L''orchestre du conservatoire pour l''ouverture des show d''humour', 'Un des membre devra être absent pour cause de maladie', null, 1, 'Rhyloo01');
INSERT INTO S_Contrat.tblContrat (noContrat, lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('CH-002', 'Chicoutimi', 'Humoriste du matin', 'Martin matte viendra se vanter chez nous', null, null, 2, 'Twinte00');
INSERT INTO S_Contrat.tblContrat (noContrat, lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('JO-002', 'Jonquière', 'Humoriste du soir', 'Soirée de rire avec Jean-Michel Anctil', 'Pas oublier d''ajouter les exigences de la semaine prochaine', null, 4, 'Twinder06');
INSERT INTO S_Contrat.tblContrat (noContrat, lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('QU-001', 'Québec', 'Animation du midi semaine 1', 'Cracheurs de feu des fous du roi', null, null, 4, 'Voonyx27');
INSERT INTO S_Contrat.tblContrat (noContrat, lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('QU-002', 'Québec', 'Animation du midi semaine 2', 'L''animation du midi avec clown des fous du roi', null, null, 2, 'Twimbo98');
INSERT INTO S_Contrat.tblContrat (noContrat, lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('MO-001', 'Montréal', 'Animation du midi semaine 1', null, null, '20160613', 4, 'Yakijo34');
GO
PRINT 'insertion des contrats terminée'
GO

/*insertion des exigences*/

GO
PRINT 'insertion des exigences commencée'
GO
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Bouteilles d''eau','2016/08/21','5697','Les clients veulent avoir des bouteilles d''eau gratuites',null,'Eau gratuite fournie',null,'QU-001',2);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Alcool','2016/09/06','8235','Le client veux avoir l''alcool de payé dans la loge',null,'Alcool fournie dans la loge','20161230','CH-002',4);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Repas fournis','2017/04/03','6754','Le client demande a avoir un repas fourni dans sa loge',null,'Le client veut son repas inclus dans sa loge',null,'JO-002',6);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Repas végétarien','2016/05/13','8600','Le client demande a n''avoir que des repas végétariens servis dans sa loge',null,'Le client veut des repas végétariens uniquement',null,'CH-002',3);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Logis fournis','2015/12/31','5912','Le client demande d''avoir l''hôtel fourni',null,'Hotel fourni par l''organisateur',null,'CH-001',5);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Nourriture','2016/10/07',null,null,null,null,null,'CH-001',2);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Logement','2015/09/06',null,null,null,null,'20160517','JO-001',4);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Transport','2017/01/22',null,'Responsabilité de l''artiste',null,null,'20150226','JO-002',3);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Logement','2017/01/26',null,null,null,null,null,'CH-002',2);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Nourriture','2016/03/07',null,null,null,null,'20140829','QU-001',2);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Prix des billets','2017/03/19','9020',null,null,null,null,'MO-001',2);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Sonorisation et éclairage','2016/04/28','5459',null,null,null,'20161221','MO-001',6);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Transport','2015/12/07','5824',null,null,null,'20160824','QU-002',1);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Nourriture','2016/01/29','5454',null,null,null,null,'JO-002',1);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Heure de la prise de son','2017/06/21',null,'vers 3h',null,null,null,'JO-002',4);
INSERT INTO S_Contrat.tblExigence([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Sonorisation et éclairage','2016/04/15','9617','Fourni par le diffuseur',null,null,null,'QU-001',3);
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
GO
PRINT 'insertion des engagements terminée'
GO

/*insertion des responsables par contrats*/
GO
PRINT 'insertion des responsables par contrats débutée'
GO
INSERT INTO S_Contrat.tblRespoContrat([noResponsable],[noContrat]) VALUES(27,'CH-001');
INSERT INTO S_Contrat.tblRespoContrat([noResponsable],[noContrat]) VALUES(18,'CH-001');
INSERT INTO S_Contrat.tblRespoContrat([noResponsable],[noContrat]) VALUES(23,'JO-001');
INSERT INTO S_Contrat.tblRespoContrat([noResponsable],[noContrat]) VALUES(1,'CH-001');
INSERT INTO S_Contrat.tblRespoContrat([noResponsable],[noContrat]) VALUES(6,'QU-001');
INSERT INTO S_Contrat.tblRespoContrat([noResponsable],[noContrat]) VALUES(23,'MO-001');
INSERT INTO S_Contrat.tblRespoContrat([noResponsable],[noContrat]) VALUES(5,'JO-002');
INSERT INTO S_Contrat.tblRespoContrat([noResponsable],[noContrat]) VALUES(10,'CH-001');
INSERT INTO S_Contrat.tblRespoContrat([noResponsable],[noContrat]) VALUES(29,'JO-001');
INSERT INTO S_Contrat.tblRespoContrat([noResponsable],[noContrat]) VALUES(13,'CH-002');
GO
PRINT 'insertion des responsables par contrats terminée'
GO

/*insertion des artistes par contrats*/
GO
PRINT 'insertion des artistes par contrats débutée'
GO
INSERT INTO S_Contrat.tblContratArtiste([noArtiste],[noContrat]) VALUES(16,'MO-001');
INSERT INTO S_Contrat.tblContratArtiste([noArtiste],[noContrat]) VALUES(7,'MO-001');
INSERT INTO S_Contrat.tblContratArtiste([noArtiste],[noContrat]) VALUES(27,'MO-001');
INSERT INTO S_Contrat.tblContratArtiste([noArtiste],[noContrat]) VALUES(9,'JO-001');
INSERT INTO S_Contrat.tblContratArtiste([noArtiste],[noContrat]) VALUES(17,'JO-001');
INSERT INTO S_Contrat.tblContratArtiste([noArtiste],[noContrat]) VALUES(4,'JO-002');
INSERT INTO S_Contrat.tblContratArtiste([noArtiste],[noContrat]) VALUES(16,'CH-001');
INSERT INTO S_Contrat.tblContratArtiste([noArtiste],[noContrat]) VALUES(9,'CH-001');
INSERT INTO S_Contrat.tblContratArtiste([noArtiste],[noContrat]) VALUES(17,'MO-001');
INSERT INTO S_Contrat.tblContratArtiste([noArtiste],[noContrat]) VALUES(23,'CH-002');
GO
PRINT 'insertion des artistes par contrats terminée'
GO

/*insertion des fichier par artistes par contrats*/
GO
PRINT 'insertion des fichier par artistes par contrats débutée'
GO
INSERT INTO S_Contrat.tblFichierOfficiel([noArtiste],[noContrat],[noFichier]) VALUES(11,'CH-002',22);
INSERT INTO S_Contrat.tblFichierOfficiel([noArtiste],[noContrat],[noFichier]) VALUES(4,'CH-001',24);
INSERT INTO S_Contrat.tblFichierOfficiel([noArtiste],[noContrat],[noFichier]) VALUES(4,'MO-001',10);
INSERT INTO S_Contrat.tblFichierOfficiel([noArtiste],[noContrat],[noFichier]) VALUES(11,'JO-002',19);
INSERT INTO S_Contrat.tblFichierOfficiel([noArtiste],[noContrat],[noFichier]) VALUES(9,'CH-001',20);
INSERT INTO S_Contrat.tblFichierOfficiel([noArtiste],[noContrat],[noFichier]) VALUES(20,'QU-002',12);
INSERT INTO S_Contrat.tblFichierOfficiel([noArtiste],[noContrat],[noFichier]) VALUES(14,'JO-001',2);
INSERT INTO S_Contrat.tblFichierOfficiel([noArtiste],[noContrat],[noFichier]) VALUES(13,'QU-002',25);
INSERT INTO S_Contrat.tblFichierOfficiel([noArtiste],[noContrat],[noFichier]) VALUES(7,'QU-001',7);
INSERT INTO S_Contrat.tblFichierOfficiel([noArtiste],[noContrat],[noFichier]) VALUES(17,'JO-001',24);
GO
PRINT 'insertion des fichier par artistes par contrats terminée'
GO

/*insertion des catégories des artistes*/

GO
PRINT 'insertion des catégories des artistes débutée'
GO
INSERT INTO S_Contrat.tblCatArtisteArt([noArtiste],[noCategorie]) VALUES(11,2);
INSERT INTO S_Contrat.tblCatArtisteArt([noArtiste],[noCategorie]) VALUES(12,5);
INSERT INTO S_Contrat.tblCatArtisteArt([noArtiste],[noCategorie]) VALUES(23,1);
INSERT INTO S_Contrat.tblCatArtisteArt([noArtiste],[noCategorie]) VALUES(12,1);
INSERT INTO S_Contrat.tblCatArtisteArt([noArtiste],[noCategorie]) VALUES(23,5);
INSERT INTO S_Contrat.tblCatArtisteArt([noArtiste],[noCategorie]) VALUES(11,3);
INSERT INTO S_Contrat.tblCatArtisteArt([noArtiste],[noCategorie]) VALUES(10,6);
INSERT INTO S_Contrat.tblCatArtisteArt([noArtiste],[noCategorie]) VALUES(12,2);
INSERT INTO S_Contrat.tblCatArtisteArt([noArtiste],[noCategorie]) VALUES(8,3);
INSERT INTO S_Contrat.tblCatArtisteArt([noArtiste],[noCategorie]) VALUES(18,4);
GO
PRINT 'insertion des catégories des artistes terminée'
GO
PRINT 'insertion terminée'
GO
