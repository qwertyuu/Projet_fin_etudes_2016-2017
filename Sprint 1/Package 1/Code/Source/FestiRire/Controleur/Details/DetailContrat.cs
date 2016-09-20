﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestiRire.Controleur.Details
{
    class DetailContrat : DetailBaseSimple
    {
        public Modele.tblContrat SelectContrat(string idContrat)
        {
            return provider.SelectContrat(idContrat);
        }

        public Modele.tblResponsable ResponsableAgence(string idContrat)
        {
            return provider.SelectResponsableAgence(idContrat);
        }

        public Modele.tblResponsable ResponsableDiffuseur(string idContrat)
        {
            return provider.SelectResponsableDiffuseur(idContrat);
        }

        public Modele.tblResponsable EnregistrerResponsable(string IdAcienContrat,string nomRespoAge, string prenomRespoAge, string courr, string cel, string tel, string poste, string signataireRespo, DateTime dateSignatire, bool idem, string noAge,int noDiff)
        {
            Modele.tblResponsable ResponsableMAJ = provider.SelectResponsableAgence(IdAcienContrat);
            if(ResponsableMAJ!=null)//On fait une MAJ
            {
                ResponsableMAJ.nom = SanitariserTexte(nomRespoAge);
                ResponsableMAJ.prenom =SanitariserTexte(prenomRespoAge);
                ResponsableMAJ.courriel =SanitariserCourriel(courr);
                ResponsableMAJ.telCellulaire =SanitariserTelephone(cel);
                ResponsableMAJ.telBureau = SanitariserTelephone(tel);
                ResponsableMAJ.extension =SanitariserTexte(poste);
                ResponsableMAJ.dateSignature = dateSignatire;
                ResponsableMAJ.noAgence = SanitariserTexte(noAge);
                ResponsableMAJ.idem = idem;
                provider.Save();
                return ResponsableMAJ;
            }
            else //On enregistre un nouveau
            {
                var RespoAge = new Modele.tblResponsable { nom = SanitariserTexte(nomRespoAge), prenom = SanitariserTexte(prenomRespoAge), courriel = SanitariserCourriel(courr), signataire = signataireRespo, dateSignature = dateSignatire, telBureau = SanitariserTelephone(tel), telCellulaire = SanitariserTelephone(cel), extension = poste, idem = idem, noAgence = SanitariserTexte(noAge), noDiffuseur = noDiff };
                provider.InsertResponsable(RespoAge);
                return RespoAge;
            }
        }
        public bool EnregistrerContrat(string IdAcienContrat,  string nomContrat,string lieu,string nomAgence, string nomDiffusseur,string com, string desc, int noStatut,string noAgence)
        {
            Modele.tblContrat contratMAJ = provider.SelectContrat(IdAcienContrat);
            if(contratMAJ!=null)
            {
                contratMAJ.nom = nomContrat;
                contratMAJ.noStatut = noStatut;
                contratMAJ.lieu = lieu;
                contratMAJ.commentaire = com;
                contratMAJ.description = desc;
                contratMAJ.noAgence = noAgence;
                provider.Save();
                return false;
            }
            else
            {
                var contrat = new Modele.tblContrat { lieu = lieu, nom = nomContrat, description = desc, commentaire = com, noStatut = noStatut, noAgence = noAgence };
                provider.InsertContrat(contrat);
                return true;
            }
        }
    }
}
