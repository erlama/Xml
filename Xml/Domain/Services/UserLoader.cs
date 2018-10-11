using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Xml.Domain.Services
{
    class UserLoader
    {
        //Hérna erum við að skapa listann sem að finns i Users.xml inní möppunni sem að verkefnið er í!
        public IList<User> LoadUsers()
        {
            var users = new List<User>();

            var doc = XDocument.Load("Users.xml");

            //Þetta er rótin af því sem að við höfum skapað sem að er í þessu falli Users.
            var root = doc.Root;

            //Þegar við höfum fundið rótina þá er hægt að bæta við rótina aðra elements sem að verður hérna username, password, role.
            //Muna bara sem að er mjög mikilvægt að username og það verður að vera eins skrifað hérna og það er í sjálfum fileinum.
            foreach (var elemnet in root.Elements())
            {
                var username = elemnet.Attribute("username").Value;
                var password = elemnet.Attribute("password").Value;
                var role = elemnet.Attribute("role").Value;

                users.Add(new User(username, password, role));

                //Console.WriteLine(elemnet);
                //Console.WriteLine();
            }

            return users;
        }
    }
}
