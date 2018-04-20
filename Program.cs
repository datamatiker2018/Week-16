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

            Console.Read();
        }

        static void Constructor()
        {
            // Calls int constructor first, then  
            // performs the string constructor body
            // This is a "chain"
            Test test = new Test("2");
            Console.WriteLine();
            // Only calls int constructor
            Test test2 = new Test(2);

            // We'll use this later
            Random rng = new Random();

            // Call SequenceAnalyser(int[]) constructor with a new int[0] (size 0, so empty)
            SequenceAnalyser sequenceAnalyzer1 = new SequenceAnalyser();
            // Call SequenceAnalyser(int[]) constructor with a new int[5] (size 5, 3 values)
            SequenceAnalyser sequenceAnalyzer2 = new SequenceAnalyser(new int[3] { 1, 2, 3 });
            // Calls SequenceAnalyser(int[]) constructor with a new int[3] (size 3, no values),
            // then performs 3 random insertions into the array in it's own constructor body
            SequenceAnalyser sequenceAnalyzer3 = new SequenceAnalyser(rng, 3);
            // Calls SequenceAnalyser(Random, int), passing it's own Random into it as the first
            // argument, and then uses it's own Random to generate a random number to pass as
            // the second argument. Remember that SequenceAnalyser(Random, int) calls 
            // SequenceAnalyser(int[]), so this is a proper "chain" of constructors
            SequenceAnalyser sequenceAnalyzer4 = new SequenceAnalyser(rng);

            // See the underlying code for a better understanding
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
