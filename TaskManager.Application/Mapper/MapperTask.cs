using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Application.Entities;
using TaskManager.Communication.Request;

namespace TaskManager.Application.Mapper;
public static class MapperTask
{
    public static EntityTask MapToEntityTask(RequestTaskJson request)
    {
        return new EntityTask
        {
            //Id = request.Id,
            Name = request.Name,
            Description = request.Description,
            LimitDate = request.LimitDate,
            Priority = request.Priority,
            Status = request.Status,
        };
    }
}
