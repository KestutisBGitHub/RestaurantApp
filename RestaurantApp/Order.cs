using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RestaurantApp
{
    public class Order
    {

        public string TableNo { get; set; }
        public int TableSize { get; set; }
        public DateTime DateAndTime { get; set; }
        public string DishName { get; set; }
        public decimal Price { get; set; }
        public decimal TotalToPay { get; set; }
        



        public Order(string tableNo, int tableSize, DateTime dateAndTime, string dishName, decimal price  )
        {
            TableNo = tableNo;
            TableSize = tableSize;
            DateAndTime = dateAndTime;
            DishName = dishName;
            Price = price;
            
            
            

        }

        public static void OrderView(string input)
        {
            string fileContent = File.ReadAllText("activeOrders.txt");
            var allOrder = JsonSerializer.Deserialize<List<Order>>(fileContent);

            var findTableOrders = allOrder.Where(x => x.TableNo == input);
            var total = 0m;
            var orderHeader = findTableOrders.ElementAt(0);
            
            foreach(var count in findTableOrders)
            {
                total += count.Price;
            }
            Console.WriteLine($"Table Number {orderHeader.TableNo}, Table size {orderHeader.TableSize}, Table total bill {total}");
            Console.WriteLine("Table order details");

            foreach (var order in findTableOrders)
            {
                Console.WriteLine($"Order date {order.DateAndTime}, dish name {order.DishName}, price {order.Price}");
            }
        }
    }
}
