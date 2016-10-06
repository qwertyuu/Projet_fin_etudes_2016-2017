 USE PE2_Officiel
 INSERT INTO S_Personnel.tblUtilisateur(IdUser,motPasse)VALUES('Equipe2','PvCmx48Mqm5pqGzWe6nKEg=='); --mot passe: Raispike
 INSERT INTO S_Personnel.tblUtilisateur(IdUser,motPasse)VALUES('Utilisateur','DMF1ucDxtqgxw5niaXcmYQ==');--mot passe: a
 INSERT INTO S_Personnel.tblUtilisateur(IdUser,motPasse)VALUES('Admin','ISMvKXpXpadDiUoOSoAfww==');--mot passe: amin
 INSERT INTO S_Personnel.tblUtilisateur(IdUser,motPasse)VALUES('User','7hHLsZBS5AsHqsDKBgwj7g==');--mot passe: user
 INSERT INTO S_Personnel.tblUtilisateur(IdUser,motPasse)VALUES('Root','Y6nw6nu5gFB5a2SehUgYRQ==');--mot passe: root
 PRINT 'Insérer utilisateurs réussi'

 INSERT INTO S_Personnel.tblMemo(expediteur, destinataire, statut, info) VALUES ('Equipe2', 'Utilisateur', 0, 'Salut monsieur l''utilisateur');
 INSERT INTO S_Personnel.tblMemo(expediteur, destinataire, statut, info) VALUES ('Utilisateur','Equipe2', 1, 'Salut');
 PRINT 'Insérer mémos réussi'
