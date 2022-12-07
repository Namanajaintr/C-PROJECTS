using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class AddingElement
    {
        public void AddElement()
        {
            int n = 10;
            int[] arr = new int[n];
            int i;

            // initial array of size 10
            for (i = 0; i < n; i++)
                arr[i] = i + 1;

            // print the original array
            for (i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();

            // element to be inserted
            int x = 50;

            // position at which element 
            // is to be inserted
            int pos = 5;

            // create a new array of size n+1
            int[] newarr = new int[n + 1];

            // insert the elements from the 
            // old array into the new array
            // insert all elements till pos
            // then insert x at pos
            // then insert rest of the elements
            for (i = 0; i < n + 1; i++)
            {
                if (i < pos - 1)
                    newarr[i] = arr[i];
                else if (i == pos - 1)
                    newarr[i] = x;
                else
                    newarr[i] = arr[i - 1];
            }

            // print the updated array
            for (i = 0; i < n + 1; i++)
                Console.Write(newarr[i] + " ");
            Console.WriteLine();
        }
    }
}

