//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ECJ.Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblActivite
    {
        public int noActivite { get; set; }
        public string nomResponsable { get; set; }
        public byte etat { get; set; }
        public System.DateTime dateCreation { get; set; }
        public string tache { get; set; }
        public string detail { get; set; }
        public Nullable<System.DateTime> dateSupprime { get; set; }
        public Nullable<int> noEvenement { get; set; }
        public Nullable<int> noSousEvenement { get; set; }
    
        public virtual tblEvenement tblEvenement { get; set; }
        public virtual tblSousEvenement tblSousEvenement { get; set; }
    }
}