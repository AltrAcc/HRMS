using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Leavemaster
{
    public int Leavemasterid { get; set; }

    public string? Leavename { get; set; }

    public string? Nameinpayslip { get; set; }

    public string? Leaverepeat { get; set; }

    public double? Leavedays { get; set; }

    public string? AllowAfterTake { get; set; }

    public string AllowHalfLeave { get; set; } = null!;

    public string? Carryfoward { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
