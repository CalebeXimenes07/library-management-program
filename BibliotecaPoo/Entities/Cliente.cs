public class Cliente
{
    public string Cpf { get; private set; }
    public string Endereco { get; private set; }
    public string Telefone { get; private set; }
    public string Nome { get; private set; }

    public Cliente()
    {

    }

    public Cliente(string cpf, string endereco, string telefone, string nome)
    {
        Cpf = cpf;
        Endereco = endereco;
        Telefone = telefone;
        Nome = nome;
    }
}