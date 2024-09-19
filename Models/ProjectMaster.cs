using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class ProjectMaster
{
    public int Id { get; set; }

    public string ProjectName { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string ProjectStatus { get; set; } = null!;
}
