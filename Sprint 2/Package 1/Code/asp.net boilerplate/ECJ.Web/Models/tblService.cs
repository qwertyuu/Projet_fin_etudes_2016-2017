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
    
    public partial class tblService
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblService()
        {
            this.tblSalle = new HashSet<tblSalle>();
            this.tblSousEvenement = new HashSet<tblSousEvenement>();
        }
    
        public int noService { get; set; }
        public string nomService { get; set; }
        public Nullable<System.DateTime> dateSupprime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSalle> tblSalle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSousEvenement> tblSousEvenement { get; set; }
    }
}
