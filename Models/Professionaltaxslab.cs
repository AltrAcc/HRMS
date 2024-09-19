using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Professionaltaxslab
{
    public int Professionaltaxslabsid { get; set; }

    public int? Worklocationid { get; set; }

    public int? Startrange { get; set; }

    public int? Endrange { get; set; }

    public int? Monthlytaxamount { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
