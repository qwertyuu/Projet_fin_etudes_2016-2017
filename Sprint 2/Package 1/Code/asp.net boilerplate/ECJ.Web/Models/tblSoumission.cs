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
        public string noSoumissionAgence { get; set; }
        public Nullable<decimal> prix { get; set; }
        public Nullable<byte> statut { get; set; }
        public string commentaire { get; set; }
        public int noAgencePub { get; set; }
        public int noAppelOffre { get; set; }
        public Nullable<System.DateTime> dateEnvoi { get; set; }
        public Nullable<System.DateTime> dateReponse { get; set; }
        public Nullable<System.DateTime> dateSupprime { get; set; }
    
        public virtual tblAgencePublicite tblAgencePublicite { get; set; }
        public virtual tblAppelOffre tblAppelOffre { get; set; }
    }
}
