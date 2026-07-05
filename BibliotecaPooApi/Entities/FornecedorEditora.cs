public class FornecedorEditora
{
    public string Cnpj { get; private set; }
    public string NomeFantasia { get; private set; }
    public string TelefoneComercial { get; private set; }

    public FornecedorEditora(string cnpj, string nomeFantasia, string telefoneComercial)
    {
        Cnpj = cnpj;
        NomeFantasia = nomeFantasia;
        TelefoneComercial = telefoneComercial;
    }
}