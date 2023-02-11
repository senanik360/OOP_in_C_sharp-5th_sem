using System;
using System.Collections;

namespace hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
            h.Add(5, "Five");
            h.Add("two", 2);
            h[3] = "three";
            foreach(DictionaryEntry i in h)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }
        }
    }
}
