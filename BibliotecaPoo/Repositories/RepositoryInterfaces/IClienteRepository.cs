public interface IClienteRepository
{
    void Adicionar(Cliente cliente);
    IReadOnlyList<Cliente> ObterTodos();
}