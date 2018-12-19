using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Colllectioons
    {
        //to allow adding and removing extra elements in the array
        //need to create an array list
        
        public void arList()
        {
            ArrayList arryList1 = new ArrayList();
            arryList1.Add(1);
            arryList1.Add("Two");
            arryList1.Add(3);
            arryList1.Add(4.5);

            IList arryList2 = new ArrayList()
            {
                100, 200
            };

            //Adding entire collection using ArrayList.AdRange() method.
            ////Note: IList does not contain AddRange() method.
            arryList1.AddRange(arryList2);

            // to acess elements, now it is stored in variable
            int retriveOne = (int)arryList1[0];

            //to go throgh the array
            foreach (var val in arryList1)
                Console.WriteLine(val);

            //to insert an item at the specified index (1 in this case)
            arryList1.Insert(1, "Second Item");
            //can also use Insert.Range(1, arrayOfYourChoice)

            //to remove an item from a list
            arryList1.Remove("Two");
            //or RemoveAt(1), at the specified index

            //to see if something is contained in array
            Console.WriteLine(arryList1.Contains("Second Item"));


        }
        

    }
}
