using System;

namespace DelegationsnEvents_2nd
{
    public delegate void concatenate(string a, string b);
    class Program
    {
        public static  string property;
        public Program()
        {
            property = "";
        }
        public static void fun1(string a,string b)
        {
            if (a.Length > b.Length)
            {
                property += a;
            }
            else
            {
                property += b;
            }
        }

        public static void fun2(string a,string b)
        {
            if (a.Length > b.Length)
            {
                property += a;
            }
            else
            {
                property += b;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Implementing multicasting concept:");
            Console.WriteLine("\n");
         
            concatenate con1 = new concatenate(Program.fun1);
            con1 += new concatenate(Program.fun2);

            Console.WriteLine("Enter the two strings:");
            string a, b;
            a=Console.ReadLine();
            b = Console.ReadLine();
            con1(a, b);
            Console.WriteLine("printing the property: {0}", property);


        }
    }
}
