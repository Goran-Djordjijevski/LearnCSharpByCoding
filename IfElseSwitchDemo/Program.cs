using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseSwitchDemo
{
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    class Program
    {
        static void Main(string[] args)
        {
            //TimeOfDay();

            //double goldCustomer = GoldCustomer(true);
            //Console.WriteLine(goldCustomer);

            SeasonOfTheYear(Season.Spring);

            Console.ReadLine();
        }

        private static void SeasonOfTheYear(Season season)
        {
            switch (season)
            {
                case Season.Spring:
                    Console.WriteLine("Spring is my favorite season.");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's perfect to go to beach.");
                    break;
                case Season.Autumn:
                    Console.WriteLine("It's autumn and a beautiful season.");
                    break;
                case Season.Winter:
                    Console.WriteLine("Please put a hot sweater.");
                    break;
                default:
                    Console.WriteLine("I don't understand that season!");
                    break;
            }
        }

        public static double GoldCustomer(bool isGoldCustomer)
        {
            double price;
            if (isGoldCustomer)
            {
                price = 19.99;
            }
            else
            {
                price = 29.99;
            }

            return price;
        }

        public static void TimeOfDay()
        {
            var hour = DateTime.Now.Hour;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon");
            }
            else
            {
                Console.WriteLine("It's evening");
            }
        }
    }
}
