public interface IEmprestimoRepository
{
    void Adicionar(Emprestimo emprestimo);
    IReadOnlyList<Emprestimo> ObterTodos();
    void Atualizar(Emprestimo emprestimo, Emprestimo novoEmprestimo);
    void Remover(Emprestimo emprestimo);
}