﻿using System;

namespace Practice
{
    public enum Season
    {
        Summer,
        Winter,
        Autumn,
        Spring
    }
    internal class ConditionalStatements
    {
        void Main(string[] args)
        {
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon.");
            }
            else
            {
                Console.WriteLine("It's evening.");
            }

            bool isGoldCustomer = true;
            float price = isGoldCustomer ? 19.95f : 29.95f;
            Console.WriteLine(price);

            var season = Season.Autumn;
            Console.WriteLine(season);
            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn and a beautiful season.");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's perfect to go to the beach.");
                    break;
                default:
                    Console.WriteLine("I don't understand that season.");
                    break;
            }

            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("We've got promotion.");
                    break;
                default:
                    Console.WriteLine("I don't understand that season.");
                    break;
            }
        }
    }
}
