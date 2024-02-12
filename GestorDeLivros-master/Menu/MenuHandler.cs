using GestaoLivros.Services;

namespace GestaoLivros.Menu;

public static class MenuHandler
{
   private static bool _sair;
    public static void Start()
    {
        
        while (!_sair)
        {
            Console.Clear();
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Buscar Autores");
            Console.WriteLine("2. Buscar Autor");
            Console.WriteLine("3. Adicionar Autor");
            Console.WriteLine("4. Excluir Autor");
            Console.WriteLine("\n-----------------------------------------------------\n");
            Console.WriteLine("5. Buscar Livros");
            Console.WriteLine("6. Buscar Livro");
            Console.WriteLine("4. Adicionar Livro");
            Console.WriteLine("7. Excluir Livro");
            Console.WriteLine("8. Sair");
            Console.Write("\nDigite sua opção: ");

            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    GetAuthors();
                    break;
                case "2":
                    GetAuthorById();
                    break;
                case "3":
                    AddAuthor();
                    break;
                case "4":
                    DeleteAuthor();
                    break;
                case "5":
                    GetBooks();
                    break;
                case "6":
                    GetBookById();
                    break;
                case "7":
                    AddBook();
                    break;
                case "8":
                    DeleteBook();
                    break;
                case "9:
                    _sair=true;
                    break;
                default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    break;
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }

    private static void GetAuthors()
    {
        AuthorsService.GetAuthors();
    }

    private static void GetAuthorById()
    {
        
        Console.Write("Insira o código do autor: ");
        var authorCode = Console.ReadLine();
        
        if (int.TryParse(authorCode,out int numericCode))
        {
            AuthorsService.GetAuthorById(numericCode);
            return;
        }


        GetAuthors();
    }
    private static void AddAuthor()
    {
        Console.WriteLine("Insira o nome do autor: ");
        string nome = Console.ReadLine();

        AuthorsService.AddAuthor(nome);
        AuthorsService.GetAuthors();
    }
    private static void DeleteAuthor()
    {
        Console.WriteLine("Insira o id do autor que quer deletar: ");
        string id = Console.ReadLine();

        if (int.TryParse(authorCode, out int numericCode))
        {
            AuthorsService.DeleteAuthor(numericCode);
            return;
        }

        AuthorsService.GetAuthors();
    }
}