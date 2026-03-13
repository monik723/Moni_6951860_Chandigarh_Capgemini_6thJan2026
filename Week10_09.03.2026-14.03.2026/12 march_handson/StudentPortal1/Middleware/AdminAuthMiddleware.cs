using Microsoft.AspNetCore.Http;
using StudentPortal1.Services;
using System.Threading.Tasks;

namespace StudentPortal1.Middleware
{
    public class AdminAuthMiddleware
    {
        private readonly RequestDelegate _next;

        public AdminAuthMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, IAuthService authService)
        {
            if (context.Request.Path.StartsWithSegments("/Admin"))
            {
                if (!authService.IsAuthenticated())
                {
                    context.Response.StatusCode = 401;
                    await context.Response.WriteAsync("Unauthorized Access");
                    return;
                }
            }

            await _next(context);
        }
    }
}