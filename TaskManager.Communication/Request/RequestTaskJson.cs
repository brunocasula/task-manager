﻿using TaskManager.Communication.Enums;

namespace TaskManager.Communication.Request;
public class RequestTaskJson
{
    //public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public TaskPrioriryType Priority { get; set; }
    public DateTime LimitDate { get; set; }
    public TaskStatusType Status { get; set; }
}
