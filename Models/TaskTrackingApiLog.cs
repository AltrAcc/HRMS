using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class TaskTrackingApiLog
{
    public long Id { get; set; }

    public long? UserId { get; set; }

    public string Message { get; set; } = null!;

    public string Context { get; set; } = null!;

    public string Level { get; set; } = null!;

    public string LevelName { get; set; } = null!;

    public string Channel { get; set; } = null!;

    public string RecordDatetime { get; set; } = null!;

    public string Extra { get; set; } = null!;

    public string Formatted { get; set; } = null!;

    public string? RemoteAddr { get; set; }

    public string? UserAgent { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
