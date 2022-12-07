using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    //exception is the one which effects the execution flow
    //avoids the execution flow crash when exception handlor is called 
    //exception can be handeled by using system. Exception class.
    //system.Application Exception and system.systemException. //system exceptions come from the system.exception class.
    //we can also custom our exceptions while coding.
    //aware of 4 keywords try, catch, finally, throw
    //try -> holdes the code which may throw an exception
    //catch -> code which will handle exception thrown by try block
    //finally -> default code
    //throw -> throws an exception manually
    class Exception
    {
        public void Execptionhandling()
        {

            string[] names = new string[] { "avi", "akshatha", "Namana", "Nayana" };
            Console.WriteLine("names[2]");
            Console.WriteLine("names[5]");

            try
            {

            }
            catch (NullReferenceException)
            {

            }
        }
        private string name;
        public string setName(string a)
        {
            if (name == null)
            {
                throw new ArgumentException("Name cannot be null");
            }
            else
            {
                name = a;
                Console.WriteLine("name is {0}", name);
                return name;
            }
        }
        public string getName()
        {
            return name;
        }
    }
}

     
        

   
