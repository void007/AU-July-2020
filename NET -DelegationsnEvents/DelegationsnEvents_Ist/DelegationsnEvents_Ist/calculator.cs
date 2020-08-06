using System;
using System.Collections.Generic;
using System.Text;

namespace DelegationsnEvents_Ist
{
    class calculator
    {
        public delegate void calci(int a, int b);
        public event calci Enter;

        public void StartCalci()
        {
            Console.WriteLine("Enter two numbers:");
            int a, b;
            string val, val2;
            val = Console.ReadLine();
            a = Convert.ToInt32(val);
            val2 = Console.ReadLine();
            b = Convert.ToInt32(val2);

            Console.WriteLine("Press Enter..");
            Console.ReadLine();
            OnEnter(a, b);
        }
        protected virtual void OnEnter(int a,int b)
        {
            Enter?.Invoke(a, b);
        }

    }
}
