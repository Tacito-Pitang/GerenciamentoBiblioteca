using GerenciamentoBiblioteca;
using static System.Net.Mime.MediaTypeNames;

Biblioteca biblioteca = new Biblioteca();

int opcao;
do
{
    Console.Clear();
    Console.WriteLine("Escolha uma opção: \n1. Adicionar Livro \n2. Adicionar Revista \n3. Listar Itens \n4. Buscar por Título \n5. Buscar por Autor \n6. Emprestar Livro \n7. Devolver Livro \n8. Sair \n");
    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Você escolheu a opção 1. Adicionar Livro");
            Livro livro = new Livro();

            Console.Write("Informe o ID: ");
            livro.Id = int.Parse(Console.ReadLine());

            Console.Write("Informe o título do livro: ");
            livro.Titulo = Console.ReadLine();

            Console.Write("Informe o autor do livro: ");
            livro.Autor = Console.ReadLine();

            Console.Write("Informe o ano de publicação: ");
            livro.AnoPublicacao = int.Parse(Console.ReadLine());

            livro.Disponivel = true;

            biblioteca.AdicionarItem(livro);

            break;
        case 2:
            Console.WriteLine("Você escolheu a opção 2. Adicionar Revista");
            Revista revista = new Revista();

            Console.Write("Informe o ID: ");
            revista.Id = int.Parse(Console.ReadLine());

            Console.Write("Informe o título da revista: ");
            revista.Titulo = Console.ReadLine();

            Console.Write("Informe o autor da revista: ");
            revista.Autor = Console.ReadLine();

            Console.Write("Informe o ano de publicação: ");
            revista.AnoPublicacao = int.Parse(Console.ReadLine());

            Console.Write("Informe a edição da revista: ");
            revista.Edicao = int.Parse(Console.ReadLine());

            biblioteca.AdicionarItem(revista);
            break;
        case 3:
            Console.WriteLine("Você escolheu a opção 3. Listar Itens");
            biblioteca.ListarItens();
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção 4. Buscar por Título");
            Console.Write("Informe o título para busca: ");
            string titulo = Console.ReadLine();
            biblioteca.BuscarPorTitulo(titulo);
            break;
        case 5:
            Console.WriteLine("Você escolheu a opção 5. Buscar por Autor");
            Console.Write("Informe o autor para busca: ");
            string autor = Console.ReadLine();
            biblioteca.BuscarPorAutor(autor);
            break;
        case 6:
            Console.WriteLine("Você escolheu a opção 6. Emprestar Livro");
            Console.Write("Informe o ID do livro a ser emprestado: ");
            int id = int.Parse(Console.ReadLine());

            Livro livroEmprestado = biblioteca.Itens.Find(i => i is Livro && i.Id == id) as Livro;

            if (livroEmprestado != null)
            {
                livroEmprestado.EmprestarLivro();
            }
            else
            {
                Console.WriteLine("Livro não encontrado ou não é um livro.");
            }
            break;
        case 7:
            Console.WriteLine("Você escolheu a opção 7. Devolver Livro");
            Console.Write("Informe o ID do livro a ser devolvido: ");
            int idlivro = int.Parse(Console.ReadLine());

            Livro livroDevolvido = biblioteca.Itens.Find(i => i is Livro && i.Id == idlivro) as Livro;

            if (livroDevolvido != null)
            {
                livroDevolvido.DevolverLivro();
            }
            else
            {
                Console.WriteLine("Livro não encontrado.");
            }
            break;
        case 8:
            Console.WriteLine("Você escolheu a opção 8. SAIR");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }

    Console.WriteLine("\nPressione qualquer tecla para continuar...");
    Console.ReadKey();
} while (opcao != 8);
