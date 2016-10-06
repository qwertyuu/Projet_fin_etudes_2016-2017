 USE PE2_Officiel
 INSERT INTO S_Personnel.tblUtilisateur(IdUser,motPasse)VALUES('Equipe2','PvCmx48Mqm5pqGzWe6nKEg=='); --mot passe: Raispike
 INSERT INTO S_Personnel.tblUtilisateur(IdUser,motPasse)VALUES('Utilisateur','DMF1ucDxtqgxw5niaXcmYQ==');--mot passe: a
 INSERT INTO S_Personnel.tblUtilisateur(IdUser,motPasse)VALUES('Admin','ISMvKXpXpadDiUoOSoAfww==');--mot passe: amin
 INSERT INTO S_Personnel.tblUtilisateur(IdUser,motPasse)VALUES('User','7hHLsZBS5AsHqsDKBgwj7g==');--mot passe: user
 INSERT INTO S_Personnel.tblUtilisateur(IdUser,motPasse)VALUES('Root','Y6nw6nu5gFB5a2SehUgYRQ==');--mot passe: root
 PRINT 'Insérer utilisateurs réussi'

 INSERT INTO S_Personnel.tblMemo(expediteur, destinataire, statut, info) VALUES ('Equipe2', 'Utilisateur', 0, 'Salut monsieur l''utilisateur');
 INSERT INTO S_Personnel.tblMemo(expediteur, destinataire, statut, info) VALUES ('Utilisateur','Equipe2', 1, 'Equipe2 revoit le nombre de place dans les salles');
 INSERT INTO S_Personnel.tblMemo(expediteur, destinataire, statut,dateEnvoi, info) VALUES ('Admin', 'User', 0, '20161003','User n''oubli pas de verifier la sonorisation');
 INSERT INTO S_Personnel.tblMemo(expediteur, destinataire, statut,dateEnvoi, info) VALUES ('Root','Equipe2', 1, '20160920','Equipe2 Faut réserver la salle');
 INSERT INTO S_Personnel.tblMemo(expediteur, destinataire, statut,dateEnvoi, info) VALUES ('Admin', 'User', 0, '20161003','User n''oubli pas de verifier la sonorisation');
 INSERT INTO S_Personnel.tblMemo(expediteur, destinataire, statut,dateEnvoi, info) VALUES ('Utilisateur', 'Root', 0, '20161003','Root n''oubli pas de verifier la luimère des salles');
 INSERT INTO S_Personnel.tblMemo(expediteur, destinataire, statut,dateEnvoi, info) VALUES ('Admin', 'Equipe2', 1, '20160823 10:30:00','Equipe2 faut voir si l''agence de publicité a accepté la publicité');
 INSERT INTO S_Personnel.tblMemo(expediteur, destinataire, statut,dateEnvoi, info) VALUES ('User', 'Equipe2', 0, '20160823 14:30:00','Equipe2 occupe toi des réservations');
 INSERT INTO S_Personnel.tblMemo(expediteur, destinataire, statut,dateEnvoi, info) VALUES ('Root', 'Admin', 1, '20161023 15:00:00','Admin vos voir si l''agence de publicité a accepté la publicité');
 INSERT INTO S_Personnel.tblMemo(expediteur, destinataire, statut,dateEnvoi, info) VALUES ('Admin', 'User', 0, '20160504 09:30:00','User occupe toi des bénévolts');
 PRINT 'Insérer mémos réussi'

GO
 PRINT 'Fin d''insertion des tables du package Personnel'

 select * from S_Personnel.tblMemo
