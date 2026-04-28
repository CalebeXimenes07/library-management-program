public class BibliotecarioRepository : IBibliotecarioRepository
{

    private List<Bibliotecario> _bibliotecarios = new List<Bibliotecario>();
    public void Adicionar(Bibliotecario bibliotecario)
    {
        _bibliotecarios.Add(bibliotecario);
    }
    public IReadOnlyList<Bibliotecario> ObterTodos() => _bibliotecarios.AsReadOnly();
}