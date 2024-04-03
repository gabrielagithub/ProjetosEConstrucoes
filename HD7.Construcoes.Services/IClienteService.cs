public interface IClienteService
{
    void Salvar(Cliente cliente);
    Cliente ObterPorId(int id);
    List<Cliente> ObterTodos();
    void Atualizar(Cliente cliente);
    void Excluir(int id);
}
