using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanchan_Selenium
{
    class controlsExample
    {

        public static void Main(String[] args)
        {
            //if statements
            int num = 100;
            if (num <= 50)
                Console.WriteLine("number is less than 50 " + num);

            //if-else
            if (num <= 50)
                Console.WriteLine("number is less than 50 " + num);
            else
                Console.WriteLine("number is greater than 50 " + num);

            //ested if
            if (num <= 150)
                if (num <= 120)
                    Console.WriteLine("number is less than 120 " + num);

            //loops
            int y = 10;
            while(y<15)
            {
                Console.WriteLine("Y is less than 15 " + y);
                y++;
            }

            do
            {
                Console.WriteLine("Y is less than 20 " + y);
                    y++;
            }
            while (y <= 20);

            for(int z=1;z<=10;z++)
            {
                Console.WriteLine("Table of 5 * " + z + " = " + z * 5);
            }

            //foreah loop

            char[] weekday = { 'M', 'T', 'W', 'T', 'F', 'S', 'S' };

            foreach(char day in weekday)
            {
                Console.WriteLine("Today is " + day);
            }

            //switch statements

            String s = "Savings";

            switch(s)
            {
                case "Savings":
                    Console.WriteLine("This is savings account ");
                    break;
                case "Loans":
                    Console.WriteLine("This is Loans account ");
                    break;
                case "Deposits":
                    Console.WriteLine("This is Deposits account ");
                    break;
                default:
                    Console.WriteLine("This is Default user ");
                    break;

               }


            Console.ReadKey();
        }
    }

    class student
    {
        //Data members of class student
        int roll_num;
        string name;
        static string dept = "Computers";
        const string university = "Delhi University";
        int fee;

        //method member
        public void fees(int af, int tf, int sf)
        {
            fee = af + tf + sf;
        }

        public static void Main(String[] args)
        {
            student usha = new student();
            usha.roll_num = 1;
            usha.name = "Usha B";
            usha.fees(100, 20, 20);
            Console.WriteLine("Roll " + usha.roll_num);
            Console.WriteLine("Name " + usha.name);
            Console.WriteLine("Fees " + usha.fee);
            Console.WriteLine("Department " +  student.dept);
            Console.WriteLine("University " + student.university);


            student kanchan = new student("Mechanical");
            Console.WriteLine("Department for Kanchan " + student.dept);


            student lg = new student(200, "AI");
            Console.WriteLine("Department for LG " + student.dept);
            Console.WriteLine("Fees for LG " + lg.fee);



            Console.ReadKey();
        }

        public student()
        {
            dept = "Electronics";
        }

        public student(string s)
        {
            dept = s;
        }
   
        public student(int f, string s2)
        {
            fee = f;
            dept = s2;
        }
    }

    class methodEX
    {
        //without return type and without parameter
        public void m1()
        {
            Console.WriteLine("Iam a method with no return value and no parameters");
        }

        //without return type with parameter
        public void m2(string name)
        {
            Console.WriteLine("Iam a method with no return value and string parameters");
        }

        //with return type without parameter
        public string m3()
        {
            string str = "Kanchan";
            return (str);
        }

        //with return with parameter
        public string m4(int age)
        {
            Console.WriteLine("Iam a method with return value and int parameters " + age);
            return "lankesh";
        }

        //return type --> void/primitive/derived/object

        //parameter --> primitive/derived/objects

    }

    class overloadEx
    {
        public static void Main(String[] args)
        {
            overloadEx o = new overloadEx();
            o.methodOne();
            o.methodOne(100);
            o.methodOne("lankesh", 200);

            Console.ReadKey();
        }

        public void methodOne()
        {
            Console.WriteLine("Iam methodOne with no parameter");
        }

        public void methodOne(int x)
        {
            Console.WriteLine("Iam methodOne with one integer parameter");
        }

        public void methodOne(string s, int y)
        {
            Console.WriteLine("Iam methodOne with one integer and one string parameter");
        }
    }

    class parent
    {
        public virtual void methodTwo(string str)
        {
            Console.WriteLine("Iam in parent methodTwo " + str);
        }

        public static void Main(String[] args)
        {

        }
    }

    class child : parent
    {
        public override void methodTwo(string s)
        {
            Console.WriteLine("Iam in child class methodTwo " + s);
        }

        public static void Main(String[] args)
        {
            parent p = new parent();
            p.methodTwo("lankesh"); //parent method will execute

            child c = new child();
            c.methodTwo("kanchan"); //child method will execute

            //object type == reference type
            parent p1 = new child();
            p1.methodTwo("usha");
            
            Console.ReadKey();
        }
    }
}
