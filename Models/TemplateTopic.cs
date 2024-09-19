using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class TemplateTopic
{
    public long Id { get; set; }

    public long TemplateId { get; set; }

    public string Name { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
