using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Payrundeduction
{
    public int Payrundeductionid { get; set; }

    public int? Payrunid { get; set; }

    public int? Employeeid { get; set; }

    public decimal? Grosspay { get; set; }

    public int? Absent { get; set; }

    public int? Ottime { get; set; }

    public decimal? Earning { get; set; }

    public decimal? Empesi { get; set; }

    public decimal? Empresi { get; set; }

    public decimal? Emppf { get; set; }

    public decimal? Emprpf { get; set; }

    public decimal? Empproftax { get; set; }

    public decimal? Deductionamt { get; set; }

    public decimal? Emiamt { get; set; }

    public decimal? Netpay { get; set; }

    public string Bonuscalculation { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
