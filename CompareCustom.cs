using _09_Generics_and_Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_colection
{
    class CompareCustom : IComparer<Class2>
    {
        public int Compare(Class2 x, Class2 y)
        {

            if ( x.id>y.id )
            {
                return 1;
            }
            if ( x.id<y.id )
            {
                return -1;
            }
            return 0;

        }
    }
}
