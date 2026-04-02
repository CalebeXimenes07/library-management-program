public enum PublicoAlvo
{
    Criancas,
    Adultos,
    Jovens,
    Homens,
    Mulheres
}
public class GeneroFiccao : Genero
{
    public string EstiloNarrativo { get; private set; }

    public GeneroFiccao(int codGenero, string nomeGenero, string estiloNarrativo) : base(codGenero, nomeGenero)
    {
        EstiloNarrativo = estiloNarrativo;

    }

}
