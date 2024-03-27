using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Communication.Collation;
using TaskManager.Communication.Response;

namespace TaskManager.Application.UseCase.TaskManager.GetById;
public class GetByIdTaskUseCase
{    
    public ResponseTaskJson? Execute(int Id)
    {
        var response = CollationTasks.GetById(Id);

        if (response != null)
        {
            return new ResponseTaskJson
            {
                Id = response.Id,
                Name = response.Name,
                Description = response.Description,
                LimitDate = response.LimitDate,
                Priority = response.Priority,
                Status = response.Status,
            };            
        }

        return null;        
    }
}
