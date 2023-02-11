using System;
using System.Collections.Generic;
using System.Text;

namespace Array_1
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
            Console.Write("Minimum element = {0}\n\n", max);
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
            Console.Write("Minimum element = {0}\n\n", min);

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
    }

