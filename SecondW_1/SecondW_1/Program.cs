using System;

namespace SecondW_1
{
    class Program
    {
        struct Box
        {
            public int height;
            public bool width;
        }

        static void Main(string[] args)
        {



            Box b1 = new Box();
            Console.WriteLine(b1.height);
            Console.WriteLine(b1.width);
            Console.ReadKey();
        }
    }
}
