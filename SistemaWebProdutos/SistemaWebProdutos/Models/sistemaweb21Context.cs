using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SistemaWebProdutos.Models
{
    public partial class sistemaweb21Context : DbContext
    {
        public sistemaweb21Context()
        {
        }

        public sistemaweb21Context(DbContextOptions<sistemaweb21Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Produtos> Produtos { get; set; }

      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produtos>(entity =>
            {
                entity.HasKey(e => e.ProdCod);

                entity.Property(e => e.ProdCod).HasColumnName("Prod_Cod");

                entity.Property(e => e.ProdNome)
                    .IsRequired()
                    .HasColumnName("Prod_Nome")
                    .HasMaxLength(20);

                entity.Property(e => e.ProdPreco)
                    .HasColumnName("Prod_Preco")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.ProdQntd).HasColumnName("Prod_Qntd");
            });
        }
    }
}
