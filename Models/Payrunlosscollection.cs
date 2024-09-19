using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Payrunlosscollection
{
    public long Payrunlosscollectionid { get; set; }

    public int? Payrunid { get; set; }

    public int? Departmentid { get; set; }

    public string? Associatedemployeeid { get; set; }

    public decimal? Loss { get; set; }

    public decimal? Scrapjama { get; set; }

    public decimal? Ytdscrapjama { get; set; }

    public decimal? Ytdlosspending { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
