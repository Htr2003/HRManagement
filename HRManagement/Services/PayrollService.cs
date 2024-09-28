using HRManagement.IServices;
using HRManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HRManagement.Services
{
    public class PayrollService : IPayrollService
    {
        private readonly HrmanagementDbContext _context;

        public PayrollService(HrmanagementDbContext context)
        {
            _context = context;
        }

        public async Task<List<Payroll>> GetPayrollsAsync()
        {
            return await _context.Payrolls.ToListAsync();
        }

        public async Task<Payroll> CreatePayrollAsync(Payroll payroll)
        {
            _context.Payrolls.Add(payroll);
            await _context.SaveChangesAsync();
            return payroll;
        }
    }
}
