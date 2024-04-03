using HD7.Construcoes.DataAccess;
using Microsoft.EntityFrameworkCore;

public class ClienteRepository : IClienteRepository
{
    private readonly HD7Context _context;

    public ClienteRepository(HD7Context context)
    {
        _context = context;
    }

    public void Add(Cliente cliente)
    {
        _context.Clientes.Add(cliente);
        _context.SaveChanges();
    }

    public Cliente GetById(int id)
    {
        return _context.Clientes.Find(id);
    }

    public List<Cliente> GetAll()
    {
        return _context.Clientes.ToList();
    }

    public void Update(Cliente cliente)
    {
        _context.Entry(cliente).State = EntityState.Modified;
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var cliente = _context.Clientes.Find(id);
        _context.Clientes.Remove(cliente);
        _context.SaveChanges();
    }
}
