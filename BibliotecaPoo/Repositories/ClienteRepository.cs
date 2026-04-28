public class ClienteRepository : IClienteRepository
{

    private List<Cliente> _clientes = new List<Cliente>();
    public void Adicionar(Cliente cliente)
    {
        _clientes.Add(cliente);
    }
    public IReadOnlyList<Cliente> ObterTodos() => _clientes.AsReadOnly();
    public void Atualizar(Cliente cliente, Cliente novoCliente)
    {
        int posicao = _clientes.IndexOf(cliente);
        if (posicao >= 0)
        {
            _clientes[posicao] = novoCliente;
        }
        else
        {
            Console.WriteLine("Erro");
        }
    }

    // Delete
    public void Remover(Cliente cliente)
    {
        _clientes.Remove(cliente);
    }
}