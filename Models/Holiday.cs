using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Holiday
{
    public int Holidaysid { get; set; }

    public int? Month { get; set; }

    public int? Calendardays { get; set; }

    public string? Holidaysdate { get; set; }

    public int? Totalholidays { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
