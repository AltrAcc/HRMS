using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Apicronjob
{
    public int Apicronjobid { get; set; }

    public long? Apiuserid { get; set; }

    public string? Apitype { get; set; }

    public string? Api { get; set; }

    public string? ResponseCode { get; set; }

    public int? Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
