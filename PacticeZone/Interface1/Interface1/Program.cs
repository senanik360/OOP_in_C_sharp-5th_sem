using System;

namespace Interface
{
    class Program : Interface1, Interface2
    {
        public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
       public  void sub(int a, int b)
        {
            Console.WriteLine(a - b);

        }
        static void Main(string[] args)
        {
            
            Console.ReadKey();
        }
    }
}
