public interface IClienteRepository
{
    void Adicionar(Cliente cliente);
    IReadOnlyList<Cliente> ObterTodos();
    void Atualizar(Cliente cliente, Cliente novoCliente);
    void Remover(string cpfCliente);
}