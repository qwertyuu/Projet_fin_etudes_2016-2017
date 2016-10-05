GO
CREATE SCHEMA S_forfait
GO

CREATE TABLE S_forfait.tblForfait (
	noForfait INT (11) NOT NULL
	,nom VARCHAR(50) NOT NULL
	,description TEXT NOT NULL
	,dateSupprime DATETIME NULL
	);

CREATE TABLE S_forfait.tblService (
	noService INT (11) NOT NULL
	,nomService VARCHAR(25) NOT NULL
	,dateSupprime DATETIME NULL
	);

CREATE TABLE S_forfait.tblSalle (
	noSalle INT (11) NOT NULL
	,nomSalle VARCHAR(100) NOT NULL
	,prix DECIMAL(19, 0) NOT NULL
	,billet INT (11) NOT NULL
	,billetVIP INT (11) NOT NULL
	,photoSalle blob
	,dateSupprime DATETIME NULL
	,urlGoogleMap TEXT
	);

CREATE TABLE S_forfait.tblServiceRequis (
	noService INT (11) NOT NULL
	,noSousEvenement INT (11) NOT NULL
	);

CREATE TABLE S_forfait.tblServiceOffert (
	noService INT (11) NOT NULL
	,noSalle INT (11) NOT NULL
	);

CREATE TABLE S_forfait.tblForfaitSousEvenement (
	noForfait INT (11) NOT NULL
	,noSousEvenement INT (11) NOT NULL
	);
