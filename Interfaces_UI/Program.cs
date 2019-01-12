using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //allows us to put more than 1 type in this list due to interface type
            List<IProductModel> cart = AddSampleData();
            CustomerModel customer = GetCustomer();

            foreach (IProductModel prod in cart)
            {
                //this is how it prints
                prod.ShipItem(customer);

                //checking if its a digitalProduct type inside of the list, if there is, then we can acess some of its
                //properties.  Basically if it also implements digital prod
                if (prod is IDigitalProductModel digital)
                {
                    Console.WriteLine($"For the { digital.Title } you have { digital.TotalDownloadsLeft } downloads left.");
                }
            }

            Console.ReadLine();
        }

        //returns the same customer which then assigned
        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Stas",
                LastName = "Berezin",
                City = "Brisbane",
                EmailAddress = "test#@hotmail.com",
                PhoneNumber = "123-123-123"
            };
        }

        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();

            //we set only title because boolean for HasOrderBeenCompleted  we set it internally
            output.Add(new PhysicalProductModel { Title = "Black Mirror disk" });
            output.Add(new PhysicalProductModel { Title = "Microsoft laptop" });
            output.Add(new PhysicalProductModel { Title = "Gym membership" });
            //the reason we can add this, because this interface implements IProductModel, hence it is allowed

            output.Add(new DigitalProductModel { Title = " `How to make money on forex` " });
            output.Add(new CourseProductModel { Title = ".NET Pro course" });

            return output;
        }
    }
}

