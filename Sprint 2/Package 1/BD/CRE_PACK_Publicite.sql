CREATE SCHEMA S_publicite
GO


CREATE TABLE S_publicite.tblAppelOffre (
	noPublicite INT (11) NOT NULL
	,nom VARCHAR(50) NOT NULL
	,media VARCHAR(25) NOT NULL
	,dateRequise DATE NOT NULL
	,dateEnvoie DATE NOT NULL
	,description TEXT NOT NULL
	,dateSupprime DATETIME NULL
	,tblEvenementnoEvenement INT (11) NOT NULL
	);

CREATE TABLE S_publicite.AgencePublicite (
	noAgencePub INT (11) NOT NULL
	,nom VARCHAR(50) NOT NULL
	,dateSupprime DATETIME NULL
	);

CREATE TABLE S_publicite.tblStatut (
	noStatut INT (11) NOT NULL
	,nom VARCHAR(20) NOT NULL
	,couleur CHAR(6) NOT NULL
	,description TEXT
	,tblAppelOffrenoPublicite INT (11) NOT NULL
	);

CREATE TABLE S_publicite.tblSoumission (
	noSoumission INT (11) NOT NULL
	,nom VARCHAR(20) NOT NULL
	,prix DECIMAL(19, 0) NOT NULL
	,statut TINYINT (1) NOT NULL
	,description TEXT NOT NULL
	,dateSupprime DATETIME NULL
	,noAppelOffre INT (11) NOT NULL
	);

CREATE TABLE S_publicite.tblAppelOffreAgence (
	noAppelOffre INT (11) NOT NULL
	,noAgencePub INT (11) NOT NULL
	,offreNoPublicite INT (11) NOT NULL
	,noStatut INT (11) NOT NULL
	,noSoumission INT (11) NOT NULL
	);
