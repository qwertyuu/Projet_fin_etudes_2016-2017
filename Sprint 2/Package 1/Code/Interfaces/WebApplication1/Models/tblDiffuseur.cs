//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblDiffuseur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblDiffuseur()
        {
            this.tblResponsable = new HashSet<tblResponsable>();
        }
    
        public int noDiffuseur { get; set; }
        public string nom { get; set; }
        public string courriel { get; set; }
        public Nullable<System.DateTime> dateSupprime { get; set; }
        public int noAdresse { get; set; }
    
        public virtual tblAdresse tblAdresse { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblResponsable> tblResponsable { get; set; }
    }
}
