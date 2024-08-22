using System;
using System.Linq.Expressions;

namespace Switch
{
    class SwitchClass
    {
        static void Main(string[] args)
        {
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Its Monday!");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("The last day of the " +
                        "week");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("Its weekend!");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Its weekend!");
                    break;
                default:
                    Console.WriteLine("The middle of the " +
                        "work week!");
                    break;
            }
        }
    }
}
namespace CodingExcersise
{
    public class ParkingCalculator
    {
        public static double Xxx(int hours)
        {
            int result = 0;
            int fee = 5;    

            switch(hours)
            {
                case 1:
                    result = fee;
                    break;
                default:
                    result = fee + (hours - 1) * 3;
                    break;
            }

            return result;
        }
    }
}