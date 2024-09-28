using System;
using System.Collections.Generic;

namespace HRManagement.Models;

public partial class Payroll
{
    public int PayrollId { get; set; }

    public int EmployeeId { get; set; }

    public int Month { get; set; }

    public int Year { get; set; }

    public decimal Salary { get; set; }

    public decimal? Bonus { get; set; }

    public decimal? Deductions { get; set; }

    public decimal? TotalPayment { get; set; }

    public virtual Employee Employee { get; set; } = null!;
}
