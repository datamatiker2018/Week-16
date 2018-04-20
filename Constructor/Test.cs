using System;

namespace ConsoleApp1
{
    class Test
    {
        private int _number;

        public Test(string number) : this(Convert.ToInt32(number))
        {
            Console.WriteLine("String");
        }

        public Test(int number)
        {
            Console.WriteLine("Integer");
            _number = number * 2;
        }
    }
}
