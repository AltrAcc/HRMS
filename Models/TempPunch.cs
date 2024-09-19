using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class TempPunch
{
    public int TempPunchid { get; set; }

    public int? Punchtimeid { get; set; }

    public int? Emplyeeid { get; set; }

    public string? TimeIn { get; set; }

    public string? TimeOut { get; set; }

    public TimeSpan? BreakIn { get; set; }

    public TimeSpan? BreakOut { get; set; }

    public decimal? Totalworkingtime { get; set; }

    public string Status { get; set; } = null!;

    public int? Approveby { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
