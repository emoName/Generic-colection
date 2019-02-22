using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Generics_and_Collections
{
    class Class1<T,U>: Class2   where T: class , Interface1, new() where U : struct
    {


        public T ff = default(T);
        int? e;
        private U? uurr = new U();


        
            
            // = ff ?? new T();

        public void method()
        {
             U? gg = uurr ?? new U();

            // T where t : class must be not-Nullable
            //T hh;
            //T? tt = hh ?? new T();


            Console.WriteLine(MyEnum.luni);
            MyEnum.

        }

    }
}
