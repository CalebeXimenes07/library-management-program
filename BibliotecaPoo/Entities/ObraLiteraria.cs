
public class ObraLiteraria
{
    public string IdLivro { get; private set; }
    public string Autor { get; private set; }
    public int AnoPublicacao { get; private set; }
    public string Titulo { get; private set; }
    public Genero Genero { get; private set; }
    public ObraLiteraria(string idLivro, string autor, int anoPublicacao, string titulo, Genero genero)
    {
        IdLivro = idLivro;
        Autor = autor;
        AnoPublicacao = anoPublicacao;
        Titulo = titulo;
        Genero = genero;
    }
}