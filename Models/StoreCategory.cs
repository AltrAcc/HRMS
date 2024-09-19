using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class StoreCategory
{
    public int Id { get; set; }

    public string? StoreCategoryName { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
