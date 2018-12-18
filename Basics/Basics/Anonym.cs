using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Anonym
    {
        public void anonVariables()
        {


            var anon = new {
                firstName = "Stas",
                hasFinishedCS = true,
                age = 25
        };
            Console.WriteLine("Author: {0}, has finished CS ? {1}, Age: {2}", anon.firstName, anon.hasFinishedCS, anon.age);

           


        }
    }
}
