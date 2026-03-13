using StudentPortal1.Services;

namespace StudentPortal1.Services
{
    public class AuthService : IAuthService
    {
        public bool IsAuthenticated()
        {
            return false;
        }
    }
}