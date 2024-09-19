using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class EmployeeReviewerMapping
{
    public int Id { get; set; }

    public int ReviewerId { get; set; }

    public int EmpId { get; set; }

    public int? ReviewCount { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
