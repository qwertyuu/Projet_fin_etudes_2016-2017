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
    
    public partial class AbpBackgroundJobs
    {
        public long Id { get; set; }
        public string JobType { get; set; }
        public string JobArgs { get; set; }
        public short TryCount { get; set; }
        public System.DateTime NextTryTime { get; set; }
        public Nullable<System.DateTime> LastTryTime { get; set; }
        public bool IsAbandoned { get; set; }
        public byte Priority { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<long> CreatorUserId { get; set; }
    }
}