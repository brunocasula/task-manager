using System.Threading.Tasks;
using TaskManager.Application.Entities;
using TaskManager.Communication.Request;

namespace TaskManager.Communication.Collation;
public static class CollationTasks
{
    public static Dictionary<int, EntityTask> tasks = [];

    public static List<EntityTask> GetAll()
    {
        return tasks.Values.ToList();
    }

    public static void Add(EntityTask task)
    {   
        task.Id = tasks.Keys.Count + 1;
        tasks.Add(task.Id, task);
    }

    public static EntityTask? GetById(int Id)
    {
        if (tasks.ContainsKey(Id))
        {
            return tasks[Id];
        }

        return null;
    }

    public static void Update(EntityTask task)
    {
        if (tasks.ContainsKey(task.Id))
        {
            tasks.Remove(task.Id);
            tasks.Add(task.Id, task);
        }
    }
    public static void Delete(int id)
    {
        if (tasks.ContainsKey(id))
        {
            tasks.Remove(id);
        }        
    }
}
