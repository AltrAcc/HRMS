using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Fptemplate
{
    public int Fptemplateid { get; set; }

    public byte[]? Fptemplate1 { get; set; }

    public int Employeeid { get; set; }

    public int? Fingercount { get; set; }

    public string? Hand { get; set; }

    public string? Finger { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
