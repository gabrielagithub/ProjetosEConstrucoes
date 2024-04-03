public class ClienteService : IClienteService
{
    private readonly IClienteRepository _repository;

    public ClienteService(IClienteRepository repository)
    {
        _repository = repository;
    }

    public void Salvar(Cliente cliente)
    {
        // Validar regras de negócio

        _repository.Add(cliente);
    }

    public Cliente ObterPorId(int id)
    {
        return _repository.GetById(id);
    }

    public List<Cliente> ObterTodos()
    {
        return _repository.GetAll();
    }

    public void Atualizar(Cliente cliente)
    {
        // Validar regras de negócio

        _repository.Update(cliente);
    }

    public void Excluir(int id)
    {
        _repository.Delete(id);
    }
}
