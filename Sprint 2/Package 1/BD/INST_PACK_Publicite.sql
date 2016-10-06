--Ce script permet de créer l'ensemble des contraintes contenues dans le package publicite
--Fait par: Raphaël Côté
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
