using static TreinoLogico78.Program.TaskManager;

namespace TreinoLogico78
{
    internal class Program
    {
        public class TaskManager
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public StatusTask Status { get; set; }

            public TaskManager() { }

            public TaskManager(int id, string title, StatusTask status)
            {
                Id = id;
                Title = title;
                Status = status;
            }

            public enum StatusTask
            {
                Pending,
                Progress,
                Completed
            }
        }
        static void Main(string[] args)
        {
            int _opcao;
            List<TaskManager> listTasks = new List<TaskManager>();

            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine();

                Console.WriteLine("1 - Create Task");
                Console.WriteLine("2 - List Task");
                Console.WriteLine("3 - Start Tasks");
                Console.WriteLine("4 - Complete Tasks ");
                Console.WriteLine("5 - Remove Tasks");
                Console.WriteLine("0 - Exit");

                while (!int.TryParse(Console.ReadLine(), out _opcao))
                {
                    Console.WriteLine("Opção invalida, tente novamente");
                }

                switch (_opcao)
                {
                    case 1:
                        Console.WriteLine("Create Tasl");
                        Console.WriteLine();
                        listTasks = new List<TaskManager>()
                        {
                           new TaskManager() { Id = 1, Title = "Task 1", Status = StatusTask.Pending},
                           new TaskManager() { Id = 2, Title = "Task 2", Status = StatusTask.Pending},
                           new TaskManager() { Id = 3, Title = "Task 3", Status = StatusTask.Pending}
                        };

                        break;
                    case 2:
                        Console.WriteLine("List Task");
                        Console.WriteLine();

                        foreach (var item in listTasks)
                        {
                            Console.WriteLine($"{item.Id}{item.Title}{item.Status}");
                        }

                        break;
                    case 3:
                        Console.WriteLine("Start Task");
                        Console.WriteLine();

                        bool checkId = false;
                        int id = int.Parse(Console.ReadLine());

                        foreach (var item in listTasks)
                        {
                            if(item.Id == id)
                            {
                                if(item.Status == StatusTask.Pending)
                                {
                                    item.Status = StatusTask.Progress;
                                    checkId = true;
                                    break;
                                }
                            }
                        }

                        if(checkId != true)
                        {
                            Console.WriteLine("Id not found and status not compatible");
                        }

                        break;
                    case 4:
                        Console.WriteLine("Completed Task");
                        Console.WriteLine();

                        bool checkId2 = false;
                        int ids = int.Parse(Console.ReadLine());

                        foreach (var item in listTasks)
                        {
                            if(item.Id == ids)
                            {
                                if(item.Status == StatusTask.Progress)
                                {
                                    item.Status = StatusTask.Completed;
                                    checkId2 = true;
                                    break;
                                }
                            }
                        }

                        if(checkId2 != true)
                        {
                            Console.WriteLine("Id not found and status not compatible");
                        }

                        break;
                    case 5:
                        Console.WriteLine("Remove Task");
                        Console.WriteLine();

                        bool checkId3 = false;
                        int id3 = int.Parse(Console.ReadLine());

                        for(int i = 0; i < listTasks.Count; i++)
                        {
                            var item = listTasks[i];
                            if(item.Id == id3)
                            {
                                if(item.Status == StatusTask.Completed)
                                {
                                    listTasks.RemoveAt(i);
                                    checkId3 = true;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("The task exists, but it is incomplete and can't be removed");
                                }
                            }
                        }
                        if (!checkId3)
                        {
                            Console.WriteLine("Id not found and status not compatible");
                        }

                        break;
                    case 0:
                        break;
                }
            }
            while (_opcao != 0);
        }
    }
}
