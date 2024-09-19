using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Esi
{
    public int Esiid { get; set; }

    public string? Esinumber { get; set; }

    public string? Deductioncycle { get; set; }

    public int? Employeescontribution { get; set; }

    public int? Employercontribution { get; set; }

    public string? Inctc { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
