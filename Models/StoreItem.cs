using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class StoreItem
{
    public int Id { get; set; }

    public int? StoreCategoryId { get; set; }

    public string? StoreItemName { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
