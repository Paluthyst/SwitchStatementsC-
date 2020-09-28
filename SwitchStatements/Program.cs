using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is it the morning, afternoon or night?");
            String timeOfDay = Console.ReadLine();
            switch(timeOfDay)
            {
                case "morning":
                    Console.WriteLine("Ah! Good Morning Friend :) ");
                    break;
                case "afternoon":
                    Console.WriteLine("Ah! Good afternoon how has your day been?");
                    break;
                case "night":
                    Console.WriteLine("Good Night I hope you sleep well");
                    break;
                default:
                    Console.WriteLine("Invalad time of day");
                    break;
            }

        }
    }
}
