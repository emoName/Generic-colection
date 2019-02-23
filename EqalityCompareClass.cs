using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_colection
{
    class EqalityCompareClass : IEqualityComparer<Dictionary<int, bool>>
    {
        public bool Equals(Dictionary<int, bool> x, Dictionary<int, bool> y)
        {
            bool r = false;
            if ( x.Count == y.Count )
            {
                r = true;
                var a = y.Keys.ToArray();
                var i=0;

                foreach ( var item in x )
                {

                    r = r && a[i] == item.Key ? true : false;
                    r = r && y[a[i]] == item.Value ? true : false;
                    if ( !r )
                    {
                        return false;
                    }
                    i++;

                }
            }
            return r;
        }

        public int GetHashCode(Dictionary<int, bool> obj)
        {
            return  123456;
        }
    }
}
