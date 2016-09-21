﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FestiRire.Modele;

namespace FestiRire.Controleur.Details
{
    class DetailEngagement : DetailBaseSimple
    {
        public void EnregistrerEngagement(string nature, DateTime date, int heure, int minutes, string duree, string lieu, string commentaire, string prixbillet, string capacite, string descCourte, string descLongue,string idContrat)
        {
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

        internal void EnregistrerEngagement(int idEngagement, string nature, DateTime date, int heure, int minutes, string duree, string lieu, string commentaire, string prixbillet, string capacite, string descCourte, string descLongue, string idContrat)
        {
            var tE = provider.SelectEngagement(idEngagement);
            tE.nature = nature;
            tE.date = date;
            tE.heure = new TimeSpan(heure, minutes, 0);
            tE.duree = duree;
            tE.lieu = lieu;
            tE.commentaire = commentaire;
            tE.descriptionCourte = descCourte;
            tE.description = descLongue;
            tE.noContrat = idContrat;
            provider.Save();
        }

        public tblEngagement LoadEngagement(int idEngagement)
        {
            return provider.SelectEngagement(idEngagement);
        }

        public void SupprimerEngagement(int idEngagement)
        {
            provider.SupprimerEngagement(idEngagement);
        }
    }
}
