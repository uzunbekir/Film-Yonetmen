﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FilmlerCokKatmanli.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FilmlerDBEntities : DbContext
    {
        public FilmlerDBEntities()
            : base("name=FilmlerDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Filmler> Filmlers { get; set; }
        public virtual DbSet<FilmOyuncular> FilmOyunculars { get; set; }
        public virtual DbSet<Oyuncular> Oyunculars { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Yonetmenler> Yonetmenlers { get; set; }
    }
}
