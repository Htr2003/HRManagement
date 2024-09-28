using HRManagement.IServices;
using HRManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HRManagement.Services
{
    public class LeaveRequestService : ILeaveRequestService
    {
        private readonly HrmanagementDbContext _context;

        public LeaveRequestService(HrmanagementDbContext context)
        {
            _context = context;
        }

        public async Task<List<LeaveRequest>> GetLeaveRequestsAsync()
        {
            return await _context.LeaveRequests.ToListAsync();
        }

        public async Task<LeaveRequest> CreateLeaveRequestAsync(LeaveRequest leaveRequest)
        {
            leaveRequest.Status = "Pending";
            _context.LeaveRequests.Add(leaveRequest);
            await _context.SaveChangesAsync();
            return leaveRequest;
        }

        public async Task<LeaveRequest> ApproveLeaveRequestAsync(int requestId)
        {
            var request = await _context.LeaveRequests.FindAsync(requestId);
            if (request != null)
            {
                request.Status = "Approved";
                await _context.SaveChangesAsync();
            }
            return request;
        }

        public async Task<LeaveRequest> RejectLeaveRequestAsync(int requestId)
        {
            var request = await _context.LeaveRequests.FindAsync(requestId);
            if (request != null)
            {
                request.Status = "Rejected";
                await _context.SaveChangesAsync();
            }
            return request;
        }
    }
}
