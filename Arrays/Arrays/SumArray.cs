using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class SumArray
    {
        public void Sum()
        {
            int[] a = new int[100];
            int i, n, sum = 0;


            Console.Write("Input the number of elements to be fimd the sum of the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element  {0} is : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                sum += a[i];
            }

            Console.Write("Sum of all elements stored in the array is : {0}\n\n", sum);
        }
    }
}
