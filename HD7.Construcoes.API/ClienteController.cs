using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class ClienteController : ControllerBase
{
    private readonly IClienteService _clienteService;

    public ClienteController(IClienteService clienteService)
    {
        _clienteService = clienteService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<ClienteViewModel>> Get()
    {
        var clientes = _clienteService.ObterTodos();

        var clienteViewModels = clientes.Select(c => ClienteViewModel.FromCliente(c));

        return Ok(clienteViewModels);
    }

    [HttpGet("{id}")]
    public ActionResult<ClienteViewModel> Get(int id)
    {
        var cliente = _clienteService.ObterPorId(id);

        if (cliente == null)
        {
            return NotFound();
        }

        var clienteViewModel = ClienteViewModel.FromCliente(cliente);

        return Ok(clienteViewModel);
    }

    [HttpPost]
    public ActionResult<ClienteViewModel> Post([FromBody] ClienteViewModel clienteViewModel)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var cliente = clienteViewModel.ToCliente();

        _clienteService.Salvar(cliente);

        return CreatedAtAction(nameof(Get), new { id = cliente.Id }, clienteViewModel);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] ClienteViewModel clienteViewModel)
    {
        if (id != clienteViewModel.Id)
        {
            return BadRequest();
        }

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var cliente = clienteViewModel.ToCliente();

        _clienteService.Atualizar(cliente);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _clienteService.Excluir(id);

        return NoContent();
    }
}
