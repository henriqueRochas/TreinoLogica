using static TreinoLogico77.Program.TaskManager;

namespace TreinoLogico77
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

            List<TaskManager> list = new List<TaskManager>()
            {
               new TaskManager() { Id = 1, Titulo = "Tarefa 1", Status = StatusTask.Pendente},
               new TaskManager() { Id = 2, Titulo = "Tarefa 2", Status = StatusTask.Pendente},
               new TaskManager() { Id = 3, Titulo = "Tarefa 3", Status = StatusTask.Pendente}
            };
            

            if (list[0].Status == StatusTask.Pendente)
            {
                list[0].Status = StatusTask.Andamento;
            }
            else
            {
                Console.WriteLine("Esse status não é valido, tente novamente");
            }

            if (list[0].Status == StatusTask.Andamento)
            {
                list[0].Status = StatusTask.Concluida;
            }
            else
            {
                Console.WriteLine("Esse status não é valido, tente novamente");
            }
        }
    }
}
