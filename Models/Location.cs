using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Location
{
    public long Id { get; set; }

    public string? Locationname { get; set; }

    public string? Extra { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
