using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class TemplateSkill
{
    public long Id { get; set; }

    public long TemplateId { get; set; }

    public long TopicId { get; set; }

    public string SkillName { get; set; } = null!;

    public string? TotalHours { get; set; }

    public string? Description { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
