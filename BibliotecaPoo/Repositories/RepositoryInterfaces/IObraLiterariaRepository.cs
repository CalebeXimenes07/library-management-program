public interface IObraLiterariaRepository
{
    void Adicionar(ObraLiteraria obraLiteraria);
    IReadOnlyList<ObraLiteraria> ObterTodos();
    void Atualizar(ObraLiteraria obraLiteraria, ObraLiteraria novaObraLiteraria);
    void Remover(ObraLiteraria obraLiteraria);
}