using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Workshift
{
    public int Workshiftid { get; set; }

    public string? Workshiftname { get; set; }

    public DateTime? Applicabledate { get; set; }

    public TimeSpan? InTime { get; set; }

    public TimeSpan? OutTime { get; set; }

    public string? Weeklyoff { get; set; }

    public string? OtType { get; set; }

    public string? Remarks { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
