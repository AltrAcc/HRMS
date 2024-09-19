using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class TagMaster
{
    public int Id { get; set; }

    public string TagName { get; set; } = null!;

    public string? Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
