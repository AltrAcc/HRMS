using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Salarytemplatesummary
{
    public long Salarytemplatesummaryid { get; set; }

    public string? Templatename { get; set; }

    public string? Description { get; set; }

    public long? Totalctcmonthly { get; set; }

    public long? Totalctcannually { get; set; }

    public string? Status { get; set; }

    public int? Deleted { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
