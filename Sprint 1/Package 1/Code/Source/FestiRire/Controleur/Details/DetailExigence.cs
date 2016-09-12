using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FestiRire.Modele;

namespace FestiRire.Controleur.Details
{
    class DetailExigence : DetailBaseSimple
    {
        public DetailExigence() : base()
        {

        }
        internal void EnregistrerExigence(string nom, DateTime dateExigence, decimal Montant, object cmbStatut, object cmbEvenement, string rtbCommentaire, string rtbDescriptionCourte, string rtbDescriptionLongue)
        {
            var exigence = new Modele.tblExigence()
            {
                nom = nom,
                date=dateExigence,
                montant=Montant,
                description=rtbDescriptionLongue,
                commentaire=rtbCommentaire,
                descriptionCourte=rtbDescriptionCourte,
                               
            };
            provider.InsertExigence(exigence);
        }

            //INSERT
        }

        //internal tblExigence LoadExigence(int idExigence)
        //{
        //    return new tblExigence();
        //    //SELECT UNIQUE
        //}
        //internal void EnregistrerExigence(int idExigence, string nom, DateTime dateExigence, string txtMontant, object cmbStatut, object cmbEvenement, string rtbCommentaire, string rtbDescriptionCourte, string rtbDescriptionLongue)
        //{
        //    //UPDATE
        //}
    
}
