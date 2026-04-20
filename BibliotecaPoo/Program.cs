
List<Bibliotecario> lb = new List<Bibliotecario>();
List<ObraLiteraria> lo = new List<ObraLiteraria>();
List<string> lt = new List<string>();
StatusPedido sp = StatusPedido.Aguardando;

Genero g = new GeneroNaoFiccao(21, "Biomedicina", "Saúde");
Pesquisador p = new Pesquisador("Calebe", "12-345.6", "Matemática", "12345");
ObraLiteraria ol = new ObraLiteraria("985", "Machado de Assis", 1889, "Dom Casmurro", g);
lo.Add(ol);
Exemplar e = new Exemplar(ol);
FornecedorEditora fe = new FornecedorEditora("1230001", "Editora Ximenes", "819999-9999");
UnidadeBiblioteca ub = new UnidadeBiblioteca("1", "Clarice Lispector", "8198888-8888", "Paulista - PE", lb);
Bibliotecario b1 = new Bibliotecario("Calebe", "123", "2", DateOnly.Parse("13-08-2007"), ub, lt);
Bibliotecario b2 = new Bibliotecario("Iuri", "123", "2", "8199234-5882", DateOnly.Parse("13-08-2007"), ub);
Bibliotecario b3 = new Bibliotecario("Caio", "123", "2", "8199234-5882", DateOnly.Parse("13-08-2007"), ub);
PedidoDeCompra pc = new PedidoDeCompra("Pedido A", 23, DateTime.Now, 950, lo, fe, sp);

lb.Add(b1);
lb.Add(b2);
lb.Add(b3);

b1.Supervisao(lb);
Console.WriteLine();
b1.Emprestimo(e, c);
Console.WriteLine();
b1.SolicitarCompraLivros(pc, 10);
Console.WriteLine();
ub.ListarBibliotecarios();