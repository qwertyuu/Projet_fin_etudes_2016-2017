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
    
    public partial class tblFichierPersonnel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblFichierPersonnel()
        {
            this.tblFichierOfficiel = new HashSet<tblFichierOfficiel>();
        }
    
        public int noFichier { get; set; }
        public string type { get; set; }
        public string chemin { get; set; }
        public string commentaire { get; set; }
        public Nullable<System.DateTime> dateSupprime { get; set; }
        public int noArtiste { get; set; }
    
        public virtual tblArtiste tblArtiste { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblFichierOfficiel> tblFichierOfficiel { get; set; }
    }
}
