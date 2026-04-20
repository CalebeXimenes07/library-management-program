public enum StatusPedido
{
    Realizado,
    Aguardando
}
public class PedidoDeCompra
{
    public string NomeDoPedido { get; private set; }
    public int IdCompra { get; private set; }
    public DateTime DataPedido { get; private set; }
    public decimal ValorTotal { get; private set; }
    public FornecedorEditora FornecedorEditora { get; private set; }
    public StatusPedido Status { get; private set; }
    public List<ObraLiteraria> ObrasLiterarias { get; private set; }

    public PedidoDeCompra(string nomeDoPedido, int idCompra, DateTime dataPedido, decimal valorTotal, List<ObraLiteraria> obrasLiterarias, FornecedorEditora fornecedorEditora, StatusPedido status)
    {
        NomeDoPedido = nomeDoPedido;
        IdCompra = idCompra;
        DataPedido = dataPedido;
        ValorTotal = valorTotal;
        ObrasLiterarias = obrasLiterarias;
        FornecedorEditora = fornecedorEditora;
        Status = status;
    }


}