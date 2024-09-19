using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Emaillog
{
    public int Logid { get; set; }

    public string Toemail { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public string Body { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
