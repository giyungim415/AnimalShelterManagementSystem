﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnimalShelterManagementSystem
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AnimalShelterManagementEntities : DbContext
    {
        public AnimalShelterManagementEntities()
            : base("name=AnimalShelterManagementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Adoption> Adoptions { get; set; }
        public virtual DbSet<AnimalShelter> AnimalShelters { get; set; }
        public virtual DbSet<FindingReport> FindingReports { get; set; }
        public virtual DbSet<FindingReportRecord> FindingReportRecords { get; set; }
        public virtual DbSet<FoundAnimalRecord> FoundAnimalRecords { get; set; }
        public virtual DbSet<HomelessAnimal> HomelessAnimals { get; set; }
        public virtual DbSet<LossReport> LossReports { get; set; }
        public virtual DbSet<PhysicalCondition> PhysicalConditions { get; set; }
        public virtual DbSet<Sex> Sexes { get; set; }
        public virtual DbSet<Species> Species { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}