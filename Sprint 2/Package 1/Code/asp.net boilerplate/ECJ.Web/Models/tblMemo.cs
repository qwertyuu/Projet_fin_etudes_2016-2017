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
    
    public partial class tblMemo
    {
        public int noMemo { get; set; }
        public string info { get; set; }
        public bool statut { get; set; }
        public System.DateTime dateEnvoi { get; set; }
        public Nullable<System.DateTime> dateSupprime { get; set; }
        public string expediteur { get; set; }
        public string destinataire { get; set; }
    
        public virtual tblUtilisateur tblUtilisateur { get; set; }
        public virtual tblUtilisateur tblUtilisateur1 { get; set; }
    }
}
