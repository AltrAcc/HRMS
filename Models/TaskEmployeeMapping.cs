using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class TaskEmployeeMapping
{
    public int Id { get; set; }

    public int? TaskId { get; set; }

    public int? UserId { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
