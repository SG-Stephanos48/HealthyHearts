using System;

namespace HealthyHearts
{
    class Program
    {
        static void Main(string[] args)
        {

            int age;

            Console.WriteLine("What is your age? ");
            age = Convert.ToInt32(Console.ReadLine());

            CalculateHeartRate(age);
        }

        public static void CalculateHeartRate(int age)
        {
            int heartrate;
            double lowzone;
            double highzone;

            heartrate = 220 - age;
            lowzone = heartrate * .50;
            highzone = heartrate * .85;

            Console.WriteLine("Your maximum Heart Rate is: " + heartrate);
            Console.WriteLine("Your target Heart Rate Zone is " + lowzone + " - " + highzone + " beats per minute");
        }
    }
}
