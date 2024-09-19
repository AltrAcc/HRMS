using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class TemplateMaster
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string? OptedBadge { get; set; }

    public string? CompletedBadge { get; set; }

    public string? CreatedBy { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
