﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityAdapter
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FortunaEntities : DbContext
    {
        public FortunaEntities()
            : base("name=FortunaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    
        public DbSet<Bank> Bank { get; set; }
        public DbSet<Bemaerkning> Bemaerkning { get; set; }
        public DbSet<Faelles_Forhandler> Faelles_Forhandler { get; set; }
        public DbSet<Faelles_Spiller> Faelles_Spiller { get; set; }
        public DbSet<Forhandler> Forhandler { get; set; }
        public DbSet<LodSeddel> LodSeddel { get; set; }
        public DbSet<LodSeddel_Hist> LodSeddel_Hist { get; set; }
        public DbSet<PeriodeSkift> PeriodeSkift { get; set; }
        public DbSet<Posteringer> Posteringer { get; set; }
        public DbSet<PostNumre> PostNumre { get; set; }
        public DbSet<Satser> Satser { get; set; }
        public DbSet<Spiller> Spiller { get; set; }
        public DbSet<Tekster> Tekster { get; set; }
        public DbSet<TeksterBreve> TeksterBreve { get; set; }
        public DbSet<Temp> Temp { get; set; }
        public DbSet<timingtry> timingtry { get; set; }
        public DbSet<Traekning> Traekning { get; set; }
    }
}
