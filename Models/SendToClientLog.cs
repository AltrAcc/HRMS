using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class SendToClientLog
{
    public int Id { get; set; }

    public int? Clientid { get; set; }

    public int? Leaveid { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
