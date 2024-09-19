using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Punchtime
{
    public int Punchtimeid { get; set; }

    public int? Employeeid { get; set; }

    public DateTime? Date { get; set; }

    public TimeSpan? TimeIn { get; set; }

    public TimeSpan? TimeOut { get; set; }

    public decimal? Totaltime { get; set; }

    public TimeSpan? ActualtimeIn { get; set; }

    public TimeSpan? ActualtimeOut { get; set; }

    public decimal? Totalactualtime { get; set; }

    public TimeSpan? BreakIn { get; set; }

    public TimeSpan? BreakOut { get; set; }

    public decimal? Totalbreak { get; set; }

    public decimal? Latepunchtime { get; set; }

    public decimal? Earlypunchtime { get; set; }

    public decimal? Totalworkingtime { get; set; }

    public decimal? Overtime { get; set; }

    /// <summary>
    /// 1-weekend,2-leave
    /// </summary>
    public int Leavetype { get; set; }

    public string Status { get; set; } = null!;

    public int? Editedby { get; set; }

    public int? Approveby { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
