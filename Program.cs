using System;
using System.Collections.Generic;
using System.Linq;

namespace JoiningDataOOPLab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>
            {
                    new Order ("Acme Hardware", "Mouse", 25, 3),
                    new Order ("Acme Hardware", "Keyboard", 45, 2),
                    new Order ("Falls Realty", "Macbook", 800, 2),
                    new Order ("Julie's Morning Diner", "iPad", 525, 1),
                    new Order ("Julie's Morning Diner", "Credit Card Reader", 45, 1)

            };

            Exercise1(orders);
            Exercise2(orders);

        }

        public static void Exercise1(List<Order> orders)
        {
            var FirstOrders = orders.GroupBy(p => p.CustomerName).Select(p => p.First());
           
            foreach (Order orderss in FirstOrders)
            {
                Console.WriteLine(orderss.CustomerName);
                Console.WriteLine(string.Format("\t{0, -20} {1, -20} {2, 0}{3,10}", "Item", "Price", "Quantity", "Total"));
                for (int i = 0; i < orders.Count; i++)
                {
                    if (orderss.CustomerName == orders[i].CustomerName)
                    {
                        Console.WriteLine("\t{0, -21} {1, -20} {2, 0}{3,15}", orders[i].Item, orders[i].Price, orders[i].Quantity, orders[i].Price * orders[i].Quantity);
                    }
                }
                
            }
        }
            public static void Exercise2(List<Order> orders)
            {
                var distinctOrders = orders.GroupBy(o => o.CustomerName).Select(o => o.First());
                //Console.WriteLine(string.Join(" ",distinctOrders));
                decimal total = 0;
                foreach (Order ordered in distinctOrders)
                {
                    Console.WriteLine(ordered.CustomerName);
                    Console.WriteLine(string.Format("\t{0, -20} {1, -20} {2, 0}{3,10}", "Item", "Price", "Quantity", "Total"));
                    for (int i = 0; i < orders.Count; i++)
                    {
                        if (ordered.CustomerName == orders[i].CustomerName)
                        {
                            Console.WriteLine("\t{0, -21} {1, -20} {2, 0}{3,15}", orders[i].Item, orders[i].Price, orders[i].Quantity, orders[i].Price * orders[i].Quantity);
                            total += orders[i].Price * orders[i].Quantity;
                        }
                    }
                    Console.WriteLine("\t{0,-20}{1,38}", "Total", total);
                    Console.WriteLine();
                    total = 0;
                }
            }



        
        
    }
}
