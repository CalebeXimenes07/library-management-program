public class ObraLiterariaRepository : IObraLiterariaRepository
{

    private List<ObraLiteraria> _obrasLiterarias = new List<ObraLiteraria>();
    public void Adicionar(ObraLiteraria obraLiteraria)
    {
        _obrasLiterarias.Add(obraLiteraria);
    }

    public IReadOnlyList<ObraLiteraria> ObterTodos() => _obrasLiterarias.AsReadOnly();
    public void Atualizar(ObraLiteraria obraLiteraria, ObraLiteraria novaObraLiteraria)
    {
            int posicao = _obrasLiterarias.IndexOf(obraLiteraria);
        if (posicao >= 0)
        {
            _obrasLiterarias[posicao] = novaObraLiteraria;
        }
        else
        {
            Console.WriteLine("Erro");
        }
    }

    public void Remover(string id)
    {
        var obraRemover = _obrasLiterarias.FirstOrDefault(x => x.IdLivro == id);
        _obrasLiterarias.Remove(obraRemover);
    }
}