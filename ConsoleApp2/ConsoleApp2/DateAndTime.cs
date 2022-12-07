using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class DateAndTime
    {
        DateTime dt = new DateTime();
        //DateTime dtNow = new DateTime.GetDateTimeFormats();
        DateTime dt1 = new DateTime(2000, 12, 23);
        DateTime dt2 = new DateTime(2000, 12, 2, 12, 20, 1);//year,month,date,hour,minute,second local kind
        DateTime dt3 = new DateTime(2000,12,23,12,20,1,DateTimeKind.Utc);//UTC kind
        DateTime current = DateTime.Now;
        DateTime currentUtc = DateTime.UtcNow;
        DateTime dt4 = new DateTime(2022, 12, 23, 12, 20, 1);
        DateTime dt5 = new DateTime(2020, 10, 13, 6, 10, 1);
        DateTime dt6 = new DateTime(2016, 6, 8, 11, 49, 0);
        DateTime dt7 = new DateTime(2022, 11, 8);


        public void Inspect() 
        {
            Console.WriteLine(this.dt);
            Console.WriteLine(this.dt1);
            Console.WriteLine(this.dt2);
            Console.WriteLine(this.dt3);
            Console.WriteLine(this.current);
            Console.WriteLine(this.currentUtc);
            Console.WriteLine(this.current-this.currentUtc);
            Console.WriteLine(this.dt4 - this.dt5);
            Console.WriteLine(DateTime.MinValue.Ticks);
            Console.WriteLine(DateTime.MaxValue.Ticks);
            Console.WriteLine("Complete date: " + dt6.ToString());

            // Get date-only portion of date, without its time.
            DateTime dateOnly = dt6.Date;
            Console.WriteLine("Short Date: " + dateOnly.ToString("d"));

            //Get the day of a particular date
            Console.WriteLine("The day of the week for {0:d} is {1}.", dt7, dt7.DayOfWeek);

            Console.WriteLine("Display date using 24-hour clock format:");
            Console.WriteLine(dateOnly.ToString("g"));
            Console.WriteLine(dateOnly.ToString("yyyy/MM/dd HH:mm"));


        }
    }
}
