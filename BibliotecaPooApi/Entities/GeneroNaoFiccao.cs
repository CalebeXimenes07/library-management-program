public enum NivelEnsino
{
    Fundamental,
    Medio,
    Superior
}
public class GeneroNaoFiccao : Genero
{
    public string AreaEstudo { get; private set; }

    public GeneroNaoFiccao(int codGenero, string nomeGenero, string areaEstudo) : base(codGenero, nomeGenero)
    {
        AreaEstudo = areaEstudo;

    }

}
