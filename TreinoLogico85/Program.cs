using TreinoLogico85.Repositories;
using TreinoLogico85.Services;

namespace TreinoLogico85
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITaskRepository repository = new InMemoryTaskRepository();
            TaskService taskService = new TaskService(repository);
            int _option;

            do
            {

                Console.WriteLine("Menu");
                Console.WriteLine();

                Console.WriteLine("1 - Create Task");
                Console.WriteLine("2 - List Task");
                Console.WriteLine("3 - Start Tasks");
                Console.WriteLine("4 - Complete Tasks ");
                Console.WriteLine("5 - Remove Tasks");
                Console.WriteLine("6 - History Tasks");
                Console.WriteLine("7 - Filter Tasks");

                while (!int.TryParse(Console.ReadLine(), out _option))
                {
                    Console.WriteLine("Opção invalida, tente novamente");
                }

                switch (_option)
                {
                    case 1:
                        Console.WriteLine("Create Tasl");
                        Console.WriteLine();

                        taskService.CreatedTask();

                        break;
                    case 2:
                        Console.WriteLine("List Task");
                        Console.WriteLine();

                        var list = taskService.ListTask();

                        foreach (var item in list)
                        {
                            Console.WriteLine($" Id{item.Id} Title {item.Title} Status {item.Status}");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Start Task");
                        Console.WriteLine();

                        int id = int.Parse(Console.ReadLine());

                        var checkTask = taskService.ChangeStatus(id);

                        if (checkTask != true)
                        {
                            Console.WriteLine("Id not found and status not compatible");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Completed Task");
                        Console.WriteLine();

                        int ids = int.Parse(Console.ReadLine());
                        var checkTask2 = taskService.ChangeStatus(ids);

                        if (checkTask2 != true)
                        {
                            Console.WriteLine("Id not found and status not compatible");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Remove Task");
                        Console.WriteLine();

                        int id3 = int.Parse(Console.ReadLine());

                        taskService.RemoveTasks(id3);
                        break;
                    case 6:
                        Console.WriteLine("History Task");
                        Console.WriteLine();

                        int id4 = int.Parse(Console.ReadLine());
                        var history = taskService.HistoryTask(id4);

                        foreach (var item in history)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 7:
                        Console.WriteLine("Filter Task");
                        Console.WriteLine();

                        var listFilter = taskService.FilterTask();

                        foreach (var item in listFilter)
                        {
                            Console.WriteLine($"Status: {item.Status}");
                        }
                        break;
                }
            }
            while (_option != 0);
        }
    }
}
