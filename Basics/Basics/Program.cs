using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    // Classess are like a container of code needed for your app
    class Program
    {
        
        static void Main(string[] args)
        {
            Loops miniLoops = new Loops();

            miniLoops.forConditionLoop();

            stopApp();          
        }

        static void stopApp()
        {

            Console.WriteLine("Ready to quit? hit Enter");
            Console.ReadLine();

            
           
        }
    }
}
