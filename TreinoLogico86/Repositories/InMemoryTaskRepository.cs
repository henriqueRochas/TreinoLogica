
using TreinoLogico86.Domain;

using TreinoLogico86.Repositories;
using static TreinoLogico86.Domain.TaskManager;

namespace TreinoLogico86
{

    internal class InMemoryTaskRepository : ITaskRepository
    {
        List<TaskManager> listTask = new List<TaskManager>();


        public void Add()
        {
            listTask.AddRange(new List<TaskManager>
                {
                     new TaskManager() { Id = 1, Title = "Task 1", Status = StatusTask.Pending},
                     new TaskManager() { Id = 2, Title = "Task 2", Status = StatusTask.Pending},
                     new TaskManager() { Id = 3, Title = "Task 3", Status = StatusTask.Pending},
                     new TaskManager() { Id = 4, Title = "Task 4", Status = StatusTask.Completed},
                     new TaskManager() { Id = 5, Title = "Task 5", Status = StatusTask.Progress},
                     new TaskManager() { Id = 6, Title = "Task 6", Status = StatusTask.Pending},
                     new TaskManager() { Id = 7, Title = "Task 7", Status = StatusTask.Completed},
                     new TaskManager() { Id = 8, Title = "Task 8", Status = StatusTask.Completed},
                     new TaskManager() { Id = 9, Title = "Task 9", Status = StatusTask.Progress}
                });
        }

        public List<TaskManager> ListTask()
        {
            return listTask;
        }

        public bool RemoveTask(int id)
        {
            var resultSearch = SearchTask(id);

            if (resultSearch == null)
            {
                return false;
            }
            else
            {
               listTask.Remove(resultSearch);
               return true;
            }
        }

        public TaskManager SearchTask(int id)
        {
            var search = listTask.FirstOrDefault(a => a.Id == id);

            if (search != null)
            {
                return search;
            }
            else
            {
                return null;
            }
        }

        public void UpdateTask()
        {
            throw new NotImplementedException();
        }

        public void UpdateTask(int id)
        {
            throw new NotImplementedException();
        }
    }
}
