using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Roledetail
{
    public int Roledetailid { get; set; }

    public int? Rolemasterid { get; set; }

    public string? Type { get; set; }

    public string? Permissionname { get; set; }

    public string? Fullaccess { get; set; }

    public string? View { get; set; }

    public string? CreatePermission { get; set; }

    public string? EditPermission { get; set; }

    public string? DeletePermission { get; set; }

    public string? Approve { get; set; }

    public string? Assigncrm { get; set; }

    public string? Pay { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
