using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Xml.Domain;
using Xml.Domain.Services;

namespace Xml
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nýja xml er XElement og er það þetta project. Gamla er XmlElement, dæmi um það er í ConasoleApp5 project!
            //Allir users eru skráðir inn í doc sem að við bjuggum til sjálf og er sparað inní debug hlutan af file eða þar sem að verkefnið er!
            //Þannig að ef að ég bæti við örðum user í það skjal þá getur sú manneksja loggað inn.

            //Hérna skrifum við út i consolen og með því að nota write ekki writeLine þá skrifarðu strax eftir username:
            Console.Write(" Username: ");
            string username = Console.ReadLine();

            Console.Write(" Password: ");
            string password = Console.ReadLine();

            var authenticationService = new AuthenticationService();

            var user = authenticationService.Authenticate(username, password);

            //Hérna er verið að athuga hvort að þessi user er nú þegar skráður inn ef ekki þá gekk ekki að skrá þig inn!
            if (user != null)
            {
                Console.WriteLine("Successfully logged in!");
                Console.WriteLine($"Role {user.Role}");
            }
            else
            {
                Console.WriteLine("Access denide!");
            }

        }

        
    }
}
