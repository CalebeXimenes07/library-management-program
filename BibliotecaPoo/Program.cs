
List<Bibliotecario> lb = new List<Bibliotecario>();

Cliente c = new Cliente("123", "Rua Vertentes", "8199167-0068", "Calebe");
ObraLiteraria ol = new ObraLiteraria("985", "Machado de Assis", 1889, "Dom Casmurro");
Exemplar e = new Exemplar(ol);
FornecedorEditora fe = new FornecedorEditora("1230001", "Editora Ximenes", "819999-9999");
UnidadeBiblioteca ub = new UnidadeBiblioteca("1", "Clarice Lispector", "8198888-8888", "Paulista - PE", lb);
Bibliotecario b1 = new Bibliotecario("Calebe", "123", "2", "8199234-5882", DateOnly.Parse("13-08-2007"), ub);
Bibliotecario b2 = new Bibliotecario("Iuri", "123", "2", "8199234-5882", DateOnly.Parse("13-08-2007"), ub);
Bibliotecario b3 = new Bibliotecario("Caio", "123", "2", "8199234-5882", DateOnly.Parse("13-08-2007"), ub);

lb.Add(b1);
lb.Add(b2);
lb.Add(b3);

b1.Supervisao(b3);
Console.WriteLine();
b1.Emprestimo(e, c);
Console.WriteLine();
b1.SolicitarCompraLivros(ol, 15, fe);
Console.WriteLine();
ub.ListarBibliotecarios();