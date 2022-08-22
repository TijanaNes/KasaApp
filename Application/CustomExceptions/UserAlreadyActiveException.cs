using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CustomExceptions
{
    public class UserAlreadyActiveException : BaseException
    {
        public UserAlreadyActiveException(string message) : base(message)
        {
        }
        public UserAlreadyActiveException()
        {

        }
    }
}
