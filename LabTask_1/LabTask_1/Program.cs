using System;

namespace LabTask_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name : Anik Sen");
            Console.WriteLine("ID : 20-42138-1");

            char c = 'a';
            int n = c; // implicit 
            Console.WriteLine("n = "+n);

            double d = 3.45;
            int f = (int)d; // explicit
            Console.WriteLine("f = "+f);


            Console.ReadKey();
        }
    }
}
