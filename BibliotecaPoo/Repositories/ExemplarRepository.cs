public class ExemplarRepository : IExemplarRepository
{

    private List<Exemplar> _exemplares = new List<Exemplar>();
    public void Adicionar(Exemplar exemplar)
    {
        _exemplares.Add(exemplar);
    }
    public IReadOnlyList<Exemplar> ObterTodos() => _exemplares.AsReadOnly();
    public void Atualizar(Exemplar exemplar, Exemplar novoExemplar)
    {
        int posicao = _exemplares.IndexOf(exemplar);
        if (posicao >= 0)
        {
            _exemplares[posicao] = novoExemplar;
        }
        else
        {
            Console.WriteLine("Erro");
        }
    }

    // Delete
    public void Remover(Exemplar exemplar)
    {
        _exemplares.Remove(exemplar);
    }
}