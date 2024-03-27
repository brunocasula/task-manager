using System.Threading.Tasks;
using TaskManager.Application.Entities;
using TaskManager.Application.Mapper;
using TaskManager.Communication.Collation;
using TaskManager.Communication.Request;
using TaskManager.Communication.Response;

namespace TaskManager.Application.UseCase.TaskManager.Create;
public class CreateTaskUseCase
{   
    public ResponseTaskCreateJson Execute(RequestTaskJson request)
    {
        EntityTask task = MapperTask.MapToEntityTask(request);

        CollationTasks.Add(task);
        
        return new ResponseTaskCreateJson
        {
            Id = task.Id,
            Name = task.Name,
        };
    }
}
