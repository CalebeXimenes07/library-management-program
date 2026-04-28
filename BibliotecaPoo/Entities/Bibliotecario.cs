public enum Especializacao
{
    Nenhuma,
    Especialista,
    Mestre,
    Doutor
}
public enum GrauDependencia
{
    Primeira,
    Segunda,
    Terceira
}

public class Dependente
{
    public string Cpf { get; private set; }
    public GrauDependencia GrauDependencia { get; private set; }

    public Dependente(string cpf, GrauDependencia grauDependencia)
    {
        Cpf = cpf;
        GrauDependencia = grauDependencia;
    }
}
public class Bibliotecario
{
    public string NomeCompletoBibliotecario { get; private set; }
    public string Cpf { get; private set; }
    public string IdBibliotecario { get; private set; }
    public DateOnly DataNascimento { get; private set; }
    public UnidadeBiblioteca UnidadeBiblioteca { get; private set; }
    public Especializacao Especializacao { get; private set; }
    public IReadOnlyList<string> Telefones => _telefones.AsReadOnly();
    public IReadOnlyList<Dependente> Dependentes => _dependentes.AsReadOnly();
    List<string> _telefones = new List<string>();
    List<Dependente> _dependentes = new List<Dependente>();
    public int Idade => DateTime.Now.Year - DataNascimento.Year;

    public Bibliotecario(string nomeCompletoBibliotecario, string cpf, string idBibliotecario, DateOnly dataNascimento, UnidadeBiblioteca unidadeBiblioteca, Especializacao especializacao)
    {
        NomeCompletoBibliotecario = nomeCompletoBibliotecario;
        Cpf = cpf;
        IdBibliotecario = idBibliotecario;
        DataNascimento = dataNascimento;
        UnidadeBiblioteca = unidadeBiblioteca;
        Especializacao = especializacao;
    }

    public void AdicioneTelefone(string numero)
    {
        if (Telefones.Count() < 3)
        {
            _telefones.Add(numero);
            Console.WriteLine($"O número {numero} foi adicionado com sucesso! ");
        }
        else
        {
            Console.WriteLine("O limite de telefones foi excedido! ");
        }
    }
    public void SolicitarCompraLivros(PedidoDeCompra pedidoDeCompra, int quantidadeExemplares)
    {
        Console.WriteLine($"Detalhes do pedido de compra:\nQuantidade: {quantidadeExemplares}");
        int i = 1;
        foreach (var obras in pedidoDeCompra.ObrasLiterarias)
        {
            Console.WriteLine($"Obra #{i}:\nTitulo: {obras.Titulo}\nId: {obras.IdLivro}\nFornecedora: {pedidoDeCompra.FornecedorEditora.NomeFantasia}");
            i++;
        }
    }


public void Supervisao(List<Bibliotecario> bibliotecariosSupervisionados)
{
    Console.WriteLine($"O bibliotecário {NomeCompletoBibliotecario} está supervisionando os bibliotecários:");
    foreach (var biblio in bibliotecariosSupervisionados)
    {
        
        Console.WriteLine($"{biblio.NomeCompletoBibliotecario}");
    }
}
public void AdicionarDependente(string cpf, GrauDependencia grauDependencia)
{
    Dependente dependente = new Dependente(cpf, grauDependencia);
    _dependentes.Add(dependente);
}
public Emprestimo RealizarEmprestimo(Exemplar exemplar, Cliente cliente)
{
    var emprestimo = new Emprestimo(exemplar, cliente, this);
    return emprestimo;

}
}
