public class UnidadeBiblioteca
{
    public string IdUnidade { get; private set; }
    public string NomeUnidade { get; private set; }
    public string TelefoneUnidade { get; private set; }
    public string EnderecoUnidade { get; private set; }
    public List<Bibliotecario> Bibliotecarios { get; private set; } = new List<Bibliotecario>();
    public UnidadeBiblioteca(string idUnidade, string nomeUnidade, string telefoneUnidade, string enderecoUnidade)
    {
        IdUnidade = idUnidade;
        NomeUnidade = nomeUnidade;
        TelefoneUnidade = telefoneUnidade;
        EnderecoUnidade = enderecoUnidade;
    }

    public UnidadeBiblioteca(string idUnidade, string nomeUnidade, string telefoneUnidade, string enderecoUnidade, List<Bibliotecario> bibliotecarios)
    {
        IdUnidade = idUnidade;
        NomeUnidade = nomeUnidade;
        TelefoneUnidade = telefoneUnidade;
        EnderecoUnidade = enderecoUnidade;
        Bibliotecarios = bibliotecarios;
    }
    public void ListarBibliotecarios()
    {
        Console.WriteLine($"Lista de funcionário da biblioteca {NomeUnidade}:");
        foreach (var bibliotecario in Bibliotecarios)
        {
            Console.WriteLine($"{bibliotecario.NomeCompletoBibliotecario}");
        }
    }
}