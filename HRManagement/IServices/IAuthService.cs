﻿namespace HRManagement.IServices
{
    public interface IAuthService
    {
        Task<string> LoginAsync(string username, string password);
    }
}
