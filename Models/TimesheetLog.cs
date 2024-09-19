using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class TimesheetLog
{
    public long Id { get; set; }

    public string? Module { get; set; }

    public int? ModuleId { get; set; }

    public string? TrackingId { get; set; }

    public string? Action { get; set; }

    public string? BeforeAction { get; set; }

    public string? AfterAction { get; set; }

    public string? Other { get; set; }

    public int? UserId { get; set; }

    public DateTime? Sented { get; set; }

    public DateTime? Delivered { get; set; }

    public DateTime? Readed { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
