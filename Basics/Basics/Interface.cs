using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    interface Interface
    {
        /*
         * contains only the method declaration, the execution code must in a class object
         * it is done so that different classess can implement the same functionality
         * 
         * 
         * */
        
         void Log(string msgToLog);
        
    }

    class ConsoleLog : Interface
    {
        //can put more code an private variables etc

        public void Log(string msgToPrint)
        {
            Console.WriteLine(msgToPrint);
        }
    }

    class FileLog : Interface
    {
        public void Log(string msgToPrint)
        {
            File.AppendText(@"C:\Log.txt").Write(msgToPrint);
        }
    }
}
