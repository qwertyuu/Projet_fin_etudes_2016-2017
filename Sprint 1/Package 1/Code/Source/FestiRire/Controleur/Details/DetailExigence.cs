﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FestiRire.Modele;

namespace FestiRire.Controleur.Details
{
    class DetailExigence : DetailBaseSimple
    {
        internal void EnregistrerExigence(string nom, DateTime dateExigence, decimal Montant, object cmbStatut, object cmbEvenement, string rtbCommentaire, string rtbDescriptionCourte, string rtbDescriptionLongue, string idContrat)
        {
            var exigence = new Modele.tblExigence()
            {
                nom = nom,
                date = dateExigence,
                montant = Montant,
                description = rtbDescriptionLongue,
                commentaire = rtbCommentaire,
                descriptionCourte = rtbDescriptionCourte,
                noContrat = idContrat,
                               
            };
            provider.InsertExigence(exigence);
        }

        internal tblExigence LoadExigence(int idExigence)
        {
            return provider.SelectExigence(idExigence);
            //SELECT UNIQUE
        }
        internal void EnregistrerExigence(int idExigence, string nom, DateTime dateExigence, string txtMontant, object cmbStatut, object cmbEvenement, string rtbCommentaire, string rtbDescriptionCourte, string rtbDescriptionLongue)
        {
            var tE = provider.SelectExigence(idExigence);
            tE.nom = nom;
            tE.date = dateExigence;
            decimal? montant = null;
            if (SanitariserTexte(txtMontant) != null)
            {
                decimal conversion = 0;
                if (decimal.TryParse(txtMontant, out conversion))
                {
                    montant = conversion;
                }
            }
            tE.montant = montant;
            tE.noStatut = (cmbStatut as Modele.tblStatut).noStatut;
            tE.commentaire = rtbCommentaire;
            tE.descriptionCourte = rtbDescriptionCourte;
            tE.description = rtbDescriptionLongue;
            provider.Save();
            //UPDATE
        }

        internal void SupprimerExigence(int idExigence)
        {
            provider.SupprimerExigence(idExigence);
        }
    }
}
