using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanchan_Selenium
{
    class ExceptionEx
    {
        public static void Main(string[] args)
        {
            int[] a = new int[3];
            int n1 = 100, n2 = 100;
            int div=0;

            try
            {
                a[0] = 100;
                a[1] = 200;
                a[2] = 300;
                a[3] = 400;
          
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
           
            finally
            {
                Console.WriteLine("I get executed irrespective of try/catch");
            }

            try
            {
                div = n1 / n2;
            }
            catch (DivideByZeroException d)
            {
                Console.WriteLine(d.Message);
            }
            finally
            {
                Console.WriteLine("I 2nd executed irrespective of try/catch");
            }

            if (div == 1)
                throw new Exception("hello i want stop here");
            else
                Console.WriteLine("value of div " + div);

            Console.WriteLine("Iam continuing execution");
            Console.ReadKey();
        }
    }
}
