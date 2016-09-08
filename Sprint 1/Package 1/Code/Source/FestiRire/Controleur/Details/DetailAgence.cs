using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestiRire.Controleur.Details
{
    class DetailAgence
    {
        DBProvider provider = new DBProvider();
        
        //Méthode permettant d'jouter une agnece
        public void AjouterAgence(string no,string name, string courr, string vil, string codepost, string adres, string cel, string tel, string poste,string prov,string pay)
        {         
                var adresse = new Modele.tblAdresse { adresse = adres, ville = vil, codepostal = codepost, province = prov, pays = pay, telBureau = tel, telCellulaire = cel, extension = poste };
                provider.SaveAdrrese(adresse);
                var agence = new Modele.tblAgence {noAgence=no,nom = name, courriel = courr,noAdresse=adresse.noAdresse };//On enregistre l'agence.
                provider.SaveAgence(agence);//Et enfin on sauvegarde les modifications.
        }
    }
}
