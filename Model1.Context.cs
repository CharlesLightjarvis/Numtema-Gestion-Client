﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Numtema_Gestion_Client
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NumtemaGestionClientEntities : DbContext
    {
        public NumtemaGestionClientEntities()
            : base("name=NumtemaGestionClientEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Historique> Historique { get; set; }
        public virtual DbSet<Rappel> Rappel { get; set; }
        public virtual DbSet<Réclamation> Réclamation { get; set; }
        public virtual DbSet<Relance> Relance { get; set; }
        public virtual DbSet<TypeClient> TypeClient { get; set; }
    }
}
