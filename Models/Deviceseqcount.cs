using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Deviceseqcount
{
    public int Deviceseqcountid { get; set; }

    public int Deviceid { get; set; }

    public int? Rollovercount { get; set; }

    public int? Seqno { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
