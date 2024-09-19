using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Billmaster
{
    public int Billmasterid { get; set; }

    public string? Name { get; set; }

    public string? Billno { get; set; }

    public DateTime? Purchasedate { get; set; }

    public string? Contactdetail { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
