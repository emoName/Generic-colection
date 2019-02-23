using _09_Generics_and_Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_colection
{
    struct MyStruct : Interface1
    {

        public void Method()
        {

        }

        public void ShowName()
        {
            Console.WriteLine($"This is :: {this} ::");
        }
    }
}
