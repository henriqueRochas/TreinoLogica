
namespace TreinoLogico75
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listaTarefas = new List<string>();
            int opcao;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine();

                Console.WriteLine("1) Criar tarefas");
                Console.WriteLine("2) Listar tarefas");
                Console.WriteLine("3) Iniciar tarefas");
                Console.WriteLine("4) Concluir tarefas");
                Console.WriteLine("5) Sair");

                while (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Valor inválido, tente novamente.");
                }

                switch(opcao)
                {
                    case 1:
                        Console.WriteLine("Criar tarefas");
                        Console.WriteLine();
                        string tarefas = Console.ReadLine();
                        listaTarefas.Add(tarefas);
                        break;
                    case 2:
                        Console.WriteLine("Lista tarefas");
                        Console.WriteLine();

                        foreach (var item in listaTarefas)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                }
            }
            while (opcao != 0);

        }
    }
}
