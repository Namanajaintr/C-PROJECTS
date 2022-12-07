using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class ArrayWhile
    {
        public void arrayWhileloop()
        {
            string[] arr = { "apple", "banana", "cherry" };
            int index = 0;
            while (index < arr.Length)
            {
                Console.WriteLine("Fruits in the basket are:"+arr[index]);
                index++;
            }
        }

        public void arrayDoWhileloop()
        {
            int i = 1, product;
            int[] n = { 5, 6, 7, 8, 9, 10 };

            do
            {
                product = n[i] * i;
                Console.WriteLine("{0} * {1} = {2}", n[i], i, product);
                i++;
            } while (i <= 5);

        }

    }
}
