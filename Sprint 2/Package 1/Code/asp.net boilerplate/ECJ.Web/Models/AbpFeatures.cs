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
    
    public partial class AbpFeatures
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<long> CreatorUserId { get; set; }
        public Nullable<int> EditionId { get; set; }
        public Nullable<int> TenantId { get; set; }
        public string Discriminator { get; set; }
    
        public virtual AbpEditions AbpEditions { get; set; }
    }
}
