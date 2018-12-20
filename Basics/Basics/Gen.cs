using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class MyGenericClass<T>
    {
        private T genericMemberVariable;

        public MyGenericClass(T value)
        {
            genericMemberVariable = value;
        }

        public T genericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(), genericParameter);
            Console.WriteLine("Return type: {0}, value: {1}", typeof(T).ToString(), genericMemberVariable);

            return genericMemberVariable;
        }

        public T genericProperty { get; set; }

        public void call()
        {
            //making it an int
            MyGenericClass<int> intGenericClass = new MyGenericClass<int>(10);

            int val = intGenericClass.genericMethod(200);
        }
    }
}
