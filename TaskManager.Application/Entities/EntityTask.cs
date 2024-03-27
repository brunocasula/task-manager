using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Communication.Enums;

namespace TaskManager.Application.Entities;
public class EntityTask
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public TaskPrioriryType Priority { get; set; }
    public DateTime LimitDate { get; set; }
    public TaskStatusType Status { get; set; }
}
