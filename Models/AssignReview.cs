using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class AssignReview
{
    public int Id { get; set; }

    public int? EmpId { get; set; }

    public DateTime? Date { get; set; }

    public int? ReviewCount { get; set; }

    public int? TotalReview { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
