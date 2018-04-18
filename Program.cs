using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // SmartProperties()
            // Objects()
            // Area()

            Test test = new Test("2");

            Console.WriteLine();

            Test test2 = new Test(2);

            Console.Read();
        }

        static void Area()
        {
            Calculation calc = new Calculation();

            // Rectangle
            Console.WriteLine(calc.Area(5.4, 5.2, false));

            // Circle
            Console.WriteLine(calc.Area(10));

            // Circle
            Console.WriteLine(calc.Area(5, 5));
        }

        static void Objects()
        {
            Dog dog = new Dog();

            dog.Color = "Blue";
            dog.Race = "Chihuahua";

            dog.Bark(); // "Bark"

            Dog dog2 = new Dog();

            dog2.Color = "Green";
            dog2.Race = "Goodboy";

            dog2.Bark(); // "Bark"

            Console.WriteLine(dog2.Fetch("stick"));

            Human human = new Human(dog);

            human.Name = "Julius";
            human.BestFriend = dog2;
        }

        static void SmartProperties()
        {
            Order order = new Order();
            OrderLine orderLine = new OrderLine();
            Product product = new Product();

            product.Name = "Mars Bar";
            product.Price = 10;

            orderLine.Product = product;
            orderLine.Quantity = 3;

            OrderLine orderLine2 = new OrderLine();
            Product product2 = new Product();

            product2.Name = "Twix";
            product2.Price = 30;

            orderLine2.Product = product2;
            orderLine2.Quantity = 1;

            order.OrderLines.Add(orderLine);
            order.OrderLines.Add(orderLine2);

            Console.WriteLine(order.Total);
        }
    }
}
