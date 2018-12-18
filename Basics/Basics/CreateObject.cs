using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class CreateObject
    {
       
        string name;
        bool IsSmart;
        int age;

        public void newUser(int age, string name, bool isSmart)
        {
            this.age = age;
            this.name = name;
            this.IsSmart = isSmart;
        }

        public String getName()
        {
            return this.name;
        }

        public bool howSmart()
        {
            return this.IsSmart;
        }

        public int howOld()
        {
            return this.age;
        }

    }
}
