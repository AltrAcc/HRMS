using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Devicefetchlog
{
    public int Deviceeventid { get; set; }

    public string? Rollovercount { get; set; }

    public string? Seqno { get; set; }

    public DateTime? Date { get; set; }

    public TimeSpan? Time { get; set; }

    public string? Eventid { get; set; }

    public string? Detail1 { get; set; }

    public string? Detail2 { get; set; }

    public string? Detail3 { get; set; }

    public string? Detail4 { get; set; }

    public string? Detail5 { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
