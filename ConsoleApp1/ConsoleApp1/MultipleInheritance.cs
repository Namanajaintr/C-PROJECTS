using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //        //Parent Class 1
    //        class MultipleInheritance
    //        {
    //            public void GetPhoneModel()
    //            {
    //                Console.WriteLine("phone base class Redmi Note 5 Pro");
    //            }
    //        }
    //        //Parent class 2
    //        class MultipleInheritance2
    //        {
    //            public void GetCameraDetails()
    //            {
    //                Console.WriteLine("camera another base class 24 Mega Pixel Camera");
    //            }
    //        }
    //        //Child Class derived from more than one Parent class
    //        class MultipleInheritance3 : MultipleInheritance2, MultipleInheritance
    //        {
    //            public void GetDetails()
    //            {
    //                Console.WriteLine("Its a RedMi Smart Phone");
    //            }
    //        }
    //    //COMPILE TIME ERROR because one derived class MultipleInheritance3
    //    //cannot handle multiple base classes MultipleInheritance2, MultipleInheritance
    //    //so use INterface to deal with  MultipleInheritance in c#
    public class MultipleInheritance
    {
        public void EvenNumber() {

            int[] arr = {-2,-20,-39, 5, 7, 45 };
            int even;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] % 2 == 0) {
                    Console.WriteLine(arr[i]);
                }
                //var data= (arr[i] % 2 == 0) ? even=arr[i]:0;
                //Console.WriteLine(data);
            }
           // Console.WriteLine("No Even Elements in an Array");
        }
    }


    //// C# program to illustrate how to
    //// implement multiple class inheritance
    //// using interfaces

    //// Interface 1
    //interface GFG1
    //{
    //    void languages();
    //}

    //// Parent class 1
    //class Geeks1 : GFG1
    //{

    //    // Providing the implementation
    //    // of languages() method
    //    public void languages()
    //    {

    //        // Creating ArrayList
    //        ArrayList My_list = new ArrayList();

    //        // Adding elements in the
    //        // My_list ArrayList
    //        My_list.Add("C");
    //        My_list.Add("C++");
    //        My_list.Add("C#");
    //        My_list.Add("Java");

    //        Console.WriteLine("Languages provided by GeeksforGeeks:");
    //        foreach (var elements in My_list)
    //        {
    //            Console.WriteLine(elements);
    //        }
    //    }
    //}

    //// Interface 2
    //interface GFG2
    //{
    //    void courses();
    //}

    //// Parent class 2
    //class Geeks2 : GFG2
    //{

    //// Providing the implementation
    //// of courses() method
    //    public void courses()
    //    {

    //        // Creating ArrayList
    //        ArrayList My_list = new ArrayList();

    //        // Adding elements in the
    //        // My_list ArrayList
    //        My_list.Add("System Design");
    //        My_list.Add("Fork Python");
    //        My_list.Add("Geeks Classes DSA");
    //        My_list.Add("Fork Java");

    //        Console.WriteLine("\nCourses provided by GeeksforGeeks:");
    //        foreach (var elements in My_list)
    //        {
    //            Console.WriteLine(elements);
    //        }
    //    }
    //}

    //// Child class
    //class GeeksforGeeks : GFG1, GFG2
    //{

    //    // Creating objects of Geeks1 and Geeks2 class
    //    Geeks1 obj1 = new Geeks1();
    //    Geeks2 obj2 = new Geeks2();

    //    public void languages()
    //    {
    //        obj1.languages();
    //    }

    //    public void courses()
    //    {
    //        obj2.courses();
    //    }
    //}
















}


