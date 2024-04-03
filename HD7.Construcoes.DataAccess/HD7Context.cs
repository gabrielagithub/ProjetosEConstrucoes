using Microsoft.EntityFrameworkCore;

namespace HD7.Construcoes.DataAccess
{
    public class HD7Context : DbContext
    {
        public HD7Context(DbContextOptions<HD7Context> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }

        // ... adicionar outros DbSet para cada entidade do sistema

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Mapear as entidades para as tabelas do banco de dados
            modelBuilder.Entity<Cliente>().ToTable("Clientes");

            // ... mapear outras entidades

            // Configurar chaves primárias
            modelBuilder.Entity<Cliente>().HasKey(e => e.Id);

            // ... configurar outras chaves primárias

            // Configurar relacionamentos
            // ...
        }
    }
}
