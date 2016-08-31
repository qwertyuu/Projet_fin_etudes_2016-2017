--But : Création des données de test du package contrats
--Date : 29-08-2016
--Par : Simon Girard


USE PE2_Test
GO

--VÉRIFIER L'ORDRE DE CRÉATION AVANT LA CRÉATION

/*insertion des responsables*/

GO
PRINT 'insertion des responsables débutée'
GO

GO
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Cruz', 'George', 'gcruz0@state.tx.us', 'George Cruz', '2016/01/15', '8631113471', '5734372137', 865, false, null, 1, 11);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Carter', 'Christina', 'ccarter1@GOogle.de', 'Christina Carter', '2016/07/22', '38562815981', '6327071769', 364, false, null, 23, 1);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Hart', 'Barbara', 'bhart2@sun.com', 'Barbara Hart', '2016/02/04', '6925115065', '130315648', 913, false, null, 34, 2);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Henry', 'Ruth', 'rhenry3@livejournal.com', 'Ruth Henry', '2016/04/25', '5281157420', '6324147750', 265, false, 2016/06/13), 31, 3);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Mason', 'Nicholas', 'nmason4@hc360.com', 'Nicholas Mason', '2015/12/08', '35119500200', '96716843409', 262, true, null, 27, 4);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Young', 'Walter', 'wyoung5@sina.com.cn', 'Walter Young', '2016/02/11', '6359817195', '5182891148', 146, true, null, 21, 5);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Chavez', 'Julia', 'jchavez6@ibm.com', 'Julia Chavez', '2016/05/03', '3327172914', '35626011103', 281, false, null, 6, 6);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Hill', 'Emily', 'ehill7@illinois.edu', 'Emily Hill', '2015/11/03', '5578512986', '6280071160', 138, false, null, 7, 7);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Walker', 'Kathy', 'kwalker8@purevolume.com', 'Kathy Walker', '2015/10/16', '191981506', '6224815701', 161, true, 2016/01/13), 8, 8);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Hicks', 'Chris', 'chicks9@GOo.ne.jp', 'Chris Hicks', '2016/01/19', '6322134224', '5730717164', 653, false, null, 9, 9);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Price', 'Carl', 'cpricea@jugem.jp', 'Carl Price', '2016/03/10', '99871270173', '8617165705', 651, false, null, 11, 10);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Oliver', 'Frances', 'foliverb@army.mil', 'Frances Oliver', '2016/07/30', '4851942270', '5560317957', 702, true, null, 11, 10);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Warren', 'Brandon', 'bwarrenc@businessweek.com', 'Brandon Warren', '2015/09/05', '5571374038', '6275116346', 528, false, null, 11, 11);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Clark', 'Barbara', 'bclarkd@ibm.com', 'Barbara Clark', '2015/10/16', '5245261440', '5537911456', 942, true, null, 11, 12);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Kim', 'Albert', 'akime@tonline.de', 'Albert Kim', '2015/11/12', '38111013266', '115131898', 660, false, null, 14, 13);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Hunt', 'Laura', 'lhuntf@sina.com.cn', 'Laura Hunt', '2016/01/21', '8689912348', '23530174902', 117, false, 20165/06/13 17,24, 14);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Rice', 'Judith', 'jriceg@army.mil', 'Judith Rice', '2016/02/02', '50481118756', '6263170508', 509, true, null, 12, 15);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Ellis', 'Lillian', 'lellish@indiatimes.com', 'Lillian Ellis', '2016/08/09', '3171709947', '4823139054', 277, false, null, 16, 16);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Mills', 'Kenneth', 'kmillsi@comcast.net', 'Kenneth Mills', '2016/01/10', '25151322405', '6239167736', 308, false, null, 19, 18);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Sims', 'Howard', 'hsimsj@zimbio.com', 'Howard Sims', '2016/04/02', '5482271992', '126159183', 488, false, null, 10, 19);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Griffin', 'James', 'jgriffink@booking.com', 'James Griffin', '2016/07/07', '42013116890', '5571630869', 637, false, null, 14, 20);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Murphy', 'Eugene', 'emurphyl@stanford.edu', 'Eugene Murphy', '2015/10/11', '9365318046', '23412896299', 516, false, null, 19, 21);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Rose', 'Robin', 'rrosem@nsw.GOv.au', 'Robin Rose', '2016/08/19', '97039131907', '8611204331', 736, false, null, 22, 22);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Arnold', 'Joe', 'jarnoldn@mac.com', 'Joe Arnold', '2016/06/07', '6241471121', '167144077', 273, true, null, 29, 23);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Davis', 'Helen', 'hdaviso@bloomberg.com', 'Helen Davis', '2016/08/27', '8641311420', '161031270', 746, false, null, 34, 24);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Ryan', 'Stephanie', 'sryanp@shoppro.jp', 'Stephanie Ryan', '2016/05/05', '776183176', '24881465362', 512, false, null, 35, 26);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Hudson', 'Frank', 'fhudsonq@macromedia.com', 'Frank Hudson', '2015/11/14', '5792651523', '38621014886', 149, false, 2013/06/13, 26, 28);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Morgan', 'Paula', 'pmorganr@GOogle.de', 'Paula Morgan', '2015/11/26', '8620734135', '5848122908', 826, false, null, 17, 29);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Sullivan', 'Chris', 'csullivans@abc.net.au', 'Chris Sullivan', '2016/01/26', '5585411605', '8126163730', 856, false, null, 8, 21);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Howard', 'Jimmy', 'jhowardt@addtoany.com', 'Jimmy Howard', '2016/07/20', '8647684121', '3165419184', 594, true, 2014/06/13, 32, 31);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Hunter', 'Barbara', 'bhunteru@narod.ru', 'Barbara Hunter', '2015/12/17', '8691148701', '771617581', 235, true, null, 9, 32);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime, noDiffuseur, noAgence) VALUES ('Fields', 'Charles', 'cfieldsv@tonline.de', 'Charles Fields', '2016/05/19', '38631006232', '8114110334', 992, false, null, 29, 33);
GO
PRINT 'insertion des reponsables réussi'
GO

/*insertion des diffuseurs*/

GO
PRINT 'insertion des diffuseurs débutée'
GO

INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Tazzy', 'bclark0@apache.org', 2016/06/13, 1);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Photofeed', 'wwoods1@opera.com', 2016/02/13, 2);
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
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Demivee', 'nlopezl@opensource.org', 2016/02/27, 22);
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
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Vidoo', 'bromeroy@unicef.org', 2016/01/05, 35);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Photobug', 'dbishopz@ca.GOv', null, 36);S
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Flipstorm', 'wolson10@purevolume.com', null, 37);
INSERT INTO S_Contrat.tblDiffuseur (nom, courriel, dateSupprime, noAdresse) VALUES ('Yakidoo', 'bhall11@fda.GOv', null, 38);

GO
PRINT 'insertion des diffuseurs réussi'
GO

/*insertion des adresses*/

GO
PRINT 'insertion des adresses débutée'
GO

INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('SainteFlavie','E4O6I0','QC','Canada','4181755665','4184221810',5807);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('Murdochville','H5K1G9','QC','Canada','4185996631','4187076683',9439);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('Wekweti','D1C8D5','NT','Canada','4183707770','4184975797',8832);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('Bay Roberts','D3Y1H7','NL','Canada','418803871','4184374362',2171);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('Lakeshore','Z1P9C4','ON','Canada','4187828760','4182441530',3733);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('Charlottetown','M4U7W7','PE','Canada','4188094124','4182279533',6251);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('Caplan','Y6Z4K6','QC','Canada','4181251564','4182594355',5340);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('Whitehorse','J2X2F7','YT','Canada','4185518302','4189937396',839);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('Kawartha Lakes','O7F0E6','ON','Canada','4185759408','4183226713',9922);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('Tuktoyaktuk','I2S5P3','NT','Canada','4186680008','4188886104',8234);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('Gravelbourg','C0W2I9','SK','Canada','4181957702','4184407891',1070);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('Bay Roberts','O2N5S8','NL','Canada','4181531514','4187161949',5900);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('Arviat','E5R1J3','NU','Canada','4188296563','4188539031',1254);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('Whitehorse','S8L1A3','YT','Canada','4184820847','4182594900',54);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('Whitehorse','M0A7C0','YT','Canada','4189088995','4181435113',4);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('Kearny','F5F2Q2','ON','Canada','4187675272','4188250409',8938);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('Tulita','X7H9X9','NT','Canada','4184517009','4187488001',7882);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('Fraser Lake','M6T7N2','BC','Canada','4188261336','4186370777',2700);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('Fredericton','M6M3S6','NB','Canada','4185122464','4181074914',5279);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('Fortune','L9D0R8','NL','Canada','4185262276','4184055003',7811);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('MansfieldetPontefract','G7B8O7','QC','Canada','4184473760','4188618109',9439);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('Argyle','B5Y2Z0','NS','Canada','4184478593','4184035933',4468);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('Weyburn','W8R9N3','SK','Canada','4186474587','4188169626',5760);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('Fort McPherson','G5I3G5','NT','Canada','4183872302','4183219935',6440);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('Minitonas','Z8H2Y3','MB','Canada','4182452811','4186749589',3598);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('Fredericton','W3B9T7','NB','Canada','4187381094','4184316029',1505);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('Harbour Grace','U9Q5L0','NL','Canada','4186441434','4188805329',7937);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('Port Coquitlam','S8G0Y9','BC','Canada','4183969822','4184153973',4950);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('Saint John','V3S5Q6','NB','Canada','4184187658','4182105046',7297);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('Saguenay','S0C5S1','QC','Canada','4188837600','4185887999',8426);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('Arviat','Z1Q3E8','NU','Canada','4184594117','4188096763',9253);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('Edmundston','M9P2I2','NB','Canada','4185376718','4186438138',7077);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('Minitonas','O4C2J7','MB','Canada','4187351849','4183013060',4633);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('Fort Providence','G8I4V8','NT','Canada','4184002201','4189134675',3379);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('Moncton','P9F4Y0','NB','Canada','4184943873','4189474731',8245);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('Weyburn','N4L8Z4','SK','Canada','4187414424','4184564069',8107);
INSERT INTO S_Contrat.tblAdresse([ville],[codepostal],[province],[pays],[telBureau],[telCellulaire],[extension]) VALUES('Gjoa Haven','T8G2A3','NU','Canada','4187423404','4185457833',7597);

GO
PRINT 'insertion des adresses réussi'
GO

/*insertion des Agences

Modifier certaines dateSupprime pour ne pas qu'elles soient toutes*/

GO
PRINT 'insertion des Agences débutée'
GO

INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Voonyx', 'valvarez0@umn.edu', null, 1);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Rhyloo', 'bpierce1@drupal.org', 2016/02/13, 2);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Chatterbridge', 'rburns2@yelp.com', null, 3);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Oyonder', 'eallen3@comcast.net', null, 4);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Einti', 'kwright4@themeforest.net', null, 5);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Twimbo', 'rrichardson5@GOo.gl', null, 2016/01/23);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Browsezoom', 'wking6@bloglovin.com', null, 6);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Gigabox', 'pwheeler7@paginegialle.it', null, 7);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Aivee', 'cstewart8@umich.edu', null, 8);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Brainverse', 'agray9@accuweather.com', null, 10);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Gabcube', 'rmatthewsa@upenn.edu', null, 11);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Teklist', 'rbellb@live.com', null, 12);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Twinte', 'rmedinac@netscape.com', null, 13);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Demizz', 'thansend@friendfeed.com', null, 14);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Linktype', 'mrobinsone@cdbaby.com', 2016/04/14, 15);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Shufflebeat', 'vmartinezf@yellowbook.com', null, 16);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Twinder', 'mramirezg@networksolutions.com', null, 21);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Yamia', 'kfranklinh@networkadvertising.org', null, 22);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Fivebridge', 'bbradleyi@shinystat.com', null, 23);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Youopia', 'cmorrisonj@blinklist.com', null, 24);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Yakijo', 'cclarkk@mediafire.com', null, 25);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Browsezoom', 'ecollinsl@is.gd', null, 26);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Podcat', 'pphillipsm@hc360.com', null, 27);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Eadel', 'jmasonn@dmoz.org', null, 28);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Eimbee', 'mnicholso@newsvine.com', null, 29);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Skippad', 'dcruzp@nasa.GOv', null, 17);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Photobug', 'lrileyq@howstuffworks.com', null, 18);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Topicstorm', 'pdeanr@bloglines.com', null, 19);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Photobug', 'jburtons@posterous.com', null, 20);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Topdrive', 'dwhitet@GOo.ne.jp', null, 30);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Yodoo', 'stayloru@epa.GOv', null, 31);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Oyoyo', 'jdeanv@mediafire.com', '2013/11/13', 32);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Linktype', 'bbradleyw@hud.GOv', null, 33);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Dabvine', 'jpetersonx@tamu.edu', null, 34);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Fivebridge', 'kclarky@lycos.com', null, 35);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Realcube', 'dwallacez@bloglines.com', null, 36);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Blogtag', 'kbrown10@blogger.com', null, 37);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Thoughtbridge', 'aburke11@psu.edu', '2016/02/13', 9);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime, noAdresse) VALUES ('Camido', 'jwoods12@hud.GOv', null, 38);
GO
PRINT 'insertion des agences réussi'
GO

/*insertion des Catégories d'artistes

Modifier certaines dateSupprime pour ne pas qu'elles soient toutes*/

GO
PRINT 'insertion des Catégories d''artistes débutée'
GO
INSERT INTO S_Contrat.tblCategorieArtiste (nom, description, dateSupprime) VALUES ('Humoriste', 'Artiste qui se produit en spectacle en interprétant des personnages comiques, des monologues humoristiques, en exploitant des situations absurdes dans l''intention de faire rire un public.', null);
INSERT INTO S_Contrat.tblCategorieArtiste (nom, description, dateSupprime) VALUES ('Musicien', 'Artiste ou groupe d''artistes qui pratiquent des compositions musicales', null);
INSERT INTO S_Contrat.tblCategorieArtiste (nom, description, dateSupprime) VALUES ('Acrobate', 'Artiste qui maîtrise une ou plusieurs disciplines d''acrobatie, dont la pratique est fondée sur l''agilité, la force, la souplesse et l''équilibre.', null);
INSERT INTO S_Contrat.tblCategorieArtiste (nom, description, dateSupprime) VALUES ('Ventriloque', 'Personne qui peut articuler sans remuer les lèvres et fait "parler" une marionette pour un effet comique.  ', null);
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
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Dennis Garza', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Betty Mccoy', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Donald Collins', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Jerry Rodriguez', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Julie Alexander', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Gloria Mills', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Sandra Mason', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Lois Rivera', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Martin Mills', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Lois Riley', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Catherine Meyer', null, null);
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
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Tammy Hall', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Cheryl Rogers', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Anthony Hall', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Scott Graham', null, null);
INSERT INTO S_Contrat.tblArtiste (nom, commentaire, dateSupprime) VALUES ('Wayne Morgan',null, null);

GO
PRINT 'insertion des artistes réussi'
GO

/*insertion des Fichier Personnel

Rajouter des valeurs pas mal partout en fait*/


GO
PRINT 'insertion des artistes débutée'
GO
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Levée de fonds','C:\Users\utilisateur.DESKTOP-7L405VB\Desktop\Photos\\',null,1,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Spectacle','C:\photos',null,2,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Levée de fonds','C:\Users\utilisateur.DESKTOP-7L405VB\Desktop\Photos\\',null,3,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Concours','D:\documents artistes',null,4,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Levée de fonds','C:\photos',null,5,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Spectacle','C:\Users\utilisateur.DESKTOP-7L405VB\Desktop\Photos\\',null,6,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Spectacle','D:\documents artistes',null,7,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Levée de fonds','C:\Users\utilisateur.DESKTOP-7L405VB\Desktop\Photos\\',null,8,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Concours','C:\photos',null,9,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Spectacle','C:\Users\utilisateur.DESKTOP-7L405VB\Desktop\Photos\\',null,10,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Spectacle','D:\documents artistes',null,11,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Concours','C:\photos',null,12,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Levée de fonds','C:\photos',null,13,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Spectacle','D:\documents artistes',null,14,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Concours','C:\Users\utilisateur.DESKTOP-7L405VB\Desktop\Photos\\',null,15,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Spectacle','D:\documents artistes',null,16,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Spectacle','C:\Users\utilisateur.DESKTOP-7L405VB\Desktop\Photos\\',null,17,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Concours','C:\photos',null,18,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Concours','C:\Users\utilisateur.DESKTOP-7L405VB\Desktop\Photos\\',null,19,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Levée de fonds','C:\Users\utilisateur.DESKTOP-7L405VB\Desktop\Photos\\',null,20,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Concours','C:\Users\utilisateur.DESKTOP-7L405VB\Desktop\Photos\\',null,21,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Concours','C:\Users\utilisateur.DESKTOP-7L405VB\Desktop\Photos\\',null,22,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Levée de fonds','C:\Users\utilisateur.DESKTOP-7L405VB\Desktop\Photos\\',null,23,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Levée de fonds','D:\documents artistes',null,24,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Spectacle','D:\documents artistes',null,25,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Spectacle','D:\documents artistes',null,26,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Spectacle','C:\Users\utilisateur.DESKTOP-7L405VB\Desktop\Photos\\',null,27,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Concours','D:\documents artistes',null,28,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Spectacle','C:\Users\utilisateur.DESKTOP-7L405VB\Desktop\Photos\\',null,1,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Concours','C:\Users\utilisateur.DESKTOP-7L405VB\Desktop\Photos\\',null,2,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Spectacle','C:\Users\utilisateur.DESKTOP-7L405VB\Desktop\Photos\\',null,3,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Levée de fonds','D:\documents artistes',null,4,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Levée de fonds','D:\documents artistes',null,5,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Spectacle','C:\Users\utilisateur.DESKTOP-7L405VB\Desktop\Photos\\',null,6,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Levée de fonds','C:\photos',null,7,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Concours','C:\photos',null,8,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Concours','C:\Users\utilisateur.DESKTOP-7L405VB\Desktop\Photos\\',null,9,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Spectacle','C:\Users\utilisateur.DESKTOP-7L405VB\Desktop\Photos\\',null,10,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Levée de fonds','C:\photos',null,11,null);
INSERT INTO S_Contrat.tblFichierPersonnel([type],[chemin],[commentaire],[noArtiste],[dateSupprime]) VALUES('Levée de fonds','D:\documents artistes',null,12,null);
GO
PRINT 'insertion des artistes réussie'
GO

/*insertion des statuts

Rajouter des valeurs pas mal partout en fait

DISCUTER AVEC LE CLIENT*/


GO
PRINT 'insertion des statuts débutée'
GO

INSERT INTO S_Contrat.tblStatut (nomStatut, description, couleur, dateSupprime) VALUES ('Terminé', 'Le contrat a été réalisé et est archivé', 'df6c25', null);
INSERT INTO S_Contrat.tblStatut (nomStatut, description, couleur, dateSupprime) VALUES ('En cours', 'Le contrat est à réaliser bientôt', '60aba8', null);
INSERT INTO S_Contrat.tblStatut (nomStatut, description, couleur, dateSupprime) VALUES ('En négotiation', 'Les discussions a propos du contrat sont encore en cours', 'e97baa', null);
INSERT INTO S_Contrat.tblStatut (nomStatut, description, couleur, dateSupprime) VALUES ('En attente', 'Le contrat est attente d''une décision', '600c3d', null);
INSERT INTO S_Contrat.tblStatut (nomStatut, description, couleur, dateSupprime) VALUES ('Annulé', 'Le contrat a été annulé', '58c7f3', null);
INSERT INTO S_Contrat.tblStatut (nomStatut, description, couleur, dateSupprime) VALUES ('Expiré', 'La date du contrat a été dépassé sans qu''une decision soit prise.', '5a0243', null);

GO
PRINT 'insertion des statuts terminée'
GO

/*insertion des statuts

Rajouter des valeurs pas mal partout en fait*/

GO
PRINT 'insertion des exigences commencée'
GO

INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Bouteilles d''eau','2016/08/21','5,697','Les clients veulent avoir des bouteilles d''eau gratuites',null,'Eau gratuite fournie',null,1,'2');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Alcool','2016/09/06','8,235','Le client veux avoir l''alcool de payé dans la loge',null,'Alcool fournie dans la loge','2016/12/30',2,'4');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Repas fournis','2017/04/03','6,754','Le client demande a avoir un repas fourni dans sa loge',null,'Le client veut son repas inclus dans sa loge',null,3,'6');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Repas végétarien','2016/05/13','8,600','Le client demande a n''avoir que des repas végétariens servis dans sa loge',null,'Le client veut des repas végétariens uniquement',null,4,'3');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES('Logis fournis','2015/12/31','5,912','Le client demande d''avoir l''hôtel fourni',null,'Hotel fourni par l''organisateur',null,5,'5');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES(null,'2016/10/07','6,113',null,null,null,null,6,'2');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES(null,'2015/09/06','8,813',null,null,null,'2016/05/17',7,'4');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES(null,'2017/01/22','8,930',null,null,null,'2015/02/26',8,'3');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES(null,'2017/01/26','7,103',null,null,null,null,9,'2');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES(null,'2016/03/07','7,610',null,null,null,'2014/08/29',10,'2');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES(null,'2017/03/19','9,020',null,null,null,null,11,'2');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES(null,'2016/04/28','5,459',null,null,null,'2016/12/21',12,'6');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES(null,'2015/12/07','5,824',null,null,null,'2016/08/24',13,'1');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES(null,'2016/01/29','5,454',null,null,null,null,14,'1');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES(null,'2017/06/21','9,048',null,null,null,null,15,'4');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES(null,'2016/04/15','9,617',null,null,null,null,16,'3');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES(null,'2016/12/04','9,369',null,null,null,null,17,'1');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES(null,'2016/11/10','5,172',null,null,null,null,18,'3');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES(null,'2016/04/30','7,766',null,null,null,'2016/04/12',19,'6');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES(null,'2016/05/31','7,043',null,null,null,null,20,'3');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES(null,'2015/09/15','7,683',null,null,null,'2016/05/16',21,'4');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES(null,'2016/09/23','5,899',null,null,null,null,22,'6');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES(null,'2016/04/05','7,980',null,null,null,null,23,'6');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES(null,'2016/01/23','5,567',null,null,null,'2015/06/02',24,'1');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES(null,'2015/12/06','8,515',null,null,null,null,25,'2');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES(null,'2017/07/16','9,327',null,null,null,null,26,'2');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES(null,'2015/09/28','5,835',null,null,null,'2015/03/19',27,'3');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES(null,'2017/03/08','9,721',null,null,null,null,28,'5');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES(null,'2017/05/18','5,850',null,null,null,'2016/04/14',29,'4');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES(null,'2015/12/30','5,348',null,null,null,'2015/10/19',30,'2');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES(null,'2016/08/05','9,847',null,null,null,null,31,'6');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES(null,'2016/04/08','5,385',null,null,null,null,32,'6');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES(null,'2016/09/08','6,221',null,null,null,null,33,'1');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES(null,'2016/07/08','6,928',null,null,null,'2016/03/23',34,'4');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES(null,'2017/05/15','6,295',null,null,null,null,35,'4');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES(null,'2016/05/31','5,970',null,null,null,null,36,'5');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES(null,'2016/05/14','9,890',null,null,null,null,37,'1');
INSERT INTO S_Contrat.tblExigences([nom],[date],[montant],[description],[commentaire],[descriptionCourte],[dateSupprime],[noContrat],[noStatut]) VALUES(null,'2016/06/29','6,647',null,null,null,null,38,'5');

GO
PRINT 'insertion des exigences terminée'
GO

/*insertion des statuts

Rajouter des valeurs pas mal partout en fait*/

GO
PRINT 'insertion des contrats commencée'
GO

INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Chicoutimi', null, null, null, null, 3, 22); 
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Jonquière', null, null, null, null, 1, 30);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Chicoutimi', null, null, null, null, 2, 31);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Jonquière', null, null, null, null, 4, 22);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Québec', null, null, null, null, 4, 30);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Québec', null, null, null, null, 2, 34);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Montréal', null, null, null, null, 4, 14);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Chicoutimi', null, null, null, null, 2, 30);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Jonquière', null, null, null, null, 6, 24);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Montréal', null, null, null, null, 3, 3);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Québec', null, null, null, null, 1, 3);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Montréal', null, null, null, null, 5, 7);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Jonquière', null, null, null, null, 6, 10);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Montréal', null, null, null, null, 1, 14);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Montréal', null, null, null, null, 3, 1);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Chicoutimi', null, null, null, null, 6, 2);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Québec', null, null, null, null, 6, 35);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Jonquière', null, null, null, null, 2, 5);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Montréal', null, null, null, null, 3, 28);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Québec', null, null, null, null, 6, 7);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Jonquière', null, null, null, null, 3, 32);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Montréal', null, null, null, null, 2, 35);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Montréal', null, null, null, null, 4, 6);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Chicoutimi', null, null, null, null, 6, 32);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Jonquière', null, null, null, null, 3, 7);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Québec', null, null, null, '2016/06/13', 5, 5);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Québec', null, null, null, '2016/10/28', 5, 28);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Chicoutimi', null, null, null, null, 1, 28);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Jonquière', null, null, null, '2017/06/03', 5, 24);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Montréal', null, null, null, null, 5, 19);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Montréal', null, null, null, null, 2, 19);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Jonquière', null, null, null, '2017/04/08', 5, 9);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Québec', null, null, null, null, 3, 23);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Chicoutimi', null, null, null, null, 4, 5);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Jonquière', null, null, null, null, 4, 22);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Jonquière', null, null, null, null, 4, 1);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Montréal', null, null, null, null, 4, 34);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Chicoutimi', null, null, null, null, 2, 31);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Montréal', null, null, null, null, 4, 1);
INSERT INTO S_Contrat.tblContrat (lieu, nom, description, commentaire, dateSupprime, noStatut, noAgence) VALUES ('Montréal', null, null, null, null, 2, 27);

GO
PRINT 'insertion des contrats terminée'
Go