using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Employeelog
{
    public long Emplogid { get; set; }

    public long Userid { get; set; }

    public DateTime? Punchdate { get; set; }

    public TimeSpan? Checkin { get; set; }

    public TimeSpan? Checkout { get; set; }

    public long Actionby { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
