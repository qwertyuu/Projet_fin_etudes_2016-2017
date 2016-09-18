using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestiRire.Controleur.Details
{
    class DetailStatut : DetailBaseSimple
    {
        private string CouleurVersString(Color c)
        {
            return string.Format("{0:X2}{1:X2}{2:X2}", c.R, c.G, c.B);
        }
        public bool AjouterStatut(int idAcien,string nom, string desc, Color coul)
        {
            string couleurGod = CouleurVersString(coul);
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
