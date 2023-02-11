using System;

namespace InputTaking
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine("Name : "+name);
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ID : " + id);

        }
    }
}
