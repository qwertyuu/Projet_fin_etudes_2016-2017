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
    
    public partial class tblSoumission
    {
        public int noSoumission { get; set; }
        public string nom { get; set; }
        public decimal prix { get; set; }
        public bool statut { get; set; }
        public string description { get; set; }
        public Nullable<System.DateTime> dateSupprime { get; set; }
        public int offreNoPublicite { get; set; }
        public string tag { get; set; }
    
        public virtual tblAppelOffreAgence tblAppelOffreAgence { get; set; }
    }
}
