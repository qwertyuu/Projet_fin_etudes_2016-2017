//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FestiRire.Modele
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblEngagement
    {
        public int noEngagement { get; set; }
        public string duree { get; set; }
        public string lieu { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<System.TimeSpan> heure { get; set; }
        public string nature { get; set; }
        public string commentaire { get; set; }
        public string description { get; set; }
        public string descriptionCourte { get; set; }
        public Nullable<System.DateTime> dateSupprime { get; set; }
        public string noContrat { get; set; }
    
        public virtual tblContrat tblContrat { get; set; }
    }
}
