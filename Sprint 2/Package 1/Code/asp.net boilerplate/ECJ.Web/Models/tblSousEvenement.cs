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
    
    public partial class tblSousEvenement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSousEvenement()
        {
            this.tblActivite = new HashSet<tblActivite>();
            this.tblDon = new HashSet<tblDon>();
            this.tblForfait = new HashSet<tblForfait>();
            this.tblService = new HashSet<tblService>();
        }
    
        public int noSousEvenement { get; set; }
        public string nom { get; set; }
        public string description { get; set; }
        public int noEvenement { get; set; }
        public Nullable<System.DateTime> dateSupprime { get; set; }
        public Nullable<int> noEngagement { get; set; }
    
        public virtual tblEngagement tblEngagement { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblActivite> tblActivite { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDon> tblDon { get; set; }
        public virtual tblEvenement tblEvenement { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblForfait> tblForfait { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblService> tblService { get; set; }
    }
}
