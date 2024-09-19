using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class DeviceInformation
{
    public int DeviceId { get; set; }

    public string? DeviceName { get; set; }

    public string SerialNumber { get; set; } = null!;

    public string? DeviceIp { get; set; }

    public int DevicePort { get; set; }

    public string? WanIp { get; set; }

    public int WanPort { get; set; }

    public int ActionBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
