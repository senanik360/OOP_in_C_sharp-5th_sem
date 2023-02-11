using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int sum = 0;
            for(int i=0; i<arr.Length; i++)
            {
                Console.Write(arr[i] + " "); 
            sum = sum + arr[i];
            }

            Console.WriteLine(" \nSum of the array :  "+sum);
            Console.WriteLine(" ");
            for(int i=arr.Length-1; i>=0; i--)
            {
                Console.Write(arr[i] + " ");
            } 
            /* foreach(int i in arr)
             {
                 Console.Write(i);
                 sum = sum + i;
             }

             Console.WriteLine(" \nSum of the array :  "+sum);

             int[] rv = arr;
             Array.Reverse(rv);
             Console.Write("\nReversed Array: ");
             foreach (int i in rv)
             {
                 Console.Write(i + " ");
             }  */

        }
    }
}
