using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RestaurantApp
{
    public class Drinks
    {
        public string ItemNo { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        

        public Drinks(string itemNo, string name, decimal price)
        {
            ItemNo = itemNo;
            Name = name;
            Price = price;
        }

        public static void PrintDrinkList()
        {
            string fileContent = File.ReadAllText("drinks.txt");
            var drinkList = JsonSerializer.Deserialize<List<Food>>(fileContent);
            foreach (var item in drinkList)
            {
                Console.WriteLine($"No: {item.ItemNo}, Name: {item.Name}, Price: {item.Price}");
            }
        }
    }
}
