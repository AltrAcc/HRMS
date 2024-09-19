using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class TimeTracking
{
    public long Id { get; set; }

    public int? UserId { get; set; }

    public int? ProjectId { get; set; }

    public int? TaskId { get; set; }

    public decimal? TotalTime { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? StopTime { get; set; }

    public string? Comment { get; set; }

    public string TrackingStatus { get; set; } = null!;

    public string Status { get; set; } = null!;

    public int? EditedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
