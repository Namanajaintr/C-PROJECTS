using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class GreetingTime {
        DateTime currentDate = DateTime.Now;
        public string goodgreet;
        public string Greet() {

            Console.WriteLine(this.currentDate);

            //DateTime dateOnly = currentDate.Date;

            //Console.WriteLine("Only Current Date: " + dateOnly);

            Console.WriteLine("Only Current Date: " + currentDate.ToString("d"));

            Console.WriteLine("Only Current Time: " + currentDate.ToString("t"));

            if (currentDate.Hour > 0 && currentDate.Hour <= 3)
                goodgreet = "Good Night";

            else if (currentDate.Hour > 3 && currentDate.Hour < 12)
                goodgreet = "Good Morning";

            else if (currentDate.Hour == 12)
                goodgreet = "Good Noon";

            else if (currentDate.Hour > 12 && currentDate.Hour <= 15)
                goodgreet = "Good AfterNoon";

            else if (currentDate.Hour > 15 && currentDate.Hour < 20)
                goodgreet = "Good Evening";

            else if (currentDate.Hour >= 20 && currentDate.Hour <= 24)
                goodgreet = "Good Night";
            else
                goodgreet = "Unknown time!";

            Console.WriteLine(goodgreet);
            return goodgreet;

        }
    }
    public class DaylightSavingTime
    {
        public void Dst() {
            // creating object of DateTime
            DateTime date = new DateTime(1970, 1,
                                 1, 4, 0, 15);

            // getting Typecode of date
            // using IsDaylightSavingTime() method;
            bool value = date.IsDaylightSavingTime();

            // checking the condition
            if (value)
                Console.WriteLine("Instance of DateTime is within the"
                                   + " daylight saving time range for" +
                                            " the current time zone.");

            else
                Console.WriteLine("Instance of DateTime is not within the"
                                  + " daylight saving time range for the " +
                                                      "current time zone.");
        }
    }
}


