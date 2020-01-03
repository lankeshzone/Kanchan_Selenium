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
            while (y < 15)
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

            for (int z = 1; z <= 10; z++)
            {
                Console.WriteLine("Table of 5 * " + z + " = " + z * 5);
            }

            //foreah loop

            char[] weekday = { 'M', 'T', 'W', 'T', 'F', 'S', 'S' };

            foreach (char day in weekday)
            {
                Console.WriteLine("Today is " + day);
            }

            //switch statements

            String s = "Savings";

            switch (s)
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
            //Console.WriteLine("Roll " + usha.roll_num);
            //Console.WriteLine("Name " + usha.name);
            //Console.WriteLine("Fees " + usha.fee);

            usha.display_syudentInf(usha);




            student kanchan = new student("Mechanical");

            kanchan.display_syudentInf(kanchan);


            student lg = new student(200, "AI");
            lg.display_syudentInf(lg);


            student peter = student.setinfo();
            Console.WriteLine("----------------");

            peter.display_syudentInf(peter);

            student[] s = new student[4];

            s[0] = usha;
            s[1] = kanchan;
            s[2] = lg;
            s[3] = peter;

            for (int x = 0; x < 4; x++)
                Console.WriteLine(s[x]);


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

        public void display_syudentInf(student s)
        {
            Console.WriteLine(" roll num " + s.roll_num);
            Console.WriteLine(" Name " + s.name);
            Console.WriteLine(" Fees " + s.fee);
            Console.WriteLine(" Department " + student.dept);
            Console.WriteLine(" University " + student.university);
        }

        public static student setinfo()
        {
            student k = new student();

            k.roll_num = 100;
            k.name = "Peter";
            k.fee = 200;
            student.dept = "AI";


            return k;
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
            modifierex m = new modifierex();
            Console.WriteLine("public " + m.a);
            // Console.WriteLine("protected " + m.b);
            Console.WriteLine("internal " + m.c);
            Console.WriteLine("protected internal " + m.d);
            Console.ReadKey();

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

    public class modifierex
    {
        public int a = 100;
        protected int b = 200;
        internal int c = 300;
        protected internal int d = 400;
        //  private protected int e = 500;

        public static void Main(String[] args)
        {
            modifierex m = new modifierex();
            Console.WriteLine("public " + m.a);
            Console.WriteLine("protected " + m.b);
            Console.WriteLine("internal " + m.c);
            Console.WriteLine("protected internal " + m.d);
            Console.ReadKey();

        }

    }

    class p
    {
        public void methodP()
        {
            Console.WriteLine("Iam method from super parent");
        }
        public static void Main(string[] args)
        {
            p p = new p();
            p.methodP();
            Console.ReadKey();
        }
    }
    class c1 : p
    {
        public void methodC1()
        {
            Console.WriteLine("Iam method from class C1");
        }
        public static void Main(string[] args)
        {
            c1 c = new c1();
            c.methodP();
            c.methodC1();
            Console.ReadKey();
        }

    }

    class c2 : p
    {
        public void methodC2()
        {
            Console.WriteLine("Iam method from class C2");
        }
        public static void Main(string[] args)
        {
            c2 c2 = new c2();
            c2.methodP();
            c2.methodC2();
            Console.ReadKey();
        }

    }

    class c3 : p
    {
        public void methodC3()
        {
            Console.WriteLine("Iam method from class C3");
        }
        public static void Main(string[] args)
        {
            c3 c3 = new c3();
            c3.methodP();
            c3.methodC3();
            Console.ReadKey();
        }

    }

    class c4 : c1
    {
        public void methodC4()
        {
            Console.WriteLine("Iam method from class C4");
        }
        public static void Main(string[] args)
        {
            c4 c4 = new c4();
            c4.methodP();
            c4.methodC1();
            c4.methodC4();
            Console.ReadKey();
        }

    }

    class c5 : c1
    {
        public void methodC5()
        {
            Console.WriteLine("Iam method from class C5");
        }
        public static void Main(string[] args)
        {
            c5 c5 = new c5();
            c5.methodP();
            c5.methodC1();
            c5.methodC5();
            Console.ReadKey();
        }

    }


    sealed class c6 : c1
    {
        public void methodC6()
        {
            Console.WriteLine("Iam method from class C6");
        }
        public static void Main(string[] args)
        {
            c6 c6 = new c6();
            c6.methodP();
            c6.methodC1();
            c6.methodC6();
            Console.ReadKey();
        }

    }


    class c7 : c4
    {
        public void methodC7()
        {
            Console.WriteLine("Iam method from class C7");
        }
        public static void Main(string[] args)
        {
            c7 c7 = new c7();
            c7.methodP();
            c7.methodC1();
            c7.methodC4();
            c7.methodC7();
            Console.ReadKey();
        }

    }

    class Test
    {
        private int x;
        public int X
        {
            get
            {
                return this.x;

            }
            set
            {
                this.x = value;
            }
        }

        public static void Main(String[] args)
        {
            Test t = new Test();
            t.X = 100;
            Console.WriteLine("value of x " + t.X);
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine("char " + c);
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("int value " + a);
            Console.ReadKey();
        }

    }


    class ExSetGet
    {
        private int a;

        public int A
        {
            get
            {
                return this.a;
            }
            set
            {
                this.a = value;
            }
        }
        public static void Main(string[] args)
        {
            ExSetGet e = new ExSetGet();
            e.A = Int32.Parse(Console.ReadLine());
            Console.WriteLine("value of private variable " + e.A);
            Console.ReadKey();

        }

    }

    class t1
    {
        public static void Main(String[] args)
        {
            ExSetGet e = new ExSetGet();
            e.A = Int32.Parse(Console.ReadLine());
            Console.WriteLine("value of private variable " + e.A);
            Console.ReadKey();
        }
    }


    abstract class abtest
    {
        //what to implement
        abstract public void fees();

        public int x;
        public void m1()
        {
            Console.WriteLine("Iam instance method in abstract class ");
        }
        public static void Main(String[] args)
        {
            // abtest a = new abtest();
            Console.WriteLine("Iam main method in abstract class ");
        }
        public abtest()
        {
            Console.WriteLine("Iam constructor in abstract class ");
        }
    }

    abstract class imptest : abtest
    {
        override public void fees()
        {
            Console.WriteLine("Iam omplemented method in child class ");
        }

        abstract public void m2();

        public static void Main(String[] args)
        {
            //imptest i = new imptest();
            //i.fees();
            //i.x = 200;
            //i.m1();

            Console.ReadKey();

        }
        public imptest()
        {
            Console.WriteLine("Iam childclass constructor");
        }

    }

    class imptest2 : imptest
    {
        override public void m2()
        {

        }
    }

    class imptest3 : abtest
    {
        override public void fees()
        {
            Console.WriteLine("Iam omplemented method in child class 2 ");
        }
        public static void Main(String[] args)
        {
            imptest3 i3 = new imptest3();
            i3.fees();
            Console.ReadKey();
        }
    }

    interface intOne
    {
        void m1();

        void m2();

    }

    interface intTwo
    {
        void m3();
    }

    class implementInterface : abtest, intOne, intTwo
    {

        public void m1()
        {

        }
        public void m2()
        {

        }
        public void m3()
        {

        }

        public override void fees()
        {
            //
        }
    }

    interface car
    {
        void engine(int capacity);
        void luxury(string option);
    }

    class BMW : car
    {
        public void engine(int capacity)
        {
            Console.WriteLine("engine capacity is " + capacity);
        }

        public void luxury(String option)
        {
            Console.WriteLine("Car has luxury feature " + option);
        }

        public static void Main(String[] args)
        {
            BMW b = new BMW();
            b.engine(2000);
            b.luxury("Leather seats");
            Console.ReadKey();
        }
    }


    class arrayEx
    {
        public static void Main(string[] args)
        {

            int[] x = new int[3];

            //To check
            int[,] y = new int[2, 2];

            string[] s = new string[2];

            arrayEx[] a = new arrayEx[2];

            arrayEx a1 = new arrayEx();
            arrayEx a2 = new arrayEx();

            a[0] = a1;
            a[1] = a2;

            Console.WriteLine(a[0]);
            Console.WriteLine(a[1]);



            x[0] = 100;
            x[1] = 340;
            x[2] = 50;
            //  x[3] = 400;
            Array.Sort(x);

            Console.WriteLine(Array.BinarySearch(x, 50));

            Console.ReadKey();

        }
    }

    //base keyword in CSharp and this in Chsarp
    class test
    {
        int y = 100;
        public test(int x)
        {
        }
    }
    class Test1 : test
    {
        public static void Main(String[] args)
        {
            Test1 t1 = new Test1(20);

        }

        public Test1(int y) : base(100)
        {

        }

    }

    class multiDime
    {
        public static void Main(String[] args)
        {
            int[,] x = new int[2, 2];

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Enter the array values");
                    x[i, j] = Int32.Parse(Console.ReadLine());
                }


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                    Console.Write(" " + x[i, j]);
                Console.WriteLine();
            }

            Console.ReadKey();
        }

    }

  
}
