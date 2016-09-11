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
        internal void EnregistrerExigence(string nom, DateTime dateExigence, string txtMontant, object cmbStatut, object cmbEvenement, string rtbCommentaire, string rtbDescriptionCourte, string rtbDescriptionLongue)
        {
            //INSERT
        }

        internal tblExigence LoadExigence(int idExigence)
        {
            //SELECT UNIQUE
        }
        internal void EnregistrerExigence(int idExigence, string nom, DateTime dateExigence, string txtMontant, object cmbStatut, object cmbEvenement, string rtbCommentaire, string rtbDescriptionCourte, string rtbDescriptionLongue)
        {
            //UPDATE
        }
    }
}
