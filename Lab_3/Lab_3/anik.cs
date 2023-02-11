using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    class anik
    {
        // pass by value
        public void add(int a, int b, int c)
        {
            int sum = a + b + c;
            Console.WriteLine("Sum of last 3 digit of my id(middle part) : " + sum);
            Console.Write("\t\t\t\t-- pass by value.\n\n");

        }
        // pass by ref
        public void mult(ref int x, int y, int z)
        {
             x = x * y* z;
            Console.WriteLine("Multiplication of last 3 digit of my id(middle part) : " + x);
            Console.Write("\t\t\t\t-- pass by ref.\n\n");


        }
        public void Out(out int k)
        {
            k = 1;
            k = k * 138;
            Console.WriteLine("Multiplication of last 3 digit of my id(middle part) with last digit : " + k);
            Console.Write("\t\t\t\t-- using out parameter.\n\n");

        }
        public void Params(params int[] id)
        {
            Console.Write("ID : ");
            foreach(int i in id){
                Console.Write(i);
            }
            Console.Write("\t\t\t\t-- using params.\n\n");

        }
        public void Named(int i, double d, string s)
        {
            Console.WriteLine("\nName : " + s + "\tCg : "+d +"\tSemester : "+ i );
            Console.Write("\t\t\t\t-- using Named parameter.\n\n");

        }
        public void jaggedArray()
        {
            char[][] charArray = new char[2][];
            charArray[0] = new char[] { 'A', 'B', 'C', 'D' };
            charArray[1] = new char[] { 'I', 'J', 'K' };
            Console.Write("\n\nOriginal elements : ");
            foreach (char[] i in charArray)
            {
                foreach (char j in i)
                {
                    Console.Write(j);
                }
                Console.Write(" ");
            }
            charArray[0][2] = 'F';
            charArray[1][1] = 'G';
            //char[][] charArray = { new[] { 'A', 'B', 'C', 'D' }, new[] { 'I', 'J', 'K' } };   --> Alternative way
            Console.Write("\n\nElements after overriding : ");
            foreach (char[] i in charArray)
            {
                foreach (char j in i)
                {
                    Console.Write(j);
                }
                Console.Write(" ");
            }
            Console.Write("\t\t\t\t-- using jagged array.");
        }

    }
}
