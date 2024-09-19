using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class EmpOtherDocument
{
    public int Id { get; set; }

    public int EmpId { get; set; }

    public string? OtherDoc { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
