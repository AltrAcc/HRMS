using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class NewPunchtime
{
    public int Punchtimeid { get; set; }

    public int? Employeeid { get; set; }

    public DateTime? Date { get; set; }

    public string? TimeIn { get; set; }

    public string? TimeOut { get; set; }

    public decimal? Totaltime { get; set; }

    public decimal? Totalactualtime { get; set; }

    public int Overtime { get; set; }

    public int Leavetype { get; set; }

    public int? Approveby { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
