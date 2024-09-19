using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Pterm
{
    public int Ptermsid { get; set; }

    public string Ptermsname { get; set; } = null!;

    public string Isdefault { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
