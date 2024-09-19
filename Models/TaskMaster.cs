using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class TaskMaster
{
    public int Id { get; set; }

    public int? ProjectId { get; set; }

    public string? Ticketid { get; set; }

    public string TaskName { get; set; } = null!;

    public DateTime? StartDate { get; set; }

    public DateTime? DueDate { get; set; }

    public string? TagId { get; set; }

    public string? Priority { get; set; }

    public string? TaskStatus { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
