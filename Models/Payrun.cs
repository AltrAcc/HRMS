using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Payrun
{
    public int Payrunid { get; set; }

    public DateTime? Payrunmonth { get; set; }

    public string? Payrunstatus { get; set; }

    public int? Totalemployee { get; set; }

    public int? Workingdays { get; set; }

    public decimal? Employeesnetpay { get; set; }

    public decimal? Totaldeduction { get; set; }

    public decimal? Totalcontribution { get; set; }

    public decimal? Totalpayrollcost { get; set; }

    public string Actionleaves { get; set; } = null!;

    public string Actionloss { get; set; } = null!;

    public string Actionloan { get; set; } = null!;

    public string Actiondeduction { get; set; } = null!;

    public string Actionbonus { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
