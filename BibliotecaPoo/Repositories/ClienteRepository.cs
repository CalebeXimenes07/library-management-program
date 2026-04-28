public class ClienteRepository : IClienteRepository
{

    private List<Cliente> _clientes = new List<Cliente>();
    public void Adicionar(Cliente cliente)
    {
        _clientes.Add(cliente);
    }
    public IReadOnlyList<Cliente> ObterTodos() => _clientes.AsReadOnly();
}