public interface IExemplarRepository
{
    void Adicionar(Exemplar exemplar);
    IReadOnlyList<Exemplar> ObterTodos();
    void Atualizar(Exemplar exemplar, Exemplar novoExemplar);
    void Remover(Exemplar exemplar);
}