using System.Text.Json.Serialization;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "tipoCliente")]

[JsonDerivedType(typeof(Aluno), typeDiscriminator: "aluno")]
[JsonDerivedType(typeof(Professor), typeDiscriminator: "professor")]

public abstract class Cliente
{
    public string Cpf { get; private set; }
    public string Nome { get; private set; }

    protected Cliente()
    {

    }
    public Cliente(string nome, string cpf)
    {
        Cpf = cpf;
        Nome = nome;
    }
}