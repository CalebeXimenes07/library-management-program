public class EmprestimoRepository : IEmprestimoRepository
{

    private List<Emprestimo> _emprestimos = new List<Emprestimo>();
    public void Adicionar(Emprestimo emprestimo)
    {
        _emprestimos.Add(emprestimo);
    }
    public IReadOnlyList<Emprestimo> ObterTodos() => _emprestimos.AsReadOnly();
    public void Atualizar(Emprestimo emprestimo, Emprestimo novoEmprestimo)
    {
        int posicao = _emprestimos.IndexOf(emprestimo);
        if (posicao >= 0)
        {
            _emprestimos[posicao] = novoEmprestimo;
        }
        else
        {
            Console.WriteLine("Erro");
        }
    }

    // Delete
    public void Remover(Emprestimo emprestimo)
    {
        _emprestimos.Remove(emprestimo);
    }
}