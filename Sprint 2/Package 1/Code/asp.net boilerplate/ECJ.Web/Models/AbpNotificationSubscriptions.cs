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
    
    public partial class AbpNotificationSubscriptions
    {
        public System.Guid Id { get; set; }
        public Nullable<int> TenantId { get; set; }
        public long UserId { get; set; }
        public string NotificationName { get; set; }
        public string EntityTypeName { get; set; }
        public string EntityTypeAssemblyQualifiedName { get; set; }
        public string EntityId { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<long> CreatorUserId { get; set; }
    }
}
