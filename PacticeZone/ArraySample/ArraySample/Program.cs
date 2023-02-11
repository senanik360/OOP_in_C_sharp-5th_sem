using System;

namespace ArraySample
{
    class ArraySample
    {
        public void MaxE(int[] arr)
        {
            int max;
            max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.Write("Maximum element = {0}\n", max);
        }
        public void MinE(int[] arr)
        {
            int min;

            min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.Write("Minimum element = {0}\n", min);

        }
        public void PrimeNumber(int[] arr)
        {
            int j, p;
            Console.Write("All Prime List:");
            for (int i = 0; i < arr.Length; i++)
            {
                j = 2;
                p = 1;
                while (j < arr[i])
                {
                    if (arr[i] % j == 0)
                    {
                        p = 0;
                        break;
                    }
                    j++;
                }

                if (p == 1)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];


            for (int i = 0; i < 20; i++)
            {
                Console.Write("Element - {0} : ", i + 1);
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

