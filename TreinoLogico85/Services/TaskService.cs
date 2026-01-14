using TreinoLogico85.Domain;
using TreinoLogico85.Repositories;
using static TreinoLogico85.Domain.TaskManager;

namespace TreinoLogico85.Services
{
    internal class TaskService
    {
        private ITaskRepository IRepository { get; set; }

        public TaskService(ITaskRepository iRepository)
        {
            IRepository = iRepository;
        }

        public void CreatedTask()
        {
            IRepository.Add();
        }

        public List<TaskManager> ListTask()
        {
            return IRepository.ListTask();
        }



        public TaskManager SearchTask(int id)
        {
            return IRepository.SearchTask(id);
        }

        public bool ChangeStatus(int id)
        {
            var resultSearch = SearchTask(id);

            if (resultSearch == null)
            {
                return false;
            }
            else
            {
                if (resultSearch.Status == StatusTask.Pending)
                {
                    resultSearch.Status = StatusTask.Progress;
                    resultSearch.HistoryTask.Add("Task Progress");
                    return true;
                }
                else if (resultSearch.Status == StatusTask.Progress)
                {
                    resultSearch.Status = StatusTask.Completed;
                    resultSearch.HistoryTask.Add("Task Completed");
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool RemoveTasks(int id)
        {
           return IRepository.RemoveTask(id);
            
        }
        public List<string> HistoryTask(int id)
        {
            var resultSearch = SearchTask(id);
            if (resultSearch != null)
            {
                return resultSearch.HistoryTask;
            }
            else
            {
                return new List<string>();
            }

        }

        public IEnumerable<TaskManager> FilterTask()
        {
            var filterStatusTask1 = IRepository.ListTask()
            .Where(i => i.Status == StatusTask.Pending || i.Status == StatusTask.Completed || i.Status == StatusTask.Progress);

            return filterStatusTask1;

        }
    }
}
