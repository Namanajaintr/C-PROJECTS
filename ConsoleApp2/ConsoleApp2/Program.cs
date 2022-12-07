using System;

namespace ConsoleApp2
{
    class Program {
        static void Main(string[] args)
        //{
        //    DateAndTime date = new DateAndTime();
        //    date.Inspect();
        //}
        //{
        //    GreetingTime greeting = new GreetingTime();
        //    greeting.Greet();
        //}
        {
            DaylightSavingTime daylight = new DaylightSavingTime();
            daylight.Dst();
        }
    }
}
