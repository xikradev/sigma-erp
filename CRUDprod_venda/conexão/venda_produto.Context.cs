﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ErpSigmaVenda.conexão
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class venda_produtoEntities : DbContext
    {
        public venda_produtoEntities()
            : base("name=venda_produtoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<produto> produto { get; set; }
        public virtual DbSet<produto_fornecedor> produto_fornecedor { get; set; }
        public virtual DbSet<venda> venda { get; set; }
        public virtual DbSet<endereco> endereco { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
        public virtual DbSet<cliente> cliente { get; set; }
        public virtual DbSet<fornecedor> fornecedor { get; set; }
    }
}
