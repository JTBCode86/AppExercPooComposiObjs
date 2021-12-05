using System;
using System.Globalization;
using AppExercPooComposiObjs.Entities;

namespace AppExercPooComposiObjs
{
    /// <summary>
    /// Exercicios - POO - Composição de objetos
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("E-mail: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Console.Write("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.Write($"Enter #{i} item data: ");
                
                Console.Write("Product: ");
                string productName = Console.ReadLine();
                
                Console.Write("price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());
                
                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(productQuantity, productPrice, product);
                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order);
            Console.ReadLine();
        }
    }
}
