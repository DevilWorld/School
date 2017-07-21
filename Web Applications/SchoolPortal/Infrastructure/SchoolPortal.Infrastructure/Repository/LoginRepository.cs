using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolPortal.Domain.Model;

namespace SchoolPortal.Infrastructure.Repository
{
    public class LoginRepository
    {
        private readonly EFDataContext _context;

        public LoginRepository()
        {
            _context = new EFDataContext();
        }

        public User GetUser(User user)
        {
            return _context.Users
                    .SingleOrDefault(x => x.UserId == user.UserId && x.Password == user.Password);
        }
    }
}
