namespace ConsoleApp1
{
    class OrderLine
    {
        public Product Product;
        public int Quantity;
        public decimal SubTotal
        {
            get
            {
                return Product.Price * Quantity;
            }
        }
    }
}
