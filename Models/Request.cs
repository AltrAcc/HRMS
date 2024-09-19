using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Request
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public DateTime Date { get; set; }

    public int CategoryId { get; set; }

    public string? Description { get; set; }

    public int Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }
}
