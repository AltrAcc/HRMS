using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Earningmaster
{
    public int Earningmasterid { get; set; }

    public string? Name { get; set; }

    public string? Payslipname { get; set; }

    public string? Paytype { get; set; }

    public string? Calculationtype { get; set; }

    public int? Amount { get; set; }

    public decimal? Percentage { get; set; }

    public string? Status { get; set; }

    public int? Deleted { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
