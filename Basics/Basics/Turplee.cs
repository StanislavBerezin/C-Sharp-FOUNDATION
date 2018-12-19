using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Turplee
    {
        /*
         * data structure to hold an object with properties
         * without creating a type (class or struct for it)
         * 
         * expensive for CPU as its used in a heap(run time)
         * 
         * */
        public void tur()
        {
            //we havent declared a type, we simply throw all we need in person
            var person = Tuple.Create(1, "Steve", "Jobs");
            Console.WriteLine(person.Item1); // returns 1
            Console.WriteLine(person.Item2); // returns "Steve"
            Console.WriteLine(person.Item3); // returns "Jobs"
        }

        public void nestedTur()
        {
            var numbers = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));
            Console.WriteLine(numbers.Item1); // returns 1
            Console.WriteLine(numbers.Item7); // returns 7
            Console.WriteLine(numbers.Rest.Item1); //returns (8, 9, 10, 11, 12, 13)
            Console.WriteLine(numbers.Rest.Item1.Item1); //returns 8
            Console.WriteLine(numbers.Rest.Item1.Item2); //returns 9
        }

        public void valueTur()
        {
            //4.7 net, but basically a smart solution to define what types of data
            //tur should hold
            // ValueTuple<int, string, string> person = (1, "Bill", "Gates");

        }
    }
}
