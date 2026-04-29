using System;
using System.Collections.Generic;
using System.Linq;

public static class Menu
{
    public static void MenuObras(ObraLiterariaRepository repo)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== MENU DE OBRAS LITERÁRIAS ===\n");
            Console.WriteLine("1. Listar Todas as Obras");
            Console.WriteLine("2. Adicionar Nova Obra");
            Console.WriteLine("3. Remover Obra");
            Console.WriteLine("0. Voltar ao Menu Principal");
            Console.Write("\nOpção: ");
            
            string op = Console.ReadLine() ?? "";
            if (op == "0") break;

            switch (op)
            {
                case "1":
                {
                    Console.WriteLine("--- LISTAGEM DE OBRAS ---");
                    var obras = repo.ObterTodos();
                    if (!obras.Any()) Console.WriteLine("Nenhuma obra cadastrada.");
                    foreach (var o in obras) Console.WriteLine($"ID: {o.IdLivro} | Título: {o.Titulo} | Autor: {o.Autor}");
                    break;
                }
                case "2":
                {
                    Console.WriteLine("--- ADICIONAR OBRA ---");
                    Console.Write("ID: "); string id = Console.ReadLine() ?? "";
                    Console.Write("Título: "); string t = Console.ReadLine() ?? "";
                    Console.Write("Autor: "); string a = Console.ReadLine() ?? "";
                    Console.Write("Ano: "); int.TryParse(Console.ReadLine(), out int ano);
                    
                    repo.Adicionar(new ObraLiteraria(id, a, ano, t, new GeneroFiccao(1, "Geral", "Descrição padrão")));
                    Console.WriteLine("\nObra adicionada com sucesso!");
                    break;
                }
                case "3":
                {
                    Console.WriteLine("--- REMOVER OBRA ---");
                    Console.Write("ID da obra: "); 
                    string idRemover = Console.ReadLine() ?? "";
                    var obraParaRemover = repo.ObterTodos().FirstOrDefault(o => o.IdLivro == idRemover);
                    
                    if (obraParaRemover != null) {
                        repo.Remover(obraParaRemover);
                        Console.WriteLine("\nObra removida!");
                    } else Console.WriteLine("\nErro: Obra não encontrada.");
                    break;
                }
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }

    public static void MenuClientes(ClienteRepository repo)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== MENU DE CLIENTES ===\n");
            Console.WriteLine("1. Listar Clientes");
            Console.WriteLine("2. Adicionar Aluno");
            Console.WriteLine("3. Adicionar Professor");
            Console.WriteLine("4. Remover Cliente");
            Console.WriteLine("0. Voltar ao Menu Principal");
            Console.Write("\nOpção: ");

            string op = Console.ReadLine() ?? "";
            if (op == "0") break;

            switch (op)
            {
                case "1":
                {
                    Console.WriteLine("--- LISTAGEM DE CLIENTES ---");
                    var clientes = repo.ObterTodos();
                    if (!clientes.Any()) Console.WriteLine("Nenhum cliente cadastrado.");
                    foreach (var c in clientes) Console.WriteLine($"CPF: {c.Cpf} | Nome: {c.Nome} | Tipo: {c.GetType().Name}");
                    break;
                }
                case "2":
                {
                    Console.WriteLine("--- CADASTRAR ALUNO ---");
                    Console.Write("Nome: "); string n = Console.ReadLine() ?? "";
                    Console.Write("CPF: "); string c = Console.ReadLine() ?? "";
                    Console.Write("Matrícula: "); string m = Console.ReadLine() ?? "";
                    repo.Adicionar(new Aluno(n, c, m));
                    Console.WriteLine("\nAluno cadastrado!");
                    break;
                }
                case "3":
                {
                    Console.WriteLine("--- CADASTRAR PROFESSOR ---");
                    Console.Write("Nome: "); string nP = Console.ReadLine() ?? "";
                    Console.Write("CPF: "); string cP = Console.ReadLine() ?? "";
                    Console.Write("Área: "); string area = Console.ReadLine() ?? "";
                    repo.Adicionar(new Professor(nP, cP, area));
                    Console.WriteLine("\nProfessor cadastrado!");
                    break;
                }
                case "4":
                {
                    Console.WriteLine("--- REMOVER CLIENTE ---");
                    Console.Write("CPF: "); string cpfRemover = Console.ReadLine() ?? "";
                    var cliRemover = repo.ObterTodos().FirstOrDefault(cli => cli.Cpf == cpfRemover);
                    if (cliRemover != null) {
                        repo.Remover(cliRemover);
                        Console.WriteLine("\nCliente removido!");
                    } else Console.WriteLine("\nErro: Cliente não encontrado.");
                    break;
                }
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }

    public static void MenuEmprestimos(EmprestimoRepository repo, ClienteRepository cRepo, BibliotecarioRepository bRepo)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== MENU DE EMPRÉSTIMOS ===\n");
            Console.WriteLine("1. Listar Empréstimos");
            Console.WriteLine("2. Realizar Empréstimo");
            Console.WriteLine("3. Devolver/Remover");
            Console.WriteLine("0. Voltar ao Menu Principal");
            Console.Write("\nOpção: ");

            string op = Console.ReadLine() ?? "";
            if (op == "0") break;

            switch (op)
            {
                case "1":
                {
                    var emp = repo.ObterTodos();
                    if (!emp.Any()) Console.WriteLine("Nenhum empréstimo.");
                    foreach (var e in emp) Console.WriteLine(e);
                    break;
                }
                case "2":
                {
                    Console.Write("CPF do Cliente: "); string cpf = Console.ReadLine() ?? "";
                    var cli = cRepo.ObterTodos().FirstOrDefault(c => c.Cpf == cpf);
                    if (cli == null) Console.WriteLine("\nErro: Cliente não encontrado.");
                    else {
                        Console.Write("Título da Obra: "); string tit = Console.ReadLine() ?? "";
                        var exemplar = new Exemplar(new ObraLiteraria("TEMP", "Autor", 2024, tit, new GeneroFiccao(0, "Geral", "")));
                        var biblio = bRepo.ObterTodos().FirstOrDefault() ?? new Bibliotecario("Admin", "000", "B01", DateOnly.FromDateTime(DateTime.Now), null!, Especializacao.Especialista);
                        repo.Adicionar(biblio.RealizarEmprestimo(exemplar, cli));
                        Console.WriteLine("\nSucesso!");
                    }
                    break;
                }
                case "3":
                {
                    Console.Write("CPF do Cliente: "); string cpfBusca = Console.ReadLine() ?? "";
                    var empRemover = repo.ObterTodos().FirstOrDefault(e => e.Cliente.Cpf == cpfBusca);
                    if (empRemover != null) {
                        repo.Remover(empRemover);
                        Console.WriteLine("\nRemovido!");
                    } else Console.WriteLine("\nErro: Não encontrado.");
                    break;
                }
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
