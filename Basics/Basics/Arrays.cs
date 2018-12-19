using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Arrays
    {
        
        
        public void arrRun()
        {
            int[] intArray = new int[3] { 10, 20, 30 };

            for (int i = 0; i < intArray.Length; i++)
                Console.WriteLine(intArray[i]);

            int[] intArrayy = new int[3] { 10, 20, 30 };

            foreach (var i in intArrayy)
                Console.WriteLine(i);
        }

        public void multRun()
        {
            int[,] intArray = new int[3, 2]{
                                {1, 2},
                                {3, 4},
                                {5, 6}
                            };
        }


        public void jaggedArray()
        {
            /*initilised with 2 brackets [][], the first for size of an array
             * e.g how many arrays in this array. Second specifies the dimension
             * of the array specifies the dimension of the array.
             * adding more [] will mean an array, withn an array of array
             * */
            int[][] intJaggedArray = new int[2][];

            //array index 0
            intJaggedArray[0] = new int[3] { 1, 2, 3 };

            //array index 1
            intJaggedArray[1] = new int[2] { 4, 5 };

        }
    }
}
