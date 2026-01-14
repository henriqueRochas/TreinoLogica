using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinoLogico86.Domain;
using static TreinoLogico86.Domain.TaskManager;

namespace TreinoLogico86.Repositories
{
    internal class TestTaskRepository : ITaskRepository
    {
        List<TaskManager> taskList = new List<TaskManager>();
        public void Add()
        {
            taskList.AddRange(new List<TaskManager>
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
            return taskList;
        }

        public bool RemoveTask(int id)
        {
            var searchTask = SearchTask(id);
            if (searchTask == null)
            {
                return false;
            }
            else
            {
                taskList.Remove(searchTask);
                return true;
            }
        }

        public TaskManager SearchTask(int id)
        {
            var searchTask = taskList.FirstOrDefault(x => x.Id == id);
            if(searchTask == null)
            {
                return null;
            }
            else
            {
                return searchTask;
            }
        }

        public void UpdateTask(int id)
        {
            var seachTask = SearchTask(id);
            if (seachTask != null)
            {
                taskList[id] = seachTask;
            }
        }
    }
}
