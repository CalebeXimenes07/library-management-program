using System;

LibrarySystem.Run();

public static class LibrarySystem
{
    private static readonly BibliotecarioRepository _bibRepo = new();
    private static readonly EmprestimoRepository _empRepo = new();
    private static readonly ClienteRepository _cliRepo = new();
    private static readonly ObraLiterariaRepository _obrRepo = new();

    public static void Run()
    {
        Seed();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== SISTEMA DE BIBLIOTECA ===\n");
            Console.WriteLine("1. Obras Literárias");
            Console.WriteLine("2. Clientes");
            Console.WriteLine("3. Empréstimos");
            Console.WriteLine("0. Sair");
            Console.Write("\nOpção: ");

            switch (Console.ReadLine())
            {
                case "1": Menu.MenuObras(_obrRepo); break;
                case "2": Menu.MenuClientes(_cliRepo); break;
                case "3": Menu.MenuEmprestimos(_empRepo, _cliRepo, _bibRepo); break;
                case "0": return;
                default: Console.WriteLine("Opção inválida! Teclado para continuar."); Console.ReadKey(); break;
            }
        }
    }

    private static void Seed()
    {
        _bibRepo.Adicionar(new Bibliotecario("Admin", "000.000.000-00", "B01", new DateOnly(1990, 1, 1), null!, Especializacao.Especialista));
        _obrRepo.Adicionar(new ObraLiteraria("101", "J.K. Rowling", 1997, "Harry Potter", new GeneroFiccao(1, "Fantasia", "")));
        _cliRepo.Adicionar(new Aluno("João Silva", "111.111.111-11", "2024001"));
    }
}
