using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Worklocation
{
    public int Worklocationsid { get; set; }

    public string? Locationname { get; set; }

    public string? Contactperson { get; set; }

    public string? Mobileno { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? Pincode { get; set; }

    public string? State { get; set; }

    public string? Ptnumber { get; set; }

    public string? Deductioncycle { get; set; }

    public string? Landlinenumbercode { get; set; }

    public string? Landlinenumber { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
