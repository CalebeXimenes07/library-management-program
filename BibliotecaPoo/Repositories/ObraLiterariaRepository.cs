public class ObraLiterariaRepository : IObraLiterariaRepository
{

    private List<ObraLiteraria> _obrasLiterarias= new List<ObraLiteraria>();
    
    // Create
    public void Adicionar(ObraLiteraria obraLiteraria)
    {
        _obrasLiterarias.Add(obraLiteraria);
    }
    // Read
    public IReadOnlyList<ObraLiteraria> ObterTodos() => _obrasLiterarias.AsReadOnly();
    
    // Update
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

    // Delete
    public void Remover(ObraLiteraria obraLiteraria)
    {
        _obrasLiterarias.Remove(obraLiteraria);
    }
}