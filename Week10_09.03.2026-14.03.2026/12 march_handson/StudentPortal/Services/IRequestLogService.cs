using StudentPortal.Models;
using System.Collections.Generic;

namespace StudentPortal.Services
{
    public interface IRequestLogService
    {
        void AddLog(RequestLog log);

        List<RequestLog> GetLogs();
    }
}