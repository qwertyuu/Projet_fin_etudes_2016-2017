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
    
    public partial class tblAppelOffre
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblAppelOffre()
        {
            this.tblSoumission = new HashSet<tblSoumission>();
        }
    
        public int noAppelOffre { get; set; }
        public string nom { get; set; }
        public System.DateTime dateRequis { get; set; }
        public System.DateTime dateEnvoi { get; set; }
        public string description { get; set; }
        public Nullable<System.DateTime> dateSupprime { get; set; }
        public int noEvenement { get; set; }
        public int noStatut { get; set; }
        public int noMedia { get; set; }
    
        public virtual tblEvenement tblEvenement { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSoumission> tblSoumission { get; set; }
        public virtual tblMedia tblMedia { get; set; }
        public virtual tblStatutAppelOffre tblStatutAppelOffre { get; set; }
    }
}
