public class Professor : Cliente, IProfessor
{
    public string AreaAtuacao { get; private set; }
    public Professor(string nome, string cpf, string areaAtuacao) : base(nome, cpf)
    {
        AreaAtuacao = areaAtuacao;

    }
}