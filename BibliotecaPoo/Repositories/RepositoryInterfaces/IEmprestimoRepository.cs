public interface IEmprestimoRepository
{
    void Adicionar(Emprestimo emprestimo);
    IReadOnlyList<Emprestimo> ObterTodos();
}