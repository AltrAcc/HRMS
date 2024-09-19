using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class ClientMaster
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string ClientName { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string? Email { get; set; }

    public string? Website { get; set; }

    public int Roleid { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zipcode { get; set; }

    public string? Country { get; set; }

    public string? Password { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
