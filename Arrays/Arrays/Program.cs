using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        //{
        //    //While and Do-While array
        //    ArrayWhile arrayloop = new ArrayWhile();
        //    arrayloop.arrayWhileloop();
        //    arrayloop.arrayDoWhileloop();
        //}

        //{
        //    //Reverse of an array
        //    Console.WriteLine("1. Reverse of an array");
        //    ReverseArray revarr = new ReverseArray();
        //    revarr.Reverse();
        //}

        //{
        //    //Sum of an array
        //    Console.WriteLine("2. Sum of an array");
        //    SumArray sumarr = new SumArray();
        //    sumarr.Sum();
        //}

        //{
        //    //Duplicate elements of an array
        //    Console.WriteLine("3. Duplicate elements of an array");
        //    DuplicateElement duplicatearr = new DuplicateElement();
        //    duplicatearr.Duplicate();
        //}

        //{
        //    //Adding new Element to an existing array
        //    AddingElement addrefvar = new AddingElement();
        //    addrefvar.AddElement();
        //}

        //{
        //    //Merge Sort
        //    int[] arr = { 12, 11, 13, 5, 6, 7 };
        //    Console.WriteLine("Given Array");
        //    printArray(arr);
        //    MergeSort ob = new MergeSort();
        //    ob.sort(arr, 0, arr.Length - 1);
        //    Console.WriteLine("\nSorted array");
        //    printArray(arr);
        //}

        //{
        //    //Quick Sort
        //    var array = new int[] { 73, 57, 49, 99, 133, 20, 1 };
        //    var expected = new int[] { 1, 20, 49, 57, 73, 99, 133 };
        //    var sortFunction = new QuickSortMethods();
        //    var sortedArray = sortFunction.SortArray(array, 0, array.Length - 1);
        //    Assert.IsNotNull(sortedArray);
        //    CollectionAssert.AreEqual(sortedArray, expected);
        //}


        //{
        //    //Heap Sort
        //    int[] arr = { 55, 25, 89, 34, 12, 19, 78, 95, 1, 100 };
        //    int n = 10, i;
        //    Console.WriteLine("Heap Sort");
        //    Console.Write("Initial array is: ");
        //    for (i = 0; i < n; i++)
        //    {
        //        Console.Write(arr[i] + " ");
        //    }
        //    heapSort(arr, 10);
        //    Console.Write("Sorted Array is: ");
        //    for (i = 0; i < n; i++)
        //    {
        //        Console.Write(arr[i] + " ");
        //    }
        //}

        //{
        //    // Selection Sort
        //    SelectionSort selectionrefvar = new SelectionSort();
        //    selectionrefvar.selectionsort();
        //}

        {
            // Insertion Sort
            InsertionSort insertionrefvar = new InsertionSort();
            insertionrefvar.insertionsort();
        } 

        //{
        //    //Bubble Sort
        //    BubbleSort bubblerefvar = new BubbleSort();
        //    bubblerefvar.bubblesort();
        //}

        //{
        //    //Execption Handling
        //    Exception exception = new Exception();
        //    exception.setName("");
        //    Console.WriteLine(exception.getName());

        //}
    }
}
