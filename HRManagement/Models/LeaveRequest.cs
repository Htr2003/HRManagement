using System;
using System.Collections.Generic;

namespace HRManagement.Models;

public partial class LeaveRequest
{
    public int LeaveRequestId { get; set; }

    public int EmployeeId { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public string? Reason { get; set; }

    public string Status { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;
}
