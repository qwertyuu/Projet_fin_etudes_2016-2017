--Script d'insertion des �v�nements
--Fait par: Pierre-Alexandre Pageau
--Date: 5 Octobre 2016

USE PE2_Officiel 

GO

PRINT('D�BUT DES INSERTIONS')

GO

PRINT('D�but des insertion de la table des �v�nements')

GO

INSERT INTO S_evenement.tblEvenement([nom],[dateDebut],[dateFin],[affiche],[url],[description],[dateSupprime]) VALUES('Festi-rire 2010','2010/01/02','2010/11/02',NULL,'https://jimdo.com/pulvinar/sed/nisl/nunc/rhoncus.json?dictumst=enim&morbi=sit&vestibulum=amet&velit=nunc&id=viverra&pretium=dapibus&iaculis=nulla&diam=suscipit&erat=ligula&fermentum=in&justo=lacus&nec=curabitur&condimentum=at&neque=ipsum&sapien=ac&placerat=tellus&ante=semper&nulla=interdum&justo=mauris&aliquam=ullamcorper&quis=purus&turpis=sit&eget=amet&elit=nulla&sodales=quisque&scelerisque=arcu&mauris=libero','dictum eu, placerat eget, venenatis a, magna. Lorem',NULL);
INSERT INTO S_evenement.tblEvenement([nom],[dateDebut],[dateFin],[affiche],[url],[description],[dateSupprime]) VALUES('Festi-rire 2011','2011/01/02','2011/11/02',NULL,'http://disqus.com/neque/libero/convallis/eget/eleifend.jsp?consequat=proin&in=risus&consequat=praesent&ut=lectus&nulla=vestibulum&sed=quam&accumsan=sapien&felis=varius&ut=ut&at=blandit&dolor=non&quis=interdum&odio=in&consequat=ante&varius=vestibulum&integer=ante&ac=ipsum&leo=primis&pellentesque=in&ultrices=faucibus&mattis=orci&odio=luctus&donec=et&vitae=ultrices&nisi=posuere&nam=cubilia&ultrices=curae&libero=duis&non=faucibus&mattis=accumsan&pulvinar=odio&nulla=curabitur&pede=convallis&ullamcorper=duis&augue=consequat&a=dui&suscipit=nec&nulla=nisi&elit=volutpat&ac=eleifend&nulla=donec&sed=ut&vel=dolor&enim=morbi&sit=vel&amet=lectus&nunc=in&viverra=quam&dapibus=fringilla&nulla=rhoncus&suscipit=mauris&ligula=enim&in=leo&lacus=rhoncus&curabitur=sed&at=vestibulum&ipsum=sit&ac=amet&tellus=cursus&semper=id&interdum=turpis&mauris=integer&ullamcorper=aliquet&purus=massa&sit=id&amet=lobortis&nulla=convallis&quisque=tortor&arcu=risus&libero=dapibus&rutrum=augue&ac=vel&lobortis=accumsan&vel=tellus','vulputate eu, odio. Phasellus at augue id ante dictum cursus. Nunc mauris elit, dictum eu, eleifend nec, malesuada ut, sem. Nulla interdum. Curabitur dictum. Phasellus in felis. Nulla tempor augue ac ipsum. Phasellus vitae mauris sit amet lorem semper auctor. Mauris vel turpis. Aliquam adipiscing lobortis risus. In mi pede,',NULL);
INSERT INTO S_evenement.tblEvenement([nom],[dateDebut],[dateFin],[affiche],[url],[description],[dateSupprime]) VALUES('Festi-rire 2012','2012/01/02','2012/11/02',NULL,'http://e-recht24.de/non/interdum/in/ante/vestibulum.aspx?odio=molestie&odio=lorem&elementum=quisque&eu=ut&interdum=erat&eu=curabitur&tincidunt=gravida&in=nisi&leo=at&maecenas=nibh&pulvinar=in&lobortis=hac&est=habitasse&phasellus=platea&sit=dictumst&amet=aliquam&erat=augue&nulla=quam&tempus=sollicitudin&vivamus=vitae&in=consectetuer&felis=eget&eu=rutrum&sapien=at&cursus=lorem&vestibulum=integer&proin=tincidunt&eu=ante&mi=vel&nulla=ipsum&ac=praesent&enim=blandit&in=lacinia&tempor=erat&turpis=vestibulum&nec=sed&euismod=magna&scelerisque=at&quam=nunc&turpis=commodo&adipiscing=placerat&lorem=praesent&vitae=blandit&mattis=nam&nibh=nulla&ligula=integer&nec=pede&sem=justo&duis=lacinia&aliquam=eget&convallis=tincidunt&nunc=eget&proin=tempus&at=vel&turpis=pede&a=morbi&pede=porttitor&posuere=lorem&nonummy=id&integer=ligula&non=suspendisse&velit=ornare&donec=consequat&diam=lectus&neque=in&vestibulum=est&eget=risus&vulputate=auctor&ut=sed&ultrices=tristique&vel=in&augue=tempus&vestibulum=sit&ante=amet&ipsum=sem&primis=fusce&in=consequat','Phasellus ornare. Fusce mollis. Duis sit amet diam eu dolor egestas rhoncus. Proin nisl sem, consequat nec, mollis vitae, posuere at, velit. Cras lorem lorem, luctus ut, pellentesque eget, dictum placerat, augue. Sed molestie. Sed id risus quis diam luctus lobortis. Class',NULL);
INSERT INTO S_evenement.tblEvenement([nom],[dateDebut],[dateFin],[affiche],[url],[description],[dateSupprime]) VALUES('Festi-rire 2013','2013/01/02','2013/11/02',NULL,'https://alibaba.com/platea/dictumst/maecenas/ut/massa.html?sed=volutpat&magna=convallis&at=morbi&nunc=odio&commodo=odio&placerat=elementum&praesent=eu&blandit=interdum&nam=eu&nulla=tincidunt&integer=in&pede=leo&justo=maecenas&lacinia=pulvinar&eget=lobortis&tincidunt=est&eget=phasellus&tempus=sit&vel=amet&pede=erat&morbi=nulla&porttitor=tempus&lorem=vivamus&id=in&ligula=felis&suspendisse=eu&ornare=sapien&consequat=cursus&lectus=vestibulum&in=proin&est=eu&risus=mi&auctor=nulla&sed=ac&tristique=enim&in=in&tempus=tempor&sit=turpis&amet=nec&sem=euismod&fusce=scelerisque&consequat=quam&nulla=turpis&nisl=adipiscing&nunc=lorem&nisl=vitae&duis=mattis&bibendum=nibh&felis=ligula&sed=nec&interdum=sem&venenatis=duis&turpis=aliquam&enim=convallis&blandit=nunc&mi=proin&in=at&porttitor=turpis&pede=a&justo=pede&eu=posuere&massa=nonummy&donec=integer&dapibus=non&duis=velit&at=donec&velit=diam&eu=neque&est=vestibulum&congue=eget&elementum=vulputate&in=ut&hac=ultrices&habitasse=vel&platea=augue&dictumst=vestibulum&morbi=ante&vestibulum=ipsum&velit=primis&id=in&pretium=faucibus&iaculis=orci&diam=luctus&erat=et&fermentum=ultrices&justo=posuere&nec=cubilia&condimentum=curae&neque=donec&sapien=pharetra&placerat=magna&ante=vestibulum&nulla=aliquet&justo=ultrices&aliquam=erat&quis=tortor&turpis=sollicitudin','sem mollis dui, in sodales elit erat vitae risus. Duis a mi fringilla mi lacinia mattis. Integer eu lacus. Quisque imperdiet, erat nonummy ultricies ornare, elit elit fermentum risus, at fringilla purus mauris a nunc. In at pede. Cras vulputate velit eu',NULL);
INSERT INTO S_evenement.tblEvenement([nom],[dateDebut],[dateFin],[affiche],[url],[description],[dateSupprime]) VALUES('Festi-rire 2014','2014/01/02','2014/11/02',NULL,'https://icq.com/turpis.html?nam=accumsan&dui=odio&proin=curabitur&leo=convallis&odio=duis&porttitor=consequat&id=dui&consequat=nec&in=nisi&consequat=volutpat&ut=eleifend&nulla=donec&sed=ut&accumsan=dolor&felis=morbi&ut=vel&at=lectus&dolor=in&quis=quam&odio=fringilla&consequat=rhoncus&varius=mauris&integer=enim&ac=leo&leo=rhoncus&pellentesque=sed&ultrices=vestibulum','Mauris molestie pharetra nibh. Aliquam ornare, libero at auctor ullamcorper, nisl arcu iaculis enim, sit amet ornare lectus justo eu arcu. Morbi sit amet massa. Quisque porttitor eros nec tellus.',NULL);
INSERT INTO S_evenement.tblEvenement([nom],[dateDebut],[dateFin],[affiche],[url],[description],[dateSupprime]) VALUES('Festi-rire 2015','2015/01/02','2015/11/02',NULL,'https://goodreads.com/quis/tortor/id.jpg?eu=nisl&nibh=duis&quisque=ac&id=nibh&justo=fusce&sit=lacus&amet=purus&sapien=aliquet&dignissim=at&vestibulum=feugiat&vestibulum=non&ante=pretium&ipsum=quis&primis=lectus&in=suspendisse&faucibus=potenti&orci=in&luctus=eleifend&et=quam&ultrices=a&posuere=odio&cubilia=in&curae=hac&nulla=habitasse',NULL,NULL);
INSERT INTO S_evenement.tblEvenement([nom],[dateDebut],[dateFin],[affiche],[url],[description],[dateSupprime]) VALUES('Festi-rire 2016','2016/01/02','2016/11/02',NULL,'https://topsy.com/magnis/dis.js?et=etiam&ultrices=justo&posuere=etiam&cubilia=pretium&curae=iaculis&nulla=justo&dapibus=in&dolor=hac&vel=habitasse&est=platea&donec=dictumst&odio=etiam&justo=faucibus&sollicitudin=cursus&ut=urna&suscipit=ut&a=tellus&feugiat=nulla&et=ut&eros=erat&vestibulum=id&ac=mauris&est=vulputate&lacinia=elementum&nisi=nullam&venenatis=varius&tristique=nulla&fusce=facilisi&congue=cras&diam=non&id=velit&ornare=nec&imperdiet=nisi&sapien=vulputate&urna=nonummy&pretium=maecenas&nisl=tincidunt&ut=lacus&volutpat=at&sapien=velit&arcu=vivamus&sed=vel&augue=nulla&aliquam=eget&erat=eros&volutpat=elementum&in=pellentesque&congue=quisque&etiam=porta&justo=volutpat&etiam=erat&pretium=quisque&iaculis=erat&justo=eros&in=viverra&hac=eget&habitasse=congue&platea=eget&dictumst=semper&etiam=rutrum&faucibus=nulla&cursus=nunc&urna=purus&ut=phasellus&tellus=in&nulla=felis&ut=donec&erat=semper&id=sapien&mauris=a&vulputate=libero&elementum=nam&nullam=dui&varius=proin&nulla=leo&facilisi=odio&cras=porttitor&non=id&velit=consequat&nec=in&nisi=consequat&vulputate=ut&nonummy=nulla&maecenas=sed&tincidunt=accumsan&lacus=felis&at=ut&velit=at&vivamus=dolor&vel=quis&nulla=odio&eget=consequat&eros=varius&elementum=integer&pellentesque=ac&quisque=leo&porta=pellentesque&volutpat=ultrices&erat=mattis','nibh. Aliquam ornare, libero at auctor ullamcorper, nisl arcu iaculis enim, sit amet ornare lectus justo eu arcu. Morbi sit amet massa. Quisque porttitor eros nec tellus. Nunc lectus pede, ultrices a, auctor non, feugiat nec, diam. Duis mi enim, condimentum eget, volutpat ornare, facilisis eget,',NULL);
INSERT INTO S_evenement.tblEvenement([nom],[dateDebut],[dateFin],[affiche],[url],[description],[dateSupprime]) VALUES('Festi-rire 2017','2017/01/02','2017/11/02',NULL,'https://kickstarter.com/convallis/duis/consequat/dui/nec/nisi/volutpat.xml?tristique=ultrices&est=enim&et=lorem&tempus=ipsum&semper=dolor&est=sit&quam=amet&pharetra=consectetuer&magna=adipiscing&ac=elit&consequat=proin&metus=interdum&sapien=mauris&ut=non&nunc=ligula&vestibulum=pellentesque&ante=ultrices&ipsum=phasellus&primis=id&in=sapien&faucibus=in&orci=sapien&luctus=iaculis&et=congue&ultrices=vivamus&posuere=metus&cubilia=arcu&curae=adipiscing&mauris=molestie&viverra=hendrerit&diam=at&vitae=vulputate&quam=vitae&suspendisse=nisl&potenti=aenean&nullam=lectus&porttitor=pellentesque&lacus=eget&at=nunc&turpis=donec&donec=quis&posuere=orci&metus=eget&vitae=orci&ipsum=vehicula&aliquam=condimentum&non=curabitur&mauris=in&morbi=libero&non=ut&lectus=massa&aliquam=volutpat&sit=convallis','massa. Integer vitae nibh. Donec est mauris, rhoncus id, mollis nec, cursus a, enim. Suspendisse aliquet, sem ut cursus luctus, ipsum leo elementum sem, vitae aliquam eros turpis non enim. Mauris quis turpis vitae purus gravida sagittis. Duis gravida.',NULL);
INSERT INTO S_evenement.tblEvenement([nom],[dateDebut],[dateFin],[affiche],[url],[description],[dateSupprime]) VALUES('Festi-rire 2018','2018/01/02','2018/11/02',NULL,'https://wix.com/erat/eros.jpg?et=magnis&commodo=dis&vulputate=parturient&justo=montes&in=nascetur&blandit=ridiculus&ultrices=mus&enim=vivamus&lorem=vestibulum&ipsum=sagittis&dolor=sapien&sit=cum&amet=sociis&consectetuer=natoque&adipiscing=penatibus&elit=et&proin=magnis&interdum=dis&mauris=parturient&non=montes&ligula=nascetur&pellentesque=ridiculus&ultrices=mus&phasellus=etiam&id=vel&sapien=augue&in=vestibulum&sapien=rutrum&iaculis=rutrum&congue=neque&vivamus=aenean&metus=auctor&arcu=gravida&adipiscing=sem&molestie=praesent&hendrerit=id&at=massa&vulputate=id&vitae=nisl&nisl=venenatis&aenean=lacinia&lectus=aenean&pellentesque=sit&eget=amet&nunc=justo&donec=morbi&quis=ut&orci=odio&eget=cras&orci=mi&vehicula=pede&condimentum=malesuada&curabitur=in&in=imperdiet&libero=et&ut=commodo&massa=vulputate&volutpat=justo&convallis=in&morbi=blandit&odio=ultrices&odio=enim','Sed eget lacus. Mauris non dui nec urna suscipit nonummy. Fusce fermentum fermentum arcu. Vestibulum ante ipsum primis in faucibus orci',NULL);
INSERT INTO S_evenement.tblEvenement([nom],[dateDebut],[dateFin],[affiche],[url],[description],[dateSupprime]) VALUES('Festi-rire 2019','2019/01/02','2019/11/02',NULL,NULL,'arcu ac orci. Ut semper pretium neque. Morbi quis urna.',NULL);
INSERT INTO S_evenement.tblEvenement([nom],[dateDebut],[dateFin],[affiche],[url],[description],[dateSupprime]) VALUES('Festi-rire 2009','2009/01/02','2009/11/02',NULL,NULL,'arcu ac orci. Ut semper pretium neque. Morbi quis urna.',NULL);

GO

PRINT('Fin des insertions des �v�nements')

GO

PRINT('D�but des insertions de la table des sous-�v�nements')

GO
INSERT INTO S_evenement.tblSousEvenement([nom],[description],[dateSupprime],[noEvenement],[noEngagement]) VALUES('Spectacle 2013','justo faucibus lectus, a sollicitudin orci sem eget massa. Suspendisse eleifend. Cras sed leo. Cras vehicula aliquet libero. Integer in magna. Phasellus dolor elit, pellentesque a,',NULL,4,2);
INSERT INTO S_evenement.tblSousEvenement([nom],[description],[dateSupprime],[noEvenement],[noEngagement]) VALUES('Collecte de fond 2013','mus. Aenean eget magna. Suspendisse tristique neque venenatis lacus. Etiam bibendum fermentum metus. Aenean sed pede nec ante blandit viverra. Donec tempus, lorem fringilla',NULL,4,1);
INSERT INTO S_evenement.tblSousEvenement([nom],[description],[dateSupprime],[noEvenement],[noEngagement]) VALUES('Spectacle 2019','luctus felis purus ac tellus. Suspendisse sed dolor. Fusce mi lorem, vehicula et, rutrum eu, ultrices sit amet, risus. Donec nibh enim, gravida sit amet, dapibus id, blandit at,',NULL,10,3);
INSERT INTO S_evenement.tblSousEvenement([nom],[description],[dateSupprime],[noEvenement],[noEngagement]) VALUES('Spectacle 2012','montes, nascetur',NULL,3,4);
INSERT INTO S_evenement.tblSousEvenement([nom],[description],[dateSupprime],[noEvenement],[noEngagement]) VALUES('Spectacle 2010','eu lacus. Quisque imperdiet, erat nonummy ultricies ornare, elit elit fermentum',NULL,1,5);
INSERT INTO S_evenement.tblSousEvenement([nom],[description],[dateSupprime],[noEvenement],[noEngagement]) VALUES('Spectacle 2014','pede et risus. Quisque libero lacus, varius et, euismod et, commodo at, libero. Morbi accumsan laoreet ipsum. Curabitur consequat, lectus',NULL,5,6);
INSERT INTO S_evenement.tblSousEvenement([nom],[description],[dateSupprime],[noEvenement],[noEngagement]) VALUES('Spectacle 2018','ligula. Aenean euismod mauris eu elit. Nulla','2013/11/08',9,7);
INSERT INTO S_evenement.tblSousEvenement([nom],[description],[dateSupprime],[noEvenement],[noEngagement]) VALUES('Souper 2014','ligula. Aenean gravida nunc sed pede. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Proin vel arcu eu odio tristique pharetra. Quisque ac libero nec ligula consectetuer rhoncus. Nullam velit dui, semper et, lacinia vitae, sodales',NULL,5,8);
INSERT INTO S_evenement.tblSousEvenement([nom],[description],[dateSupprime],[noEvenement],[noEngagement]) VALUES('Souper 2018','mi pede, nonummy ut, molestie in, tempus eu, ligula. Aenean euismod mauris eu elit. Nulla facilisi. Sed','2013/11/14',9,9);
INSERT INTO S_evenement.tblSousEvenement([nom],[description],[dateSupprime],[noEvenement],[noEngagement]) VALUES('Collecte de fond 2019','dolor. Fusce mi lorem, vehicula et,','2014/04/08',9,10);
INSERT INTO S_evenement.tblSousEvenement([nom],[description],[dateSupprime],[noEvenement],[noEngagement]) VALUES('Collecte de fond 2014','Aenean euismod mauris eu elit. Nulla facilisi. Sed neque. Sed eget lacus. Mauris non dui nec urna suscipit nonummy. Fusce fermentum fermentum arcu. Vestibulum ante ipsum primis in',NULL,5,11);
INSERT INTO S_evenement.tblSousEvenement([nom],[description],[dateSupprime],[noEvenement],[noEngagement]) VALUES('Souper 2019','aliquet. Phasellus fermentum convallis ligula. Donec luctus aliquet odio. Etiam ligula tortor, dictum eu, placerat eget, venenatis a, magna. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Etiam laoreet,',NULL,10,12);
INSERT INTO S_evenement.tblSousEvenement([nom],[description],[dateSupprime],[noEvenement],[noEngagement]) VALUES('Spectacle 2016','est ac mattis semper, dui lectus rutrum urna, nec luctus felis purus ac tellus. Suspendisse sed dolor. Fusce mi lorem, vehicula et, rutrum eu, ultrices sit amet, risus. Donec nibh enim,',NULL,7,13);
INSERT INTO S_evenement.tblSousEvenement([nom],[description],[dateSupprime],[noEvenement],[noEngagement]) VALUES('Collecte de fond 2019','eu','2013/12/08',10,14);
INSERT INTO S_evenement.tblSousEvenement([nom],[description],[dateSupprime],[noEvenement],[noEngagement]) VALUES('Spectacle 2009','eu','2009/12/08',11,15);


GO

PRINT('Fin des insertions des sous-�v�nements')

GO

PRINT('D�but des insertions de la table des activit�s')

GO

INSERT INTO S_evenement.tblActivite([nomResponsable],[etat],[dateCreation],[tache],[detail],[dateSupprime],[noEvenement],[noSousEvenement]) VALUES('Mia Glenn','0','2015/03/05','Euismod PC','quam. Curabitur',NULL,NULL,10);
INSERT INTO S_evenement.tblActivite([nomResponsable],[etat],[dateCreation],[tache],[detail],[dateSupprime],[noEvenement],[noSousEvenement]) VALUES('Brooke Austin','0','2013/11/22','Massa Rutrum Magna Limited','aliquet libero. Integer in magna. Phasellus dolor elit, pellentesque a, facilisis','2014/04/12','10',NULL);
INSERT INTO S_evenement.tblActivite([nomResponsable],[etat],[dateCreation],[tache],[detail],[dateSupprime],[noEvenement],[noSousEvenement]) VALUES('Athena Hebert','1','2015/06/20','Aliquet Sem Ut Limited','Quisque nonummy ipsum non arcu. Vivamus sit amet risus. Donec egestas. Aliquam',NULL,NULL,13);
INSERT INTO S_evenement.tblActivite([nomResponsable],[etat],[dateCreation],[tache],[detail],[dateSupprime],[noEvenement],[noSousEvenement]) VALUES('Ariel Blackwell','1','2014/01/05','Est LLC','a, aliquet vel,',NULL,'2',NULL);
INSERT INTO S_evenement.tblActivite([nomResponsable],[etat],[dateCreation],[tache],[detail],[dateSupprime],[noEvenement],[noSousEvenement]) VALUES('Doris Dillon','1','2015/02/16','Porttitor Eros Company','dui, semper et, lacinia vitae, sodales at, velit. Pellentesque ultricies dignissim lacus. Aliquam rutrum lorem ac risus. Morbi',NULL,'5',NULL);
INSERT INTO S_evenement.tblActivite([nomResponsable],[etat],[dateCreation],[tache],[detail],[dateSupprime],[noEvenement],[noSousEvenement]) VALUES('Cameran Meyers','0','2014/11/11','Egestas Urna Justo Corporation','pede, nonummy ut, molestie in, tempus eu, ligula. Aenean euismod mauris eu elit. Nulla facilisi. Sed',NULL,NULL,1);
INSERT INTO S_evenement.tblActivite([nomResponsable],[etat],[dateCreation],[tache],[detail],[dateSupprime],[noEvenement],[noSousEvenement]) VALUES('Kelly Blevins','1','2015/09/14','Dignissim Tempor Corp.','dolor quam, elementum at, egestas a, scelerisque sed, sapien. Nunc pulvinar arcu et pede. Nunc',NULL,'3',NULL);
INSERT INTO S_evenement.tblActivite([nomResponsable],[etat],[dateCreation],[tache],[detail],[dateSupprime],[noEvenement],[noSousEvenement]) VALUES('Bevis George','0','2014/01/12','Proin Nisl Sem Industries','lorem semper auctor. Mauris vel turpis. Aliquam adipiscing lobortis risus. In mi pede, nonummy ut,','2014/11/22',NULL,9);
INSERT INTO S_evenement.tblActivite([nomResponsable],[etat],[dateCreation],[tache],[detail],[dateSupprime],[noEvenement],[noSousEvenement]) VALUES('Cassandra Roth','1','2014/09/13','Fusce Industries','senectus et netus et malesuada fames ac turpis egestas. Aliquam fringilla cursus purus. Nullam scelerisque neque sed sem egestas blandit.',NULL,'8',NULL);
INSERT INTO S_evenement.tblActivite([nomResponsable],[etat],[dateCreation],[tache],[detail],[dateSupprime],[noEvenement],[noSousEvenement]) VALUES('Hasad Christensen','1','2015/04/23','Libero Nec PC','et, euismod et, commodo at, libero. Morbi accumsan laoreet ipsum. Curabitur consequat, lectus sit amet luctus vulputate, nisi sem semper erat, in',NULL,NULL,3);


GO

PRINT('Fin des insertions des activit�s')

GO

PRINT('D�but des insertions de la table des Commanditaires')

GO

INSERT INTO S_evenement.tblCommanditaire([nomCommanditaire],[nomContact],[logo],[url],[textePresentation],[courrielContact],[numTel],[extension],[dateSupprime]) VALUES('In Sodales Consulting','Brent Downs',NULL,NULL,'id enim. Curabitur massa. Vestibulum accumsan neque et','dui.semper.et@eu.co.uk','8338354826','87332','2017/03/29');
INSERT INTO S_evenement.tblCommanditaire([nomCommanditaire],[nomContact],[logo],[url],[textePresentation],[courrielContact],[numTel],[extension],[dateSupprime]) VALUES('Adipiscing Enim Institute','Jael Rogers',NULL,NULL,'metus eu erat semper rutrum. Fusce dolor quam,','elit.pede.malesuada@Quisquenonummyipsum.edu','3171318382','98364',NULL);
INSERT INTO S_evenement.tblCommanditaire([nomCommanditaire],[nomContact],[logo],[url],[textePresentation],[courrielContact],[numTel],[extension],[dateSupprime]) VALUES('Fringilla Donec Company','Irma Morse',NULL,NULL,'Vivamus sit amet risus. Donec egestas. Aliquam nec enim. Nunc','magna.nec@Inlorem.net','1675258218','4455',NULL);
INSERT INTO S_evenement.tblCommanditaire([nomCommanditaire],[nomContact],[logo],[url],[textePresentation],[courrielContact],[numTel],[extension],[dateSupprime]) VALUES('Rhoncus Donec Company','Sydney Dean',NULL,NULL,'consectetuer euismod est arcu ac orci. Ut semper pretium neque. Morbi quis urna. Nunc quis arcu vel quam dignissim','blandit@primis.net','2124948669','79692',NULL);
INSERT INTO S_evenement.tblCommanditaire([nomCommanditaire],[nomContact],[logo],[url],[textePresentation],[courrielContact],[numTel],[extension],[dateSupprime]) VALUES('Risus A Ultricies Limited','Amaya Montgomery',NULL,NULL,'sit amet, consectetuer adipiscing elit. Etiam laoreet, libero et tristique','in.aliquet.lobortis@facilisiSedneque.net','2274657545','23162',NULL);
INSERT INTO S_evenement.tblCommanditaire([nomCommanditaire],[nomContact],[logo],[url],[textePresentation],[courrielContact],[numTel],[extension],[dateSupprime]) VALUES('Risus Foundation','Odysseus Snyder',NULL,NULL,'aliquam eu, accumsan sed, facilisis vitae, orci. Phasellus dapibus','id.libero.Donec@Nam.com','4313659527','66812',NULL);
INSERT INTO S_evenement.tblCommanditaire([nomCommanditaire],[nomContact],[logo],[url],[textePresentation],[courrielContact],[numTel],[extension],[dateSupprime]) VALUES('Proin Velit Sed Consulting','Xenos Wilder',NULL,NULL,'ultrices posuere','ut@nuncrisusvarius.co.uk','9494312495','9649',NULL);
INSERT INTO S_evenement.tblCommanditaire([nomCommanditaire],[nomContact],[logo],[url],[textePresentation],[courrielContact],[numTel],[extension],[dateSupprime]) VALUES('Egestas Inc.','Marah Powell',NULL,NULL,'lacus pede sagittis augue, eu tempor erat neque non quam. Pellentesque','eleifend.nec@tempordiam.com','5371697716','27687',NULL);
INSERT INTO S_evenement.tblCommanditaire([nomCommanditaire],[nomContact],[logo],[url],[textePresentation],[courrielContact],[numTel],[extension],[dateSupprime]) VALUES('Aenean Institute','Blake Ramirez',NULL,NULL,'est, vitae sodales nisi magna sed dui. Fusce aliquam, enim nec tempus','id@laciniaat.co.uk','6613729942','22345',NULL);
INSERT INTO S_evenement.tblCommanditaire([nomCommanditaire],[nomContact],[logo],[url],[textePresentation],[courrielContact],[numTel],[extension],[dateSupprime]) VALUES('Ligula Aenean Gravida Institute','Shelly Dale',NULL,NULL,'Nam ligula elit, pretium et, rutrum non, hendrerit id, ante. Nunc mauris sapien, cursus','quam@tempusscelerisquelorem.co.uk','7712329869','10525',NULL);
INSERT INTO S_evenement.tblCommanditaire([nomCommanditaire],[nomContact],[logo],[url],[textePresentation],[courrielContact],[numTel],[extension],[dateSupprime]) VALUES('Lectus Quis Industries','Jelani Donovan',NULL,NULL,'montes, nascetur ridiculus mus. Proin vel nisl. Quisque fringilla euismod','lorem.Donec.elementum@Donecsollicitudinadipiscing.ca','8454369174','50589',NULL);
INSERT INTO S_evenement.tblCommanditaire([nomCommanditaire],[nomContact],[logo],[url],[textePresentation],[courrielContact],[numTel],[extension],[dateSupprime]) VALUES('Bibendum Sed Est Institute','Charlotte Burke',NULL,NULL,'congue a, aliquet vel, vulputate','pede.Cum@sagittisplaceratCras.edu','7743522111','20314',NULL);
INSERT INTO S_evenement.tblCommanditaire([nomCommanditaire],[nomContact],[logo],[url],[textePresentation],[courrielContact],[numTel],[extension],[dateSupprime]) VALUES('Placerat Limited','Malachi Bowen',NULL,NULL,'et magnis dis parturient montes, nascetur ridiculus mus. Donec dignissim magna a tortor. Nunc commodo auctor velit. Aliquam nisl.','aliquam.adipiscing.lacus@lobortisquis.ca','7744825879','77746',NULL);
INSERT INTO S_evenement.tblCommanditaire([nomCommanditaire],[nomContact],[logo],[url],[textePresentation],[courrielContact],[numTel],[extension],[dateSupprime]) VALUES('Nullam Nisl Maecenas Industries','Quin Ochoa',NULL,NULL,'lacinia orci,','id.enim@Integervitae.com','2671957243','35705',NULL);
INSERT INTO S_evenement.tblCommanditaire([nomCommanditaire],[nomContact],[logo],[url],[textePresentation],[courrielContact],[numTel],[extension],[dateSupprime]) VALUES('Facilisis Vitae Limited','Tatiana Mcfadden',NULL,NULL,'at, egestas a, scelerisque sed, sapien. Nunc pulvinar arcu et pede.','sodales.Mauris@nulla.org','7221856923','1612',NULL);
INSERT INTO S_evenement.tblCommanditaire([nomCommanditaire],[nomContact],[logo],[url],[textePresentation],[courrielContact],[numTel],[extension],[dateSupprime]) VALUES('Egestas Hendrerit Associates','Ila Rasmussen',NULL,NULL,'et, rutrum','justo.Praesent@convallisest.com','3278312316','47445',NULL);
INSERT INTO S_evenement.tblCommanditaire([nomCommanditaire],[nomContact],[logo],[url],[textePresentation],[courrielContact],[numTel],[extension],[dateSupprime]) VALUES('Amet Risus Institute','Bert Rogers',NULL,NULL,'orci luctus et ultrices posuere cubilia Curae; Donec tincidunt. Donec vitae erat vel pede blandit congue. In','interdum@neque.com','2711531856','78391',NULL);
INSERT INTO S_evenement.tblCommanditaire([nomCommanditaire],[nomContact],[logo],[url],[textePresentation],[courrielContact],[numTel],[extension],[dateSupprime]) VALUES('Quis Corporation','Malachi Burris',NULL,NULL,'erat vitae risus.','Vivamus.nisi@ridiculus.com','7846946917','58123',NULL);
INSERT INTO S_evenement.tblCommanditaire([nomCommanditaire],[nomContact],[logo],[url],[textePresentation],[courrielContact],[numTel],[extension],[dateSupprime]) VALUES('Donec Egestas Duis LLP','Tate Rutledge',NULL,NULL,'consequat, lectus sit amet luctus vulputate,','iaculis@diam.edu','2778722746','76569',NULL);
INSERT INTO S_evenement.tblCommanditaire([nomCommanditaire],[nomContact],[logo],[url],[textePresentation],[courrielContact],[numTel],[extension],[dateSupprime]) VALUES('At Fringilla Purus LLP','Mara Sellers',NULL,NULL,'feugiat metus sit amet ante. Vivamus non lorem vitae','neque.sed.dictum@Curabiturdictum.ca','5236843781','16123','2016/12/04');


GO

PRINT('Fin des insertions des commanditaires')

GO


PRINT('D�but de cr�ation de la table des dons')


INSERT INTO S_evenement.tblDon([noCommanditaire],[noSousEvenement],[montant],[dateDon],[dateSupprime]) VALUES(13,12,152,'2015/01/09',NULL);
INSERT INTO S_evenement.tblDon([noCommanditaire],[noSousEvenement],[montant],[dateDon],[dateSupprime]) VALUES(14,14,885,'2013/12/29',NULL);
INSERT INTO S_evenement.tblDon([noCommanditaire],[noSousEvenement],[montant],[dateDon],[dateSupprime]) VALUES(7,14,860,'2015/04/13',NULL);
INSERT INTO S_evenement.tblDon([noCommanditaire],[noSousEvenement],[montant],[dateDon],[dateSupprime]) VALUES(11,7,942,'2015/07/24',NULL);
INSERT INTO S_evenement.tblDon([noCommanditaire],[noSousEvenement],[montant],[dateDon],[dateSupprime]) VALUES(3,9,245,'2015/07/17',NULL);
INSERT INTO S_evenement.tblDon([noCommanditaire],[noSousEvenement],[montant],[dateDon],[dateSupprime]) VALUES(13,10,233,'2014/10/22',NULL);
INSERT INTO S_evenement.tblDon([noCommanditaire],[noSousEvenement],[montant],[dateDon],[dateSupprime]) VALUES(5,14,645,'2014/10/27',NULL);
INSERT INTO S_evenement.tblDon([noCommanditaire],[noSousEvenement],[montant],[dateDon],[dateSupprime]) VALUES(4,10,701,'2014/03/06',NULL);
INSERT INTO S_evenement.tblDon([noCommanditaire],[noSousEvenement],[montant],[dateDon],[dateSupprime]) VALUES(1,6,243,'2013/10/06',NULL);
INSERT INTO S_evenement.tblDon([noCommanditaire],[noSousEvenement],[montant],[dateDon],[dateSupprime]) VALUES(16,2,611,'2014/08/14',NULL);
INSERT INTO S_evenement.tblDon([noCommanditaire],[noSousEvenement],[montant],[dateDon],[dateSupprime]) VALUES(6,12,642,'2014/05/20',NULL);
INSERT INTO S_evenement.tblDon([noCommanditaire],[noSousEvenement],[montant],[dateDon],[dateSupprime]) VALUES(5,12,684,'2015/08/21',NULL);
INSERT INTO S_evenement.tblDon([noCommanditaire],[noSousEvenement],[montant],[dateDon],[dateSupprime]) VALUES(16,13,745,'2014/09/25',NULL);
INSERT INTO S_evenement.tblDon([noCommanditaire],[noSousEvenement],[montant],[dateDon],[dateSupprime]) VALUES(16,14,614,'2013/10/09',NULL);
INSERT INTO S_evenement.tblDon([noCommanditaire],[noSousEvenement],[montant],[dateDon],[dateSupprime]) VALUES(16,12,226,'2014/05/30',NULL);
INSERT INTO S_evenement.tblDon([noCommanditaire],[noSousEvenement],[montant],[dateDon],[dateSupprime]) VALUES(20,12,778,'2013/10/28',NULL);
INSERT INTO S_evenement.tblDon([noCommanditaire],[noSousEvenement],[montant],[dateDon],[dateSupprime]) VALUES(7,5,450,'2014/03/12',NULL);
INSERT INTO S_evenement.tblDon([noCommanditaire],[noSousEvenement],[montant],[dateDon],[dateSupprime]) VALUES(14,5,689,'2014/10/27',NULL);
INSERT INTO S_evenement.tblDon([noCommanditaire],[noSousEvenement],[montant],[dateDon],[dateSupprime]) VALUES(14,2,656,'2014/05/08',NULL);
INSERT INTO S_evenement.tblDon([noCommanditaire],[noSousEvenement],[montant],[dateDon],[dateSupprime]) VALUES(19,7,796,'2014/01/04','2014/01/09');

GO

PRINT('Fin des insertions de la table des dons')
GO

