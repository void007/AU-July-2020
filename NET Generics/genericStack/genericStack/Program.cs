using System;
using System.Collections.Generic;

namespace genericStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> st= new Stack<string>();
            st.Push("Mandeep");
            st.Push("Holiday");
            st.Push("Determination");
            st.Push("Assignment");
            st.Push("logo");
            st.Push("thats..it");
            print(st);
            Console.WriteLine("Top item of the stack is:");
            Console.WriteLine(st.Peek());

            Console.WriteLine("Remove top two elemens of the stack");
            st.Pop();
            st.Pop();
            Console.WriteLine("Now the updated stack is:\n");
            print(st);

        }
        public static void print(Stack<string> st)
        {
            foreach(string s in st)
            {
                Console.WriteLine(s);
            }
        }
    }
}
