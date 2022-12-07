using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class InsertionSort
    {
        // Recursive function to sort an array using insertion sort
        public void insertionsort() {
            int[] arr = new int[100];
            int n, i, j, val, flag;

            //Inputting the number of elemnts to be sorted from the console
            Console.Write("Input the total number of elements to sort in ascending order :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} number of elements to the array :\n", n);
            for (i = 0; i < n; i++) {
                Console.Write("element {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Printing the Initial Array using Insertion Sort
            Console.WriteLine("Insertion Sort");

            Console.WriteLine("Initial array is: ");
            for (i = 0; i < n; i++) {
                Console.WriteLine(arr[i] + " ");
            }

            for (i = 1; i < n; i++) {
                val = arr[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;) {
                    if (val < arr[j]) {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else flag = 1;
                }
            }

            //Printing the Sorted Array using Insertion Sort
            Console.WriteLine("Sorted Array is: ");
            for (i = 0; i < n; i++) {
                Console.WriteLine(arr[i] + " ");
            }

        }
    }
}