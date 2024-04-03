using Microsoft.EntityFrameworkCore;

public interface IContexto : IDisposable
{
    DbSet<Cliente> Clientes { get; set; }

    int SaveChanges();
}
