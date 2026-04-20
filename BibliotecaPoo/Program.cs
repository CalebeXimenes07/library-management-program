
using System.Net.Http.Headers;

List<Bibliotecario> lb = new List<Bibliotecario>();
List<ObraLiteraria> lo = new List<ObraLiteraria>();
List<string> lt = new List<string>();
StatusPedido sp = StatusPedido.Aguardando;
Especializacao m = Especializacao.Mestre;

Genero g = new GeneroNaoFiccao(21, "Biomedicina", "Saúde");
Pesquisador p = new Pesquisador("Lucas", "12-345.6", "Matemática", "12345");
ObraLiteraria ol = new ObraLiteraria("985", "Machado de Assis", 1889, "Dom Casmurro", g);
lo.Add(ol);
Exemplar e = new Exemplar(ol);
FornecedorEditora fe = new FornecedorEditora("1230001", "Editora Menezes", "819999-9999");
UnidadeBiblioteca ub = new UnidadeBiblioteca("1", "Clarice Lispector", "8198888-8888", "Paulista - PE", lb);
Bibliotecario b1 = new Bibliotecario("Saulo", "123", "2", DateOnly.Parse("13-08-2007"), ub, m);
Bibliotecario b2 = new Bibliotecario("Judas", "123", "2", DateOnly.Parse("13-08-2007"),ub, m);
Bibliotecario b3 = new Bibliotecario("Carlos", "123", "2", DateOnly.Parse("13-08-2007"), ub, m);
PedidoDeCompra pc = new PedidoDeCompra("Pedido A", 23, DateTime.Now, 950, lo, fe, sp);

Professor prof = new Professor("Paulo", "756", "Exatas");
Aluno aluno = new Aluno("João", "756", "132");
Pesquisador pesq = new Pesquisador("Pedro", "064", "Humanas", "909");

lb.Add(b1);
lb.Add(b2);
lb.Add(b3);

b1.Supervisao(lb);
Console.WriteLine();
Emprestimo emprestimoUm = b1.RealizarEmprestimo(e, prof);
Console.WriteLine(emprestimoUm);
emprestimoUm.RenovarEmprestimo();
Console.WriteLine();
b1.SolicitarCompraLivros(pc, 10);
Console.WriteLine();
ub.ListarBibliotecarios();