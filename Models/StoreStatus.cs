using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class StoreStatus
{
    public int Id { get; set; }

    public string StoreStatusName { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
