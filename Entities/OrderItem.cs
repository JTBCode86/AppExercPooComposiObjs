using System;
using System.Globalization;

namespace AppExercPooComposiObjs.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }

        public double Price { get; set; }

        public Product Product { get; set; }

        public OrderItem()
        {
            
        }

        public OrderItem(int quantity, double price, Product product)
        {
            this.Quantity = quantity;
            this.Price = price;
            this.Product = product;
        }

        public double SubTotal() 
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return Product.ProductName
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
