using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace linqassignent
{
   public class list1
    {
        public string name { get; set; }
        public int id { get; set; }
    }
   public class list2
    {
        public string name { get; set; }
        public int id { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count vowels in string::");
            Console.WriteLine("Enter your string");
            string str = Console.ReadLine().ToLower();
            var vowels = new System.Collections.Generic.HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

            int total_vowels = str.Count(c => vowels.Contains(c));

            Console.WriteLine("Total number of vowels:{0} ", total_vowels);
            Console.WriteLine("\n");

            Console.WriteLine("Contains ee in names::");
            string[] names= {"mandeep","rupali","sandeep","deep","anju"};
            //var ch = new System.Collections.Generic.HashSet<char> {'ee' };
            var query = from name in names
                        where name.Contains("ee")
                        select name;

            foreach (string name in query)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\n");

            Console.WriteLine("Join two list and return common values::");
            List<list1> list1 = new List<list1>()
            {
                new list1{name="mandeep",id=1},
                new list1{name="mandy", id=2},
                new list1{name="akash",id=3}
            };
            List<list2> list2 = new List<list2>()
            {
                new list2{name="chris", id=5},
                new list2{name="mandeep",id=1},
                new list2{name="mandy",id=2}
            };

            var res = from l1 in list1
                      join l2 in list2
                        on l1.id equals l2.id
                      select new
                      {
                          name=l1.name,
                          id=l1.id
                      };

            foreach(var name in res)
            {
                Console.WriteLine("name: {0}, Id: {1}", name.name,name.id);
            }
        }
    }
}
