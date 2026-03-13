using Microsoft.AspNetCore.Http;
using StudentPortal.Models;
using StudentPortal.Services;
using System.Diagnostics;
using System.Threading.Tasks;

namespace StudentPortal.Middleware
{
    public class RequestTrackingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IRequestLogService _logService;

        public RequestTrackingMiddleware(RequestDelegate next, IRequestLogService logService)
        {
            _next = next;
            _logService = logService;
        }

        public async Task Invoke(HttpContext context)
        {
            var stopwatch = Stopwatch.StartNew();

            await _next(context);

            stopwatch.Stop();

            var log = new RequestLog
            {
                Url = context.Request.Path,
                ExecutionTime = stopwatch.ElapsedMilliseconds
            };

            _logService.AddLog(log);
        }
    }
}