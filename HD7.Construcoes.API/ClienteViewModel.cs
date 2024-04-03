public class ClienteViewModel
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }

    public static ClienteViewModel FromCliente(Cliente cliente)
    {
        return new ClienteViewModel
        {
            Id = cliente.Id,
            Nome = cliente.Nome,
            Email = cliente.Email,
            Telefone = cliente.Telefone
        };
    }

    public Cliente ToCliente()
    {
        return new Cliente
        {
            Id = Id,
            Nome = Nome,
            Email = Email,
            Telefone = Telefone
        };
    }
}
