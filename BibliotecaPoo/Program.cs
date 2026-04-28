var biblioRepo = new BibliotecarioRepository();
var emprestRepo = new EmprestimoRepository();
var exemplarRepo = new ExemplarRepository();
var clienteRepo = new ClienteRepository();
var obraRepo = new ObraLiterariaRepository();

StatusPedido sp = StatusPedido.Aguardando;
Especializacao m = Especializacao.Mestre;
GrauDependencia grauDep = GrauDependencia.Primeira;

Genero g = new GeneroNaoFiccao(21, "Biomedicina", "Saúde");


ObraLiteraria obra1 = new ObraLiteraria("985", "Machado de Assis", 1889, "Dom Casmurro", g);
obraRepo.Adicionar(obra1);
var listaObra = obraRepo.ObterTodos().ToList();

ObraLiteraria obra2 = new ObraLiteraria("985", "Machado de Assis", 1889, "Quincas Borba", g);

Exemplar e = new Exemplar(obra1);
exemplarRepo.Adicionar(e);
var listaExemplares = exemplarRepo.ObterTodos().ToList();

UnidadeBiblioteca ub = new UnidadeBiblioteca("1", "Clarice Lispector", "8198888-8888", "Paulista - PE");

Bibliotecario b1 = new Bibliotecario("Saulo", "123", "2", DateOnly.Parse("13-08-2007"), ub, m);
Bibliotecario b2 = new Bibliotecario("Judas", "123", "2", DateOnly.Parse("13-08-2007"), ub, m);
Bibliotecario b3 = new Bibliotecario("Carlos", "123", "2", DateOnly.Parse("13-08-2007"), ub, m);
biblioRepo.Adicionar(b1);
biblioRepo.Adicionar(b2);
biblioRepo.Adicionar(b3);
var listaBiblio = biblioRepo.ObterTodos().ToList();

FornecedorEditora fe = new FornecedorEditora("1230001", "Editora Menezes", "819999-9999");


PedidoDeCompra pc = new PedidoDeCompra("Pedido A", 23, DateTime.Now, 950, listaObra, fe, sp);

Professor prof = new Professor("Paulo", "756", "Exatas");
Aluno aluno = new Aluno("João", "756", "132");
Pesquisador pesq = new Pesquisador("Pedro", "064", "Humanas", "909");
clienteRepo.Adicionar(prof);
clienteRepo.Adicionar(aluno);
clienteRepo.Adicionar(pesq);
var listaClientes = clienteRepo.ObterTodos().ToList();

var emprestimo = new Emprestimo(e, aluno, b1);
emprestRepo.Adicionar(emprestimo);
var listaEmprestimos = emprestRepo.ObterTodos().ToList();

//Console.WriteLine("Bibliotecários: ");
//foreach (var biblio in listaBiblio)
//{
//    Console.WriteLine(biblio.NomeCompletoBibliotecario);
//}
Console.WriteLine();
Console.WriteLine("Obra antes: ");
foreach (var obras in listaObra)
{
    Console.WriteLine(obras.Titulo);
}
obraRepo.Atualizar(obra1, obra2);
listaObra = obraRepo.ObterTodos().ToList();

Console.WriteLine();
Console.WriteLine("Obra depois: ");
foreach (var obras in listaObra)
{
    Console.WriteLine(obras.Titulo);
}
//Console.WriteLine(); 
//Console.WriteLine("Clientes: ");
//foreach (var cliente in listaClientes)
//{
//    Console.WriteLine(cliente.Nome);
//}
//Console.WriteLine();
//Console.WriteLine("Exemplares: ");
//foreach (var exemplar in listaExemplares)
//{
//    Console.WriteLine(exemplar.ObraLiteraria.Titulo);
//}
//Console.WriteLine();
//Console.WriteLine("Emprestimos: ");
//foreach (var emprestimos in listaEmprestimos)
//{
//    Console.WriteLine(emprestimos);
//}