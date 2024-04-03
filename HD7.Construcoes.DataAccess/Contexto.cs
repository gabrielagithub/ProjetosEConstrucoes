using Microsoft.EntityFrameworkCore;

public class Contexto : DbContext, IContexto
{
    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {
    }

    public DbSet<Cliente> Clientes { get; set; }

    public int SaveChanges()
    {
        return base.SaveChanges();
    }
}
