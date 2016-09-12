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
            var statut = new Modele.tblStatut { nomStatut = nom, description = desc, couleur = coul };//On enregistre le statut.
            provider.InsertStatut(statut);//Et enfin on sauvegarde les modifications.
        }
        internal bool StatutExiste(string _noStatut, out string nomStatut)
        {
            var statut = provider.SelectAgence(_noStatut);
            if (statut != null)
            {
                nomStatut = statut.nom;
                return true;
            }
            nomStatut = "";
            return false;
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
