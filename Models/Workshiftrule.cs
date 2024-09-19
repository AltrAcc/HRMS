using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Workshiftrule
{
    public int Workshiftruleid { get; set; }

    public int? Workshiftid { get; set; }

    public int? Ruleid { get; set; }

    public string? Value { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
