
namespace TreinoLogico76
{
    internal class Program
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public StatusTask Status { get; set; }

        public enum StatusTask
        {
            Pendente,
            Andamento,
            Concluido
        }
        static void Main(string[] args)
        {
           List<Program> list = new List<Program>();
            list.Add(new Program() { Id = 1, Titulo = "Tarefa 1",  Status = StatusTask.Pendente });
            list.Add(new Program() { Id = 2, Titulo = "Tarefa 2",  Status = StatusTask.Concluido });
            list.Add(new Program() { Id = 3, Titulo = "Tarefa 3",  Status = StatusTask.Andamento });

            foreach (var item in list)
            {
                Console.WriteLine($"Id {item.Id} Titulo {item.Titulo} Status {item.Status}");
            }
        }
    }
}
