using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Enumm
    {

        /*
         * Value data type, used to give a name to each constant
         * Used for constants
         * */
        enum WeekDays
        {
            Monday = 0,
            Tuesday = 1,
            Wednesday = 2,
            Thursday = 3,
            Friday = 4,
            Saturday = 5,
            Sunday = 6
        }

        public void runFunction()
        {
            // Console.WriteLine(WeekDays.Friday); //gets the FRIDAY
            //  Console.WriteLine((int)WeekDays.Friday); //get 4

            //to get the days "string str" and Enum.GetNames"
            //to get values "int str" and Enum.GetValues"
            foreach (int str in Enum.GetValues(typeof(WeekDays)))
                Console.WriteLine(str);

        }
     

    }
}
