--Ce script permet de créer l'ensemble des contraintes contenues dans le package évènement
--Fait par: Pierre-Alexandre Pageau
--En ce: 6 Octobre 2016

USE PE2_Officiel

ALTER TABLE S_Evenement.tblEvenement ADD
CONSTRAINT NOEVEN_EVEN_PK PRIMARY KEY(noEvenement)
PRINT('Fin des contraintes PK des évènements')

GO

ALTER TABLE S_Evenement.tblSousEvenement ADD
CONSTRAINT NOSOUSEVEN_SOUSEVEN_PK PRIMARY KEY(noSousEvenement)
PRINT('Fin des contraintes PK des sous-évènements')

GO

ALTER TABLE S_Evenement.tblActivite ADD
CONSTRAINT NOACT_ACT_PK PRIMARY KEY(noActivite)
PRINT('Fin des contraintes PK des activitées')

GO

ALTER TABLE S_Evenement.tblCommanditaire ADD
CONSTRAINT NOCOMM_COMM_PK PRIMARY KEY(noCommanditaire)
PRINT('Fin des contraintes PK des commanditaires')

GO

ALTER TABLE S_Evenement.tblDon ADD
CONSTRAINT NODON_DON_PK PRIMARY KEY(noDon)
PRINT('Fin des contraintes PK des dons')

GO

ALTER TABLE S_Evenement.tblActivite ADD
CONSTRAINT NOSOUSEVEN_ACT_FK FOREIGN KEY(noSousEvenement) REFERENCES S_Evenement.tblSousEvenement(noSousEvenement),
CONSTRAINT NOEVEN_ACT_FK FOREIGN KEY(noEvenement) REFERENCES S_Evenement.tblEvenement(noEvenement),
CONSTRAINT PILE_UNE_FK CHECK(((CASE WHEN noSousEvenement IS NULL THEN 0 ELSE 1 END) + (CASE WHEN noEvenement IS NULL THEN 0 ELSE 1 END)) = 1)
PRINT('Fin des contraintes FK des activitées')

GO

ALTER TABLE S_Evenement.tblSousEvenement ADD
CONSTRAINT NOEVEN_SOUSEVEN_FK FOREIGN KEY(noEvenement) REFERENCES S_Evenement.tblEvenement(noEvenement)
PRINT('Fin des contraintes FK des sous-évènements')

GO

ALTER TABLE S_Contrat.tblEngagement ADD
CONSTRAINT NOSOUSEVENEMENT_ENGAGEMENT FOREIGN KEY(noSousEvenement) REFERENCES S_evenement.tblSousEvenement(noSousEvenement)
PRINT('Fin des contraintes FK des engagements')

GO

ALTER TABLE S_Evenement.tblDon ADD
CONSTRAINT NOCOMM_DON_FK FOREIGN KEY(noCommanditaire) REFERENCES S_Evenement.tblCommanditaire(noCommanditaire),
CONSTRAINT NOSOUSEVEN_DON_FK FOREIGN KEY(noSousEvenement) REFERENCES S_Evenement.tblSousEvenement(noSousEvenement)
PRINT('Fin des contraintes FK des dons')

GO

ALTER TABLE S_Evenement.tblCommanditaire ADD
CONSTRAINT CHE_COUR_FORM_COMM CHECK(courrielContact like '%_@__%.__%'),
CONSTRAINT CHE_NO_TEL CHECK(numTel NOT LIKE '%[^0-9]%')
PRINT 'Fin création des contraintes CHECK de table commanditaire'