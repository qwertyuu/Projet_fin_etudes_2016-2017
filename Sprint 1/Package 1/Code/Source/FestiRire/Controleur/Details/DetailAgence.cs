using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestiRire.Controleur.Details
{
    class DetailAgence : DetailBaseSimple
    {
        DBProvider provider = new DBProvider();

        public Modele.tblAgence LoadAgence(string id)
        {
            return provider.SelectAgence(id);
        }
        //Méthode permettant d'jouter une agence
        public bool EnregistrerAgence(string _noAgence,string name, string courr, string vil, string codepost, string adres, string cel, string tel, string poste,string prov,string pay)
        {
            
            Modele.tblAgence a = provider.SelectAgence(SanitariserTexte(_noAgence));
            if (a != null)
            {
                var addr = a.tblAdresse;
                addr.adresse = SanitariserTexte(adres);
                addr.ville = SanitariserTexte(vil);
                addr.codepostal = SanitariserTexte(codepost);
                addr.province = SanitariserTexte(prov);
                addr.pays = SanitariserTexte(pay);
                addr.telBureau = SanitariserTelephone(tel);
                addr.telCellulaire = SanitariserTelephone(cel);
                addr.extension = NullSiVide(SanitariserTexte(poste));
                a.nom = SanitariserTexte(name);
                a.courriel = SanitariserCourriel(courr);
                provider.Save();
                return true;
            }
            else
            {
                var adresse = new Modele.tblAdresse { adresse = SanitariserTexte(adres), ville = SanitariserTexte(vil), codepostal = SanitariserTexte(codepost), province = SanitariserTexte(prov), pays = SanitariserTexte(pay), telBureau = SanitariserTelephone(tel), telCellulaire = SanitariserTelephone(cel), extension = NullSiVide(SanitariserTexte(poste)) };
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
