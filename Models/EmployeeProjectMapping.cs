using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class EmployeeProjectMapping
{
    public int Id { get; set; }

    public int ProjectId { get; set; }

    public int EmpId { get; set; }

    public int CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
