﻿using DemoLibrary;
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
            List<IProductModel> cart = AddSampleData();
            CustomerModel customer = GetCustomer();

            foreach (IProductModel prod in cart)
            {
                //this is how it prints
                prod.ShipItem(customer);

                //checking if its a digitalProduct
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
            output.Add(new DigitalProductModel { Title = " `How to make money on forex` " });
            output.Add(new CourseProductModel { Title = ".NET Pro course" });

            return output;
        }
    }
}

