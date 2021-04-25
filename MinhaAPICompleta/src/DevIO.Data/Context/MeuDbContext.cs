using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevIO.Data.Context
{
    public class MeuDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Fornecedor> Fornecedores { get; set; }

        public MeuDbContext(DbContextOptions options) : base(options)
        {
            // Importante para permitir realizar a edição dos models
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // caso exista alguma propriedade criada e nao seja definida o seu tamanho será criada com 
            // varchar(100) no BD
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                    .Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");


            // Ele vai obter todas as Entidades que herdam de IEntityTypeConfiguration e registrar todas 
            // decimal uma unica vez
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MeuDbContext).Assembly);

            // Desativar o Delete Cascade para cada propriedade que encontrar um relacionamento de FK
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) 
                relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }
    }
}
