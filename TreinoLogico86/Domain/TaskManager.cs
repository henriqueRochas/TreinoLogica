
namespace TreinoLogico86.Domain
{
    internal class TaskManager
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public StatusTask Status { get; set; }
        public List<string> HistoryTask { get; set; } = new List<string>();

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
}
