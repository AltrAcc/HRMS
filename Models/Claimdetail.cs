using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Claimdetail
{
    public int Claimdetailid { get; set; }

    public int? Claimsummaryid { get; set; }

    public int? Reimbursementid { get; set; }

    public DateTime? Billdate { get; set; }

    public string? Billno { get; set; }

    public string? Vendor { get; set; }

    public string? Remarks { get; set; }

    public decimal? Amount { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
