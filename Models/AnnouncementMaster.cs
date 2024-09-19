using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class AnnouncementMaster
{
    public long Id { get; set; }

    public string? Title { get; set; }

    public string? Detail { get; set; }

    public string? File { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
