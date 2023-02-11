using System;

namespace Indexer
{
   public class indexer
    {
        private int []arr = new int[60];
        public int this [int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            indexer obj = new indexer();
            obj[0] = 1;
            obj[1] = 2;
            obj[2] = 3;
            Console.WriteLine($"Numbers : {obj[0]}{obj[0]}");
        }
    }
}
