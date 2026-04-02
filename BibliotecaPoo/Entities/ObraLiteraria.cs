using System.IO.Pipes;

public class ObraLiteraria
{
    public string IdLivro { get; private set; }
    public string Autor { get; private set; }
    public double AnoPublicacao { get; private set; }
    public string Titulo { get; private set; }
    public ObraLiteraria()
    {

    }
    public ObraLiteraria(string idLivro, string autor, double anoPublicacao, string titulo)
    {
        IdLivro = idLivro;
        Autor = autor;
        AnoPublicacao = anoPublicacao;
        Titulo = titulo;
    }
}