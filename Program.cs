﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // SmartProperties()



            Console.Read();
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
