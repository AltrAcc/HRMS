using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class MoodTracker
{
    public int MoodTrackerid { get; set; }

    public string? Mood { get; set; }

    public int? UserId { get; set; }

    public DateTime? MoodDate { get; set; }

    public string? Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
