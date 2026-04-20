public abstract class Cliente
{
    public string Cpf { get; private set; }
    public string Nome { get; private set; }

    public Cliente(string nome, string cpf)
    {
        Cpf = cpf;
        Nome = nome;
    }
}