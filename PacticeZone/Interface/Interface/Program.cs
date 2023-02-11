using System;

namespace Interface
{
    interface test
    {
        int sum(int a, int b);
    }
    class cal : test
    {
        public int sum (int a, int b)
        {
            return a % b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            test t; t = new cal(); Console.WriteLine(t.sum(5, 6)); Console.ReadKey();
        }
    }
}
