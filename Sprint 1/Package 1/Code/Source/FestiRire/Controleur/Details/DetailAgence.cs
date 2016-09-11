﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestiRire.Controleur.Details
{
    class DetailAgence : DetailBaseSimple
    {

        public DetailAgence() : base()
        {

        }


        public Modele.tblAgence LoadAgence(string id)
        {
            return provider.SelectAgence(id);
        }
        //Méthode permettant d'jouter une agnece
        public void AjouterAgence(string no,string name, string courr, string vil, string codepost, string adres, string cel, string tel, string poste,string prov,string pay)
        {
            var adresse = new Modele.tblAdresse { adresse = adres, ville = vil, codepostal = codepost, province = prov, pays = pay, telBureau = tel, telCellulaire = cel, extension = poste };
            provider.InsertAdresse(adresse);
            var agence = new Modele.tblAgence {noAgence=no,nom = name, courriel = courr,noAdresse=adresse.noAdresse };//On enregistre l'agence.
            provider.InsertAgence(agence);//Et enfin on sauvegarde les modifications.
        }

        //Méthode permettant de supprimer une agence.
        public void DeleteAgence(string no)
        {
           
            if(!String.IsNullOrEmpty(no))
            {
                provider.SupprimerAgence(no);
               
            }
        }
        public bool EnregistrerAgence(string orig, string _noAgence,string name, string courr, string vil, string codepost, string adres, string cel, string tel, string poste,string prov,string pay)
        {
            
            Modele.tblAgence a = provider.SelectAgence(SanitariserTexte(orig ?? _noAgence));
            if (a != null)
            {
                //Update
                var addr = a.tblAdresse;
                addr.adresse = SanitariserTexte(adres);
                addr.ville = SanitariserTexte(vil);
                addr.codepostal = SanitariserTexte(codepost);
                addr.province = SanitariserTexte(prov);
                addr.pays = SanitariserTexte(pay);
                addr.telBureau = SanitariserTelephone(tel);
                addr.telCellulaire = SanitariserTelephone(cel);
                addr.extension = SanitariserTexte(poste);
                a.nom = SanitariserTexte(name);
                a.courriel = SanitariserCourriel(courr);
                provider.Save();
                return true;
            }
            else
            {
                //Insert
                var adresse = new Modele.tblAdresse { adresse = SanitariserTexte(adres), ville = SanitariserTexte(vil), codepostal = SanitariserTexte(codepost), province = SanitariserTexte(prov), pays = SanitariserTexte(pay), telBureau = SanitariserTelephone(tel), telCellulaire = SanitariserTelephone(cel), extension = SanitariserTexte(poste) };
                provider.InsertAdresse(adresse);
                var agence = new Modele.tblAgence { noAgence = _noAgence, nom = name, courriel = courr, noAdresse = adresse.noAdresse };//On enregistre l'agence.
                provider.InsertAgence(agence);//Et enfin on sauvegarde les modifications.
                return false;
            }

        }
        internal bool AgenceExiste(string _noAgence, out string nomAgence)
        {
            var Agence = provider.SelectAgence(SanitariserTexte(_noAgence));
            if (Agence != null)
            {
                nomAgence = Agence.nom;
                return true;
            }
            nomAgence = "";
            return false;
        }
    }
}
