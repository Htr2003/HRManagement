using HRManagement.Models;

namespace HRManagement.IServices
{
    public interface IPayrollService
    {
        Task<List<Payroll>> GetPayrollsAsync();
        Task<Payroll> CreatePayrollAsync(Payroll payroll);
    }
}
