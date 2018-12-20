using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Diction
    {
        public void test()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>()
                                                            {
                                                                {1,"One"},
                                                                {2, "Two"},
                                                                {3,"Three"}
                                                            };


            string result;

            //get a value of 4 and put it in the result
            if (dict.TryGetValue(4, out result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Could not find the specified key.");
            }

            //can also do
            dict.ContainsKey(1); // returns true
            dict.ContainsKey(4);

            dict.Contains(new KeyValuePair<int, string>(1, "One"));

        }
    }
    }
}
