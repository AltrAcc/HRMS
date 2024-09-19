using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class DeviceStatus
{
    public long DeviceStatus1 { get; set; }

    public string? Ip { get; set; }

    public string? Status { get; set; }

    public string? Extra { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
