public interface IClienteRepository : IRepository<Cliente> // Herda da interface genérica IRepository
{
    // Métodos específicos para a entidade Cliente
    void Add(Cliente cliente);
    Cliente GetById(int id);
    List<Cliente> GetAll();
    void Update(Cliente cliente);
    void Delete(int id);
}
