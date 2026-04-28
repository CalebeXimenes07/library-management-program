public enum StatusExemplar
{
    Disponivel,
    Emprestado,
    Reservado
}
public class Exemplar
{
    public string IdExemplar { get; private set; }
    public StatusExemplar Status { get; private set; }
    public ObraLiteraria ObraLiteraria { get; private set; }


    public Exemplar(ObraLiteraria obraLiteraria)
    {
        ObraLiteraria = obraLiteraria;
        Status = StatusExemplar.Disponivel;
        IdExemplar = obraLiteraria.IdLivro;
    }

}