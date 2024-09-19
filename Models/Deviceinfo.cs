using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Deviceinfo
{
    public int Deviceinfoid { get; set; }

    public string? Devicename { get; set; }

    public string? Devicecode { get; set; }

    public string? Ipaddress { get; set; }

    public int? Portno { get; set; }

    public string? Devicetype { get; set; }

    public string? Productname { get; set; }

    public string? Location { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Reader { get; set; }

    public string Status { get; set; } = null!;

    public int Main { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? CreatedAt { get; set; }
}
