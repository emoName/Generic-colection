using Generic_colection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Generics_and_Collections
{
    class Class1<T, U> : Class2 where T : class, Interface1//, new()
                                where U : struct
    {


        public void NulableMethod()
        {
            // T where t : class must be not-Nullable
            //T hh;
            //T? tt = hh ?? new T();
            // = ff ?? new T();


            T ff = default(T);

            // in cazul dat lucrezi cu cimpurile interfetei 
            // deci esti limitat cu ceia ce mostenesti/ implimentezi
            // in rest nu iti este numic acesibil
            ff.ShowName();
            //  ff += ff;

            int? e = default(int);
            e = null;
            U? uurr = new U();
            uurr = null;
            U? gg = uurr ?? uurr ?? new U();


            if ( e.Value == null && e.HasValue )
            {
                Console.WriteLine(ff.ToString());
            }

        }

        public void ListMethod()
        {


            List<T> ts = new List<T>();
            List<T> tss = new List<T>();

            ts.AddRange(tss);



        }

        public void EnumMethod()
        {
            Console.WriteLine(MyEnum.luni);
            int? n = null;
            MyEnum? myEnum = (MyEnum?)n ?? (MyEnum.joi | (MyEnum)3);

            //Enum is not impliment IEnumerable
            //foreach ( var item in myEnum ) {   }
            for ( int i = 2; i < Enum.GetNames(typeof(MyEnum)).Length + 2; i++ )
            {
                Console.WriteLine((MyEnum)i);
            }
            foreach ( var item in Enum.GetValues(typeof(MyEnum)) )
            {
                Console.WriteLine((int)item);
            }
            Console.WriteLine(Enum.GetNames(typeof(MyEnum)).Count());

            Console.WriteLine(myEnum);
        }

        public void DictionnaryMethod()
        {
            Dictionary<string, Dictionary<int, bool>> myDictionar = new Dictionary<string, Dictionary<int, bool>>();
            Dictionary<int, bool> myDictionar1 = new Dictionary<int, bool>() { { 4, true } };

            myDictionar.Add("dds", myDictionar1);
            myDictionar["dds"] = new Dictionary<int, bool>() { { 1, false }, { 7, true } };

            myDictionar.TryGetValue("dds", out myDictionar1);



        }

        public void EqalityMethod()
        {
            Dictionary<int, bool> myDictionar1 = new Dictionary<int, bool>() { { 1, false }, { 7, true } };
            Dictionary<int, bool> myDictionar3 = new Dictionary<int, bool>() { { 1, false }, { 7, true } };

            myDictionar1.Equals(myDictionar3);

            // valoarea constructorului trebue sa coincida cu {key} prima valoare
            //la adaugare unei valori el foloseste acelasi algoritm de fiecare data :)
            // apel  getHashCode == precedent ==> Eqals () 
            var myDictionar2 = new Dictionary<Dictionary<int, bool>, bool>(new EqalityCompareClass())
              { { myDictionar1, false }, {  new Dictionary<int, bool>() { { 1, false }, { 7, true },{3,false } }, true } };
            // apeleaza getHashCode 
            myDictionar2[myDictionar1] = true;
            bool bb;
            myDictionar2.TryGetValue(myDictionar1, out bb);
            Console.WriteLine(bb);
            // apeleaza getHashCode 
            Console.WriteLine(myDictionar2.ContainsKey(myDictionar1));



            var a = myDictionar1.Keys;
            foreach ( var item in a )
            {
                Console.WriteLine(item);
            }

            var b = a.ToArray();

            foreach ( var item in b )
            {
                Console.WriteLine(item);
            }

            var l = new List<Class2>() { new Class2(1, "pisica"), new Class2(2, "hulub") };

            l.Sort(new CompareCustom());

        }





    }
}
