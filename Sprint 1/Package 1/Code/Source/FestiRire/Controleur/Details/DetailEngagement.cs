using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FestiRire.Modele;

namespace FestiRire.Controleur.Details
{
    class DetailEngagement : DetailBaseSimple
    {
        public void EnregistrerEngagement(string _nature, DateTime date, int heure, int minutes, string _duree, string _lieu, string _commentaire, string _prixbillet, string _capacite, string descCourte, string descLongue, string idContrat)
        {
            string nature = SanitariserTexte(_nature);
            string duree = SanitariserTexte(_duree);
            string lieu = SanitariserTexte(_lieu);
            string commentaire = SanitariserTexte(_commentaire);
            string prixbillet = SanitariserTexte(_prixbillet);
            string capacite = SanitariserTexte(_capacite);
            //INSERT
            Modele.tblEngagement tE = new tblEngagement()
            {
                nature = nature,
                date = date,
                heure = new TimeSpan(heure, minutes, 0),
                duree = duree,
                lieu = lieu,
                commentaire = commentaire,
                descriptionCourte = descCourte,
                description = descLongue,
                noContrat=idContrat
                
            };
            provider.InsertEngagement(tE);
        }
        internal void EnregistrerEngagement(int idEngagement, string _nature, DateTime date, int heure, int minutes, string _duree, string _lieu, string _commentaire, string _prixbillet, string _capacite, string descCourte, string descLongue)
        {
            string nature = SanitariserTexte(_nature);
            string duree = SanitariserTexte(_duree);
            string lieu = SanitariserTexte(_lieu);
            string commentaire = SanitariserTexte(_commentaire);
            string prixbillet = SanitariserTexte(_prixbillet);
            string capacite = SanitariserTexte(_capacite);
            //UPDATE
            var tE = provider.SelectEngagement(idEngagement);
            tE.nature = nature;
            tE.date = date;
            tE.heure = new TimeSpan(heure, minutes, 0);
            tE.duree = duree;
            tE.lieu = lieu;
            tE.commentaire = commentaire;
            tE.descriptionCourte = descCourte;
            tE.description = descLongue;
            provider.Save();
        }

        public tblEngagement LoadEngagement(int idEngagement)
        {
            //SELECT
            return provider.SelectEngagement(idEngagement);
        }

        public void SupprimerEngagement(int idEngagement)
        {
            //DATE SUPPRIME
            provider.SupprimerEngagement(idEngagement);
        }
    }
}
