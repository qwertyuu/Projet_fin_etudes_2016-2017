using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestiRire.Controleur.Details
{
    class DetailStatut : DetailBaseSimple
    {
        private string EnleverDiese(string car)
        {
            return car.Remove(0, 1);
        }
        public bool AjouterStatut(int idAcien,string nom, string desc, string coul)
        {
            string couleurGod = EnleverDiese(coul);
            Modele.tblStatut statut = provider.SelectStatut(idAcien);

            if (statut != null)
            {
                //l'élément exite on fait une mise à jour.
                statut.nomStatut = nom;
                statut.description = desc;
                statut.couleur = couleurGod;
                provider.Save();
                return false;
            }
            else //On fait ajoute si l'élément n'existe pas
            {
                var stat = new Modele.tblStatut { nomStatut = SanitariserTexte(nom), description = SanitariserTexte(desc),couleur=couleurGod };
                provider.InsertStatut(stat);
                return true;
            }
        }




        public Modele.tblStatut LoadStatut(int id)
        {
            return provider.SelectStatut(id);
        }
        public void DeleteStatut(int no)
        {
            provider.SupprimerStatut(no);
        }
    }
}
