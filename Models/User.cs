using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class User
{
    public long Id { get; set; }

    public int? Roleid { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime? EmailVerifiedAt { get; set; }

    public string Password { get; set; } = null!;

    public string? TnC { get; set; }

    public string? RememberToken { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
