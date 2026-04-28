public class EmprestimoRepository : IEmprestimoRepository
{

    private List<Emprestimo> _emprestimos = new List<Emprestimo>();
    public void Adicionar(Emprestimo emprestimo)
    {
        _emprestimos.Add(emprestimo);
    }
    public IReadOnlyList<Emprestimo> ObterTodos() => _emprestimos.AsReadOnly();
}