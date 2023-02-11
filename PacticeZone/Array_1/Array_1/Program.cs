using System;

namespace Array_1
{


        class Program
        {
            static void Main(string[] args)
            {
                int[] arr = new int[20];
                int x;
           
                for (int i = 0; i < 20; i++)
                {
                    Console.Write("Element - {0} : ", i+1);
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                ArraySample obj = new ArraySample();
                obj.MaxE(arr);
                obj.MinE(arr);
                obj.PrimeNumber(arr);
            Console.ReadKey();
        }
      
        }
    }

