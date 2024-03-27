using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using System.Threading.Tasks;
using TaskManager.Communication.Collation;
using TaskManager.Communication.Enums;
using TaskManager.Communication.Response;

namespace TaskManager.Application.UseCase.TaskManager.Get;
public class GetAllTaskUseCase
{   
    public ResponseAllTaskJson Execute()
    {
        //var Tasks = CollationTaskDictionary.tasks.Values.ToList();        
        var Tasks = CollationTasks.tasks.Values;
        var ResponseTasks = new List<ResponseTaskJson>();

        foreach (var Task in Tasks)
        {
            ResponseTasks.Add(
                new ResponseTaskJson
                {
                    Id = Task.Id,
                    Name = Task.Name,
                    Description = Task.Description,
                    LimitDate = Task.LimitDate,
                    Priority = Task.Priority,
                    Status = Task.Status,
                }
            );
        }

        return new ResponseAllTaskJson
        {
            Tasks = ResponseTasks            
        };
    }
}
