using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Payrunpayment
{
    public int Parunpaymentid { get; set; }

    public int? Payrunid { get; set; }

    public int? Employeeid { get; set; }

    public decimal? Grosspay { get; set; }

    public int? Absent { get; set; }

    public decimal? Ottime { get; set; }

    public decimal? Netpay { get; set; }

    public string? Mode { get; set; }

    public string Bankname { get; set; } = null!;

    public decimal? Amount { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
