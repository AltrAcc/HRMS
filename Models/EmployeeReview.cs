using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class EmployeeReview
{
    public int EmployeeReviewId { get; set; }

    public int? Projectid { get; set; }

    public int? Mentorid { get; set; }

    public int? Buddyid { get; set; }

    public DateTime? Date { get; set; }

    public string Tagid { get; set; } = null!;

    public decimal? Param1Rating { get; set; }

    public string? Param1Comment { get; set; }

    public decimal? Param2Rating { get; set; }

    public string? Param2Comment { get; set; }

    public decimal? Param3Rating { get; set; }

    public string? Param3Comment { get; set; }

    public decimal? Param4Rating { get; set; }

    public string? Param4Comment { get; set; }

    public decimal? Param5Rating { get; set; }

    public string? Param5Comment { get; set; }

    public decimal? Param6Rating { get; set; }

    public string? Param6Comment { get; set; }

    public decimal? Param7Rating { get; set; }

    public string? Param7Comment { get; set; }

    public decimal? Param8Rating { get; set; }

    public string? Param8Comment { get; set; }

    public decimal? Param9Rating { get; set; }

    public string? Param9Comment { get; set; }

    public decimal? Param10Rating { get; set; }

    public string? Param10Comment { get; set; }

    public decimal? OverallRating { get; set; }

    public string? OverallComment { get; set; }

    public decimal? PrivateRating { get; set; }

    public string? PrivateComment { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
