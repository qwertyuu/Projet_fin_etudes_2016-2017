using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestiRire.Controleur.Details
{
    class DetailStatut : DetailBaseSimple
    {
        public void AjouterStatut(string nom, string desc, string coul)
        {
            var statut = new Modele.tblStatut { nomStatut = SanitariserTexte(nom), description = desc, couleur = coul };//On enregistre le statut.
            provider.InsertStatut(statut);//Et enfin on sauvegarde les modifications.
        }

        public void AjouterStatut(int idStatut, string nom, string desc, string coul)
        {
            var statut = provider.SelectStatut(idStatut);
            statut.nomStatut = SanitariserTexte(nom);
            statut.description = desc;
            statut.couleur = coul;
            provider.Save();//Et enfin on sauvegarde les modifications.
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
