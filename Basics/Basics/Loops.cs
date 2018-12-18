using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Loops
    {
        //ALL LOOPS POSITIONED HERE

        //WHILE LOOPS
        public void whileLoop()
        {
            int number = 0;

            while (number < 5)
            {
                Console.WriteLine(number);
                number++;
            }
        }
        //breaks the while loop
        public void whileBreakLoop()
        {
            int i = 0;

            while (true)
            {
                Console.WriteLine("Value of i: {0}", i);

                i++;

                if (i > 10)
                    break;
            }
        }

        //FOR LOOP
        public void forLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Value of i: {0}", i);
            }
        }

        //FOR LOOP until certain condition is true
        public void forConditionLoop()
        {
            int i = 0;

            for (; ; )
            {
                //can be used infinitely
                if (i < 10)
                {
                    Console.WriteLine("Value of i: {0}", i);
                    i++;
                }
                else
                    break;
            }
        }
      

        // DO WHILE, executes the code at least once to see the conditions

}
}
