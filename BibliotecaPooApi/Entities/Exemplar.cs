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

    protected Exemplar()
    {

    }
    public Exemplar(ObraLiteraria obraLiteraria)
    {
        IdExemplar = Guid.NewGuid().ToString().Substring(0, 8);
        ObraLiteraria = obraLiteraria;
        Status = StatusExemplar.Disponivel;
    }

}