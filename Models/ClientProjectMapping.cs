using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class ClientProjectMapping
{
    public int Id { get; set; }

    public int ClientId { get; set; }

    public int ProjectId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
