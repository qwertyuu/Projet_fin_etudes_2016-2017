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
