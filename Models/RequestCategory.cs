using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class RequestCategory
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
