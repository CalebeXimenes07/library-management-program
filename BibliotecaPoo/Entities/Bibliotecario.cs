using System.Data;
using System.Threading.Channels;

public class Bibliotecario
{
    public string NomeCompletoBibliotecario { get; private set; }
    public string Cpf { get; private set; }
    public string IdBibliotecario { get; private set; }
    public string Telefone { get; private set; }
    public DateOnly DataNascimento { get; private set; }
    public UnidadeBiblioteca UnidadeBiblioteca { get; private set; }

    public Bibliotecario()
    {

    }

    public Bibliotecario(string nomeCompletoBibliotecario, string cpf, string idBibliotecario, string telefone, DateOnly dataNascimento, UnidadeBiblioteca unidadeBiblioteca)
    {
        NomeCompletoBibliotecario = nomeCompletoBibliotecario;
        Cpf = cpf;
        IdBibliotecario = idBibliotecario;
        Telefone = telefone;
        DataNascimento = dataNascimento;
        UnidadeBiblioteca = unidadeBiblioteca;
    }

    public void Emprestimo(Exemplar exemplar, Cliente cliente) => Console.WriteLine($"Detalhes do empréstimo:\nCódigo do exemplar: {exemplar.IdExemplar}\nCliente: {cliente.Nome}");

    public void SolicitarCompraLivros(ObraLiteraria obraLiteraria, int quantidadeExemplares, FornecedorEditora fornecedorEditora) => Console.WriteLine($"Detalhes do pedido de compra:\nQuantidade: {quantidadeExemplares}\nTitulo: {obraLiteraria.Titulo}\nId: {obraLiteraria.IdLivro}\nFornecedora: {fornecedorEditora.NomeFantasia}");
    public void Supervisao(Bibliotecario bibliotecarioSupervisionado) => Console.WriteLine($"O bibliotecário {NomeCompletoBibliotecario} está supervisionando o bibliotecário {bibliotecarioSupervisionado.NomeCompletoBibliotecario}.");
}
