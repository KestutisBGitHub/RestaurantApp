

using System.Text.Json;

namespace RestaurantApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var start = new MainApp();

            start.StartApp();



            //var tableList = new List<Order>()
            //{
            //    new Order( "1", 2, DateTime.Now, 100, "Sultys" ),
            //    new Order( "2", 2, DateTime.Now, 100, "Sultys" ),
            //    new Order( "3", 2, DateTime.Now, 100, "Sultys" ),
                
            //};
            //tableList.Add("alus");
            ////foreach(var item in tableList)
            //{
            //    Console.WriteLine($"{item.TableNo} {item.TableSize} {item.DateAndTime} {item.TotalToPay} {item.Name}");
            //}

            //var jsonString = JsonSerializer.Serialize(tableList);
           // File.WriteAllText("activeOrders.txt", jsonString);


        }
    }
}