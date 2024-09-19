using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Loan
{
    public int Loanid { get; set; }

    public int? Employeeid { get; set; }

    public double? Loanamount { get; set; }

    public DateTime? Disbursementdate { get; set; }

    public string? Reason { get; set; }

    public DateTime EmiStartdate { get; set; }

    public double? EmiAmount { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
