﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinanceCentral.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FCModels : DbContext
    {
        public FCModels()
            : base("name=FCModels")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Expenses> Expenses { get; set; }
        public virtual DbSet<FinancialAidAmt> FinancialAidAmt { get; set; }
        public virtual DbSet<FinancialAidType> FinancialAidTypes { get; set; }
        public virtual DbSet<Goals> Goals { get; set; }
        public virtual DbSet<Income> Incomes { get; set; }
    }
}
