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
        public DetailEngagement() : base()
        {

        }

        public void EnregistrerEngagement(string nature, DateTime date, string heure, string duree, string lieu, string commentaire, string prixbillet, string capacite, string descCourte, string descLongue)
        {

            Modele.tblEngagement tE = new tblEngagement()
            {
                nature = nature,
                date = date,
                heure = heure,
                duree = duree,
                lieu = lieu,
                commentaire = commentaire,
                descriptionCourte = descCourte,
                description = descLongue,
            };
            provider.InsertEngagement(tE);
        }

        public tblEngagement LoadEngagement(int idEngagement)
        {
            return provider.SelectEngagement(idEngagement);
        }
    }
}
