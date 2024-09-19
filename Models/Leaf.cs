using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Leaf
{
    public int Leaveid { get; set; }

    public int? Employeeid { get; set; }

    public int? Leavetype { get; set; }

    public DateTime? Leavedate { get; set; }

    public double? Remainleave { get; set; }

    public DateTime? Leavefromdate { get; set; }

    public DateTime? Leavetodate { get; set; }

    public double? Totalleave { get; set; }

    public string? Reason { get; set; }

    public string? HalfTime { get; set; }

    public string? ClientRemarks { get; set; }

    public string LeaveStatus { get; set; } = null!;

    public int? FlagId { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
