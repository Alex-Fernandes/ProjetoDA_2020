﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetoDA_2020
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ModelProjetoContainer : DbContext
    {
        public ModelProjetoContainer()
            : base("name=ModelProjetoContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Arrendamento> Arrendamentos { get; set; }
        public virtual DbSet<Casa> Casas { get; set; }
        public virtual DbSet<Limpeza> Limpezas { get; set; }
        public virtual DbSet<Servico> Servicos { get; set; }
        public virtual DbSet<Venda> Vendas { get; set; }
    }
}
