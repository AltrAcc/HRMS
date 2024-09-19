using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Timerule
{
    public int Timeruleid { get; set; }

    public string? Timerule1 { get; set; }

    public string Withvalue { get; set; } = null!;

    public string? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
