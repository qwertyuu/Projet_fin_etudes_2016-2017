//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
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
        public string tag { get; set; }
    
        public virtual tblEvenement tblEvenement { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSoumission> tblSoumission { get; set; }
        public virtual tblMedia tblMedia { get; set; }
        public virtual tblStatutAppelOffre tblStatutAppelOffre { get; set; }
    }
}
