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
    
    public partial class tblEvenement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblEvenement()
        {
            this.tblActivite = new HashSet<tblActivite>();
            this.tblSousEvenement = new HashSet<tblSousEvenement>();
            this.tblAppelOffre = new HashSet<tblAppelOffre>();
        }
    
        public int noEvenement { get; set; }
        public string nom { get; set; }
        public System.DateTime dateDebut { get; set; }
        public System.DateTime datefin { get; set; }
        public byte[] affiche { get; set; }
        public string url { get; set; }
        public string description { get; set; }
        public Nullable<System.DateTime> dateSupprime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblActivite> tblActivite { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSousEvenement> tblSousEvenement { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAppelOffre> tblAppelOffre { get; set; }
    }
}
