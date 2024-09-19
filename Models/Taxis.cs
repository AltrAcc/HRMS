using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Taxis
{
    public int Taxesid { get; set; }

    public string? Panno { get; set; }

    public string? Tanno { get; set; }

    public string? TdsAoCode { get; set; }

    public string? Taxpaymentmode { get; set; }

    public string? Taxdeductorname { get; set; }

    public string? Taxdeductorfathername { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
