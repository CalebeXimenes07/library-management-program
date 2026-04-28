public interface IObraLiterariaRepository
{
    void Adicionar(ObraLiteraria obraLiteraria);
    IReadOnlyList<ObraLiteraria> ObterTodos();
}