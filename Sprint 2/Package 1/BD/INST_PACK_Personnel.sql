 USE PE2_Officiel
 INSERT INTO S_Personnel.tblUtilisateur(IdUser,motPasse)VALUES('Equipe2','PvCmx48Mqm5pqGzWe6nKEg==');
 INSERT INTO S_Personnel.tblUtilisateur(IdUser,motPasse)VALUES('Utilisateur','DMF1ucDxtqgxw5niaXcmYQ==');
 PRINT 'Ins�rer utilisateurs r�ussi'

 INSERT INTO S_Personnel.tblMemo(expediteur, destinataire, statut, info) VALUES ('Equipe2', 'Utilisateur', 0, 'Salut monsieur l''utilisateur');
 INSERT INTO S_Personnel.tblMemo(expediteur, destinataire, statut, info) VALUES ('Utilisateur','Equipe2', 1, 'Salut');
 PRINT 'Ins�rer m�mos r�ussi'