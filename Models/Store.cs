using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Store
{
    public int StoreId { get; set; }

    public int? StoreCategoryId { get; set; }

    public int? StoreItemId { get; set; }

    public string? Uniqueno { get; set; }

    public DateTime? PurchaseDate { get; set; }

    public string? SupplierName { get; set; }

    public string? Warranty { get; set; }

    public decimal? Price { get; set; }

    public string? Type { get; set; }

    public int? StoreStatus { get; set; }

    public string? Assignto { get; set; }

    public int? AssignEmployee { get; set; }

    public string? AssignOther { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
