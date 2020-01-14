using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace Kanchan_Selenium
{
    class collectionEx
    {

        public static void Main(String[] args)
        {
            ArrayList a = new ArrayList();

            HashSet<int> hs1 = new HashSet<int>();

            IDictionary<int, string> id = new SortedDictionary<int, string>();
            

            


            a.Add("Rajesh");
            a.Add(100);
            a.Add('c');
            a.Add(10.25f);

            foreach (object x in a)
                Console.WriteLine(x);

            Console.WriteLine(a.Contains('c'));

            Console.WriteLine(a.Count);

            Console.WriteLine(a.IndexOf(10.25f));
            ArrayList b = new ArrayList();
            b.Add(23);
            b.Add("Beena");

            a.AddRange(b);
            object[] s = new object[100];
            a.CopyTo(s);

            for (int d = 0; d < s.Length; d++)
                Console.WriteLine(s[d]);

            a.Insert(3, "Kanchan");
            foreach (object x in a)
                Console.WriteLine(x);

            Console.WriteLine(a.IsFixedSize);

            a.Remove("Beena");
            foreach (object x in a)
                Console.WriteLine(x);

            a.Reverse();
            foreach (object x in a)
                Console.WriteLine(x);

            Hashtable hs = new Hashtable();
            hs.Add(100, "Lankesh");
            hs.Add(23, "Usha");
            hs.Add(235, "Rajesh");
            hs.Add(21, "Beena");

            ICollection c = hs.Keys;
            ICollection v = hs.Values;

            foreach (object aa in c)
                Console.WriteLine(aa);


            foreach (object aa in v)
                Console.WriteLine(aa);

            hs.Remove(235);
            Console.WriteLine(hs.Count);
            Console.WriteLine(hs.ContainsKey(100));

            SortedList sl = new SortedList();
            

            Console.ReadKey();
        }
    }

    class idictionaryEx
    {
        public static void Main(String[] args)
        {
            OrderedDictionary od = new OrderedDictionary();

            od.Add(100, "Lankesh");
            od.Add(200, "Kanchan");
            od.Add(23, "Beena");
            od.Add(34, "Jashuth");

            Console.WriteLine(od.Contains(34));

            Console.WriteLine(od.Count);

            Console.ReadKey();

        }
    }
}
