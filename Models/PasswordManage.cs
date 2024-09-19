using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class PasswordManage
{
    public int PasswordManageId { get; set; }

    public int? ProjectId { get; set; }

    public string? Header { get; set; }

    public string? Url { get; set; }

    public string? Password { get; set; }

    public string? User { get; set; }

    public string? Upload { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }
}
