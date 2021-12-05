namespace AppExercPooComposiObjs.Entities
{
    class Product
    {
        public string ProductName { get; set; }

        public double ProductPrice { get; set; }

        public Product()
        {
        
        }

        public Product(string productName, double productPrice)
        {
            this.ProductName = productName;
            this.ProductPrice = productPrice;
        }
    }
}
