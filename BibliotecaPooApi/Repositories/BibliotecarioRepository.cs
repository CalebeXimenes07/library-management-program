public class BibliotecarioRepository : IBibliotecarioRepository
{

    private List<Bibliotecario> _bibliotecarios = new List<Bibliotecario>();
    public void Adicionar(Bibliotecario bibliotecario)
    {
        _bibliotecarios.Add(bibliotecario);
    }

    public IReadOnlyList<Bibliotecario> ObterTodos() => _bibliotecarios.AsReadOnly();
    public void Atualizar(Bibliotecario bibliotecario, Bibliotecario novoBibliotecario)
    {
        int posicao = _bibliotecarios.IndexOf(bibliotecario);
        if (posicao >= 0)
        {
            _bibliotecarios[posicao] = novoBibliotecario;
        }
        else
        {
            Console.WriteLine("Erro");
        }
    }

    // Delete
    public void Remover(string cpf)
    {
        var biblioRemover = _bibliotecarios.FirstOrDefault(x => x.Cpf == cpf);
        _bibliotecarios.Remove(biblioRemover);
    }
}