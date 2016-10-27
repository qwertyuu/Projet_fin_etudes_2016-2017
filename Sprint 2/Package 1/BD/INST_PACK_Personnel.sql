 USE PE2_Officiel

 INSERT INTO S_Personnel.tblMemo(expediteur, destinataire, statut, info) VALUES (5, 5, 0, 'Salut monsieur l''utilisateur');
 INSERT INTO S_Personnel.tblMemo(expediteur, destinataire, statut, info) VALUES (5, 4, 1, 'Equipe2 revoit le nombre de place dans les salles');
 INSERT INTO S_Personnel.tblMemo(expediteur, destinataire, statut,dateEnvoi, info) VALUES (2, 5, 0, '20161003','User n''oubli pas de verifier la sonorisation');
 INSERT INTO S_Personnel.tblMemo(expediteur, destinataire, statut,dateEnvoi, info) VALUES (5, 2, 1, '20160920','Equipe2 Faut réserver la salle');
 INSERT INTO S_Personnel.tblMemo(expediteur, destinataire, statut,dateEnvoi, info) VALUES (4, 5, 0, '20161003','User n''oubli pas de verifier la sonorisation');
 INSERT INTO S_Personnel.tblMemo(expediteur, destinataire, statut,dateEnvoi, info) VALUES (2, 4, 0, '20161003','Root n''oubli pas de verifier la luimère des salles');
 INSERT INTO S_Personnel.tblMemo(expediteur, destinataire, statut,dateEnvoi, info) VALUES (5, 5, 1, '20160823 10:30:00','Equipe2 faut voir si l''agence de publicité a accepté la publicité');
 INSERT INTO S_Personnel.tblMemo(expediteur, destinataire, statut,dateEnvoi, info) VALUES (5, 4, 0, '20160823 14:30:00','Equipe2 occupe toi des réservations');
 INSERT INTO S_Personnel.tblMemo(expediteur, destinataire, statut,dateEnvoi, info) VALUES (3, 4, 1, '20161023 15:00:00','Admin vos voir si l''agence de publicité a accepté la publicité');
 INSERT INTO S_Personnel.tblMemo(expediteur, destinataire, statut,dateEnvoi, info) VALUES (4, 2, 0, '20160504 09:30:00','User occupe toi des bénévolts');
GO
 PRINT 'Insérer mémos réussi'

GO
 PRINT 'Fin d''insertion des tables du package Personnel'
