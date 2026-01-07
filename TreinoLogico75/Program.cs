
using System.Collections.Generic;
using static TreinoLogico75.Program.TaskManager;

namespace TreinoLogico75
{
    internal class Program
    {
        public class TaskManager
        {
            public int Id { get; set; }
            public string Titulo { get; set; }
            public StatusTask Status { get; set; }

            public enum StatusTask
            {
                Pendente,
                Andamento,
                Concluida
            }

            public TaskManager() { }

            public TaskManager(int id, string titulo, StatusTask status)
            {
                Id = id;
                Titulo = titulo;
                Status = status;
            }
        }
        static void Main(string[] args)
        {

            List<TaskManager> list = new List<TaskManager>();
            int _opcao;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine();

                Console.WriteLine("1) Criar tarefas");
                Console.WriteLine("2) Listar tarefas");
                Console.WriteLine("3) Iniciar tarefas");
                Console.WriteLine("4) Concluir tarefas");
                Console.WriteLine("0) Sair");

                while (!int.TryParse(Console.ReadLine(), out _opcao))
                {
                    Console.WriteLine("Valor inválido, tente novamente.");
                }

                switch (_opcao)
                {
                    case 1:
                        Console.WriteLine("Criar tarefas");
                        Console.WriteLine();

                        list = new List<TaskManager>()
                        {
                           new TaskManager() { Id = 1, Titulo = "Tarefa 1", Status = StatusTask.Pendente},
                           new TaskManager() { Id = 2, Titulo = "Tarefa 2", Status = StatusTask.Pendente},
                           new TaskManager() { Id = 3, Titulo = "Tarefa 3", Status = StatusTask.Pendente}
                        };

                        break;
                    case 2:
                        Console.WriteLine("Lista tarefas");
                        Console.WriteLine();

                        foreach (var item in list)
                        {
                            Console.WriteLine($"Id: {item.Id} Titulo: {item.Titulo} Status: {item.Status}");
                        }
                        break;
                    case 3:
                        bool verifId = false;
                        Console.WriteLine("Iniciar tarefas");
                        Console.WriteLine();

                        int idProcurar = int.Parse(Console.ReadLine());
                        foreach (var item in list)
                        {
                            if (item.Id == idProcurar)
                            {
                                if(item.Status == StatusTask.Pendente)
                                {
                                    item.Status = StatusTask.Andamento;
                                    verifId = true;
                                    Console.WriteLine("Status alterado!");
                                    break;
                                }
                            }
                        }
                        if (verifId != true)
                        {
                            Console.WriteLine("o Id existe, mas o status não permite");
                        }

                        break;
                    case 4:
                        bool verifId2 = false;
                        Console.WriteLine("Concluir tarefa");
                        Console.WriteLine();

                        int procurarId = int.Parse(Console.ReadLine());

                        foreach (var item in list)
                        {
                            if(item.Id == procurarId)
                            {
                                if(item.Status == StatusTask.Andamento)
                                {
                                    item.Status = StatusTask.Concluida;
                                    Console.WriteLine("Status alterado!");
                                    verifId2 = true;
                                    break;
                                }
                            }
                            if(verifId2 != true)
                            {
                                Console.WriteLine("o Id existe, mas o status não permite");
                            }
                        }
                        break;
                    case 5:
                        break;
                }
            }
            while (_opcao != 0);

        }
    }
}
