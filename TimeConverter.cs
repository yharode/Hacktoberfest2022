using System;

namespace TimeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeConverter();   
        }

        static void TimeConverter()
        {
            int hour, minute, second;

            Console.WriteLine("Enter seconds : "); second = Convert.ToInt32(Console.ReadLine());

            hour = second / (60 * 60);
            second = second - ((60 * 60) * hour);
            minute = second / 60;
            second = second - (60 * minute);

            Console.WriteLine(" Seconds is the same as " + hour + " Hour " + minute + " Minute " + second + " Seconds");
            Console.ReadLine();
        }
    }
}
