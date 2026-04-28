public interface IExemplarRepository
{
    void Adicionar(Exemplar exemplar);
    IReadOnlyList<Exemplar> ObterTodos();
}