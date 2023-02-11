using System;

namespace Delegate
{
    public delegate void del(int a, int b);
    class calculator
    {
        public void add(int a, int b)
        {
            Console.WriteLine("Addition  : " + (a + b));
        }
        public void sub(int a, int b)
        {
            Console.WriteLine("Subtraction  : " + (a - b));
        }
        public void mul(int a, int b)
        {
            Console.WriteLine("Multiplication  : " + (a * b));
        }
    }
    class Program
    {
        static void fun(del d ,del dl, int a, int b)
        {
            d(a, b);
            dl(a, b);
        }
        static void Main(string[] args)
        {
            calculator cal = new calculator();
            //cal.add(10, 5);
            /*del d = cal.add;
            //d(10, 5);
            d +=cal.sub;
            d +=cal.mul;
            d(10, 5);*/
            fun(cal.add, cal.sub, 10, 5);
           // fun(cal.sub, 10, 5);
           
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
