﻿using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Employeesalarytemplatedetail
{
    public long Employeesalarytemplatedetailid { get; set; }

    public long? Employeesalarytemplateid { get; set; }

    public string? Type { get; set; }

    public string? Salarycomponent { get; set; }

    public string? Calculationtype { get; set; }

    public string? Amtmonthly { get; set; }

    public string? Amtannually { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
