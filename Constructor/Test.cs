using System;

namespace ConsoleApp1
{
    class Test
    {
        private int _number;

        public Test(string number) 
        {
            _number = Convert.ToInt32(number);
        }

        public Test(int number)
        {
            Console.WriteLine("Integer");
            _number = number * 2;
        }
    }
}
