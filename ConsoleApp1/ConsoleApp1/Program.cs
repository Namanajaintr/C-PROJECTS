using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Creating the object of the derived class
            //My_Member obj = new My_Member();
            //// Access the method of derived class
            //obj.member();

            //ColorRectangle r1 = new ColorRectangle("pink",
            //       "Fibonacci rectangle", 2.0, 3.236);

            //ColorRectangle r2 = new ColorRectangle("black",
            //                           "Square", 4.0, 4.0);

            //Console.WriteLine("Details of r1: ");
            //r1.DisplayStyle();
            //r1.DisplayDim();
            //r1.DisplayColor();

            //Console.WriteLine("Area r1 is " + r1.Area());
            //Console.WriteLine();

            //Console.WriteLine("Details of r2: ");
            //r2.DisplayStyle();
            //r2.DisplayDim();
            //r2.DisplayColor();

            //Console.WriteLine("Area r2 is " + r2.Area());

            // Method Overloading
            //MethodOverloading obj1 = new MethodOverloading();
            //Console.WriteLine("sum of the two "
            //                  + "integer value : " + obj1.Add(1, 2));
            //Console.WriteLine("sum of the three "
            //                  + "integer value : " + obj1.Add(1, 2, 3));


            //MethodOverloading2 obj2 = new MethodOverloading2();
            //Console.WriteLine("sum of the three "
            //                  + "integer value : " + obj2.Add(1, 2, 3));
            //Console.WriteLine("sum of the three "
            //                  + "double value : " + obj2.Add(1.0, 2.0, 3.0));

            //MethodOverloading3 obj3 = new MethodOverloading3();
            //obj3.Identity("Akku", 1);
            //obj3.Identity(2, "Abby");


            ////Method OverRiding without virtual and override methods
            //// 'obj' is the object of
            //// class 'baseClass'
            //MethodOverriding obj = new MethodOverriding();
            //     // invokes the method 'show()' of class 'baseClass'
            //    obj.show();

            //    MethodOverriding2 obj2 = new MethodOverriding2();
            //    // it also invokes the method
            //    // 'show()' of class 'baseClass'
            //    obj2.show();

            ////In this above program, the object obj invokes class baseClass two times and call the method show() of class baseClass.
            ////To avoid this problem we use virtual and override keyword.

            ////Method OverRiding with virtual and override methods
            //baseClass obj3;

            //// 'obj' is the object
            //// of class 'baseClass'
            //obj3 = new baseClass();

            //// it invokes 'show()'
            //// of class 'baseClass'
            //obj3.show();

            //// the same object 'obj' is now
            //// the object of class 'derived'
            //obj3 = new derived();

            //// it invokes 'show()' of class 'derived'
            //// 'show()' of class 'derived' is overridden
            //// for 'override' modifier
            //obj3.show();

            //Constructor Overloading
            //Constructor2 constructor2 = new Constructor2("Namana", 40.267, 20);
            //    Console.WriteLine("Calling int and string values from base class and double from derived class");
            //    Console.WriteLine(constructor2.name);
            //    Console.WriteLine(constructor2.id);
            //    Console.WriteLine(constructor2.color);

            //    Constructor2 constructor3 = new Constructor2("lambastyle", 40.267f, 357.908);
            //    Console.WriteLine("Calling double  and float values from current derived class");
            //    Console.WriteLine(constructor3.style);
            //    Console.WriteLine(constructor2.width);
            //    Console.WriteLine(constructor2.color);

            //    Properties objt = new Properties();
            //    Console.WriteLine(objt.Name);

            ////Abstract Class
            ////we cant create object for abstract class so inherit it to class
            //Pig myPig = new Pig();  // Create a Pig object
            //myPig.animalSound();
            //myPig.sleep();

            ////Polymorphism
            //Polymorphism myAnimal = new Polymorphism();  // Create a Animal object
            //Polymorphism myCat = new Cat();  // Create a Pig object
            //Polymorphism myDog = new Dog();  // Create a Dog object

            //myAnimal.animalSound();
            //myCat.animalSound();
            //myDog.animalSound();

            //Interface
            DemoClass myObj = new DemoClass();
            myObj.myMethod();
            myObj.myOtherMethod();
            myObj.myOtherMethod();

            //Enum
            //int myNum = (int)Months.April;
            //Console.WriteLine(myNum);

            ////Properties
            //Properties myObjects = new Properties();
            //myObjects.Name = "Liam";
            //Console.WriteLine(myObjects.Name);

            ////SingleInheritence
            //// Creating object of Child class and
            //// invoke the methods of Parent and Child classes
            //Cuboid objs = new Cuboid(2, 4, 6);
            //Console.WriteLine($"Volume is : {objs.Volume()}");
            //Console.WriteLine($"Area is : {objs.Area()}");
            //Console.WriteLine($"Perimeter is : {objs.Perimeter()}");

            ////HierarchicalInheritance
            //Teacher t = new Teacher(25054, 50000, "Sanjay", 28);
            //Doctor d = new Doctor(25045, 750, "Rohit", 32);

            //t.TeacherDetails();
            //Console.WriteLine(
            //    "-----------------------------------");
            //d.DoctorDetails();

            int? x = null;
            int y = x ?? 99;
            Console.WriteLine("The Value of 'Y' is:" + y);
            string message = null;
            string resultMessage = message ?? "Original message is null";
            Console.WriteLine("The value of result message is:" + resultMessage);



            //int[] arr = { 4, 5, 7, 8, 14, 45, 76, 3 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 == 0)
            //    {
            //        Console.WriteLine(arr[i] + "<br />");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No Even Elements in an Array");
            //    }

            //}
            MultipleInheritance refvar = new MultipleInheritance();
            refvar.EvenNumber();
        }
    }   
}
