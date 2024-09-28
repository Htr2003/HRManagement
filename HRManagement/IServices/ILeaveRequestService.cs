using HRManagement.Models;

namespace HRManagement.IServices
{
    public interface ILeaveRequestService
    {
        Task<List<LeaveRequest>> GetLeaveRequestsAsync();
        Task<LeaveRequest> CreateLeaveRequestAsync(LeaveRequest leaveRequest);
        Task<LeaveRequest> ApproveLeaveRequestAsync(int requestId);
        Task<LeaveRequest> RejectLeaveRequestAsync(int requestId);
    }
}
