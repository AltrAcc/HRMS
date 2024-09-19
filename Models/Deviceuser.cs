using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Deviceuser
{
    public long Deviceusersid { get; set; }

    public long Employeeid { get; set; }

    public int Deviceinfoid { get; set; }

    public string Devicestatus { get; set; } = null!;

    public DateTime? Expirydate { get; set; }

    public string Uploadfptemplate { get; set; } = null!;

    public string? Enrollcardno { get; set; }

    public int Enroll { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
