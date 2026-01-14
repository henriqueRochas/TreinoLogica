
using TreinoLogico85.Domain;

namespace TreinoLogico85.Repositories
{
    internal interface ITaskRepository
    {
        void Add();
        List<TaskManager> ListTask();
        TaskManager SearchTask(int id);
        bool RemoveTask(int id);
    }
}
