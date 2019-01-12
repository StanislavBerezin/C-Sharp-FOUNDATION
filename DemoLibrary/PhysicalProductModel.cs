using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    //inhereting from Interface for ProductModel which forces us to make
    //title, hasOrderBeenCompleted and ShipItem
    public class PhysicalProductModel : IProductModel
    {
        public string Title { get; set; }
        //private set, so that only from here it can get set, in this casde from ShipItem, so we dont set it when we call
        //this object, it will be set only from inside
        public bool HasOrderBeenCompleted { get; private set; }

        public void ShipItem(CustomerModel customer)
        {
            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Simulating shipping { Title } to { customer.FirstName } in { customer.City }");
                HasOrderBeenCompleted = true;
            }
        }
    }
}
