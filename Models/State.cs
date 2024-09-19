using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class State
{
    public int Stateid { get; set; }

    public string Statename { get; set; } = null!;

    public string Gstcode { get; set; } = null!;

    public int CountryId { get; set; }
}
