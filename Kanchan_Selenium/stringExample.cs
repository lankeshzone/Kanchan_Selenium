using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanchan_Selenium
{
    class stringExample
    {

        public static void Main(String[] args)
        {
            string str = "This is an example string";

            Console.WriteLine("contains " + str.Contains("is an"));

            Console.WriteLine("Length " + str.Length);

            string str2 = str.Replace('i', 'm');
            Console.WriteLine("replaced string " + str2);

            string str3 = str2.Insert(4, "j");
            Console.WriteLine("Insert at 4th index  " + str3);

            Console.WriteLine("index of " + str.IndexOf('e'));
            Console.WriteLine("Equals method " + str.Equals(str2));

            string[] s = { "test", "three" };

            Console.WriteLine("concat " + String.Concat(s));

            char[] c = new char[100];
            
            str.CopyTo(0, c, 0, str.Length);
            for(int x=0;x<c.Length;x++)
            Console.Write(c[x]);

            Console.WriteLine("Split strings " + str);

            char[] aa = { 'i','a' };
            String[] s1 = str.Split(aa);

            for (int j = 0; j < s1.Length; j++)
                Console.WriteLine(s1[j]);


            Console.ReadKey();

        }

    }
}
