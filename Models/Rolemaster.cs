using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Rolemaster
{
    public int Rolemasterid { get; set; }

    public string? Rolename { get; set; }

    public string? Discription { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
