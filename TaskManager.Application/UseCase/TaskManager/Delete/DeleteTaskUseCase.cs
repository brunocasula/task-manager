using System.Threading.Tasks;
using TaskManager.Communication.Collation;

namespace TaskManager.Application.UseCase.TaskManager.Delete;
public class DeleteTaskUseCase
{
    public void Execute(int Id)
    {        
        CollationTasks.Delete(Id);
    }
}
