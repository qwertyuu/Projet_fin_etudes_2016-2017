USE PE2_Test
GO

/*insertion des responsables

Modifier certaines dateSupprime pour ne pas qu'elles soient toutes "null"
*/

GO
PRINT 'insertion des responsables débutée'
GO

GO
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime) VALUES ('Cruz', 'George', 'gcruz0@state.tx.us', 'George Cruz', '2016/01/15', '8631113471', '5734372137', 865, false, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime) VALUES ('Carter', 'Christina', 'ccarter1@GOogle.de', 'Christina Carter', '2016/07/22', '38562815981', '6327071769', 364, false, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime) VALUES ('Hart', 'Barbara', 'bhart2@sun.com', 'Barbara Hart', '2016/02/04', '6925115065', '130315648', 913, false, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime) VALUES ('Henry', 'Ruth', 'rhenry3@livejournal.com', 'Ruth Henry', '2016/04/25', '5281157420', '6324147750', 265, false, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime) VALUES ('Mason', 'Nicholas', 'nmason4@hc360.com', 'Nicholas Mason', '2015/12/08', '35119500200', '96716843409', 262, true, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime) VALUES ('Young', 'Walter', 'wyoung5@sina.com.cn', 'Walter Young', '2016/02/11', '6359817195', '5182891148', 146, true, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime) VALUES ('Chavez', 'Julia', 'jchavez6@ibm.com', 'Julia Chavez', '2016/05/03', '3327172914', '35626011103', 281, false, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime) VALUES ('Hill', 'Emily', 'ehill7@illinois.edu', 'Emily Hill', '2015/11/03', '5578512986', '6280071160', 138, false, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime) VALUES ('Walker', 'Kathy', 'kwalker8@purevolume.com', 'Kathy Walker', '2015/10/16', '191981506', '6224815701', 161, true, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime) VALUES ('Hicks', 'Chris', 'chicks9@GOo.ne.jp', 'Chris Hicks', '2016/01/19', '6322134224', '5730717164', 653, false, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime) VALUES ('Price', 'Carl', 'cpricea@jugem.jp', 'Carl Price', '2016/03/10', '99871270173', '8617165705', 651, false, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime) VALUES ('Oliver', 'Frances', 'foliverb@army.mil', 'Frances Oliver', '2016/07/30', '4851942270', '5560317957', 702, true, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime) VALUES ('Warren', 'Brandon', 'bwarrenc@businessweek.com', 'Brandon Warren', '2015/09/05', '5571374038', '6275116346', 528, false, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime) VALUES ('Clark', 'Barbara', 'bclarkd@ibm.com', 'Barbara Clark', '2015/10/16', '5245261440', '5537911456', 942, true, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime) VALUES ('Kim', 'Albert', 'akime@tonline.de', 'Albert Kim', '2015/11/12', '38111013266', '115131898', 660, false, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime) VALUES ('Hunt', 'Laura', 'lhuntf@sina.com.cn', 'Laura Hunt', '2016/01/21', '8689912348', '23530174902', 117, false, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime) VALUES ('Rice', 'Judith', 'jriceg@army.mil', 'Judith Rice', '2016/02/02', '50481118756', '6263170508', 509, true, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime) VALUES ('Ellis', 'Lillian', 'lellish@indiatimes.com', 'Lillian Ellis', '2016/08/09', '3171709947', '4823139054', 277, false, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime) VALUES ('Mills', 'Kenneth', 'kmillsi@comcast.net', 'Kenneth Mills', '2016/01/10', '25151322405', '6239167736', 308, false, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime) VALUES ('Sims', 'Howard', 'hsimsj@zimbio.com', 'Howard Sims', '2016/04/02', '5482271992', '126159183', 488, false, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime) VALUES ('Griffin', 'James', 'jgriffink@booking.com', 'James Griffin', '2016/07/07', '42013116890', '5571630869', 637, false, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime) VALUES ('Murphy', 'Eugene', 'emurphyl@stanford.edu', 'Eugene Murphy', '2015/10/11', '9365318046', '23412896299', 516, false, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime) VALUES ('Rose', 'Robin', 'rrosem@nsw.GOv.au', 'Robin Rose', '2016/08/19', '97039131907', '8611204331', 736, false, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime) VALUES ('Arnold', 'Joe', 'jarnoldn@mac.com', 'Joe Arnold', '2016/06/07', '6241471121', '167144077', 273, true, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime) VALUES ('Davis', 'Helen', 'hdaviso@bloomberg.com', 'Helen Davis', '2016/08/27', '8641311420', '161031270', 746, false, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime) VALUES ('Ryan', 'Stephanie', 'sryanp@shoppro.jp', 'Stephanie Ryan', '2016/05/05', '776183176', '24881465362', 512, false, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime) VALUES ('Hudson', 'Frank', 'fhudsonq@macromedia.com', 'Frank Hudson', '2015/11/14', '5792651523', '38621014886', 149, false, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime) VALUES ('Morgan', 'Paula', 'pmorganr@GOogle.de', 'Paula Morgan', '2015/11/26', '8620734135', '5848122908', 826, false, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime) VALUES ('Sullivan', 'Chris', 'csullivans@abc.net.au', 'Chris Sullivan', '2016/01/26', '5585411605', '8126163730', 856, false, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime) VALUES ('Howard', 'Jimmy', 'jhowardt@addtoany.com', 'Jimmy Howard', '2016/07/20', '8647684121', '3165419184', 594, true, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime) VALUES ('Hunter', 'Barbara', 'bhunteru@narod.ru', 'Barbara Hunter', '2015/12/17', '8691148701', '771617581', 235, true, null);
INSERT INTO S_Contrat.tblResponsable (nom, prenom, courriel, signataire, date, telBureau, telCellulaire, extension, idem, dateSupprime) VALUES ('Fields', 'Charles', 'cfieldsv@tonline.de', 'Charles Fields', '2016/05/19', '38631006232', '8114110334', 992, false, null);
GO
PRINT 'insertion des reponsables réussi'
GO

/*insertion des diffUSEurs

Modifier certaines dateSupprime pour ne pas qu'elles soient toutes "null"*/

GO
PRINT 'insertion des diffUSEurs débutée'
GO

INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Tazzy', 'bclark0@apache.org', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Photofeed', 'wwoods1@opera.com', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Wikido', 'rdixon2@php.net', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Brainlounge', 'cmitchell3@latimes.com', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Jaxbean', 'ereyes4@scientificamerican.com', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Browsebug', 'jperez5@GOogle.fr', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Yodel', 'jhayes6@is.gd', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Brainsphere', 'frobinson7@GOogle.de', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Zooveo', 'dmontGOmery8@yellowpages.com', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Photolist', 'rcrawford9@360.cn', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Leexo', 'rdaya@mysql.com', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Skippad', 'athompsonb@weather.com', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Oodoo', 'gharrisc@purevolume.com', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Meevee', 'fgriffind@samsung.com', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Feedspan', 'wcastilloe@ustream.tv', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Tagcat', 'aowensf@GOogle.com.hk', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Quatz', 'jmeyerg@sciencedaily.com', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Flashdog', 'jalexanderh@livejournal.com', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Yacero', 'sjohnsoni@cdc.GOv', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Jayo', 'lmeyerj@people.com.cn', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Avaveo', 'wkelleyk@cornell.edu', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Demivee', 'nlopezl@opensource.org', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Yotz', 'lwheelerm@si.edu', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Topiczoom', 'tkingn@usa.GOv', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Demimbu', 'pmedinao@purevolume.com', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Flipopia', 'cwebbp@businessinsider.com', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Zoombox', 'jmartinq@latimes.com', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Einti', 'jgreenr@miitbeian.GOv.cn', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Layo', 'scoopers@xrea.com', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Oozz', 'flyncht@bigcartel.com', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Edgeify', 'kfloresu@biglobe.ne.jp', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Midel', 'sbishopv@wordpress.org', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Browsezoom', 'vchavezw@businessweek.com', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Zooxo', 'hstephensx@mac.com', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Vidoo', 'bromeroy@unicef.org', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Photobug', 'dbishopz@ca.GOv', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Flipstorm', 'wolson10@purevolume.com', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Yakidoo', 'bhall11@fda.GOv', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Vitz', 'hhenderson12@mapy.cz', null);
INSERT INTO S_Contrat.tblDiffUSEur (nom, courriel, dateSupprime) VALUES ('Feedbug', 'rroberts13@cbsnews.com', null);

GO
PRINT 'insertion des diffUSEurs réussi'
GO

/*insertion des adresses

Modifier certaines dateSupprime pour ne pas qu'elles soient toutes*/

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

INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Voonyx', 'valvarez0@umn.edu', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Rhyloo', 'bpierce1@drupal.org', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Chatterbridge', 'rburns2@yelp.com', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Oyonder', 'eallen3@comcast.net', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Einti', 'kwright4@themeforest.net', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Twimbo', 'rrichardson5@GOo.gl', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Browsezoom', 'wking6@bloglovin.com', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Gigabox', 'pwheeler7@paginegialle.it', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Aivee', 'cstewart8@umich.edu', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Brainverse', 'agray9@accuweather.com', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Gabcube', 'rmatthewsa@upenn.edu', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Teklist', 'rbellb@live.com', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Twinte', 'rmedinac@netscape.com', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Demizz', 'thansend@friendfeed.com', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Linktype', 'mrobinsone@cdbaby.com', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Shufflebeat', 'vmartinezf@yellowbook.com', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Twinder', 'mramirezg@networksolutions.com', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Yamia', 'kfranklinh@networkadvertising.org', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Fivebridge', 'bbradleyi@shinystat.com', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Youopia', 'cmorrisonj@blinklist.com', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Yakijo', 'cclarkk@mediafire.com', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Browsezoom', 'ecollinsl@is.gd', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Podcat', 'pphillipsm@hc360.com', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Eadel', 'jmasonn@dmoz.org', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Eimbee', 'mnicholso@newsvine.com', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Skippad', 'dcruzp@nasa.GOv', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Photobug', 'lrileyq@howstuffworks.com', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Topicstorm', 'pdeanr@bloglines.com', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Photobug', 'jburtons@posterous.com', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Topdrive', 'dwhitet@GOo.ne.jp', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Yodoo', 'stayloru@epa.GOv', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Oyoyo', 'jdeanv@mediafire.com', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Linktype', 'bbradleyw@hud.GOv', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Dabvine', 'jpetersonx@tamu.edu', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Fivebridge', 'kclarky@lycos.com', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Realcube', 'dwallacez@bloglines.com', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Blogtag', 'kbrown10@blogger.com', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Thoughtbridge', 'aburke11@psu.edu', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Camido', 'jwoods12@hud.GOv', null);
INSERT INTO S_Contrat.tblAgence (nom, courriel, dateSupprime) VALUES ('Chatterpoint', 'kfisher13@webmd.com', null);

GO
PRINT 'insertion des agences réussi'
GO

/*insertion des Catégories d'artistes

Modifier certaines dateSupprime pour ne pas qu'elles soient toutes*/

GO
PRINT 'insertion des Catégories d''artistes débutée'
GO
insert into S_Contrat.tblCategorieArtiste (nom, description, dateSupprime) values ('Humoriste', 'Artiste qui se produit en spectacle en interprétant des personnages comiques, des monologues humoristiques, en exploitant des situations absurdes dans l''intention de faire rire un public.', null);
insert into S_Contrat.tblCategorieArtiste (nom, description, dateSupprime) values ('Musicien', 'Artiste ou groupe d''artistes qui pratiquent des compositions musicales', null);
insert into S_Contrat.tblCategorieArtiste (nom, description, dateSupprime) values ('Acrobate', 'Artiste qui maîtrise une ou plusieurs disciplines d''acrobatie, dont la pratique est fondée sur l''agilité, la force, la souplesse et l''équilibre.', null);
insert into S_Contrat.tblCategorieArtiste (nom, description, dateSupprime) values ('Ventriloque', 'Personne qui peut articuler sans remuer les lèvres et fait "parler" une marionette pour un effet comique.  ', null);
insert into S_Contrat.tblCategorieArtiste (nom, description, dateSupprime) values ('Danseur', 'Personne ou groupe qui performe des chorégraphie dans un but artistique', null);
insert into S_Contrat.tblCategorieArtiste (nom, description, dateSupprime) values ('Théâtre', 'Art de représenter sur scène des événements mettant en cause des êtres humains.'  , null);

GO
PRINT 'insertion des Catégories d''artistes réussi'
GO