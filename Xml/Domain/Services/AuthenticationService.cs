using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xml.Domain.Services
{
    class AuthenticationService : IAuthenticationService
    {
        private readonly IUserLoader _userLoader;

        public AuthenticationService()
        {
            _userLoader = new UserLoader();
        }

        public User Authenticate(string username, string password)
        {
            var users = _userLoader.LoadUsers();

            return users.FirstOrDefault(x => x.Username == username && x.Password == password);
        }
    }
}
