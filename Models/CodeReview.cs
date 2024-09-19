using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class CodeReview
{
    public long Id { get; set; }

    public int? Projectid { get; set; }

    /// <summary>
    /// user_id
    /// </summary>
    public int? Mentorid { get; set; }

    /// <summary>
    /// emp_id
    /// </summary>
    public int? Buddyid { get; set; }

    public string? CodeDescription { get; set; }

    public string? CodeImage { get; set; }

    public string? Tagid { get; set; }

    public decimal? Rating { get; set; }

    public string? StartText { get; set; }

    public string? StopText { get; set; }

    public string? ContinueText { get; set; }

    public string? ReviewStatus { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
