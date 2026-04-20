public class Emprestimo
{
    public Exemplar Exemplar { get; private set; }
    public Cliente Cliente { get; private set; }
    public Bibliotecario Bibliotecario { get; private set; }
    public DateTime DataEmprestimo { get; private set; }
    public DateTime DataDevolucao { get; private set; }

    public Emprestimo(Exemplar exemplar, Cliente cliente, Bibliotecario bibliotecario)
    {
        Exemplar = exemplar;
        Cliente = cliente;
        Bibliotecario = bibliotecario;
        DataEmprestimo = DateTime.Now;
        DataDevolucao = DataEmprestimo.AddDays(7); 
    }

    public void RenovarEmprestimo()
    {
     DataDevolucao = DataDevolucao.AddDays(7);
        Console.WriteLine($"Nova data de devolução: {DataDevolucao}");
    }
    public override string ToString()
    {
        return $"Exemplar: {Exemplar.ObraLiteraria.Titulo}, Cliente: {Cliente.Nome}, Bibliotecário: {Bibliotecario.NomeCompletoBibliotecario}, Data Empréstimo: {DataEmprestimo}, Data Devolução: {DataDevolucao}";
    }
}