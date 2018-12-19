using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    //stucts are useful to hold small data values
    //when struct is created, all vars remain unassigned
    //can use new Employee to create a new one, or just Employee emp(but need to assign values)
    //
    //
    //
    //
    class Struct
    {
        struct Employee
        {
            public int EmpId;
            public string FirstName;
            public string LastName;
            public Employee(int empid, string fname, string lname)
            {
                this.EmpId = empid;
                this.FirstName = fname;
                this.LastName = lname;



            }
            static void isCreated()
            {
                Console.Write("An object has been created");
            }

        }

        //can call it when no constructor, var will be unassigned
        //Employee emp = new Employee();

        //with constructor, u must initialise all of the constructor values
        Employee emp = new Employee(7, "Stas", "Berezin");
        
       /*
        Structs can have constants, fields, methods, props etc
        cannot inherit from another struct or class
        cannot be abstract, virtual or protected

        DIfference between class and struct
        Value type rather than reference type (class)
        cannot have a default constructor (everything is just unassigned)

           
    */
    }
}
