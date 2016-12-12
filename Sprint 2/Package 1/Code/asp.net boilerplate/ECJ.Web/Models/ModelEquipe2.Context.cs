﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PE2_OfficielEntities : DbContext
    {
        public PE2_OfficielEntities()
            : base("name=PE2_OfficielEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblAdresse> tblAdresse { get; set; }
        public virtual DbSet<tblAgence> tblAgence { get; set; }
        public virtual DbSet<tblArtiste> tblArtiste { get; set; }
        public virtual DbSet<tblCategorieArtiste> tblCategorieArtiste { get; set; }
        public virtual DbSet<tblContrat> tblContrat { get; set; }
        public virtual DbSet<tblDiffuseur> tblDiffuseur { get; set; }
        public virtual DbSet<tblEngagement> tblEngagement { get; set; }
        public virtual DbSet<tblExigence> tblExigence { get; set; }
        public virtual DbSet<tblFichierOfficiel> tblFichierOfficiel { get; set; }
        public virtual DbSet<tblFichierPersonnel> tblFichierPersonnel { get; set; }
        public virtual DbSet<tblResponsable> tblResponsable { get; set; }
        public virtual DbSet<tblStatut> tblStatut { get; set; }
        public virtual DbSet<tblActivite> tblActivite { get; set; }
        public virtual DbSet<tblCommanditaire> tblCommanditaire { get; set; }
        public virtual DbSet<tblDon> tblDon { get; set; }
        public virtual DbSet<tblEvenement> tblEvenement { get; set; }
        public virtual DbSet<tblSousEvenement> tblSousEvenement { get; set; }
        public virtual DbSet<tblForfait> tblForfait { get; set; }
        public virtual DbSet<tblSalle> tblSalle { get; set; }
        public virtual DbSet<tblService> tblService { get; set; }
        public virtual DbSet<tblMemo> tblMemo { get; set; }
        public virtual DbSet<tblAgencePublicite> tblAgencePublicite { get; set; }
        public virtual DbSet<tblMedia> tblMedia { get; set; }
        public virtual DbSet<tblStatutAppelOffre> tblStatutAppelOffre { get; set; }
        public virtual DbSet<vueSomAgence> vueSomAgence { get; set; }
        public virtual DbSet<vueSomArtiste> vueSomArtiste { get; set; }
        public virtual DbSet<vueSomCatArtiste> vueSomCatArtiste { get; set; }
        public virtual DbSet<vueSomContrat> vueSomContrat { get; set; }
        public virtual DbSet<vueSomEngagement> vueSomEngagement { get; set; }
        public virtual DbSet<vueSomExigence> vueSomExigence { get; set; }
        public virtual DbSet<vueSomStatut> vueSomStatut { get; set; }
        public virtual DbSet<vueSomCommanditaire> vueSomCommanditaire { get; set; }
        public virtual DbSet<vueSomEvenement> vueSomEvenement { get; set; }
        public virtual DbSet<vueSomAppelOffre> vueSomAppelOffre { get; set; }
        public virtual DbSet<vueSomSoumission> vueSomSoumission { get; set; }
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AbpAuditLogs> AbpAuditLogs { get; set; }
        public virtual DbSet<AbpBackgroundJobs> AbpBackgroundJobs { get; set; }
        public virtual DbSet<AbpEditions> AbpEditions { get; set; }
        public virtual DbSet<AbpFeatures> AbpFeatures { get; set; }
        public virtual DbSet<AbpLanguages> AbpLanguages { get; set; }
        public virtual DbSet<AbpLanguageTexts> AbpLanguageTexts { get; set; }
        public virtual DbSet<AbpNotifications> AbpNotifications { get; set; }
        public virtual DbSet<AbpNotificationSubscriptions> AbpNotificationSubscriptions { get; set; }
        public virtual DbSet<AbpOrganizationUnits> AbpOrganizationUnits { get; set; }
        public virtual DbSet<AbpPermissions> AbpPermissions { get; set; }
        public virtual DbSet<AbpRoles> AbpRoles { get; set; }
        public virtual DbSet<AbpSettings> AbpSettings { get; set; }
        public virtual DbSet<AbpTenantNotifications> AbpTenantNotifications { get; set; }
        public virtual DbSet<AbpTenants> AbpTenants { get; set; }
        public virtual DbSet<AbpUserAccounts> AbpUserAccounts { get; set; }
        public virtual DbSet<AbpUserLoginAttempts> AbpUserLoginAttempts { get; set; }
        public virtual DbSet<AbpUserLogins> AbpUserLogins { get; set; }
        public virtual DbSet<AbpUserNotifications> AbpUserNotifications { get; set; }
        public virtual DbSet<AbpUserOrganizationUnits> AbpUserOrganizationUnits { get; set; }
        public virtual DbSet<AbpUserRoles> AbpUserRoles { get; set; }
        public virtual DbSet<tblCalculateur> tblCalculateur { get; set; }
        public virtual DbSet<vueSomSalle> vueSomSalle { get; set; }
        public virtual DbSet<tblAppelOffre> tblAppelOffre { get; set; }
        public virtual DbSet<tblSoumission> tblSoumission { get; set; }
        public virtual DbSet<AbpUsers> AbpUsers { get; set; }
        public virtual DbSet<tblQuestionSecrete> tblQuestionSecrete { get; set; }
    }
}
