using System;
using System.Collections;

namespace Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(20);
            list.Add("OOP2");
            list.Add(40.40);
            Console.WriteLine("Count : " + list.Count);
            Console.WriteLine("Capscity : " + list.Capacity);
           /* foreach (var i in list)
            {
                Console.WriteLine(i);
            }*/
            ArrayList alist = new ArrayList() { 2,4,"t"};

            list.AddRange(alist);
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            list.Insert(1, "Q OOP2");
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
