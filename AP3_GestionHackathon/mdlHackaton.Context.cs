﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AP3_GestionHackathon
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class fantocheEntities : DbContext
    {
        public fantocheEntities()
            : base("name=fantocheEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<administrateur> administrateur { get; set; }
        public virtual DbSet<ArchiveHackathon> ArchiveHackathon { get; set; }
        public virtual DbSet<ArchiveMembre> ArchiveMembre { get; set; }
        public virtual DbSet<atelier> atelier { get; set; }
        public virtual DbSet<conferencier> conferencier { get; set; }
        public virtual DbSet<equipe> equipe { get; set; }
        public virtual DbSet<hackathon> hackathon { get; set; }
        public virtual DbSet<inscrire> inscrire { get; set; }
        public virtual DbSet<membre> membre { get; set; }
        public virtual DbSet<organisateur> organisateur { get; set; }
        public virtual DbSet<organise> organise { get; set; }
        public virtual DbSet<participer> participer { get; set; }
        public virtual DbSet<salle> salle { get; set; }
        public virtual DbSet<token> token { get; set; }
    }
}