using System;

namespace DelagatesnEvents_3rd
{
    public delegate int operation(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            operation op = new operation(Program.add);
            operation op2 = new operation(Program.mul);
            int x, y;
            string val, val2;
            Console.WriteLine("Enter two numbers:");
            val=Console.ReadLine();
            val2 = Console.ReadLine();
            x = Convert.ToInt32(val);
            y = Convert.ToInt32(val2);
            Console.WriteLine("Addition is {0}:",op(x, y));
            Console.WriteLine("Multiplication is {0}", mul(x, y));

        }
        public static int add(int a,int b)
        {
            return (a + b);
        }
        public static int mul(int a,int b)
        {
            return (a * b);
        }
    }
}
