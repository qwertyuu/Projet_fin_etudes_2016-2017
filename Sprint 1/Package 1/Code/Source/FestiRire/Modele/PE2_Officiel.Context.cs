﻿//------------------------------------------------------------------------------
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
        public virtual DbSet<vueSomAgence> vueSomAgence { get; set; }
        public virtual DbSet<vueSomArtiste> vueSomArtiste { get; set; }
        public virtual DbSet<vueSomCatArtiste> vueSomCatArtiste { get; set; }
        public virtual DbSet<vueSomContrat> vueSomContrat { get; set; }
        public virtual DbSet<vueSomEngagement> vueSomEngagement { get; set; }
        public virtual DbSet<vueSomExigence> vueSomExigence { get; set; }
        public virtual DbSet<vueSomStatut> vueSomStatut { get; set; }
    }
}