using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Payrunleaf
{
    public long Payrunleaveid { get; set; }

    public int? Payrunid { get; set; }

    public int? Employeeid { get; set; }

    public string? Punchstatus { get; set; }

    public int? Calanderdays { get; set; }

    public int? Workingdays { get; set; }

    public int? Holidays { get; set; }

    public int? Absent { get; set; }

    public int? Overtime { get; set; }

    public string? Overtimeadjustment { get; set; }

    public int? Payabledays { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
