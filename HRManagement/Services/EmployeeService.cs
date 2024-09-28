using HRManagement.IServices;
using HRManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HRManagement.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HrmanagementDbContext _context;

        public EmployeeService(HrmanagementDbContext context)
        {
            _context = context;
        }

        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            return await _context.Employees.FindAsync(id);
        }
    }
}
