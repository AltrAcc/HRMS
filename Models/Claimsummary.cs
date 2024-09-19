using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Claimsummary
{
    public int Claimsummaryid { get; set; }

    public int? Employeeid { get; set; }

    public DateTime? Claimdate { get; set; }

    public decimal? Claimamount { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
