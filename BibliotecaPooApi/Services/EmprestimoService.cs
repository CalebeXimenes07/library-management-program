
public class EmprestimoService : IEmprestimoService
{
    private readonly IEmprestimoRepository _emprestimoRepo;
    private readonly IBibliotecarioRepository _biblioRepo;
    private readonly IClienteRepository _clienteRepo;
    private readonly IExemplarRepository _exemplarRepo;

    public EmprestimoService(
        IEmprestimoRepository emprestimoRepo,
        IBibliotecarioRepository biblioRepo,
        IClienteRepository clienteRepo,
        IExemplarRepository exemplarRepo)
    {
        _emprestimoRepo = emprestimoRepo;
        _biblioRepo = biblioRepo;
        _clienteRepo = clienteRepo;
        _exemplarRepo = exemplarRepo;
    }

    public string ExecutarEmprestimo(string cpfBibliotecario, string idExemplar, string cpfCliente)
    {
        var bibliotecario = _biblioRepo.ObterTodos().FirstOrDefault(x => x.Cpf == cpfBibliotecario);
        var cliente = _clienteRepo.ObterTodos().FirstOrDefault(x => x.Cpf == cpfCliente);
        var exemplar = _exemplarRepo.ObterTodos().FirstOrDefault(x => x.IdExemplar == idExemplar);

        if (bibliotecario == null || cliente == null || exemplar == null)
            throw new Exception("Dados inválidos para realizar o empréstimo.");


        Emprestimo novoEmprestimo = bibliotecario.RealizarEmprestimo(exemplar, cliente);

        _emprestimoRepo.Adicionar(novoEmprestimo);

        return novoEmprestimo.Id;
    }
}