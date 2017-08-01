using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolPortal.Domain.Model;

namespace SchoolPortal.Domain.Interfaces.Repository
{
    public interface IUserRepository
    {
        bool IsUserExists(string userName);
        User GetUser(User user);
    }
}
