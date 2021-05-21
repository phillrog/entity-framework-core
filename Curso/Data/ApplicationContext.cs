using CursoEFCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace CursoEFCore.Data
{
    public class ApplicationContext: DbContext 
    {
        public DbSet<Pedido> Pedidos {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder); 
            optionsBuilder.UseSqlServer("Data source=(localdb)\\mssqllocaldb;Initial Catalog=CursoEFCore;Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>( c =>{
            c.ToTable("Clientes");
            c.HasKey(p => p.Id);
            c.Property(p => p.Nome).HasColumnType("VARCHAR(80)").IsRequired();
            c.Property(p => p.Telefone).HasColumnType("CHAR(11)");
            c.Property(p => p.CEP).HasColumnType("CHAR(8)").IsRequired();
            c.Property(p => p.Estado).HasColumnType("CHAR(2)").IsRequired();
            c.Property(p => p.Cidade).HasMaxLength(60).IsRequired();
            c.HasIndex(i => i.Telefone).HasName("idx_cliente_telefone");
        });

        }
    }
}