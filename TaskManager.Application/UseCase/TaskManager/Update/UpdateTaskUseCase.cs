using TaskManager.Application.Entities;
using TaskManager.Application.Mapper;
using TaskManager.Communication.Collation;
using TaskManager.Communication.Request;

namespace TaskManager.Application.UseCase.TaskManager.Update;
public class UpdateTaskUseCase
{
    public void Execute(int id, RequestTaskJson request)
    {
        EntityTask task = MapperTask.MapToEntityTask(request);

        CollationTasks.Update(task);
    }
}
