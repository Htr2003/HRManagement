using HRManagement.IServices;
using HRManagement.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LeaveRequestController : ControllerBase
    {
        private readonly ILeaveRequestService _leaveRequestService;

        public LeaveRequestController(ILeaveRequestService leaveRequestService)
        {
            _leaveRequestService = leaveRequestService;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<List<LeaveRequest>>> GetLeaveRequests()
        {
            var requests = await _leaveRequestService.GetLeaveRequestsAsync();
            return Ok(requests);
        }

        [HttpPost]
        public async Task<ActionResult<LeaveRequest>> CreateLeaveRequest(LeaveRequest leaveRequest)
        {
            var createdRequest = await _leaveRequestService.CreateLeaveRequestAsync(leaveRequest);
            return CreatedAtAction(nameof(GetLeaveRequests), new { id = createdRequest.LeaveRequestId }, createdRequest);
        }

        [HttpPut("{id}/approve")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<LeaveRequest>> ApproveLeaveRequest(int id)
        {
            var approvedRequest = await _leaveRequestService.ApproveLeaveRequestAsync(id);
            if (approvedRequest == null)
                return NotFound();
            return Ok(approvedRequest);
        }

        [HttpPut("{id}/reject")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<LeaveRequest>> RejectLeaveRequest(int id)
        {
            var rejectedRequest = await _leaveRequestService.RejectLeaveRequestAsync(id);
            if (rejectedRequest == null)
                return NotFound();
            return Ok(rejectedRequest);
        }
    }
}
