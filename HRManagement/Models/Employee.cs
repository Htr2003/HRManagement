using System;
using System.Collections.Generic;

namespace HRManagement.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Department { get; set; }

    public string? Position { get; set; }

    public DateOnly DateOfJoining { get; set; }

    public int? UserId { get; set; }

    public virtual ICollection<LeaveRequest> LeaveRequests { get; set; } = new List<LeaveRequest>();

    public virtual ICollection<Payroll> Payrolls { get; set; } = new List<Payroll>();

    public virtual User? User { get; set; }
}
