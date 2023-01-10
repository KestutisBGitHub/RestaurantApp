

using System.Text.Json;

namespace RestaurantApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var customConsole = new CustomConsole();

            var start = new MainApp();

            start.StartApp(customConsole);



            //var orderlist = new List<Order>()
            //{
            //    new Order( "1", 2, DateTime.Now,  "Sultys", 5 ),
            //    new Order( "2", 4, DateTime.Now,  "Alus", 6),
            //    new Order( "2", 6, DateTime.Now,  "Gira", 10 ),
            //    new Order( "1", 2, DateTime.Now,  "ssss", 5 ),
            //    new Order( "1", 2, DateTime.Now,  "dddd", 5 ),
            //    new Order( "1", 2, DateTime.Now,  "wwww", 5 ),
            //};

            //string fileContent = File.ReadAllText("activeOrders.txt");
            //var allOrder = JsonSerializer.Deserialize<List<Order>>(fileContent);

            //var findTableOrders = allOrder.Where(x => x.TableNo == "1");
            //var total = 0m;
            //var pint = findTableOrders.ElementAt(0);
            //Console.WriteLine(pint.DishName);
  
            
            

            //foreach (var count in findTableOrders)
            //{
            //    total += count.Price;
            //}
            //foreach (var order in findTableOrders)
            //{
            //    Console.WriteLine($"{order.DishName}");
            //}

            //};
            //tableList.Add("alus");
            //foreach(var item in tableList)
            //{
            //    Console.WriteLine($"{item.TableNo} {item.TableSize} {item.DateAndTime} {item.TotalToPay} {item.Name}");
            //}

            //var jsonString = JsonSerializer.Serialize(orderlist);
            //File.WriteAllText("activeOrders.txt", jsonString);


        }
    }
}