using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Comment
{
    public long Id { get; set; }

    public long? CodeReviewid { get; set; }

    public int? Userid { get; set; }

    public string? Message { get; set; }

    public string? Reply { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
