using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AppExercPooComposiObjs.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public Client Client { get; set; }

        public List<OrderItem> orderItems = new List<OrderItem>();

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status,Client client)
        {
            this.Moment = moment;
            this.Status = status;
            this.Client = client;
        }

        public void AddItem(OrderItem orderItem) 
        {
            orderItems.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem) 
        {
            orderItems.Remove(orderItem);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in orderItems)
            {
                sum += item.SubTotal();
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            
            foreach (OrderItem item in orderItems)
            {
                sb.AppendLine(item.ToString());
            }
            
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            
            return sb.ToString();
        }
    }
}
