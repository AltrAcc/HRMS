using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class LogOfTemplateApproval
{
    public long Id { get; set; }

    public long TemplateId { get; set; }

    public long SkillsId { get; set; }

    public long TopicId { get; set; }

    public long Approver { get; set; }

    public long EmpId { get; set; }

    public long EmpSkillsetMappingId { get; set; }

    public string SubmitForApproval { get; set; } = null!;

    public string Comment { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
