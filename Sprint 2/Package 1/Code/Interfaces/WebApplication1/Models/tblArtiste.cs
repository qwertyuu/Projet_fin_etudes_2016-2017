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
    
    public partial class tblArtiste
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblArtiste()
        {
            this.tblFichierPersonnel = new HashSet<tblFichierPersonnel>();
            this.tblFichierOfficiel = new HashSet<tblFichierOfficiel>();
            this.tblCategorieArtiste = new HashSet<tblCategorieArtiste>();
            this.tblContrat = new HashSet<tblContrat>();
        }
    
        public int noArtiste { get; set; }
        public string nom { get; set; }
        public string commentaire { get; set; }
        public Nullable<System.DateTime> dateSupprime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblFichierPersonnel> tblFichierPersonnel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblFichierOfficiel> tblFichierOfficiel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCategorieArtiste> tblCategorieArtiste { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblContrat> tblContrat { get; set; }
    }
}
