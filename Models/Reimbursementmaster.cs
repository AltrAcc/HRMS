using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Reimbursementmaster
{
    public int Reimbursementmasterid { get; set; }

    public string? Name { get; set; }

    public string? Payslipname { get; set; }

    public string? Paytype { get; set; }

    public string? Amount { get; set; }

    public string? Balancecarrayforward { get; set; }

    public string? Status { get; set; }

    public int? Deleted { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
