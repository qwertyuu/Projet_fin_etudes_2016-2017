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