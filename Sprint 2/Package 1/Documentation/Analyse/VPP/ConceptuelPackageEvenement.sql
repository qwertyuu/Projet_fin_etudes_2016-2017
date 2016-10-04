CREATE TABLE tblActivite (
	noActivite INT (11) NOT NULL AUTO_INCREMENT
	,nomResponsable VARCHAR(50) NOT NULL
	,etat VARCHAR(25) NOT NULL
	,`date` DATE NOT NULL
	,tache VARCHAR(50) NOT NULL
	,detail TEXT
	,dateSupprime DATETIME NULL
	,noEvenement INT (11) NOT NULL
	,noSousEvenement INT (11) NOT NULL
	,PRIMARY KEY (noActivite)
	);

CREATE TABLE tblEvenement (
	noEvenement INT (11) NOT NULL AUTO_INCREMENT
	,nom VARCHAR(35) NOT NULL
	,dateDebut DATE NOT NULL
	,datefin DATE NOT NULL
	,affiche blob
	,url TEXT
	,description TEXT
	,dateSupprime DATETIME NULL
	,PRIMARY KEY (noEvenement)
	);

CREATE TABLE tblCommanditaire (
	noCommanditaire INT (11) NOT NULL AUTO_INCREMENT
	,nomCommanditaire VARCHAR(50) NOT NULL
	,nomContact VARCHAR(50) NOT NULL
	,logo blob
	,url TEXT
	,textePresentation TEXT NOT NULL
	,courriel VARCHAR(255) NOT NULL
	,numTel CHAR(10) NOT NULL
	,extension VARCHAR(5)
	,dateSupprimee DATETIME NULL
	,PRIMARY KEY (noCommanditaire)
	);

CREATE TABLE tblSousEvenement (
	noSousEvenement INT (11) NOT NULL AUTO_INCREMENT
	,nom VARCHAR(50) NOT NULL
	,description TEXT NOT NULL
	,noEvenement INT (11) NOT NULL
	,dateSupprime DATETIME NULL
	,PRIMARY KEY (noSousEvenement)
	);

CREATE TABLE tblDon (
	noDon INT (11) NOT NULL
	,noCommanditaire INT (11) NOT NULL
	,noSousEvenement INT (11) NOT NULL
	,Montant DECIMAL(19, 0) NOT NULL
	,`date` DATE NOT NULL
	,dateSupprime DATETIME NULL
	,PRIMARY KEY (
		noDon
		,noCommanditaire
		,noSousEvenement
		)
	);

CREATE TABLE tblServiceRequis (
	noService INT (11)
	,nomService VARCHAR(25)
	);

CREATE TABLE tblForfait (
	noForfait INT (11) NOT NULL AUTO_INCREMENT
	,nom VARCHAR(50) NOT NULL
	,description TEXT NOT NULL
	,dateSupprime DATETIME NULL
	,PRIMARY KEY (noForfait)
	);

CREATE TABLE tblService (
	noService INT (11) NOT NULL AUTO_INCREMENT
	,nomService VARCHAR(25) NOT NULL
	,dateSupprime DATETIME NULL
	,PRIMARY KEY (noService)
	);

CREATE TABLE tblSalle (
	noSalle INT (11) NOT NULL AUTO_INCREMENT
	,nomSalle VARCHAR(100) NOT NULL
	,prix DECIMAL(19, 0) NOT NULL
	,billet INT (11) NOT NULL
	,billetVIP INT (11) NOT NULL
	,photoSalle blob
	,dateSupprime DATETIME NULL
	,PRIMARY KEY (noSalle)
	);

CREATE TABLE tblSousEvenement_tblForfait_tblSousEvenement (
	tblSousEvenementnoSousEvenement INT (11) NOT NULL
	,tblForfait_tblSousEvenementnoSousEvenement INT (11) NOT NULL
	,tblForfait_tblSousEvenementnoForfait INT (11) NOT NULL
	,PRIMARY KEY (
		tblSousEvenementnoSousEvenement
		,tblForfait_tblSousEvenementnoSousEvenement
		,tblForfait_tblSousEvenementnoForfait)
	);

CREATE TABLE tblServiceRequis (
	noService INT (11) NOT NULL
	,noSousEvenement INT (11) NOT NULL
	,PRIMARY KEY (
		noService
		,noSousEvenement
		)
	);

CREATE TABLE tblForfaitSousEvenement (
	noForfait INT (11) NOT NULL
	,noSousEvenement INT (11) NOT NULL
	,PRIMARY KEY (
		noForfait
		,noSousEvenement
		)
	);

CREATE TABLE tblAppelOffre (
	noPublicite INT (11) NOT NULL AUTO_INCREMENT
	,nom VARCHAR(50) NOT NULL
	,media VARCHAR(25) NOT NULL
	,dateRequise DATE NOT NULL
	,dateEnvoie DATE NOT NULL
	,description TEXT NOT NULL
	,dateSupprime DATETIME NULL
	,tblEvenementnoEvenement INT (11) NOT NULL
	,PRIMARY KEY (noPublicite)
	);

CREATE TABLE AgencePublicite (
	noAgencePub INT (11) NOT NULL AUTO_INCREMENT
	,nom VARCHAR(50) NOT NULL
	,dateSupprime DATETIME NULL
	,PRIMARY KEY (noAgencePub)
	);

CREATE TABLE tblStatut (
	noStatut INT (11) NOT NULL AUTO_INCREMENT
	,nom VARCHAR(20) NOT NULL
	,couleur CHAR(6) NOT NULL
	,description TEXT
	,tblAppelOffrenoPublicite INT (11) NOT NULL
	,PRIMARY KEY (noStatut)
	);

CREATE TABLE tblSoumission (
	noSoumission INT (11) NOT NULL AUTO_INCREMENT
	,nom VARCHAR(20) NOT NULL
	,prix DECIMAL(19, 0) NOT NULL
	,statut TINYINT (1) NOT NULL
	,description TEXT NOT NULL
	,dateSupprime DATETIME NULL
	,noAppelOffre INT (11) NOT NULL
	,PRIMARY KEY (noSoumission)
	);

CREATE TABLE tblAppelOffreAgence (
	noAppelOffre INT (11) NOT NULL
	,AgencePublicitenoAgencePub INT (11) NOT NULL
	,OffrenoPublicite INT (11) NOT NULL
	,tblStatutnoStatut INT (11) NOT NULL
	,tblSoumissionnoSoumission INT (11) NOT NULL
	,PRIMARY KEY (
		noAppelOffre
		,AgencePublicitenoAgencePub
		)
	);

CREATE TABLE tblMemo (
	noMemo INT (11) NOT NULL AUTO_INCREMENT
	,info TEXT
	,statut TINYINT (1)
	,dateSupprime DATE NOT NULL
	,expediteur VARCHAR(30) NOT NULL
	,destinataire VARCHAR(30) NOT NULL
	,PRIMARY KEY (noMemo)
	);

CREATE TABLE tblServiceOffert (
	noService INT (11) NOT NULL
	,noSalle INT (11) NOT NULL
	,PRIMARY KEY (
		noService
		,noSalle
		)
	);

CREATE TABLE tblUtilisateur (
	IdUser VARCHAR(30) NOT NULL
	,motPasse CHAR(24) NOT NULL
	,PRIMARY KEY (IdUser)
	);

CREATE TABLE tblUtilisateur_tblUtilisateur (
	tblUtilisateuridUser VARCHAR(30) NOT NULL
	,tblUtilisateuridUser2 VARCHAR(30) NOT NULL
	,PRIMARY KEY (
		tblUtilisateuridUser
		,tblUtilisateuridUser2
		)
	);
