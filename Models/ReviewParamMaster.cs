using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class ReviewParamMaster
{
    public int ReviewParamMasterId { get; set; }

    public string? ReviewParamName { get; set; }

    public decimal? Persantage { get; set; }

    public string? Comment { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
