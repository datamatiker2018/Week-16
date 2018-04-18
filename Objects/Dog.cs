using System;

namespace ConsoleApp1
{
    class Dog
    {
        public string Color;
        public string Race;

        public void Bark()
        {
            Console.WriteLine($"The {Race} bark - and it's {Color} by the way");
        }

        public string Fetch(string what)
        {
            return $"The {Race} fetched a {what} - and it's {Color} by the way";
        }

        public static void Sit()
        {
            Console.WriteLine($"The {Race} sat down");
        }
    }
}
