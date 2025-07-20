using Csharp_Advanced.Enums;
using Csharp_Advanced.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Advanced.Classes
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role role { get; set; }

        public BasicAuthenticationService(string UserName, string Password, Role role)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.role = role;
        }

        public bool AuthenticateUser(string username, string password)
        {
            if (UserName == username &&  Password == password) 
                return true;
            return false;
        }

        public bool AuthorizeUser(string username, Role role)
        {
            if (UserName == username && this.role == role)
                return true;
            return false;
        }
    }
}
