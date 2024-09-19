using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Employeesalarytemplate
{
    public int Employeesalarytemplateid { get; set; }

    public int? Employeeid { get; set; }

    public int? Salarytemplateid { get; set; }

    public long? Salary { get; set; }

    public int? Perfomancebonus { get; set; }

    public int? Totalctcmonthly { get; set; }

    public int? Totalctcannually { get; set; }

    public string? Status { get; set; }

    public int? Deleted { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
