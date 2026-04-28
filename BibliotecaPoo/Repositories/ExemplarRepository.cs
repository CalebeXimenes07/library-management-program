public class ExemplarRepository : IExemplarRepository
{

    private List<Exemplar> _exemplares = new List<Exemplar>();
    public void Adicionar(Exemplar exemplar)
    {
        _exemplares.Add(exemplar);
    }
    public IReadOnlyList<Exemplar> ObterTodos() => _exemplares.AsReadOnly();
}