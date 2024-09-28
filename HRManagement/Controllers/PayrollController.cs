using HRManagement.IServices;
using HRManagement.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PayrollController : ControllerBase
    {
        private readonly IPayrollService _payrollService;

        public PayrollController(IPayrollService payrollService)
        {
            _payrollService = payrollService;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<List<Payroll>>> GetPayrolls()
        {
            var payrolls = await _payrollService.GetPayrollsAsync();
            return Ok(payrolls);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Payroll>> CreatePayroll(Payroll payroll)
        {
            var createdPayroll = await _payrollService.CreatePayrollAsync(payroll);
            return CreatedAtAction(nameof(GetPayrolls), new { id = createdPayroll.PayrollId }, createdPayroll);
        }
    }
}
