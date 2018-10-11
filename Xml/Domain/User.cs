using System;
using System.Collections.Generic;
using System.Text;

namespace Xml.Domain
{
    class User
    {
        public string Username { get; }
        public string Password { get; }
        public string Role { get; }

        public User(string userName, string passWord, string role)
        {
            Username = userName;
            Password = passWord;
            Role = role;
        }
    }
}
