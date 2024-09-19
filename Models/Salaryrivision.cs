using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Salaryrivision
{
    public int Salaryrivisionid { get; set; }

    public int? Employeeid { get; set; }

    public int? Salarytemplateid { get; set; }

    public string? Salaryrevisiontype { get; set; }

    public decimal? Oldamount { get; set; }

    public decimal? Newamount { get; set; }

    public decimal? Percentage { get; set; }

    public DateTime? Effectfromdate { get; set; }

    public DateTime? Payoutmonth { get; set; }

    public decimal? Totalctcmonthly { get; set; }

    public decimal? Totalctcannually { get; set; }

    public string? Salaryrivisionstatus { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
