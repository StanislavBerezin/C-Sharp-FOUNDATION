using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class StringDataStore
    {

        private string[] strArr = new string[10]; // internal data storage

        public string this[int index]
        {
            get
            {
                if (index < 0 && index >= strArr.Length)
                    throw new IndexOutOfRangeException("Cannot store more than 10 objects");

                return strArr[index];
            }

            set
            {
                if (index < 0 || index >= strArr.Length)
                    throw new IndexOutOfRangeException("Cannot store more than 10 objects");

                strArr[index] = value;
            }
        }

        public void runIndex()
        {
            StringDataStore strStore = new StringDataStore();

            //because of indexer we can use it as an array to assign values 
            strStore[0] = "One";
            strStore[1] = "Two";
            strStore[2] = "Three";
            strStore[3] = "Four";

            for (int i = 0; i < 10; i++)
                Console.WriteLine(strStore[i]);
        }
    }

    
            

}
