using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Interfaces
{
    interface ILogin
    {
        bool Validate(string userName, string password);
    }
}
