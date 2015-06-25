using School.Domain.Interfaces;

namespace School.Domain.Services
{
    internal class Login : ILogin
    {
        public bool Validate(string userName, string password)
        {
            return true;
        }
    }
}
