
using TreinoLogico86.Domain;

namespace TreinoLogico86.Repositories
{
    internal interface ITaskRepository
    {
        void Add();
        List<TaskManager> ListTask();
        TaskManager SearchTask(int id);
        bool RemoveTask(int id);
        void UpdateTask(int id);
    }
}
