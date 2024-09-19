using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class EmployeeSkillsetMapping
{
    public long Id { get; set; }

    public long TemplateId { get; set; }

    public long? TopicId { get; set; }

    public long SkillsId { get; set; }

    public int EmpId { get; set; }

    public long? TaskId { get; set; }

    public long Approver { get; set; }

    public string? Comment { get; set; }

    public string? SubmitComment { get; set; }

    public decimal? Rating { get; set; }

    public bool CompletedStatus { get; set; }

    public string SubmitForApproval { get; set; } = null!;

    public DateTime? SubmitForApprovalAt { get; set; }

    public DateTime? ApprovedAt { get; set; }

    public string? TimeTaken { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
