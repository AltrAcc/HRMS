using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Payrolldepartment
{
    public int Payrolldepartmentid { get; set; }

    public string? Departmentname { get; set; }

    public string? Parentdepartment { get; set; }

    public string? Subdepartmentaction { get; set; }

    public string? Description { get; set; }

    public string? Status { get; set; }

    public int? Deleted { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
