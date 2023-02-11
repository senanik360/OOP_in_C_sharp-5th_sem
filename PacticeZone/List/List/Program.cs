using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> slst = new SortedList<int, string>();
            slst.Add(1, "Nice");
            slst.Add(4, "Very Nice");
            slst.Add(2, "Super Nice");
            slst.Add(3, "Exceptionally Nice");
            string val2 = slst.Values[3];
            Console.ReadLine();
        }
    }
}
