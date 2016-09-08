using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestiRire.Controleur.Details
{
    class DetailAgence
    {
        Modele.PE2_OfficielEntities bd = new Modele.PE2_OfficielEntities();
        
        //Méthode permettant d'jouter une agnece
        public void AjouterAgence(string name, string courr, string vil, string codepost, string adres, string cel, string tel, string poste,string prov,string pay)
        {
            if(bd!=null) //On verifie que le modèle n'est pas null.
            {
                var adresse = new Modele.tblAdresse { adresse = adres, ville = vil, codepostal = codepost, province = prov, pays = pay, telBureau = tel, telCellulaire = cel, extension = poste };
                bd.tblAdresse.Add(adresse);
                var agence = new Modele.tblAgence { nom = name, courriel = courr };//On enregistre l'agence.
                bd.tblAgence.Add(agence);
                bd.SaveChanges();//Et enfin on sauvegarde les modifications.
            }


        }
    }
}
