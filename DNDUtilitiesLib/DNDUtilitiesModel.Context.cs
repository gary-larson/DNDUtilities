﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DNDUtilitiesLib
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DNDDatabaseEntities : DbContext
    {
        public DNDDatabaseEntities()
            : base("name=DNDDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ability> abilities { get; set; }
        public virtual DbSet<alignment> alignments { get; set; }
        public virtual DbSet<class_tables> class_tables { get; set; }
        public virtual DbSet<@class> classes { get; set; }
        public virtual DbSet<domain> domains { get; set; }
        public virtual DbSet<equipment_category> equipment_category { get; set; }
        public virtual DbSet<equipment_subcategory> equipment_subcategory { get; set; }
        public virtual DbSet<equipment> equipments { get; set; }
        public virtual DbSet<feat> feats { get; set; }
        public virtual DbSet<item> items { get; set; }
        public virtual DbSet<monster_descriptors> monster_descriptors { get; set; }
        public virtual DbSet<monster_families> monster_families { get; set; }
        public virtual DbSet<monster_sizes> monster_sizes { get; set; }
        public virtual DbSet<monster_types> monster_types { get; set; }
        public virtual DbSet<monster> monsters { get; set; }
        public virtual DbSet<power_disciplines> power_disciplines { get; set; }
        public virtual DbSet<power_subdisciplines> power_subdisciplines { get; set; }
        public virtual DbSet<power> powers { get; set; }
        public virtual DbSet<skill_subtypes> skill_subtypes { get; set; }
        public virtual DbSet<skill> skills { get; set; }
        public virtual DbSet<spell_schools> spell_schools { get; set; }
        public virtual DbSet<spell_subschools> spell_subschools { get; set; }
        public virtual DbSet<spell_types> spell_types { get; set; }
        public virtual DbSet<spell> spells { get; set; }
    }
}
