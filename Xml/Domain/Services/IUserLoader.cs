using System;
using System.Collections.Generic;
using System.Text;

namespace Xml.Domain.Services
{
     interface IUserLoader
     {
         List<User> LoadUsers();
     }
    
}
