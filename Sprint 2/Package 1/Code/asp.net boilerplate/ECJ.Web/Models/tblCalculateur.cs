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
    
    public partial class tblCalculateur
    {
        public int noSousEvenement { get; set; }
        public Nullable<int> billet { get; set; }
        public Nullable<int> billetVIP { get; set; }
        public Nullable<int> prixBillet { get; set; }
        public Nullable<int> prixBilletVIP { get; set; }
        public Nullable<int> souperSpectacle { get; set; }
        public Nullable<int> prixSouper { get; set; }
        public Nullable<int> jeunePourcent { get; set; }
        public Nullable<int> adultePourcent { get; set; }
        public Nullable<int> ainePourcent { get; set; }
        public Nullable<int> jeuneRatio { get; set; }
        public Nullable<int> adulteRatio { get; set; }
        public Nullable<int> aineRatio { get; set; }
        public Nullable<int> promo { get; set; }
        public Nullable<int> prevente { get; set; }
        public Nullable<int> customBillet1 { get; set; }
        public Nullable<int> customBillet2 { get; set; }
        public Nullable<int> customPrix1 { get; set; }
        public Nullable<int> customPrix2 { get; set; }
        public string customNom1 { get; set; }
        public string customNom2 { get; set; }
    
        public virtual tblSousEvenement tblSousEvenement { get; set; }
    }
}
