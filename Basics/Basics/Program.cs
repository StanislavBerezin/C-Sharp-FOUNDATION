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
            //simple
            Loops miniLoops = new Loops();
            Anonym AnonIdentity = new Anonym();
            AnonIdentity.anonVariables();
            miniLoops.forConditionLoop();
            //simple done

            //creating new object 1.0
            CreateObject identity = new CreateObject();
            identity.newUser(25, "Stas", true);
            Console.WriteLine(identity.howOld());
            //finished 1.0

            //intereface 1.1
            //CREATING INTERFACE and EXECUTING INTERFACE
            Interface log = new ConsoleLog();
            log.Log("HEY");
            //interface finished 1.1

            //ENUM 1.2
            Enumm en = new Enumm();
            en.runFunction();
            //ENUM 1.2 done


            
            

            stopApp();          
        }

        static void stopApp()
        {

            Console.WriteLine("Ready to quit? hit Enter");
            Console.ReadLine();

            
           
        }
    }
}
