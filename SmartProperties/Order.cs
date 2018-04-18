using System.Collections.Generic;

namespace ConsoleApp1
{
    class Order
    {
        public List<OrderLine> OrderLines = new List<OrderLine>();

        public decimal Total
        {
            get
            {
                decimal total = 0;

                foreach (OrderLine orderLine in OrderLines)
                {
                    total = total + orderLine.SubTotal; 
                }

                return total;
            }
        }
    }
}
