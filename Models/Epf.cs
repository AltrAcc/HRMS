using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Epf
{
    public int Epfid { get; set; }

    public string? Epfnumber { get; set; }

    public string? Deductioncycle { get; set; }

    public string? Employerscontribution { get; set; }

    public string? Employeescontribution { get; set; }

    public string? Inctc { get; set; }

    public string? Contributionrate { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
