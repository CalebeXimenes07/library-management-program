public interface IBibliotecarioRepository
{
    void Adicionar(Bibliotecario bibliotecario);
    IReadOnlyList<Bibliotecario> ObterTodos();
    void Atualizar(Bibliotecario bibliotecario, Bibliotecario novoBibliotecario);
    void Remover(Bibliotecario bibliotecario);
}