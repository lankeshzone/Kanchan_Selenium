using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanchan_Selenium
{
    class Program
    {
        //<datatype> variablename = value;
        static int x = 1;

        const float pi = 3.14f;

        //data member (var/constant)
        //method member (method

        static void Main(string[] args)
        {

            Console.WriteLine("Constant value is " + pi);
            Console.WriteLine("variable value is " + x);

            //aritmetic operations
            int n1 = 10;
            int n2 = 20;

            int val;
            val = n1 + n2;
            Console.WriteLine("Addition " + val);

            //relational operators

            if (val <= 100)
                Console.WriteLine("value is less than 100 " + val);

            //logical operator
            if (n1 > 5 || n2 > 5)
                Console.WriteLine("One or both the inputs are more than five");


            if (n1 > 5 && n2 > 5)
                Console.WriteLine("Both the inputs are more than five");

            Console.ReadKey();
        }

    }

}
