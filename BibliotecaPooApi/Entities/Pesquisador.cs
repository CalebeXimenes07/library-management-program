public class Pesquisador : Cliente, IAluno, IProfessor
{
    public string MatriculaAluno { get; set; }
    public string AreaAtuacao { get; set; }
    public Pesquisador(string nome, string cpf, string areaAtuacao, string matriculaAluno) : base(nome, cpf)
    {
        MatriculaAluno = matriculaAluno;
        AreaAtuacao = areaAtuacao;
    }
}