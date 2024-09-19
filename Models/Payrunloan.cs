using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Payrunloan
{
    public long Payrunloanid { get; set; }

    public int? Payrunid { get; set; }

    public int? Loanid { get; set; }

    public int? Employeeid { get; set; }

    public decimal? Remaingamount { get; set; }

    public decimal Emideductamt { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
