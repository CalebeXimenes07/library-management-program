public class Genero
{
    public int CodGenero { get; private set; }
    public string NomeGenero { get; private set; }

    public Genero(int codGenero, string nomeGenero)
    {
        CodGenero = codGenero;
        NomeGenero = nomeGenero;
    }
}