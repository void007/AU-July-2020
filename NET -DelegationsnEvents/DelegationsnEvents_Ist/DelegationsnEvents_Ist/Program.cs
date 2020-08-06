using System;

namespace DelegationsnEvents_Ist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementing event handling..");
            calculator cal = new calculator();
            cal.Enter += Subscriber_function;
            cal.StartCalci();

        }
        public static void Subscriber_function(int a,int b)
        {
            int sum = a + b;
            Console.WriteLine("Sum is:{0}", sum);
        }
        

        
    }
}
